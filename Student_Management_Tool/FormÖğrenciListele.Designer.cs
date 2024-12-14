namespace Student_Management_Tool
{
    partial class FormÖğrenciListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÖğrenciListele));
            dataGridView1 = new DataGridView();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ısimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyisimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ogrenciNumarasiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonNumarasiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bölümDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kayitTarihiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fotoğrafDataGridViewImageColumn = new DataGridViewImageColumn();
            öğrenciBindingSource = new BindingSource(components);
            studentBindingSource2 = new BindingSource(components);
            studentBindingSource1 = new BindingSource(components);
            studentBindingSource = new BindingSource(components);
            label1 = new Label();
            buttonBölümeGöreAra = new Button();
            label2 = new Label();
            textBoxİsmeGöre = new TextBox();
            textBoxBölümeGöre = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)öğrenciBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.Honeydew;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, ısimDataGridViewTextBoxColumn, soyisimDataGridViewTextBoxColumn, ogrenciNumarasiDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonNumarasiDataGridViewTextBoxColumn, bölümDataGridViewTextBoxColumn, kayitTarihiDataGridViewTextBoxColumn, fotoğrafDataGridViewImageColumn });
            dataGridView1.DataSource = öğrenciBindingSource;
            dataGridView1.Location = new Point(419, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(844, 427);
            dataGridView1.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // ısimDataGridViewTextBoxColumn
            // 
            ısimDataGridViewTextBoxColumn.DataPropertyName = "Isim";
            ısimDataGridViewTextBoxColumn.HeaderText = "Isim";
            ısimDataGridViewTextBoxColumn.Name = "ısimDataGridViewTextBoxColumn";
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            soyisimDataGridViewTextBoxColumn.DataPropertyName = "Soyisim";
            soyisimDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            // 
            // ogrenciNumarasiDataGridViewTextBoxColumn
            // 
            ogrenciNumarasiDataGridViewTextBoxColumn.DataPropertyName = "OgrenciNumarasi";
            ogrenciNumarasiDataGridViewTextBoxColumn.HeaderText = "OgrenciNumarasi";
            ogrenciNumarasiDataGridViewTextBoxColumn.Name = "ogrenciNumarasiDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonNumarasiDataGridViewTextBoxColumn
            // 
            telefonNumarasiDataGridViewTextBoxColumn.DataPropertyName = "TelefonNumarasi";
            telefonNumarasiDataGridViewTextBoxColumn.HeaderText = "TelefonNumarasi";
            telefonNumarasiDataGridViewTextBoxColumn.Name = "telefonNumarasiDataGridViewTextBoxColumn";
            // 
            // bölümDataGridViewTextBoxColumn
            // 
            bölümDataGridViewTextBoxColumn.DataPropertyName = "Bölüm";
            bölümDataGridViewTextBoxColumn.HeaderText = "Bölüm";
            bölümDataGridViewTextBoxColumn.Name = "bölümDataGridViewTextBoxColumn";
            // 
            // kayitTarihiDataGridViewTextBoxColumn
            // 
            kayitTarihiDataGridViewTextBoxColumn.DataPropertyName = "KayitTarihi";
            kayitTarihiDataGridViewTextBoxColumn.HeaderText = "KayitTarihi";
            kayitTarihiDataGridViewTextBoxColumn.Name = "kayitTarihiDataGridViewTextBoxColumn";
            // 
            // fotoğrafDataGridViewImageColumn
            // 
            fotoğrafDataGridViewImageColumn.DataPropertyName = "Fotoğraf";
            fotoğrafDataGridViewImageColumn.HeaderText = "Fotoğraf";
            fotoğrafDataGridViewImageColumn.Name = "fotoğrafDataGridViewImageColumn";
            // 
            // öğrenciBindingSource
            // 
            öğrenciBindingSource.DataSource = typeof(Models.Öğrenci);
            // 
            // studentBindingSource2
            // 
            studentBindingSource2.DataSource = typeof(Models.Öğrenci);
            // 
            // studentBindingSource1
            // 
            studentBindingSource1.DataSource = typeof(Models.Öğrenci);
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Öğrenci);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(67, 280);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 1;
            label1.Text = "İsme Göre Arama";
            // 
            // buttonBölümeGöreAra
            // 
            buttonBölümeGöreAra.BackColor = Color.FromArgb(0, 0, 64);
            buttonBölümeGöreAra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonBölümeGöreAra.ForeColor = SystemColors.ControlLightLight;
            buttonBölümeGöreAra.Location = new Point(208, 408);
            buttonBölümeGöreAra.Name = "buttonBölümeGöreAra";
            buttonBölümeGöreAra.Size = new Size(96, 41);
            buttonBölümeGöreAra.TabIndex = 4;
            buttonBölümeGöreAra.Text = "ARA";
            buttonBölümeGöreAra.UseVisualStyleBackColor = false;
            buttonBölümeGöreAra.Click += buttonBölümeGöreAra_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(67, 345);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 3;
            label2.Text = "Bölüme Göre Arama";
            // 
            // textBoxİsmeGöre
            // 
            textBoxİsmeGöre.Location = new Point(67, 304);
            textBoxİsmeGöre.Name = "textBoxİsmeGöre";
            textBoxİsmeGöre.Size = new Size(237, 23);
            textBoxİsmeGöre.TabIndex = 5;
            // 
            // textBoxBölümeGöre
            // 
            textBoxBölümeGöre.Location = new Point(67, 369);
            textBoxBölümeGöre.Name = "textBoxBölümeGöre";
            textBoxBölümeGöre.Size = new Size(237, 23);
            textBoxBölümeGöre.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(26, 32);
            label3.Name = "label3";
            label3.Size = new Size(318, 32);
            label3.TabIndex = 8;
            label3.Text = "ÖĞRENCİ LİSTELEME EKRANI";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(97, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(377, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 550);
            panel1.TabIndex = 28;
            // 
            // FormÖğrenciListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1294, 482);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(textBoxBölümeGöre);
            Controls.Add(textBoxİsmeGöre);
            Controls.Add(buttonBölümeGöreAra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormÖğrenciListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListStudents";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)öğrenciBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentNbrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registredDateDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ısimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ogrenciNumarasiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonNumarasiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bölümDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kayitTarihiDataGridViewTextBoxColumn;
        private DataGridViewImageColumn fotoğrafDataGridViewImageColumn;
        private BindingSource öğrenciBindingSource;
    }
}