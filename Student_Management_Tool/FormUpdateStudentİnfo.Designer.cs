namespace Student_Management_Tool
{
    partial class FormUpdateStudentİnfo
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
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentNbrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bölümDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registredDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            buttonUpdate = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            buttonAra = new Button();
            label6 = new Label();
            label5 = new Label();
            textBoxTelNo = new TextBox();
            label4 = new Label();
            textBoxMail = new TextBox();
            label2 = new Label();
            textBoxSoyisim = new TextBox();
            label7 = new Label();
            textBoxİsim = new TextBox();
            buttonSil = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, studentNbrDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, bölümDataGridViewTextBoxColumn, registredDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentBindingSource;
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(845, 150);
            dataGridView1.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // studentNbrDataGridViewTextBoxColumn
            // 
            studentNbrDataGridViewTextBoxColumn.DataPropertyName = "StudentNbr";
            studentNbrDataGridViewTextBoxColumn.HeaderText = "StudentNbr";
            studentNbrDataGridViewTextBoxColumn.Name = "studentNbrDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // bölümDataGridViewTextBoxColumn
            // 
            bölümDataGridViewTextBoxColumn.DataPropertyName = "Bölüm";
            bölümDataGridViewTextBoxColumn.HeaderText = "Bölüm";
            bölümDataGridViewTextBoxColumn.Name = "bölümDataGridViewTextBoxColumn";
            // 
            // registredDateDataGridViewTextBoxColumn
            // 
            registredDateDataGridViewTextBoxColumn.DataPropertyName = "RegistredDate";
            registredDateDataGridViewTextBoxColumn.HeaderText = "RegistredDate";
            registredDateDataGridViewTextBoxColumn.Name = "registredDateDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(330, 242);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(97, 40);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 57);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(96, 15);
            label1.TabIndex = 2;
            label1.Text = "Öğrenci No Girin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(96, 23);
            textBox1.TabIndex = 3;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(63, 210);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(96, 40);
            buttonAra.TabIndex = 4;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(613, 133);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 24;
            label6.Text = "Bölüm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(613, 25);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 22;
            label5.Text = "Telefon Numarası";
            // 
            // textBoxTelNo
            // 
            textBoxTelNo.Location = new Point(607, 68);
            textBoxTelNo.Name = "textBoxTelNo";
            textBoxTelNo.Size = new Size(100, 23);
            textBoxTelNo.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 76);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 20;
            label4.Text = "Mail Adresi";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(404, 119);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(100, 23);
            textBoxMail.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 133);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 16;
            label2.Text = "Soyisim";
            // 
            // textBoxSoyisim
            // 
            textBoxSoyisim.Location = new Point(210, 176);
            textBoxSoyisim.Name = "textBoxSoyisim";
            textBoxSoyisim.Size = new Size(100, 23);
            textBoxSoyisim.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(216, 25);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 14;
            label7.Text = "İsim";
            // 
            // textBoxİsim
            // 
            textBoxİsim.Location = new Point(210, 68);
            textBoxİsim.Name = "textBoxİsim";
            textBoxİsim.Size = new Size(100, 23);
            textBoxİsim.TabIndex = 13;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(547, 242);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(97, 40);
            buttonSil.TabIndex = 25;
            buttonSil.Text = "Öğrenciyi Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(607, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FormUpdateStudentİnfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 450);
            Controls.Add(comboBox1);
            Controls.Add(buttonSil);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxTelNo);
            Controls.Add(label4);
            Controls.Add(textBoxMail);
            Controls.Add(label2);
            Controls.Add(textBoxSoyisim);
            Controls.Add(label7);
            Controls.Add(textBoxİsim);
            Controls.Add(buttonAra);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonUpdate);
            Controls.Add(dataGridView1);
            Name = "FormUpdateStudentİnfo";
            Text = "FormUpdateStudentİnfo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonUpdate;
        private Label label1;
        private TextBox textBox1;
        private Button buttonAra;
        private Label label6;
        private Label label5;
        private TextBox textBoxTelNo;
        private Label label4;
        private TextBox textBoxMail;
        private Label label2;
        private TextBox textBoxSoyisim;
        private Label label7;
        private TextBox textBoxİsim;
        private Button buttonSil;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentNbrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bölümDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registredDateDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
    }
}