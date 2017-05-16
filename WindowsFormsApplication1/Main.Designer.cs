namespace WindowsFormsApplication1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_JieShu = new System.Windows.Forms.Button();
            this.btn_Sousuo = new System.Windows.Forms.Button();
            this.btn_Fanhui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_JieShu
            // 
            this.btn_JieShu.Location = new System.Drawing.Point(277, 276);
            this.btn_JieShu.Name = "btn_JieShu";
            this.btn_JieShu.Size = new System.Drawing.Size(144, 60);
            this.btn_JieShu.TabIndex = 1;
            this.btn_JieShu.Text = "我要借书";
            this.btn_JieShu.UseVisualStyleBackColor = true;
            this.btn_JieShu.Click += new System.EventHandler(this.btn_JieShu_Click);
            // 
            // btn_Sousuo
            // 
            this.btn_Sousuo.Location = new System.Drawing.Point(82, 276);
            this.btn_Sousuo.Name = "btn_Sousuo";
            this.btn_Sousuo.Size = new System.Drawing.Size(144, 60);
            this.btn_Sousuo.TabIndex = 3;
            this.btn_Sousuo.Text = "搜索图书";
            this.btn_Sousuo.UseVisualStyleBackColor = true;
            this.btn_Sousuo.Click += new System.EventHandler(this.btn_Sousuo_Click);
            // 
            // btn_Fanhui
            // 
            this.btn_Fanhui.Location = new System.Drawing.Point(472, 276);
            this.btn_Fanhui.Name = "btn_Fanhui";
            this.btn_Fanhui.Size = new System.Drawing.Size(144, 60);
            this.btn_Fanhui.TabIndex = 4;
            this.btn_Fanhui.Text = "返回登录";
            this.btn_Fanhui.UseVisualStyleBackColor = true;
            this.btn_Fanhui.Click += new System.EventHandler(this.btn_Fanhui_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 423);
            this.Controls.Add(this.btn_Fanhui);
            this.Controls.Add(this.btn_Sousuo);
            this.Controls.Add(this.btn_JieShu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_JieShu;
        private System.Windows.Forms.Button btn_Sousuo;
        private System.Windows.Forms.Button btn_Fanhui;
    }
}