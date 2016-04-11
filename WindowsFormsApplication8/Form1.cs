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
   
    public partial class Form1 : Form
    {
         OleDbConnection bağlantıYolu;
         public void Baglanti()
         {
             try
             {
                 bağlantıYolu = new OleDbConnection
          ("Provider=Microsoft.ACE.OLEDB.12.0;"+
     "Data Source=MesajTahtasi.accdb");

                 bağlantıYolu.Open();
             }
             catch (OleDbException ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }   
        

         private void VeriSil(int id )
         {
             Baglanti();
             try
             {
                 OleDbCommand silSorgusu = new OleDbCommand();
                 silSorgusu.CommandText = "DELETE From MesajTahtasi Where (ID)=" + id + "";
                 silSorgusu.Connection = bağlantıYolu;
                 silSorgusu.ExecuteNonQuery();
                 bağlantıYolu.Close();
             }catch (OleDbException ex)
             {
                 MessageBox.Show(ex.Message);
             }
             
             
         }
         private void VeriEkle(String isim, String mesaj)
         {
             Baglanti();
             OleDbCommand kayıtSorgusu = new OleDbCommand();  // sorgu örneği oluşturuldu
             kayıtSorgusu.CommandText =
      "INSERT Into MesajTahtasi (isim, mesaj) Values ('" + isim + "' ,'" + mesaj + "' )"; 
             // sorguya sql söz dizilimi atandı
             kayıtSorgusu.Connection = bağlantıYolu; // sorgu bağlantı yoluna gönderildi
             kayıtSorgusu.ExecuteNonQuery();   // sorgu işletildi
             bağlantıYolu.Close();       // bağlantı kapatıldı

         }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mesajTahtasiDataSet1.MesajTahtasi' table. You can move, or remove it, as needed.
           
            this.mesajTahtasiTableAdapter.Fill(this.mesajTahtasiDataSet.MesajTahtasi);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.VeriEkle(txtIsim.Text, txtMesaj.Text);
            this.mesajTahtasiTableAdapter.Fill(this.mesajTahtasiDataSet.MesajTahtasi);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Form1 form1 =  new Form1();

            int studentID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            form1.VeriSil(studentID);
            this.mesajTahtasiTableAdapter.Fill(this.mesajTahtasiDataSet.MesajTahtasi);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a=new Form2();
            a.Show();
        }

       
       
    }
}
