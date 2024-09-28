using System.Diagnostics;
using System.Text.RegularExpressions;

namespace TheHelperOfTheKana
{
    public partial class Form1 : Form
    {
        private const string path = "assets";
        private List<string> imagesPath = new List<string>();
        private int lastImageIndex = -1;
        private int score = 0;
        private int topScore = 0;
        private bool hideImage = false;
        private int type = 0;
        private Dictionary<string, Image> images = new();

        public Form1()
        {
            InitializeComponent();

            LB_Score.Text = "0";
            LB_TopScore.Text = "0";
            RB_NotHideImage.Checked = true;

            LoadImages();
        }

        private async void LoadImages()
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);

                foreach (var file in files)
                {
                    if (!images.ContainsKey(file))
                    {
                        images[file] = Image.FromFile(file);
                    }
                }

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
    }
}
