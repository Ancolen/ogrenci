namespace Student_Management_Tool
{
    partial class FormÖğrenciBilgiGüncelleme
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÖğrenciBilgiGüncelleme));
            studentBindingSource = new BindingSource(components);
            buttonUpdate = new Button();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            buttonAra = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Öğrenci);
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(0, 0, 64);
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(733, 259);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(125, 40);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(592, 66);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 22;
            label5.Text = "Telefon Numarası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(592, 135);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 20;
            label4.Text = "Mail Adresi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(342, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 550);
            panel1.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(26, 38);
            label11.Name = "label11";
            label11.Size = new Size(290, 30);
            label11.TabIndex = 32;
            label11.Text = "ÖĞRENCİ BİLGİ GÜNCELLEME";
            label11.Click += label11_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(78, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // buttonAra
            // 
            buttonAra.BackColor = Color.FromArgb(0, 0, 64);
            buttonAra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonAra.ForeColor = SystemColors.ControlLightLight;
            buttonAra.Location = new Point(174, 341);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(97, 43);
            buttonAra.TabIndex = 30;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = false;
            buttonAra.Click += buttonAra_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 302);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(54, 278);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(128, 21);
            label1.TabIndex = 28;
            label1.Text = "Öğrenci No Girin";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(592, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(266, 23);
            textBox4.TabIndex = 36;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(592, 93);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(266, 23);
            textBox5.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(381, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label12.Location = new Point(417, 303);
            label12.Name = "label12";
            label12.Size = new Size(91, 25);
            label12.TabIndex = 39;
            label12.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(592, 198);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 41;
            label2.Text = "Bölümü";
            // 
            // FormÖğrenciBilgiGüncelleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 396);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label12);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(panel1);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(buttonAra);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonUpdate);
            Name = "FormÖğrenciBilgiGüncelleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUpdateStudentİnfo";
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonUpdate;
        private Label label5;
        private Label label4;
        private BindingSource studentBindingSource;
        private Panel panel1;
        private Label label11;
        private PictureBox pictureBox2;
        private Button buttonAra;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox5;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label2;
    }
}