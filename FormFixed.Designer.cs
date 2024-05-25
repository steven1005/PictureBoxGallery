
namespace PictureBoxGallery
{
    partial class FormFixed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRenameImg = new System.Windows.Forms.Button();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStatusNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbWaterImg = new System.Windows.Forms.PictureBox();
            this.btnWaterImg = new System.Windows.Forms.Button();
            this.tbWaterSize = new System.Windows.Forms.TextBox();
            this.lbWaterImgSize = new System.Windows.Forms.Label();
            this.btnWaterMark = new System.Windows.Forms.Button();
            this.gbWaterMark = new System.Windows.Forms.GroupBox();
            this.gbWaterLoc = new System.Windows.Forms.GroupBox();
            this.rdoWaterRD = new System.Windows.Forms.RadioButton();
            this.rdoWaterRT = new System.Windows.Forms.RadioButton();
            this.rdoWaterLD = new System.Windows.Forms.RadioButton();
            this.rdoWaterLT = new System.Windows.Forms.RadioButton();
            this.lbWaterImgName = new System.Windows.Forms.Label();
            this.gbImgResize = new System.Windows.Forms.GroupBox();
            this.btnImgResizePercent = new System.Windows.Forms.Button();
            this.btnImgResizeFixed = new System.Windows.Forms.Button();
            this.tbImgSizePercent = new System.Windows.Forms.TextBox();
            this.tbImgWidth = new System.Windows.Forms.TextBox();
            this.lbImgSizePercent = new System.Windows.Forms.Label();
            this.lbImgResize = new System.Windows.Forms.Label();
            this.btnOpenImagePath = new System.Windows.Forms.Button();
            this.lbOpenPath = new System.Windows.Forms.Label();
            this.gbJpg = new System.Windows.Forms.GroupBox();
            this.chbJPG = new System.Windows.Forms.CheckBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWaterImg)).BeginInit();
            this.gbWaterMark.SuspendLayout();
            this.gbWaterLoc.SuspendLayout();
            this.gbImgResize.SuspendLayout();
            this.gbJpg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRenameImg
            // 
            this.btnRenameImg.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRenameImg.Location = new System.Drawing.Point(197, 12);
            this.btnRenameImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRenameImg.Name = "btnRenameImg";
            this.btnRenameImg.Size = new System.Drawing.Size(141, 61);
            this.btnRenameImg.TabIndex = 0;
            this.btnRenameImg.Text = "更名";
            this.btnRenameImg.UseVisualStyleBackColor = true;
            this.btnRenameImg.Click += new System.EventHandler(this.btnRenameImg_Click);
            // 
            // tbNewName
            // 
            this.tbNewName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbNewName.Location = new System.Drawing.Point(9, 27);
            this.tbNewName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(179, 36);
            this.tbNewName.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusNow});
            this.statusStrip.Location = new System.Drawing.Point(0, 468);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(895, 35);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "狀態";
            // 
            // toolStatusNow
            // 
            this.toolStatusNow.Name = "toolStatusNow";
            this.toolStatusNow.Size = new System.Drawing.Size(61, 30);
            this.toolStatusNow.Text = "狀態";
            // 
            // pbWaterImg
            // 
            this.pbWaterImg.Location = new System.Drawing.Point(17, 22);
            this.pbWaterImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbWaterImg.Name = "pbWaterImg";
            this.pbWaterImg.Size = new System.Drawing.Size(216, 212);
            this.pbWaterImg.TabIndex = 3;
            this.pbWaterImg.TabStop = false;
            // 
            // btnWaterImg
            // 
            this.btnWaterImg.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWaterImg.Location = new System.Drawing.Point(245, 22);
            this.btnWaterImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWaterImg.Name = "btnWaterImg";
            this.btnWaterImg.Size = new System.Drawing.Size(190, 48);
            this.btnWaterImg.TabIndex = 4;
            this.btnWaterImg.Text = "載入浮水印";
            this.btnWaterImg.UseVisualStyleBackColor = true;
            this.btnWaterImg.Click += new System.EventHandler(this.btnWaterImg_Click);
            // 
            // tbWaterSize
            // 
            this.tbWaterSize.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbWaterSize.Location = new System.Drawing.Point(176, 281);
            this.tbWaterSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbWaterSize.Name = "tbWaterSize";
            this.tbWaterSize.Size = new System.Drawing.Size(216, 36);
            this.tbWaterSize.TabIndex = 5;
            this.tbWaterSize.Text = "0.3";
            // 
            // lbWaterImgSize
            // 
            this.lbWaterImgSize.AutoSize = true;
            this.lbWaterImgSize.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbWaterImgSize.Location = new System.Drawing.Point(18, 284);
            this.lbWaterImgSize.Name = "lbWaterImgSize";
            this.lbWaterImgSize.Size = new System.Drawing.Size(130, 24);
            this.lbWaterImgSize.TabIndex = 6;
            this.lbWaterImgSize.Text = "浮水印縮放";
            // 
            // btnWaterMark
            // 
            this.btnWaterMark.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWaterMark.Location = new System.Drawing.Point(17, 325);
            this.btnWaterMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWaterMark.Name = "btnWaterMark";
            this.btnWaterMark.Size = new System.Drawing.Size(212, 60);
            this.btnWaterMark.TabIndex = 7;
            this.btnWaterMark.Text = "浮水印功能";
            this.btnWaterMark.UseVisualStyleBackColor = true;
            this.btnWaterMark.Click += new System.EventHandler(this.btnWaterMark_Click);
            // 
            // gbWaterMark
            // 
            this.gbWaterMark.Controls.Add(this.gbWaterLoc);
            this.gbWaterMark.Controls.Add(this.btnWaterImg);
            this.gbWaterMark.Controls.Add(this.btnWaterMark);
            this.gbWaterMark.Controls.Add(this.pbWaterImg);
            this.gbWaterMark.Controls.Add(this.lbWaterImgName);
            this.gbWaterMark.Controls.Add(this.lbWaterImgSize);
            this.gbWaterMark.Controls.Add(this.tbWaterSize);
            this.gbWaterMark.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbWaterMark.Location = new System.Drawing.Point(418, 5);
            this.gbWaterMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbWaterMark.Name = "gbWaterMark";
            this.gbWaterMark.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbWaterMark.Size = new System.Drawing.Size(464, 393);
            this.gbWaterMark.TabIndex = 8;
            this.gbWaterMark.TabStop = false;
            this.gbWaterMark.Text = "浮水印功能";
            // 
            // gbWaterLoc
            // 
            this.gbWaterLoc.Controls.Add(this.rdoWaterRD);
            this.gbWaterLoc.Controls.Add(this.rdoWaterRT);
            this.gbWaterLoc.Controls.Add(this.rdoWaterLD);
            this.gbWaterLoc.Controls.Add(this.rdoWaterLT);
            this.gbWaterLoc.Location = new System.Drawing.Point(245, 78);
            this.gbWaterLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbWaterLoc.Name = "gbWaterLoc";
            this.gbWaterLoc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbWaterLoc.Size = new System.Drawing.Size(178, 144);
            this.gbWaterLoc.TabIndex = 8;
            this.gbWaterLoc.TabStop = false;
            this.gbWaterLoc.Text = "位置";
            // 
            // rdoWaterRD
            // 
            this.rdoWaterRD.AutoSize = true;
            this.rdoWaterRD.Checked = true;
            this.rdoWaterRD.Location = new System.Drawing.Point(104, 92);
            this.rdoWaterRD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoWaterRD.Name = "rdoWaterRD";
            this.rdoWaterRD.Size = new System.Drawing.Size(69, 37);
            this.rdoWaterRD.TabIndex = 0;
            this.rdoWaterRD.TabStop = true;
            this.rdoWaterRD.Text = "RD";
            this.rdoWaterRD.UseVisualStyleBackColor = true;
            // 
            // rdoWaterRT
            // 
            this.rdoWaterRT.AutoSize = true;
            this.rdoWaterRT.Location = new System.Drawing.Point(104, 47);
            this.rdoWaterRT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoWaterRT.Name = "rdoWaterRT";
            this.rdoWaterRT.Size = new System.Drawing.Size(66, 37);
            this.rdoWaterRT.TabIndex = 0;
            this.rdoWaterRT.Text = "RT";
            this.rdoWaterRT.UseVisualStyleBackColor = true;
            // 
            // rdoWaterLD
            // 
            this.rdoWaterLD.AutoSize = true;
            this.rdoWaterLD.Location = new System.Drawing.Point(26, 93);
            this.rdoWaterLD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoWaterLD.Name = "rdoWaterLD";
            this.rdoWaterLD.Size = new System.Drawing.Size(68, 37);
            this.rdoWaterLD.TabIndex = 0;
            this.rdoWaterLD.Text = "LD";
            this.rdoWaterLD.UseVisualStyleBackColor = true;
            // 
            // rdoWaterLT
            // 
            this.rdoWaterLT.AutoSize = true;
            this.rdoWaterLT.Location = new System.Drawing.Point(26, 48);
            this.rdoWaterLT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoWaterLT.Name = "rdoWaterLT";
            this.rdoWaterLT.Size = new System.Drawing.Size(65, 37);
            this.rdoWaterLT.TabIndex = 0;
            this.rdoWaterLT.Text = "LT";
            this.rdoWaterLT.UseVisualStyleBackColor = true;
            // 
            // lbWaterImgName
            // 
            this.lbWaterImgName.AutoSize = true;
            this.lbWaterImgName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbWaterImgName.Location = new System.Drawing.Point(17, 248);
            this.lbWaterImgName.Name = "lbWaterImgName";
            this.lbWaterImgName.Size = new System.Drawing.Size(58, 24);
            this.lbWaterImgName.TabIndex = 6;
            this.lbWaterImgName.Text = "名稱";
            // 
            // gbImgResize
            // 
            this.gbImgResize.Controls.Add(this.btnImgResizePercent);
            this.gbImgResize.Controls.Add(this.btnImgResizeFixed);
            this.gbImgResize.Controls.Add(this.tbImgSizePercent);
            this.gbImgResize.Controls.Add(this.tbImgWidth);
            this.gbImgResize.Controls.Add(this.lbImgSizePercent);
            this.gbImgResize.Controls.Add(this.lbImgResize);
            this.gbImgResize.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbImgResize.Location = new System.Drawing.Point(9, 95);
            this.gbImgResize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbImgResize.Name = "gbImgResize";
            this.gbImgResize.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbImgResize.Size = new System.Drawing.Size(398, 258);
            this.gbImgResize.TabIndex = 9;
            this.gbImgResize.TabStop = false;
            this.gbImgResize.Text = "尺寸變更";
            // 
            // btnImgResizePercent
            // 
            this.btnImgResizePercent.Location = new System.Drawing.Point(11, 192);
            this.btnImgResizePercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImgResizePercent.Name = "btnImgResizePercent";
            this.btnImgResizePercent.Size = new System.Drawing.Size(245, 53);
            this.btnImgResizePercent.TabIndex = 7;
            this.btnImgResizePercent.Text = "變更尺寸(百分比)";
            this.btnImgResizePercent.UseVisualStyleBackColor = true;
            this.btnImgResizePercent.Click += new System.EventHandler(this.btnImgResizePercent_Click);
            // 
            // btnImgResizeFixed
            // 
            this.btnImgResizeFixed.Location = new System.Drawing.Point(11, 91);
            this.btnImgResizeFixed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImgResizeFixed.Name = "btnImgResizeFixed";
            this.btnImgResizeFixed.Size = new System.Drawing.Size(245, 53);
            this.btnImgResizeFixed.TabIndex = 7;
            this.btnImgResizeFixed.Text = "變更尺寸(固定)";
            this.btnImgResizeFixed.UseVisualStyleBackColor = true;
            this.btnImgResizeFixed.Click += new System.EventHandler(this.btnImgResize_Click);
            // 
            // tbImgSizePercent
            // 
            this.tbImgSizePercent.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbImgSizePercent.Location = new System.Drawing.Point(113, 148);
            this.tbImgSizePercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbImgSizePercent.Name = "tbImgSizePercent";
            this.tbImgSizePercent.Size = new System.Drawing.Size(216, 36);
            this.tbImgSizePercent.TabIndex = 5;
            this.tbImgSizePercent.Text = "30";
            // 
            // tbImgWidth
            // 
            this.tbImgWidth.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbImgWidth.Location = new System.Drawing.Point(133, 47);
            this.tbImgWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbImgWidth.Name = "tbImgWidth";
            this.tbImgWidth.Size = new System.Drawing.Size(216, 36);
            this.tbImgWidth.TabIndex = 5;
            this.tbImgWidth.Text = "480";
            // 
            // lbImgSizePercent
            // 
            this.lbImgSizePercent.AutoSize = true;
            this.lbImgSizePercent.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbImgSizePercent.Location = new System.Drawing.Point(7, 148);
            this.lbImgSizePercent.Name = "lbImgSizePercent";
            this.lbImgSizePercent.Size = new System.Drawing.Size(82, 24);
            this.lbImgSizePercent.TabIndex = 6;
            this.lbImgSizePercent.Text = "百分比";
            // 
            // lbImgResize
            // 
            this.lbImgResize.AutoSize = true;
            this.lbImgResize.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbImgResize.Location = new System.Drawing.Point(7, 51);
            this.lbImgResize.Name = "lbImgResize";
            this.lbImgResize.Size = new System.Drawing.Size(34, 24);
            this.lbImgResize.TabIndex = 6;
            this.lbImgResize.Text = "寬";
            // 
            // btnOpenImagePath
            // 
            this.btnOpenImagePath.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpenImagePath.Location = new System.Drawing.Point(185, 393);
            this.btnOpenImagePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenImagePath.Name = "btnOpenImagePath";
            this.btnOpenImagePath.Size = new System.Drawing.Size(134, 68);
            this.btnOpenImagePath.TabIndex = 10;
            this.btnOpenImagePath.Text = "開啟路徑";
            this.btnOpenImagePath.UseVisualStyleBackColor = true;
            this.btnOpenImagePath.Click += new System.EventHandler(this.btnOpenImagePath_Click);
            // 
            // lbOpenPath
            // 
            this.lbOpenPath.AutoSize = true;
            this.lbOpenPath.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbOpenPath.Location = new System.Drawing.Point(326, 410);
            this.lbOpenPath.Name = "lbOpenPath";
            this.lbOpenPath.Size = new System.Drawing.Size(58, 24);
            this.lbOpenPath.TabIndex = 6;
            this.lbOpenPath.Text = "路徑";
            // 
            // gbJpg
            // 
            this.gbJpg.Controls.Add(this.chbJPG);
            this.gbJpg.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbJpg.Location = new System.Drawing.Point(12, 389);
            this.gbJpg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbJpg.Name = "gbJpg";
            this.gbJpg.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbJpg.Size = new System.Drawing.Size(166, 76);
            this.gbJpg.TabIndex = 11;
            this.gbJpg.TabStop = false;
            this.gbJpg.Text = "無損壓縮";
            // 
            // chbJPG
            // 
            this.chbJPG.AutoSize = true;
            this.chbJPG.Checked = true;
            this.chbJPG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbJPG.Location = new System.Drawing.Point(28, 32);
            this.chbJPG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbJPG.Name = "chbJPG";
            this.chbJPG.Size = new System.Drawing.Size(90, 37);
            this.chbJPG.TabIndex = 0;
            this.chbJPG.Text = "壓縮";
            this.chbJPG.UseVisualStyleBackColor = true;
            // 
            // FormFixed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 503);
            this.Controls.Add(this.gbJpg);
            this.Controls.Add(this.btnOpenImagePath);
            this.Controls.Add(this.gbImgResize);
            this.Controls.Add(this.lbOpenPath);
            this.Controls.Add(this.gbWaterMark);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.btnRenameImg);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFixed";
            this.Text = "FormFixed";
            this.Load += new System.EventHandler(this.FormFixed_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWaterImg)).EndInit();
            this.gbWaterMark.ResumeLayout(false);
            this.gbWaterMark.PerformLayout();
            this.gbWaterLoc.ResumeLayout(false);
            this.gbWaterLoc.PerformLayout();
            this.gbImgResize.ResumeLayout(false);
            this.gbImgResize.PerformLayout();
            this.gbJpg.ResumeLayout(false);
            this.gbJpg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenameImg;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusNow;
        private System.Windows.Forms.PictureBox pbWaterImg;
        private System.Windows.Forms.Button btnWaterImg;
        private System.Windows.Forms.TextBox tbWaterSize;
        private System.Windows.Forms.Label lbWaterImgSize;
        private System.Windows.Forms.Button btnWaterMark;
        private System.Windows.Forms.GroupBox gbWaterMark;
        private System.Windows.Forms.GroupBox gbImgResize;
        private System.Windows.Forms.Button btnImgResizeFixed;
        private System.Windows.Forms.TextBox tbImgWidth;
        private System.Windows.Forms.Label lbImgResize;
        private System.Windows.Forms.GroupBox gbWaterLoc;
        private System.Windows.Forms.RadioButton rdoWaterRD;
        private System.Windows.Forms.RadioButton rdoWaterRT;
        private System.Windows.Forms.RadioButton rdoWaterLD;
        private System.Windows.Forms.RadioButton rdoWaterLT;
        private System.Windows.Forms.Label lbWaterImgName;
        private System.Windows.Forms.Button btnOpenImagePath;
        private System.Windows.Forms.Label lbOpenPath;
        private System.Windows.Forms.Button btnImgResizePercent;
        private System.Windows.Forms.TextBox tbImgSizePercent;
        private System.Windows.Forms.Label lbImgSizePercent;
        private System.Windows.Forms.GroupBox gbJpg;
        private System.Windows.Forms.CheckBox chbJPG;
    }
}