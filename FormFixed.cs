using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace PictureBoxGallery
{
    public partial class FormFixed : Form
    {
        private Image watermarkImage;
        private string sOpenFolder;
        public FormFixed()
        {
            InitializeComponent();
        }

        private void FormFixed_Load(object sender, EventArgs e)
        {
            tbNewName.Text = DateTime.Now.ToString("yyyyMMdd");
            sOpenFolder = Global.strImgPath;
            lbOpenPath.Text = Global.strImgPath;
        }

        private void btnRenameImg_Click(object sender, EventArgs e)
        {
            toolStatusNow.Text = "";
            string outputDirectory = Global.strImgPath + @"\\renamed_images";
            Directory.CreateDirectory(outputDirectory);

            for (int i = 0; i < Global.listImg.Count; i++)
            {
                string fileName = Path.GetFileNameWithoutExtension(Global.listImg[i]);
                string extension = Path.GetExtension(Global.listImg[i]);
                string newFileName = tbNewName.Text + $"_{i + 1}{extension}";
                string outputPath = Path.Combine(outputDirectory, newFileName);

                File.Copy(Global.listImg[i], outputPath);
            }
            sOpenFolder = outputDirectory;
            lbOpenPath.Text = sOpenFolder;
            //MessageBox.Show($"Images renamed and saved to {outputDirectory}.");
            toolStatusNow.Text = $"照片更名後另存路徑 {outputDirectory}.";
        }

        private void btnWaterMark_Click(object sender, EventArgs e)
        {
            toolStatusNow.Text = "";
            if (watermarkImage == null)
            {
                toolStatusNow.Text = $"ERROR：請載入浮水印";
                return;
            }
            double fScale = Convert.ToDouble(tbWaterSize.Text);
            if (fScale > 0.5 || fScale <= 0)
            {
                toolStatusNow.Text = $"ERROR：浮水印尺寸要小於等於0.5";
                return;
            }

            string outputDirectory = Global.strImgPath + @"\\watermarked_images";
            Directory.CreateDirectory(outputDirectory);

            for (int i = 0; i < Global.listImg.Count; i++)
            {
                string fileName = Path.GetFileName(Global.listImg[i]);
                string outputPath = Path.Combine(outputDirectory, fileName);

                using (var image = new Bitmap(Global.listImg[i]))
                using (var graphics = Graphics.FromImage(image))
                {
                    int watermarkWidth = (int)(image.Width * fScale); // 浮水印寬度為原始圖片寬度的60%
                    int watermarkHeight = (int)(watermarkWidth * watermarkImage.Height / (double)watermarkImage.Width); // 根據原始圖片和浮水印的比例計算高度

                    var scaledWatermark = new Bitmap(watermarkImage, watermarkWidth, watermarkHeight);

                    int x = 10, y = 10;

                    // 根據使用者的選擇來確定浮水印的位置
                    if (rdoWaterLT.Checked)
                    {
                        //x = 2; // 左上角
                        //y = 2;
                    }
                    else if (rdoWaterLD.Checked)
                    {
                        y = image.Height - watermarkHeight - y;
                    }
                    else if (rdoWaterRT.Checked)
                    {
                        x = image.Width - watermarkWidth - x; // 右上角
                    }
                    else // LowerRightRadioButton.Checked
                    {
                        x = image.Width - watermarkWidth - x; // 右下角
                        y = image.Height - watermarkHeight - y;
                    }

                    graphics.DrawImage(scaledWatermark, x, y);

                    if (chbJPG.Checked)
                    {
                        image.Save(outputPath, ImageFormat.Jpeg);
                    }
                    else
                    {
                        image.Save(outputPath, ImageFormat.Exif);
                    }
                }

                sOpenFolder = outputDirectory;
                lbOpenPath.Text = sOpenFolder;
                //MessageBox.Show($"Watermarks added and images saved to {outputDirectory}.");
                toolStatusNow.Text = $"浮水印圖片儲存於 {outputDirectory}.";
            }
        }

        private void btnImgResize_Click(object sender, EventArgs e)
        {
            toolStatusNow.Text = "";
            int newWidth = Convert.ToInt32(tbImgWidth.Text); // 自定義的新寬度

            string outputDirectory = Global.strImgPath + @"\\resized_images_fixed";
            Directory.CreateDirectory(outputDirectory);
            for (int i = 0; i < Global.listImg.Count; i++)
            {
                string fileName = Path.GetFileName(Global.listImg[i]);
                string outputPath = Path.Combine(outputDirectory, fileName);

                using (var image = new Bitmap(Global.listImg[i]))
                {
                    if (image.Width > newWidth)
                    {
                        double scaleFactor = (double)newWidth / image.Width;
                        int newHeight = (int)(image.Height * scaleFactor);

                        using (var newImage = new Bitmap(image, newWidth, newHeight))
                        {
                            if (chbJPG.Checked)
                            {
                                newImage.Save(outputPath, ImageFormat.Jpeg);
                            }
                            else
                            {
                                newImage.Save(outputPath, ImageFormat.Bmp);
                            }
                        }
                    }
                }
            }

            sOpenFolder = outputDirectory;
            lbOpenPath.Text = sOpenFolder;
            //MessageBox.Show($"Images resized and saved to {outputDirectory}.");
            toolStatusNow.Text = $"照片尺寸(固定)變更儲存於 {outputDirectory}.";
        }

        private void btnWaterImg_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; ; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                watermarkImage = Image.FromFile(open.FileName);
                pbWaterImg.Image = new Bitmap(open.FileName);
                pbWaterImg.SizeMode = PictureBoxSizeMode.Zoom;
                // image file path
                lbWaterImgName.Text = open.FileName;
            }
        }

        private void btnOpenImagePath_Click(object sender, EventArgs e)
        {
            // opens explorer, showing some other folder)
            toolStatusNow.Text = "";
            if (sOpenFolder.Length > 0)
            {
                if (Directory.Exists(sOpenFolder))
                {
                    Process.Start(sOpenFolder);
                    toolStatusNow.Text = $"開啟資料夾 {sOpenFolder}.";
                }
                else
                {
                    toolStatusNow.Text = $"ERROR：資料夾不存在 {sOpenFolder}.";
                }
            }
            else
            {
                toolStatusNow.Text = $"ERROR：無法開啟資料夾 {sOpenFolder}.";
            }
        }

        private void btnImgResizePercent_Click(object sender, EventArgs e)
        {
            toolStatusNow.Text = "";
            double newWidth = Convert.ToDouble(tbImgSizePercent.Text) / 100; // 自定義的新寬度

            string outputDirectory = Global.strImgPath + @"\\resized_images_percent";
            Directory.CreateDirectory(outputDirectory);
            for (int i = 0; i < Global.listImg.Count; i++)
            {
                string fileName = Path.GetFileName(Global.listImg[i]);
                string outputPath = Path.Combine(outputDirectory, fileName);

                using (var image = new Bitmap(Global.listImg[i]))
                {
                    if (image.Width > image.Width * newWidth)
                    {
                        double scaleFactor = image.Width * (double)newWidth;
                        int newHeight = (int)(image.Height * (double)newWidth);

                        using (var newImage = new Bitmap(image, Convert.ToInt32(image.Width * (double)newWidth), newHeight))
                        {
                            if (chbJPG.Checked)
                            {
                                newImage.Save(outputPath, ImageFormat.Jpeg);
                            }
                            else
                            {
                                newImage.Save(outputPath, ImageFormat.Bmp);
                            }
                        }
                    }
                }
            }

            sOpenFolder = outputDirectory;
            lbOpenPath.Text = sOpenFolder;
            //MessageBox.Show($"Images resized and saved to {outputDirectory}.");
            toolStatusNow.Text = $"照片尺寸(百分比)變更儲存於 {outputDirectory}.";
        }
    }
}
