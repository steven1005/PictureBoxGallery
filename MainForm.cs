using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxGallery
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                Global.strImgPath = tbImgPath.Text;
                Global.iImgShowCount = Convert.ToInt32(tbImgCount.Text);

                if (!System.IO.Directory.Exists(Global.strImgPath))
                {
                    MessageBox.Show("圖片路徑不存在");
                    return;
                }
            }
            catch (Exception)
            {

            }
            FormShow form = new FormShow();
            form.ShowDialog();
        }

        private void btnFixed_Click(object sender, EventArgs e)
        {
            try
            {
                Global.strImgPath = tbImgPath.Text;
                Global.iImgShowCount = Convert.ToInt32(tbImgCount.Text);

                Global.listImg.Clear();
                Global.listImg = System.IO.Directory.GetFiles(Global.strImgPath, "*.jpg").ToList();
                //MessageBox.Show($"Loaded {Global.listImg.Count} images.");

                if (!System.IO.Directory.Exists(Global.strImgPath) || Global.listImg.Count <= 0)
                {
                    MessageBox.Show("圖片路徑不存在");
                    return;
                }
            }
            catch (Exception)
            {

            }
            FormFixed form = new FormFixed();
            form.ShowDialog();
        }
    }
}
