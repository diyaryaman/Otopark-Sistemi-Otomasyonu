using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OtoparkOtomasyon
{
    public partial class Form1 : Form
    {
        private int toplamKapasite = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otoparkDataSet.Araclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.araclarTableAdapter.Fill(this.otoparkDataSet.Araclar);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerCikis.Visible = checkBox1.Checked;
            label4.Visible = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                string plaka = textBoxPlaka.Text;
                string markaModel = textBoxMarkaModel.Text;
                DateTime girisTarihi = dateTimePickerGiris.Value;
                DateTime? cikisTarihi = null;
                string durum = "";

                if (checkBox1.Checked == true)
                {
                    cikisTarihi = dateTimePickerCikis.Value;
                    durum = "Dışarıda";
                }
                else
                {
                    durum = "İçerde";
                }

                string query = "INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum) VALUES (@Plaka, @MarkaModel, @GirisTarihi, @CikisTarihi, @durum)";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, baglanti))
                    {
                        command.Parameters.AddWithValue("@Plaka", plaka);
                        command.Parameters.AddWithValue("@MarkaModel", markaModel);
                        command.Parameters.AddWithValue("@GirisTarihi", girisTarihi);
                        if (cikisTarihi == null)
                        {
                            command.Parameters.AddWithValue("@CikisTarihi", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@CikisTarihi", cikisTarihi);
                        }
                        command.Parameters.AddWithValue("@durum", durum);

                        baglanti.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla eklendi.");
                        listele();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Veri ekleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listele()
        {
            string connectionString = "Data Source";
            string query = "SELECT AracID, Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum FROM Araclar";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Araclar", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            bosyerler();
            label5.Visible = false;
            txtarama.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            ortalama();
            label5.Visible = false;
            txtarama.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            ortalamakazanc();
            label5.Visible = false;
            txtarama.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            kacarac();
            label5.Visible = false;
            txtarama.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            listele();
            txtarama.Visible = true;
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Düzenleme";
            btnColumn.Name = "duzenlebuton";
            btnColumn.Text = "Düzenle";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnColumn);
            // DataGridView'e buton sütunu ekleyin
            DataGridViewButtonColumn btnColumn2 = new DataGridViewButtonColumn();
            btnColumn2.HeaderText = "Sil";
            btnColumn2.Name = "Sil";
            btnColumn2.Text = "Sil";
            btnColumn2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnColumn2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtarama.Text;
            if (string.IsNullOrEmpty(filterText))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                // Verileri filtreleme
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("MarkaModel LIKE '%{0}%' OR Convert(Plaka, 'System.String') LIKE '%{0}%'", filterText);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer tıklanan hücre bir buton hücresiyse
            if (e.ColumnIndex == dataGridView1.Columns["duzenlebuton"].Index && e.RowIndex >= 0)
            {
                // Tıklanan satırın verilerini alın
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["AracID"].Value);
                string plaka = row.Cells["Plaka"].Value.ToString();
                string markaModel = row.Cells["MarkaModel"].Value.ToString();
                DateTime girisTarihi = Convert.ToDateTime(row.Cells["GirisTarihi"].Value);
                DateTime? cikisTarihi = null;
                if (row.Cells["CikisTarihi"].Value != DBNull.Value)
                {
                    cikisTarihi = Convert.ToDateTime(row.Cells["CikisTarihi"].Value);
                }
                // Düzenleme formunu açın ve verileri geçirin
                Form2 form2 = new Form2(this, id, plaka, markaModel, girisTarihi, cikisTarihi);
                form2.OnUpdate += (updatedId, updatedPlaka, updatedMarkaModel, updatedGirisTarihi, updatedCikisTarihi, updatedDurum) =>
                {
                    UpdateDatabase(form2.Id, form2.Plaka, form2.MarkaModel, form2.GirisTarihi, form2.CikisTarihi);
                };

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    listele();
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["Sil"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Silme işlemi için ilgili metodu çağırabiliriz
                    DeleteRecord(e.RowIndex);
                }
            }

        }
          private void UpdateDatabase(int id, string plaka, string markaModel, DateTime girisTarihi, DateTime? cikisTarihi)
        {
            string connectionString = "Data Source";
            string query = "UPDATE Araclar SET Plaka = @plaka, MarkaModel = @markaModel, GirisTarihi = @girisTarihi, CikisTarihi = @cikisTarihi WHERE AracID = @id";
            string durum = cikisTarihi.HasValue ? "Dışarıda" : "İçerde"; // Çıkış tarihine göre durumu belirle

            using (SqlConnection bglnt = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, bglnt);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@plaka", plaka);
                cmd.Parameters.AddWithValue("@markaModel", markaModel);
                cmd.Parameters.AddWithValue("@girisTarihi", girisTarihi);
                // Çıkış tarihi null ise, veritabanında bu alanı null olarak ayarlar
                if (cikisTarihi == null)
                {
                    cmd.Parameters.AddWithValue("@cikisTarihi", DBNull.Value);
                    if (!checkBox1.Checked)
                    {
                        cmd.Parameters.AddWithValue("@durum", "İçerde");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@durum", "Dışarıda");
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@cikisTarihi", cikisTarihi.Value);
                    cmd.Parameters.AddWithValue("@durum", "İçerde"); // Set durum to "İçerde" regardless of checkBox2 state
                }

                bglnt.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void bosyerler()
        {
            string connectionString = "Data Source";
            using (SqlConnection veribaglanti = new SqlConnection(connectionString))
            {
                try
                {
                    veribaglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Araclar WHERE Durum = 'İçerde'", veribaglanti);
                    int icerdekiAracSayisi = (int)cmd.ExecuteScalar();
                    int bosYerSayisi = toplamKapasite - icerdekiAracSayisi;

                    DataTable sonucTable = new DataTable();
                    sonucTable.Columns.Add("Boş Yer Sayısı", typeof(int));
                    DataRow row = sonucTable.NewRow();
                    row["Boş Yer Sayısı"] = bosYerSayisi;
                    sonucTable.Rows.Add(row);

                    dataGridView1.DataSource = sonucTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    if (veribaglanti.State == ConnectionState.Open)
                    {
                        veribaglanti.Close();
                    }
                }

            }
        }
        private void kacarac()
        {
            string connectionString = "Data Source";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("select count(Durum) AS [Araç Sayısı] from Araclar", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }
        }
        private void ortalama()
        {
            string connectionString = "Data Source";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT DATEDIFF(hour, GirisTarihi, CikisTarihi) AS KalisSuresi FROM Araclar WHERE CikisTarihi IS NOT NULL", baglanti);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int toplamSaat = 0;
                    int aracSayisi = 0;

                    while (reader.Read())
                    {
                        aracSayisi++;
                        toplamSaat += reader.GetInt32(0);
                    }

                    reader.Close();

                    if (aracSayisi > 0)
                    {
                        double ortalamaSure = (double)toplamSaat / aracSayisi;
                        dataGridView1.Columns.Add("Column1", "Araç Sayısı");
                        dataGridView1.Columns.Add("Column2", "Ortalama Süre");
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewTextBoxCell deger = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell ortalama = new DataGridViewTextBoxCell();
                        deger.Value = aracSayisi;
                        ortalama.Value = ortalamaSure.ToString("N2");
                        row.Cells.Add(deger);
                        row.Cells.Add(ortalama);
                        dataGridView1.Rows.Add(row);
                    }
                    else
                    {
                        MessageBox.Show("Henüz çıkış yapmış araç bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ortalama kalış süresi hesaplanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ortalamakazanc()
        {
            string connectionString = "Data Source";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT DATEDIFF(hour, GirisTarihi, CikisTarihi) AS KalisSuresi FROM Araclar WHERE CikisTarihi IS NOT NULL", baglanti);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int toplamSaat = 0;
                    int aracSayisi = 0;

                    while (reader.Read())
                    {
                        aracSayisi++;
                        toplamSaat += reader.GetInt32(0);
                    }

                    reader.Close();

                    if (aracSayisi > 0)
                    {
                        double ortalamaSure = (double)toplamSaat / aracSayisi;
                        double ortalamakazanc = (double)ortalamaSure * 50;
                        dataGridView1.Columns.Add("Column1", "Araç Sayısı");
                        dataGridView1.Columns.Add("Column2", "Ortalama Kazanç");
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewTextBoxCell deger = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell ortalama = new DataGridViewTextBoxCell();
                        deger.Value = aracSayisi;
                        ortalama.Value = ortalamakazanc.ToString("N2") + " ₺";
                        row.Cells.Add(deger);
                        row.Cells.Add(ortalama);
                        dataGridView1.Rows.Add(row);
                    }
                    else
                    {
                        MessageBox.Show("Henüz çıkış yapmış araç bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ortalama kalış süresi hesaplanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteRecord(int rowIndex)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            int id = Convert.ToInt32(row.Cells["AracID"].Value);

            string connectionString = "Data Source";
            string query = "DELETE FROM Araclar WHERE AracID = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            // DataGridView'den ilgili satırı kaldırın
            dataGridView1.Rows.RemoveAt(rowIndex);

            MessageBox.Show("Kayıt başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      

    }
}