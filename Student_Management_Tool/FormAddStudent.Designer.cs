namespace Student_Management_Tool
{
    partial class FormAddStudent
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
            button1 = new Button();
            textBoxİsim = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxSoyisim = new TextBox();
            label4 = new Label();
            textBoxMail = new TextBox();
            label5 = new Label();
            textBoxTelNo = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(268, 473);
            button1.Name = "button1";
            button1.Size = new Size(88, 36);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxİsim
            // 
            textBoxİsim.Location = new Point(268, 182);
            textBoxİsim.Name = "textBoxİsim";
            textBoxİsim.Size = new Size(202, 23);
            textBoxİsim.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(268, 158);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 2;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(268, 215);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 4;
            label2.Text = "Soyad";
            // 
            // textBoxSoyisim
            // 
            textBoxSoyisim.Location = new Point(268, 239);
            textBoxSoyisim.Name = "textBoxSoyisim";
            textBoxSoyisim.Size = new Size(202, 23);
            textBoxSoyisim.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(268, 339);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 8;
            label4.Text = "Mail Adresi";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(268, 363);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(202, 23);
            textBoxMail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(268, 276);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 10;
            label5.Text = "Telefon Numarası";
            // 
            // textBoxTelNo
            // 
            textBoxTelNo.Location = new Point(268, 300);
            textBoxTelNo.Name = "textBoxTelNo";
            textBoxTelNo.Size = new Size(202, 23);
            textBoxTelNo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(268, 399);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 12;
            label6.Text = "Bölüm";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bilgisayar Programcılığı", "Fizik", "Astronomi" });
            comboBox1.Location = new Point(268, 423);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 23);
            comboBox1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 264);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FormAddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 539);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxTelNo);
            Controls.Add(label4);
            Controls.Add(textBoxMail);
            Controls.Add(label2);
            Controls.Add(textBoxSoyisim);
            Controls.Add(label1);
            Controls.Add(textBoxİsim);
            Controls.Add(button1);
            Name = "FormAddStudent";
            Text = "FromAddStudent";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxİsim;
        private Label label1;
        private Label label2;
        private TextBox textBoxSoyisim;
        private Label label4;
        private TextBox textBoxMail;
        private Label label5;
        private TextBox textBoxTelNo;
        private Label label6;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}