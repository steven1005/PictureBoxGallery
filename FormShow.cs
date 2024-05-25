using ExifLib;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PictureBoxGallery
{
    public partial class FormShow : Form
    {
        private PictureBox[] pictureBoxes;
        private int currentIndex = 0;
        private Action arrangeMethod; // 儲存排列方式的委派變數

        public FormShow()
        {
            InitializeComponent();
            InitializePictureBoxes(Global.iImgShowCount);
            LoadPictures();
            timer1.Start();
            this.BackColor = Color.Black; // 設置主畫面底色為黑色
            ArrangeAsTwoRows(); // 在主畫面開始時以兩行顯示圖片
            arrangeMethod = ArrangeAsTwoRows; // 儲存排列方式
        }

        private void InitializePictureBoxes(int count)
        {
            pictureBoxes = new PictureBox[count];
            for (int i = 0; i < count; i++)
            {
                pictureBoxes[i] = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.None, // 將框架設置為 None
                    BackColor = Color.Black // 設置 PictureBox 的底色為黑色
                };
                Controls.Add(pictureBoxes[i]);
            }
        }

        private void LoadPictures()
        {
            string[] pictureFiles = Directory.GetFiles(Global.strImgPath, "*.jpg");
            if (pictureFiles.Length == 0)
            {
                MessageBox.Show("No JPG files found in the specified folder.");
                return;
            }

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                LoadPictureWithExif(pictureFiles[currentIndex], pictureBox);
                currentIndex = (currentIndex + 1) % pictureFiles.Length;
            }
        }

        private void LoadPictureWithExif(string filePath, PictureBox pictureBox)
        {
            using (ExifReader reader = new ExifReader(filePath))
            {
                Image image = Image.FromFile(filePath);

                // 檢查圖片是否包含 Exif 元數據
                bool hasRotation = reader.GetTagValue(ExifTags.Orientation, out ushort orientation);
                if (hasRotation && orientation != 1)
                {
                    // 如果圖片包含 Exif 元數據並且需要旋轉，則進行旋轉
                    RotateImage(image, orientation);
                }

                // 將圖片顯示在 PictureBox 中
                pictureBox.Image = image;
            }
            //Image image = Image.FromFile(filePath);
            //// 將圖片顯示在 PictureBox 中
            //pictureBox.Image = image;
        }

        private void RotateImage(Image image, ushort orientation)
        {
            switch (orientation)
            {
                case 2:
                    image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                case 3:
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 4:
                    image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;
                case 5:
                    image.RotateFlip(RotateFlipType.Rotate90FlipX);
                    break;
                case 6:
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 7:
                    image.RotateFlip(RotateFlipType.Rotate270FlipX);
                    break;
                case 8:
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadPictures();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.Items.Add("Arrange as Two Columns", null, ArrangeAsTwoColumns);
                contextMenuStrip.Items.Add("Arrange as Two Rows", null, ArrangeAsTwoRows);
                contextMenuStrip.Show(this, e.Location);
                
            }
            else if (e.Button == MouseButtons.Left)
            {
                ArrangeAtMousePosition(e.Location);
            }
        }

        private void ArrangeAtMousePosition(Point mouseLocation)
        {
            // 计算排列位置
            int rowCount = 2;
            int columnCount = (int)Math.Ceiling((double)pictureBoxes.Length / rowCount); // 計算所需的行數
            int totalHorizontalMargin = (columnCount + 1) * 3; // 水平間距為0.3公分
            int totalVerticalMargin = (rowCount + 1) * 3; // 垂直間距為0.3公分
            int totalWidthAvailable = ClientSize.Width - totalHorizontalMargin;
            int pictureBoxWidth = totalWidthAvailable / columnCount;
            int pictureBoxHeight = (ClientSize.Height - totalVerticalMargin) / rowCount;

            // 將PictureBox排列到鼠標點擊的位置
            int index = 0;
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                int row = index / columnCount;
                int col = index % columnCount;

                int x = mouseLocation.X + (col + 1) * 3 + col * (pictureBoxWidth + 3);
                int y = mouseLocation.Y + (row + 1) * 3 + row * (pictureBoxHeight + 3);

                pictureBox.Location = new Point(x, y);
                pictureBox.Size = new Size(pictureBoxWidth, pictureBoxHeight);

                index++;
            }
        }

        private void ArrangeAsTwoColumns(object sender, EventArgs e)
        {
            arrangeMethod = ArrangeAsTwoColumns; // 儲存排列方式
            ArrangeAsTwoColumns(); // 使用排列方式
        }

        private void ArrangeAsTwoRows(object sender, EventArgs e)
        {
            arrangeMethod = ArrangeAsTwoRows; // 儲存排列方式
            ArrangeAsTwoRows(); // 使用排列方式
        }
        private void ArrangeAsTwoRows()
        {
            int rowCount = 2;
            int columnCount = (int)Math.Ceiling((double)pictureBoxes.Length / rowCount); // 計算所需的行數
            int totalHorizontalMargin = (columnCount + 1) * 3; // 水平間距為0.3公分
            int totalVerticalMargin = (rowCount + 1) * 3; // 垂直間距為0.3公分
            int totalWidthAvailable = ClientSize.Width - totalHorizontalMargin;
            int pictureBoxWidth = totalWidthAvailable / columnCount;
            int pictureBoxHeight = (ClientSize.Height - totalVerticalMargin) / rowCount;

            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                int row = i / columnCount;
                int col = i % columnCount;

                int x = (col + 1) * 3 + col * (pictureBoxWidth + 3);
                int y = (row + 1) * 3 + row * (pictureBoxHeight + 3);

                pictureBoxes[i].Location = new Point(x, y);
                pictureBoxes[i].Size = new Size(pictureBoxWidth, pictureBoxHeight);
            }
        }

        private void ArrangeAsTwoColumns()
        {
            int columnCount = 2;
            int rowCount = (int)Math.Ceiling((double)pictureBoxes.Length / columnCount); // 計算所需的列數
            int totalHorizontalMargin = (columnCount + 1) * 3; // 水平間距為0.3公分
            int totalVerticalMargin = (rowCount + 1) * 3; // 垂直間距為0.3公分
            int totalHeightAvailable = ClientSize.Height - totalVerticalMargin;
            int pictureBoxHeight = totalHeightAvailable / rowCount;
            int pictureBoxWidth = (ClientSize.Width - totalHorizontalMargin) / columnCount;

            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                int col = i % columnCount;
                int row = i / columnCount;

                int x = (col + 1) * 3 + col * (pictureBoxWidth + 3);
                int y = (row + 1) * 3 + row * (pictureBoxHeight + 3);

                pictureBoxes[i].Location = new Point(x, y);
                pictureBoxes[i].Size = new Size(pictureBoxWidth, pictureBoxHeight);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (arrangeMethod != null) // 如果已經選擇了排列方式
            {
                arrangeMethod(); // 使用所選擇的排列方式
            }
        }
    }
}