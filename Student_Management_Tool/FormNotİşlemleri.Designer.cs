namespace Student_Management_Tool
{
    partial class FormNotİşlemleri
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
            dataGridView1 = new DataGridView();
            lessonsBindingSource = new BindingSource(components);
            studentBindingSource = new BindingSource(components);
            buttonAra = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lessonsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(273, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(407, 119);
            dataGridView1.TabIndex = 0;
            // 
            // lessonsBindingSource
            // 
            lessonsBindingSource.DataMember = "Lessons";
            lessonsBindingSource.DataSource = studentBindingSource;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // buttonAra
            // 
            buttonAra.BackColor = SystemColors.ActiveCaption;
            buttonAra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonAra.ForeColor = SystemColors.ControlLightLight;
            buttonAra.Location = new Point(39, 334);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(82, 36);
            buttonAra.TabIndex = 7;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = false;
            buttonAra.Click += buttonAra_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 295);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(39, 271);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(128, 21);
            label1.TabIndex = 5;
            label1.Text = "Öğrenci No Girin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(273, 174);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 8;
            label2.Text = "1. Ders";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(273, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(430, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(430, 174);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 10;
            label3.Text = "2. Ders";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(584, 241);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(584, 174);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 12;
            label4.Text = "3. Ders";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(273, 334);
            button1.Name = "button1";
            button1.Size = new Size(82, 36);
            button1.TabIndex = 14;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(39, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 201);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(273, 295);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(273, 271);
            label5.Name = "label5";
            label5.Size = new Size(39, 21);
            label5.TabIndex = 17;
            label5.Text = "Vize";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(430, 295);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(584, 295);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(430, 271);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 20;
            label6.Text = "Vize";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(584, 271);
            label7.Name = "label7";
            label7.Size = new Size(39, 21);
            label7.TabIndex = 21;
            label7.Text = "Vize";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(273, 217);
            label8.Name = "label8";
            label8.Size = new Size(43, 21);
            label8.TabIndex = 22;
            label8.Text = "Final";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(430, 217);
            label9.Name = "label9";
            label9.Size = new Size(43, 21);
            label9.TabIndex = 23;
            label9.Text = "Final";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(584, 217);
            label10.Name = "label10";
            label10.Size = new Size(43, 21);
            label10.TabIndex = 24;
            label10.Text = "Final";
            // 
            // FormNotİşlemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(724, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(buttonAra);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormNotİşlemleri";
            Text = "FormNotİşlemleri";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lessonsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource studentBindingSource;
        private BindingSource lessonsBindingSource;
        private Button buttonAra;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}