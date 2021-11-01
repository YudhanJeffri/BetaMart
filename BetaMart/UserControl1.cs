using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace BetaMart
{
    public partial class UserControl1 : UserControl
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\XII RPL 6\UKK\OOP\BetaMartDB.accdb");
        string valueRadio = "";
        OleDbDataReader dr;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        int UserExist;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tanggalMasuk = tanggal_masuk.Value.ToShortDateString();

            bool isChecked = radio_impor.Checked;
            if (isChecked)
            {
                valueRadio = radio_impor.Text;
            }
            else
                valueRadio = radio_lokal.Text;

           /* Console.WriteLine(nama_buah.Text);
            Console.WriteLine(harga_beli.Text);
            Console.WriteLine(valueRadio);
            Console.WriteLine(harga_jual.Text);
            Console.WriteLine(stok.Text);
            Console.WriteLine(tanggalMasuk);*/

            if (nama_buah.Text != ""
                && harga_beli.Text != ""
                && valueRadio != ""
                && harga_jual.Text != ""
                && stok.Text != ""
                && tanggalMasuk != "") {
                try
                {
                    con.Open();
                    cmd = new OleDbCommand(
                        "Insert into DataBuahTbl (nama,harga_beli,jenis_buah,harga_jual,stok,tanggal_masuk)" +
                        "values('" + nama_buah.Text + "','" + harga_beli.Text + "'," +
                        "'" + valueRadio + "','" + harga_jual.Text + "','" + stok.Text + "'," +
                        "'" + tanggalMasuk + "')", con);
                    if (id_buah.Text != "")
                    {
                        MessageBox.Show("ID Buah dilarang di isi!");
                        con.Close();
                    }
                    else {
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Berhasil Disimpan");
                        fillgrid();
                    }
                    
                }
                catch (Exception) {
                    MessageBox.Show("Terjadi sebuah kesalahan!");
                    con.Close();
                } finally {
                    con.Close();
                    fillgrid();
                }

            } else {
                MessageBox.Show("Silahkan untuk mengisi semua data kecuali Id Buah!");
            } 

           
        }
        void getData()
        {
            con.Open();
            if (id_buah.Text != "")
            {
                OleDbCommand count = new OleDbCommand("select count(*) from DataBuahTbl where id_buah="+ int.Parse(id_buah.Text) + " ", con);
                cmd = new OleDbCommand("select nama,harga_beli,jenis_buah,harga_jual,stok,tanggal_masuk from DataBuahTbl where id_buah=" + int.Parse(id_buah.Text) + " ", con);
            
                UserExist = (int)count.ExecuteScalar();

                if (UserExist > 0)
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        nama_buah.Text = dr.GetValue(0).ToString();
                        harga_beli.Text = dr.GetValue(1).ToString();
                        if (dr.GetValue(2).ToString() == "Impor")
                        {
                            radio_impor.Checked = true;
                        }
                        else if (dr.GetValue(2).ToString() == "Lokal")
                        {
                            radio_lokal.Checked = true;
                        }
                        harga_jual.Text = dr.GetValue(3).ToString();
                        stok.Text = dr.GetValue(4).ToString();
                        tanggal_masuk.Text = dr.GetValue(5).ToString();

                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Data dengan ID Buah " +id_buah.Text+ " tidak ditemukan!");
                    con.Close();
                }
            }
            else {
                nama_buah.Text = "";
                harga_beli.Text = "";
                radio_impor.Checked = false;
                radio_lokal.Checked = false;
                harga_jual.Text = "";
                stok.Text = "";
                tanggal_masuk.Text = "";
                con.Close();
            }
            
        }
        void fillgrid() 
        {
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter("select * from DataBuahTbl order by id_buah", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Terjadi sebuah kesalahan!");
                con.Close();
            }
            
        }

        private void radio_impor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string tanggalMasuk = tanggal_masuk.Value.ToShortDateString();

            bool isChecked = radio_impor.Checked;
            if (isChecked)
            {
                valueRadio = radio_impor.Text;
            }
            else
                valueRadio = radio_lokal.Text;


            if (id_buah.Text != ""
               && nama_buah.Text != ""
               && harga_beli.Text != ""
               && valueRadio != ""
               && harga_jual.Text != ""
               && stok.Text != ""
               && tanggalMasuk != "" && UserExist > 0)
            {
                try
                {
                    con.Open();
                    cmd = new OleDbCommand(
                        "Update DataBuahTbl set nama='" + nama_buah.Text + "'," +
                        "harga_beli='" + harga_beli.Text + "'," +
                        "jenis_buah='" + valueRadio + "'," +
                        "harga_jual='" + harga_jual.Text + "'," +
                        "stok='" + stok.Text + "'," +
                        "tanggal_masuk='" + tanggalMasuk + "' where id_buah=" + id_buah.Text + " ", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Berhasil");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan!, pesan error : " + ex);
                    con.Close();
                }
                finally
                {
                    fillgrid();
                }
            }
            else if (UserExist == 0) {
                MessageBox.Show("Data dengan ID Buah "+ id_buah.Text + " tidak ditemukan!");
            } else 
            {
                MessageBox.Show("Silahkan untuk mengisi semua data!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (UserExist == 0)
            {
                MessageBox.Show("Data dengan ID Buah " + id_buah.Text + " tidak ditemukan!");
            }
            else {
                try
                {
                    con.Open();
                    cmd = new OleDbCommand("Delete from DataBuahTbl where id_buah=" + id_buah.Text + " ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Berhasil Dihapus");
                    fillgrid();
                }
                catch (Exception ex){
                    MessageBox.Show("Terjadi kesalahan, Pesan error " + ex);
                }
            }
            

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void id_buah_TextChanged(object sender, EventArgs e)
        {
            getData();
            fillgrid();
        }

        private void id_onlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void hargaBeli_onlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void hargaJual_onlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void stok_onlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
