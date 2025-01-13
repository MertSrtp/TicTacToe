namespace TicTacToe
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn3x3 = new System.Windows.Forms.Button();
            this.btn5x5 = new System.Windows.Forms.Button();
            this.btn7x7 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn3x3
            // 
            this.btn3x3.BackColor = System.Drawing.Color.SeaShell;
            this.btn3x3.Location = new System.Drawing.Point(121, 340);
            this.btn3x3.Name = "btn3x3";
            this.btn3x3.Size = new System.Drawing.Size(121, 66);
            this.btn3x3.TabIndex = 0;
            this.btn3x3.Text = "3x3";
            this.btn3x3.UseVisualStyleBackColor = false;
            this.btn3x3.Click += new System.EventHandler(this.btn3x3_Click);
            // 
            // btn5x5
            // 
            this.btn5x5.BackColor = System.Drawing.Color.SeaShell;
            this.btn5x5.Location = new System.Drawing.Point(435, 340);
            this.btn5x5.Name = "btn5x5";
            this.btn5x5.Size = new System.Drawing.Size(121, 66);
            this.btn5x5.TabIndex = 1;
            this.btn5x5.Text = "5x5";
            this.btn5x5.UseVisualStyleBackColor = false;
            this.btn5x5.Click += new System.EventHandler(this.btn5x5_Click);
            // 
            // btn7x7
            // 
            this.btn7x7.BackColor = System.Drawing.Color.SeaShell;
            this.btn7x7.Location = new System.Drawing.Point(721, 340);
            this.btn7x7.Name = "btn7x7";
            this.btn7x7.Size = new System.Drawing.Size(121, 66);
            this.btn7x7.TabIndex = 2;
            this.btn7x7.Text = "7x7";
            this.btn7x7.UseVisualStyleBackColor = false;
            this.btn7x7.Click += new System.EventHandler(this.btn7x7_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TicTacToe.Properties.Resources.AOZ0I;
            this.pictureBox3.Location = new System.Drawing.Point(691, 111);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TicTacToe.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(419, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicTacToe.Properties.Resources.board_0;
            this.pictureBox1.Location = new System.Drawing.Point(104, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(932, 595);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn3x3);
            this.Controls.Add(this.btn7x7);
            this.Controls.Add(this.btn5x5);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn3x3;
        private System.Windows.Forms.Button btn5x5;
        private System.Windows.Forms.Button btn7x7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

