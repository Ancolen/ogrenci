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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            buttonBilgiGüncelle = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(83, 270);
            button1.Name = "button1";
            button1.Size = new Size(109, 64);
            button1.TabIndex = 0;
            button1.Text = "Öğrenci Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(219, 270);
            button2.Name = "button2";
            button2.Size = new Size(109, 64);
            button2.TabIndex = 1;
            button2.Text = "Öğrenci Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(430, 134);
            button3.Name = "button3";
            button3.Size = new Size(109, 64);
            button3.TabIndex = 2;
            button3.Text = "Öğrenci Listele";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // buttonBilgiGüncelle
            // 
            buttonBilgiGüncelle.Location = new Point(83, 98);
            buttonBilgiGüncelle.Name = "buttonBilgiGüncelle";
            buttonBilgiGüncelle.Size = new Size(109, 64);
            buttonBilgiGüncelle.TabIndex = 3;
            buttonBilgiGüncelle.Text = "Öğrenci Bilgi Güncelle";
            buttonBilgiGüncelle.UseVisualStyleBackColor = true;
            buttonBilgiGüncelle.Click += buttonBilgiGüncelle_Click;
            // 
            // button4
            // 
            button4.Location = new Point(219, 134);
            button4.Name = "button4";
            button4.Size = new Size(109, 64);
            button4.TabIndex = 4;
            button4.Text = "Öğrenci Not İşlemleri";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormAnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 498);
            Controls.Add(button4);
            Controls.Add(buttonBilgiGüncelle);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormAnaMenu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button buttonBilgiGüncelle;
        private Button button4;
    }
}
