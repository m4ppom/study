namespace ImageController
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.basePicture = new System.Windows.Forms.PictureBox();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.re_pic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.basePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // basePicture
            // 
            this.basePicture.Image = ((System.Drawing.Image)(resources.GetObject("basePicture.Image")));
            this.basePicture.Location = new System.Drawing.Point(158, 97);
            this.basePicture.Name = "basePicture";
            this.basePicture.Size = new System.Drawing.Size(490, 230);
            this.basePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.basePicture.TabIndex = 0;
            this.basePicture.TabStop = false;
            this.basePicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(158, 333);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(75, 23);
            this.btnEmpty.TabIndex = 1;
            this.btnEmpty.Text = "empty";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // re_pic
            // 
            this.re_pic.Location = new System.Drawing.Point(240, 332);
            this.re_pic.Name = "re_pic";
            this.re_pic.Size = new System.Drawing.Size(75, 23);
            this.re_pic.TabIndex = 2;
            this.re_pic.Text = "repainting";
            this.re_pic.UseVisualStyleBackColor = true;
            this.re_pic.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.re_pic);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.basePicture);
            this.Name = "Form1";
            this.Text = "ImageController";
            ((System.ComponentModel.ISupportInitialize)(this.basePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox basePicture;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button re_pic;
    }
}

