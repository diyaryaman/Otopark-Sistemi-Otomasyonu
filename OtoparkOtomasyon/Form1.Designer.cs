namespace OtoparkOtomasyon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.textBoxMarkaModel = new System.Windows.Forms.TextBox();
            this.dateTimePickerGiris = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCikis = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otoparkDataSet = new OtoparkOtomasyon.OtoparkDataSet();
            this.araclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.araclarTableAdapter = new OtoparkOtomasyon.OtoparkDataSetTableAdapters.AraclarTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Araç Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Boş Yer Sayısı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ortalama Kalış Süresi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(185, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ortalama Kazanç";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(274, 169);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "Araç Sayısı";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(357, 169);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 39);
            this.button6.TabIndex = 5;
            this.button6.Text = "Araçları Göster";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marka Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giriş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Çıkış Tarihi";
            this.label4.Visible = false;
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Location = new System.Drawing.Point(96, 22);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(213, 20);
            this.textBoxPlaka.TabIndex = 10;
            this.textBoxPlaka.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxMarkaModel
            // 
            this.textBoxMarkaModel.Location = new System.Drawing.Point(95, 48);
            this.textBoxMarkaModel.Name = "textBoxMarkaModel";
            this.textBoxMarkaModel.Size = new System.Drawing.Size(213, 20);
            this.textBoxMarkaModel.TabIndex = 11;
            this.textBoxMarkaModel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePickerGiris
            // 
            this.dateTimePickerGiris.Location = new System.Drawing.Point(95, 74);
            this.dateTimePickerGiris.Name = "dateTimePickerGiris";
            this.dateTimePickerGiris.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerGiris.TabIndex = 12;
            // 
            // dateTimePickerCikis
            // 
            this.dateTimePickerCikis.Location = new System.Drawing.Point(95, 100);
            this.dateTimePickerCikis.Name = "dateTimePickerCikis";
            this.dateTimePickerCikis.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerCikis.TabIndex = 13;
            this.dateTimePickerCikis.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(315, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Çıkış Tarihi";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bul:";
            // 
            // txtarama
            // 
            this.txtarama.Location = new System.Drawing.Point(517, 186);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(355, 20);
            this.txtarama.TabIndex = 16;
            this.txtarama.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(860, 186);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // otoparkDataSet
            // 
            this.otoparkDataSet.DataSetName = "OtoparkDataSet";
            this.otoparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // araclarBindingSource
            // 
            this.araclarBindingSource.DataMember = "Araclar";
            this.araclarBindingSource.DataSource = this.otoparkDataSet;
            // 
            // araclarTableAdapter
            // 
            this.araclarTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OtoparkOtomasyon.Properties.Resources.Otopark2;
            this.pictureBox1.Location = new System.Drawing.Point(431, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtarama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePickerCikis);
            this.Controls.Add(this.dateTimePickerGiris);
            this.Controls.Add(this.textBoxMarkaModel);
            this.Controls.Add(this.textBoxPlaka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Otopark Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.TextBox textBoxMarkaModel;
        private System.Windows.Forms.DateTimePicker dateTimePickerGiris;
        private System.Windows.Forms.DateTimePicker dateTimePickerCikis;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtoparkDataSet otoparkDataSet;
        private System.Windows.Forms.BindingSource araclarBindingSource;
        private OtoparkDataSetTableAdapters.AraclarTableAdapter araclarTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

