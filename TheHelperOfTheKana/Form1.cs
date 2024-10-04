using System.Diagnostics;
using System.Text.RegularExpressions;

namespace TheHelperOfTheKana
{
    public partial class Form1 : Form
    {
        private const string path = "assets";
        private List<string> imagesPath = [];
        private int lastImageIndex = -1;
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

                    //if (!images.ContainsKey(file))
                    //{
                    //    images[file] = Image.FromFile(file);
                    //}
                }

                UpdateRomajiRange();

                imagesPath = new List<string>(images.Keys);

                await LoadRandomImage();
            }
            else
            {
                MessageBox.Show("不存在assets目录，请检查后重试！", "目录不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Task LoadImage(string path)
        {
            if (images.ContainsKey(path))
            {
                PB_1.Image = images[path];
            }
            else
            {
                MessageBox.Show($"不存在文件{path}，请检查后重试！", "文件不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Task.CompletedTask;
        }

        private int GetRandomIndex()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            int iSeed = BitConverter.ToInt32(buffer, 0);
            Random random = new Random(iSeed);

            int imgCount = imagesPath.Count;
            var index = random.Next(imgCount);

            return index;
        }

        private async Task LoadRandomImage()
        {
            var index = GetRandomIndex();
            while (index == lastImageIndex)
            {
                index = GetRandomIndex();
            }
            lastImageIndex = index;

            if (RB_NotHideImage.Checked)
            {
                await LoadImage(imagesPath[index]);
            }
            else
            {
                PB_1.Image = null;
            }

            ExtractRomaji(imagesPath[index]);
        }

        private string ExtractRomajiFromName(string name)
        {
            string pattern = @"([a-zA-Z]+)(\d+)";
            Match match = Regex.Match(name, pattern);
            if (match.Success)
            {
                var romaji = match.Groups[1].Value;
                Debug.WriteLine("罗马字部分: " + romaji);
                return romaji;
            }
            else
            {
                Debug.WriteLine("提取罗马字失败！");
                return name;
            }
        }

        private void ExtractRomaji(string input)
        {
            string pattern = @"\\(\w+)\.";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                var romaji = match.Groups[1].Value;
                string pattern2 = @"([a-zA-Z]+)(\d+)";
                Match match2 = Regex.Match(romaji, pattern2);
                if (match2.Success)
                {
                    romaji = match2.Groups[1].Value;
                    string numberPart = match2.Groups[2].Value;
                    int.TryParse(numberPart, out type);

                    Debug.WriteLine("罗马字部分: " + romaji);
                    Debug.WriteLine("数字部分: " + type);

                    LB_Romaji.Text = romaji;
                }
            }
        }

        private void UpdateScore()
        {
            if (score == 100)
            {
                LB_Score.Text = score.ToString();
                MessageBox.Show("恭喜！达到目标分数！", "达成目标", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LB_Score.Text = score.ToString();
            }

            if (topScore < score)
            {
                topScore = score;
                LB_TopScore.Text = topScore.ToString();
            }
        }

        private async void BT_Yes_Click(object sender, EventArgs e)
        {
            score += 1;
            UpdateScore();
            await LoadRandomImage();
        }

        private async void BTN_No_Click(object sender, EventArgs e)
        {
            score -= 1;
            UpdateScore();
            await LoadRandomImage();
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
                LoadImage(imagesPath[lastImageIndex]);
                hideImage = false;
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
            string oldPath = imagesPath[lastImageIndex];
            string[] temp = oldPath.Split('.');
            var extension = "." + temp[^1];

            var romaji = LB_Romaji.Text;
            switch (type)
            {
                case 1:
                    type = 2;
                    break;
                case 2:
                    type = 1;
                    break;
            }
            string imagePath = path + "\\" + romaji + type + extension;
            if (RB_NotHideImage.Checked)
            {
                LoadImage(imagePath);
            }
            else
            {
                PB_1.Image = null;
            }

            lastImageIndex = imagesPath.IndexOf(imagePath);
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
