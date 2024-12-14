namespace Student_Management_Tool
{
    partial class FormAnaMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaMenu));
            button1 = new Button();
            button3 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            buttonBilgiGüncelle = new Button();
            button4 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(239, 213);
            button1.Name = "button1";
            button1.Size = new Size(155, 64);
            button1.TabIndex = 0;
            button1.Text = "Öğrenci Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(52, 213);
            button3.Name = "button3";
            button3.Size = new Size(155, 64);
            button3.TabIndex = 2;
            button3.Text = "Öğrenci Listele";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // buttonBilgiGüncelle
            // 
            buttonBilgiGüncelle.BackColor = Color.FromArgb(0, 0, 64);
            buttonBilgiGüncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonBilgiGüncelle.ForeColor = Color.White;
            buttonBilgiGüncelle.Location = new Point(148, 305);
            buttonBilgiGüncelle.Name = "buttonBilgiGüncelle";
            buttonBilgiGüncelle.Size = new Size(155, 64);
            buttonBilgiGüncelle.TabIndex = 3;
            buttonBilgiGüncelle.Text = "Öğrenci Bilgi Güncelle";
            buttonBilgiGüncelle.UseVisualStyleBackColor = false;
            buttonBilgiGüncelle.Click += buttonBilgiGüncelle_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 64);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(331, 305);
            button4.Name = "button4";
            button4.Size = new Size(155, 64);
            button4.TabIndex = 4;
            button4.Text = "Öğrenci Not İşlemleri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(239, 141);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 5;
            label1.Text = "ANA MENÜ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-21, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 109);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(142, 33);
            label2.Name = "label2";
            label2.Size = new Size(250, 32);
            label2.TabIndex = 9;
            label2.Text = "MERSİN ÜNİVERSİTESİ";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(419, 213);
            button2.Name = "button2";
            button2.Size = new Size(155, 64);
            button2.TabIndex = 1;
            button2.Text = "Öğrenci Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormAnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(632, 415);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(buttonBilgiGüncelle);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormAnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button buttonBilgiGüncelle;
        private Button button4;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Button button2;
    }
}
