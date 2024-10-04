using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TheHelperOfTheKana
{
    public partial class Form1 : Form
    {
        private const string path = "assets";
        private int lastImageIndex = -1;
        private Dictionary<int, Image> currentKana = [];
        private int score = 0;
        private int topScore = 0;
        private bool hideImage = false;
        private int type = 0;
        private static List<string> unvoicedRomaji = ["a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "si", "su", "se", "so", "ta", "ti", "tu", "te", "to",
            "na", "ni", "nu", "ne", "no", "ha", "hi", "hu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ya", "yu", "yo", "ra", "ri", "ru", "re", "ro", "wa", "wo", "nn"];
        private static List<string> voicedRomaji = ["ga", "gi", "gu", "ge", "go", "za", "zi", "zu", "ze", "zo", "da", "di", "du", "de", "do", "ba", "bi", "bu", "be", "bo"];
        private static List<string> semiVoicedRomaji = ["pa", "pi", "pu", "pe", "po"];
        private static List<string> allVoicedRomaji = [.. voicedRomaji, .. semiVoicedRomaji];
        private static List<string> allRomaji = [];
        private Dictionary<string, Image> images = [];
        private Dictionary<string, Image> imgUnvoicedHiragana = [];
        private Dictionary<string, Image> imgUnvoicedKatakana = [];
        private Dictionary<string, Image> imgVoicedHiragana = [];
        private Dictionary<string, Image> imgVoicedKatakana = [];
        private Dictionary<string, Image> imgSemiVoicedHiragana = [];
        private Dictionary<string, Image> imgSemiVoicedKatakana = [];
        private List<Dictionary<string, Image>> hiraganaDirectories = [];
        private List<Dictionary<string, Image>> katakanaDirectories = [];
        private List<Dictionary<string, Image>> allDirectories = [];

        public Form1()
        {
            InitializeComponent();

            LB_Score.Text = "0";
            LB_TopScore.Text = "0";
            RB_NotHideImage.Checked = true;
            CB_Unvoiced.Checked = true;
            RB_All.Checked = true;

            LoadImages();
        }

        private void AddImageToProperDictionary(string file)
        {
            var name = Path.GetFileNameWithoutExtension(file);
            var romaji = ExtractRomajiFromName(name);
            List<List<string>> temp = [unvoicedRomaji, voicedRomaji, semiVoicedRomaji];
            int index = -1;

            if (name.EndsWith('1'))
            {
                for (int i = 0; i < temp.Count; i++)
                {
                    foreach (var item in temp[i])
                    {
                        if (item == romaji)
                        {
                            index = i;
                            break;
                        }
                    }
                }

                if (index == 0)
                {
                    imgUnvoicedHiragana.Add(romaji, Image.FromFile(file));
                }
                else if (index == 1)
                {
                    imgVoicedHiragana.Add(romaji, Image.FromFile(file));
                }
                else if (index == 2)
                {
                    imgSemiVoicedHiragana.Add(romaji, Image.FromFile(file));
                }
            }
            else if (name.EndsWith('2'))
            {
                for (int i = 0; i < temp.Count; i++)
                {
                    foreach (var item in temp[i])
                    {
                        if (item == romaji)
                        {
                            index = i;
                            break;
                        }
                    }
                }

                if (index == 0)
                {
                    imgUnvoicedKatakana.Add(romaji, Image.FromFile(file));
                }
                else if (index == 1)
                {
                    imgVoicedKatakana.Add(romaji, Image.FromFile(file));
                }
                else if (index == 2)
                {
                    imgSemiVoicedKatakana.Add(romaji, Image.FromFile(file));
                }
            }
        }

        private async void LoadImages()
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);

                foreach (var file in files)
                {
                    AddImageToProperDictionary(file);
                }

                hiraganaDirectories = [imgUnvoicedHiragana, imgVoicedHiragana, imgSemiVoicedHiragana];
                katakanaDirectories = [imgUnvoicedKatakana, imgVoicedKatakana, imgSemiVoicedKatakana];

                UpdateRomajiRange();
                UpdateKanaRange();

                await LoadRandomImage(allRomaji);
            }
            else
            {
                MessageBox.Show("不存在assets目录，请检查后重试！", "目录不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task LoadRandomImage(List<string> romajiList)
        {
            var index = GetRandomIndex(romajiList.Count);
            while (index == lastImageIndex)
            {
                index = GetRandomIndex(romajiList.Count);
            }
            lastImageIndex = index;

            var key = romajiList[index];

            if (RB_NotHideImage.Checked)
            {
                await LoadImage(key);
            }
            else
            {
                PB_1.Image = null;
            }

            UpdateRomaji(key);
        }

        private int GetRandomIndex(int maxValue)
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            int iSeed = BitConverter.ToInt32(buffer, 0);
            Random random = new(iSeed);

            var index = random.Next(maxValue);

            return index;
        }

        private Task LoadImage(string key)
        {
            if (RB_All.Checked)
            {
                allDirectories = GetRandomDirectories();
            }

            foreach (var dict in allDirectories)
            {
                if (dict.TryGetValue(key, out var img) && !currentKana.ContainsKey(type))
                {
                    currentKana.Add(type, img);
                    PB_1.Image = img;
                }
            }

            return Task.CompletedTask;
        }

        private List<Dictionary<string, Image>> GetRandomDirectories()
        {
            var index = GetRandomIndex(2);
            switch (index)
            {
                case 0:
                    type = 1;
                    return hiraganaDirectories;
                case 1:
                    type = 2;
                    return katakanaDirectories;
            }

            return hiraganaDirectories;
        }

        private void UpdateRomaji(string romaji)
        {
            LB_Romaji.Text = romaji;
        }

        private string ExtractRomajiFromName(string name)
        {
            string pattern = @"([a-zA-Z]+)(\d+)";
            Match match = Regex.Match(name, pattern);
            if (match.Success)
            {
                var romaji = match.Groups[1].Value;
                return romaji;
            }
            else
            {
                Debug.WriteLine("提取罗马字失败！");
                return name;
            }
        }

        private void UpdateScore()
        {
            LB_Score.Text = score.ToString();

            if (topScore < score)
            {
                topScore = score;
                LB_TopScore.Text = topScore.ToString();
            }
        }

        private async void BT_Yes_Click(object sender, EventArgs e)
        {
            currentKana.Clear();
            UpdateKanaRange();
            score += 1;
            UpdateScore();
            await LoadRandomImage(allRomaji);
        }

        private async void BTN_No_Click(object sender, EventArgs e)
        {
            currentKana.Clear();
            UpdateKanaRange();
            score -= 1;
            UpdateScore();
            await LoadRandomImage(allRomaji);
        }

        private void LB_Score_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否重置分数？", "重置分数", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                score = 0;
                UpdateScore();
            }
        }

        private void PB_1_Click(object sender, EventArgs e)
        {
            if (!hideImage)
            {
                PB_1.Image = null;
                hideImage = true;
            }
            else
            {
                if (currentKana.TryGetValue(type, out Image? img))
                {
                    PB_1.Image = img;
                    hideImage = false;
                }
            }
        }

        private void RB_HideImage_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB_NotHideImage_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void LB_Romaji_Click(object sender, EventArgs e)
        {
            var romaji = LB_Romaji.Text;
            if (type == 1)
            {
                type = 2;

                if (currentKana.TryGetValue(type, out Image? img))
                {
                    PB_1.Image = img;
                }
                else
                {
                    allDirectories = katakanaDirectories;
                    LoadImage(romaji);
                }
            }
            else if (type == 2)
            {
                type = 1;

                if (currentKana.TryGetValue(type, out Image? img))
                {
                    PB_1.Image = img;
                }
                else
                {
                    allDirectories = hiraganaDirectories;
                    LoadImage(romaji);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                BTN_Yes.PerformClick();
                return true;
            }
            else if (keyData == Keys.Right)
            {
                BTN_No.PerformClick();
                return true;
            }
            else if (keyData == Keys.Up)
            {
                LB_Romaji_Click(LB_Romaji, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                return true;
            }
            else if (keyData == Keys.Down)
            {
                PB_1_Click(PB_1, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UpdateRomajiRange()
        {
            bool unvoiced = CB_Unvoiced.Checked;
            bool semiVoiced = CB_SemiVoiced.Checked;
            bool voiced = CB_Voiced.Checked;

            if (unvoiced && !semiVoiced && !voiced)
            {
                allRomaji = unvoicedRomaji;
            }
            else if (!unvoiced && semiVoiced && !voiced)
            {
                allRomaji = semiVoicedRomaji;
            }
            else if (!unvoiced && !semiVoiced && voiced)
            {
                allRomaji = voicedRomaji;
            }
            else if (!unvoiced && semiVoiced && voiced)
            {
                allRomaji = allVoicedRomaji;
            }
            else if (unvoiced && semiVoiced && !voiced)
            {
                allRomaji = [.. unvoicedRomaji, .. semiVoicedRomaji];
            }
            else if (unvoiced && !semiVoiced && voiced)
            {
                allRomaji = [.. unvoicedRomaji, .. voicedRomaji];
            }
            else if (unvoiced && semiVoiced && voiced)
            {
                allRomaji = [.. unvoicedRomaji, .. allVoicedRomaji];
            }
            else
            {
                allRomaji = unvoicedRomaji;
            }

            lastImageIndex = -1;
        }

        private void CB_Unvoiced_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRomajiRange();
        }

        private void CB_SemiVoiced_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRomajiRange();
        }

        private void CB_Voiced_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRomajiRange();
        }

        private void UpdateKanaRange()
        {
            bool hiragana = RB_Hiragana.Checked;
            bool katakana = RB_Katakana.Checked;
            bool all = RB_All.Checked;

            if (all)
            {
                allDirectories = GetRandomDirectories();
            }
            else if (hiragana)
            {
                allDirectories = hiraganaDirectories;
                type = 1;
            }
            else if (katakana)
            {
                allDirectories = katakanaDirectories;
                type = 2;
            }
        }

        private void RB_Hiragana_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKanaRange();
        }

        private void RB_Katakana_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKanaRange();
        }

        private void RB_All_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKanaRange();
        }
    }
}
