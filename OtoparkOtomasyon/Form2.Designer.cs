namespace OtoparkOtomasyon
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtMarkaModel = new System.Windows.Forms.TextBox();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Iptal = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giriş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Çıkış Tarihi";
            this.label4.Visible = false;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(89, 14);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(200, 20);
            this.txtPlaka.TabIndex = 4;
            // 
            // txtMarkaModel
            // 
            this.txtMarkaModel.Location = new System.Drawing.Point(88, 40);
            this.txtMarkaModel.Name = "txtMarkaModel";
            this.txtMarkaModel.Size = new System.Drawing.Size(201, 20);
            this.txtMarkaModel.TabIndex = 5;
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(89, 93);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpCikisTarihi.TabIndex = 7;
            this.dtpCikisTarihi.Visible = false;
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Kaydet.Location = new System.Drawing.Point(89, 120);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Kaydet.TabIndex = 8;
            this.Kaydet.Text = "KAYDET";
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // Iptal
            // 
            this.Iptal.BackColor = System.Drawing.Color.Red;
            this.Iptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Iptal.Location = new System.Drawing.Point(214, 120);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(75, 23);
            this.Iptal.TabIndex = 9;
            this.Iptal.Text = "İPTAL";
            this.Iptal.UseVisualStyleBackColor = false;
            this.Iptal.Click += new System.EventHandler(this.Iptal_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(296, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Çıkış Tarihi";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(89, 67);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpGirisTarihi.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 147);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Iptal);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.txtMarkaModel);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "DÜZENLE";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtMarkaModel;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
    }
}