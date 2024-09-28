using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

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

        public Form1()
        {
            InitializeComponent();

            LB_Score.Text = "0";
            LB_TopScore.Text = "0";
            RB_NotHideImage.Checked = true;

            LoadImages();
        }

        private void RenameFiles(string FolderPath)
        {
            if (Directory.Exists(FolderPath))
            {
                Debug.WriteLine("Exist !");
                string[] files = Directory.GetFiles(FolderPath);
                foreach (var file in files)
                {
                    var name = file.Replace(FolderPath + "\\", "");
                    string[] temp = name.Split('.');
                    var extension = temp[^1];

                    StringBuilder sb = new StringBuilder();
                    foreach (var l in temp)
                    {
                        sb.Append(l);
                        sb.Append('.');
                    }
                    name = sb.ToString();

                    string[] temp2 = name.Split('-');
                    name = temp2[0] + ".";
                    string newName = FolderPath + "\\" + name + extension;
                    File.Move(file, newName);
                }
                Debug.WriteLine("Done !");
            }
            else
            {
                Debug.WriteLine("Foler Not Exists !");
            }
        }

        private async void LoadImages()
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                imagesPath = [.. files];

                await LoadRandomImage();
            }
            else
            {
                MessageBox.Show("不存在assets目录，请检查后重试！", "目录不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Task LoadImage(string path)
        {
            if (File.Exists(path))
            {
                PB_1.Image = Image.FromFile(path);
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
            Random random = new(iSeed);

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
            } else
            {
                PB_1.Image = null;
            }

            lastImageIndex = imagesPath.IndexOf(imagePath);
        }
    }
}
