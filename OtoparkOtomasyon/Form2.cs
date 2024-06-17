using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class Form2 : Form
    {
        public int Id { get; private set; }
        public string Plaka { get; private set; }
        public string MarkaModel { get; private set; }
        public DateTime GirisTarihi { get; private set; }
        public DateTime? CikisTarihi { get; private set; }

        public event Action<int, string, string, DateTime, DateTime?, string> OnUpdate;
        public Form2(Form1 Form1, int id, string plaka, string markaModel, DateTime girisTarihi, DateTime? cikisTarihi)
        {
            InitializeComponent();
            Id = id;
            Plaka = plaka;
            MarkaModel = markaModel;
            GirisTarihi = girisTarihi;
            CikisTarihi = cikisTarihi;
            txtPlaka.Text = plaka;
            txtMarkaModel.Text = markaModel;
            dtpGirisTarihi.Value = girisTarihi;
            if (cikisTarihi.HasValue)
            {
                dtpCikisTarihi.Value = cikisTarihi.Value;
            }
            else
            {
                dtpCikisTarihi.Format = DateTimePickerFormat.Custom;
                dtpCikisTarihi.CustomFormat = " ";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text;
            string markaModel = txtMarkaModel.Text;
            DateTime girisTarihi = dtpGirisTarihi.Value;
            DateTime? cikisTarihi = null;
            string durum = "";

            if (checkBox1.Checked == true)
            {
                cikisTarihi = dtpCikisTarihi.Value;
                durum = "Dışarıda";
            }
            else
            {
                durum = "İçerde";
            }
            OnUpdate?.Invoke(Id, plaka, markaModel, girisTarihi, cikisTarihi, durum);
            UpdateDatabase(Id, plaka, markaModel, girisTarihi, cikisTarihi,durum);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void UpdateDatabase(int id, string plaka, string markaModel, DateTime girisTarihi, DateTime? cikisTarihi, string durum)
        {
            string connectionString = "Data Source";
            string query = "UPDATE Araclar SET Plaka = @plaka, MarkaModel = @markaModel, GirisTarihi = @girisTarihi, CikisTarihi = @cikisTarihi, Durum = @durum WHERE AracID = @id";


            using (SqlConnection bglnt = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, bglnt);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@plaka", plaka);
                cmd.Parameters.AddWithValue("@markaModel", markaModel);
                cmd.Parameters.AddWithValue("@girisTarihi", girisTarihi);
                if (cikisTarihi == null)
                {
                    cmd.Parameters.AddWithValue("@CikisTarihi", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CikisTarihi", cikisTarihi);
                }
                cmd.Parameters.AddWithValue("@durum", durum);
                MessageBox.Show("Kayıt başarıyla değiştirildi.");
                bglnt.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void Iptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpCikisTarihi.Visible = checkBox1.Checked;
            label4.Visible = checkBox1.Checked;
        }
    }
}
