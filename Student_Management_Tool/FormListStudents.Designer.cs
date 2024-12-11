namespace Student_Management_Tool
{
    partial class FormListStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListStudents));
            dataGridView1 = new DataGridView();
            studentBindingSource1 = new BindingSource(components);
            studentBindingSource = new BindingSource(components);
            label1 = new Label();
            buttonBölümeGöreAra = new Button();
            label2 = new Label();
            textBoxİsmeGöre = new TextBox();
            textBoxBölümeGöre = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            studentBindingSource2 = new BindingSource(components);
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentNbrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bölümDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registredDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, studentNbrDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, bölümDataGridViewTextBoxColumn, registredDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentBindingSource2;
            dataGridView1.Location = new Point(22, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 220);
            dataGridView1.TabIndex = 0;
            // 
            // studentBindingSource1
            // 
            studentBindingSource1.DataSource = typeof(Models.Student);
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(338, 75);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 1;
            label1.Text = "İsme Göre Arama";
            // 
            // buttonBölümeGöreAra
            // 
            buttonBölümeGöreAra.BackColor = SystemColors.ActiveCaption;
            buttonBölümeGöreAra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonBölümeGöreAra.ForeColor = SystemColors.ControlLightLight;
            buttonBölümeGöreAra.Location = new Point(338, 197);
            buttonBölümeGöreAra.Name = "buttonBölümeGöreAra";
            buttonBölümeGöreAra.Size = new Size(82, 39);
            buttonBölümeGöreAra.TabIndex = 4;
            buttonBölümeGöreAra.Text = "ARA";
            buttonBölümeGöreAra.UseVisualStyleBackColor = false;
            buttonBölümeGöreAra.Click += buttonBölümeGöreAra_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(338, 135);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 3;
            label2.Text = "Bölüme Göre Arama";
            // 
            // textBoxİsmeGöre
            // 
            textBoxİsmeGöre.Location = new Point(338, 99);
            textBoxİsmeGöre.Name = "textBoxİsmeGöre";
            textBoxİsmeGöre.Size = new Size(237, 23);
            textBoxİsmeGöre.TabIndex = 5;
            // 
            // textBoxBölümeGöre
            // 
            textBoxBölümeGöre.Location = new Point(338, 159);
            textBoxBölümeGöre.Name = "textBoxBölümeGöre";
            textBoxBölümeGöre.Size = new Size(237, 23);
            textBoxBölümeGöre.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(295, 26);
            label3.Name = "label3";
            label3.Size = new Size(318, 32);
            label3.TabIndex = 8;
            label3.Text = "ÖĞRENCİ LİSTELEME EKRANI";
            // 
            // studentBindingSource2
            // 
            studentBindingSource2.DataSource = typeof(Models.Student);
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
            // FormListStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(892, 508);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxBölümeGöre);
            Controls.Add(textBoxİsmeGöre);
            Controls.Add(buttonBölümeGöreAra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormListStudents";
            Text = "FormListStudents";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource studentBindingSource;
        private Label label1;
        private Button buttonBölümeGöreAra;
        private Label label2;
        private TextBox textBoxİsmeGöre;
        private TextBox textBoxBölümeGöre;
        private BindingSource studentBindingSource1;
        private PictureBox pictureBox1;
        private Label label3;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentNbrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bölümDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registredDateDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource2;
    }
}