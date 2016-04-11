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

namespace WindowsFormsApplication8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection bağlantıYolu;
        public void Baglanti()
        {
            try
            {
                bağlantıYolu = new OleDbConnection
         ("Provider=Microsoft.ACE.OLEDB.12.0;" +
    "Data Source=MesajTahtasi.accdb");

                bağlantıYolu.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VeriSil(int id)
        {
            Baglanti();
            try
            {
                OleDbCommand silSorgusu = new OleDbCommand();
                silSorgusu.CommandText = "DELETE From MesajTahtasi Where (ID)=" + id + "";
                silSorgusu.Connection = bağlantıYolu;
                silSorgusu.ExecuteNonQuery();
                bağlantıYolu.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            VeriSil(28);
            form1.Refresh();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mesajTahtasiDataSet1.MesajTahtasi' table. You can move, or remove it, as needed.


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Refresh();
        }
    }
}
