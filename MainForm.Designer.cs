
namespace PictureBoxGallery
{
    partial class MainForm
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
            this.tbImgPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnFixed = new System.Windows.Forms.Button();
            this.gbShow = new System.Windows.Forms.GroupBox();
            this.lbImgCount = new System.Windows.Forms.Label();
            this.tbImgCount = new System.Windows.Forms.TextBox();
            this.gbFixed = new System.Windows.Forms.GroupBox();
            this.gbShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbImgPath
            // 
            this.tbImgPath.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbImgPath.Location = new System.Drawing.Point(131, 45);
            this.tbImgPath.Name = "tbImgPath";
            this.tbImgPath.Size = new System.Drawing.Size(259, 36);
            this.tbImgPath.TabIndex = 0;
            this.tbImgPath.Text = "D:\\\\PIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "圖片路徑";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(26, 370);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(121, 44);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "圖片展示";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnFixed
            // 
            this.btnFixed.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFixed.Location = new System.Drawing.Point(164, 370);
            this.btnFixed.Name = "btnFixed";
            this.btnFixed.Size = new System.Drawing.Size(121, 44);
            this.btnFixed.TabIndex = 2;
            this.btnFixed.Text = "圖片修改";
            this.btnFixed.UseVisualStyleBackColor = true;
            this.btnFixed.Click += new System.EventHandler(this.btnFixed_Click);
            // 
            // gbShow
            // 
            this.gbShow.Controls.Add(this.lbImgCount);
            this.gbShow.Controls.Add(this.tbImgCount);
            this.gbShow.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbShow.Location = new System.Drawing.Point(16, 96);
            this.gbShow.Name = "gbShow";
            this.gbShow.Size = new System.Drawing.Size(361, 107);
            this.gbShow.TabIndex = 3;
            this.gbShow.TabStop = false;
            this.gbShow.Text = "展示";
            // 
            // lbImgCount
            // 
            this.lbImgCount.AutoSize = true;
            this.lbImgCount.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbImgCount.Location = new System.Drawing.Point(6, 32);
            this.lbImgCount.Name = "lbImgCount";
            this.lbImgCount.Size = new System.Drawing.Size(58, 24);
            this.lbImgCount.TabIndex = 1;
            this.lbImgCount.Text = "數量";
            // 
            // tbImgCount
            // 
            this.tbImgCount.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbImgCount.Location = new System.Drawing.Point(87, 32);
            this.tbImgCount.Name = "tbImgCount";
            this.tbImgCount.Size = new System.Drawing.Size(259, 36);
            this.tbImgCount.TabIndex = 0;
            this.tbImgCount.Text = "6";
            // 
            // gbFixed
            // 
            this.gbFixed.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbFixed.Location = new System.Drawing.Point(16, 209);
            this.gbFixed.Name = "gbFixed";
            this.gbFixed.Size = new System.Drawing.Size(361, 135);
            this.gbFixed.TabIndex = 3;
            this.gbFixed.TabStop = false;
            this.gbFixed.Text = "修改";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.gbFixed);
            this.Controls.Add(this.gbShow);
            this.Controls.Add(this.btnFixed);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbImgPath);
            this.Name = "MainForm";
            this.Text = "選擇功能";
            this.gbShow.ResumeLayout(false);
            this.gbShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbImgPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnFixed;
        private System.Windows.Forms.GroupBox gbShow;
        private System.Windows.Forms.Label lbImgCount;
        private System.Windows.Forms.TextBox tbImgCount;
        private System.Windows.Forms.GroupBox gbFixed;
    }
}