namespace WindowsFormsApplication1
{
    partial class Guanliyuan
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
            this.btn_ReadAllUser = new System.Windows.Forms.Button();
            this.btn_ReadAllBook = new System.Windows.Forms.Button();
            this.btn_ReadAllBorrow = new System.Windows.Forms.Button();
            this.btn_DelUser = new System.Windows.Forms.Button();
            this.btn_UpUsr = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ReadAllUser
            // 
            this.btn_ReadAllUser.Location = new System.Drawing.Point(21, 15);
            this.btn_ReadAllUser.Name = "btn_ReadAllUser";
            this.btn_ReadAllUser.Size = new System.Drawing.Size(205, 50);
            this.btn_ReadAllUser.TabIndex = 0;
            this.btn_ReadAllUser.Text = "查看全部用户";
            this.btn_ReadAllUser.UseVisualStyleBackColor = true;
            this.btn_ReadAllUser.Click += new System.EventHandler(this.btn_ReadAllUser_Click);
            // 
            // btn_ReadAllBook
            // 
            this.btn_ReadAllBook.Location = new System.Drawing.Point(21, 183);
            this.btn_ReadAllBook.Name = "btn_ReadAllBook";
            this.btn_ReadAllBook.Size = new System.Drawing.Size(205, 50);
            this.btn_ReadAllBook.TabIndex = 1;
            this.btn_ReadAllBook.Text = "查看全部图书";
            this.btn_ReadAllBook.UseVisualStyleBackColor = true;
            this.btn_ReadAllBook.Click += new System.EventHandler(this.btn_ReadAllBook_Click);
            // 
            // btn_ReadAllBorrow
            // 
            this.btn_ReadAllBorrow.Location = new System.Drawing.Point(21, 407);
            this.btn_ReadAllBorrow.Name = "btn_ReadAllBorrow";
            this.btn_ReadAllBorrow.Size = new System.Drawing.Size(205, 50);
            this.btn_ReadAllBorrow.TabIndex = 2;
            this.btn_ReadAllBorrow.Text = "查看全部借阅信息";
            this.btn_ReadAllBorrow.UseVisualStyleBackColor = true;
            this.btn_ReadAllBorrow.Click += new System.EventHandler(this.btn_ReadAllBorrow_Click);
            // 
            // btn_DelUser
            // 
            this.btn_DelUser.Location = new System.Drawing.Point(21, 71);
            this.btn_DelUser.Name = "btn_DelUser";
            this.btn_DelUser.Size = new System.Drawing.Size(205, 50);
            this.btn_DelUser.TabIndex = 3;
            this.btn_DelUser.Text = "删除用户信息";
            this.btn_DelUser.UseVisualStyleBackColor = true;
            this.btn_DelUser.Click += new System.EventHandler(this.btn_DelUser_Click);
            // 
            // btn_UpUsr
            // 
            this.btn_UpUsr.Location = new System.Drawing.Point(21, 127);
            this.btn_UpUsr.Name = "btn_UpUsr";
            this.btn_UpUsr.Size = new System.Drawing.Size(205, 50);
            this.btn_UpUsr.TabIndex = 4;
            this.btn_UpUsr.Text = "修改用户信息";
            this.btn_UpUsr.UseVisualStyleBackColor = true;
            this.btn_UpUsr.Click += new System.EventHandler(this.btn_UpUsr_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 239);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 50);
            this.button7.TabIndex = 6;
            this.button7.Text = "删除图书信息";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(21, 295);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(205, 50);
            this.button8.TabIndex = 7;
            this.button8.Text = "增加图书信息";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(21, 351);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(205, 50);
            this.button9.TabIndex = 8;
            this.button9.Text = "修改图书信息";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(21, 463);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(205, 50);
            this.button10.TabIndex = 9;
            this.button10.Text = "删除借阅信息";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(21, 519);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(205, 50);
            this.button11.TabIndex = 10;
            this.button11.Text = "增加借阅信息";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(21, 575);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(205, 50);
            this.button12.TabIndex = 11;
            this.button12.Text = "修改借阅信息";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(650, 610);
            this.dataGridView1.TabIndex = 12;
            // 
            // Guanliyuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 636);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_UpUsr);
            this.Controls.Add(this.btn_DelUser);
            this.Controls.Add(this.btn_ReadAllBorrow);
            this.Controls.Add(this.btn_ReadAllBook);
            this.Controls.Add(this.btn_ReadAllUser);
            this.Name = "Guanliyuan";
            this.Text = "Guanliyuan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ReadAllUser;
        private System.Windows.Forms.Button btn_ReadAllBook;
        private System.Windows.Forms.Button btn_ReadAllBorrow;
        private System.Windows.Forms.Button btn_DelUser;
        private System.Windows.Forms.Button btn_UpUsr;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}