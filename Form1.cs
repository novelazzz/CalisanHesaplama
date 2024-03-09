using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace LupaFiyatHesaplama
{
     
    public partial class Form1 : Form
    {
        private decimal toplamUcret;
        private int fisTutari;
        private string fisTuru;
        ArrayList fisTutariList = new ArrayList();
        int fisToplam = 0;
        public static OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        public Form1()
        {
            InitializeComponent();
        }
        void griddoldur()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=hesap.accdb");
            da = new OleDbDataAdapter("SELECT * FROM Tablo1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Tablo1");
            dataGridView1.DataSource = ds.Tables["Tablo1"];
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();            
        }


        private void button1_Click(object sender, EventArgs e)
        {        
            // Kullanıcı girişleri

            DateTime baslangicSaat = DateTime.Parse(isBasBox.Text);
            DateTime bitisSaat = DateTime.Parse(isBitBox.Text);
            string isTur = isTurBox.SelectedItem.ToString();

            // Saat ücretini ve ek ücreti hesapla

            decimal saatUcreti = 0;
            decimal ekUcret = 0;

            switch (isTur)
            {
                case "Birinci Grup İşleri":

                    saatUcreti = 650; //Bu iş türü için belirlenen ücret
                    break;

                case "İkinci Grup İşleri":

                    saatUcreti = 750; //Bu iş türü için belirlenen ücret
                    break;

                case "Stand":

                    saatUcreti = 900; //Bu iş türü için belirlenen ücret
                    break;
            }

            //Toplam çalışma süresi ve ücreti hesapla
            TimeSpan calismaSuresi = bitisSaat - baslangicSaat;
            

            if (calismaSuresi.TotalHours > 8)
            {
                ekUcret = (decimal)(calismaSuresi.TotalHours - 8) * 100;
            }           

            foreach (int fisTutari in fisTutariList)
            {
                fisToplam = fisToplam + fisTutari;
            }
            MessageBox.Show($"Toplam fiş tutarı: {fisToplam:C} ");


            toplamUcret = saatUcreti + ekUcret ;
            toplamUcret += fisToplam;

            string adSoyad = calisanComboX.SelectedItem.ToString();

            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO  Tablo1 (Ad_Soyad,isBasTarihi,isBitTarihi,isTürü,fisTut,fisTuruss,toplamAlacak) values (@adSoyad , @baslangicSaat,@bitisSaat , @isTur ,@fisToplam , @fisTuru , @toplamUcret)";
            cmd.Parameters.AddWithValue("@adSoyad", adSoyad);
            cmd.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
            cmd.Parameters.AddWithValue("@bitisSaat", bitisSaat);
            cmd.Parameters.AddWithValue("@isTur", isTur);
            cmd.Parameters.AddWithValue("@fisToplam", fisToplam);
            cmd.Parameters.AddWithValue("@fisTuru", fisTuru);
            cmd.Parameters.AddWithValue("@toplamUcret", toplamUcret);
            cmd.ExecuteNonQuery();
            con.Close();

            griddoldur();






            MessageBox.Show($"Toplam Ücret: {toplamUcret:C}");
            MessageBox.Show($"Mesai Ücreti: {ekUcret:C}");
            listBox1.Items.Add("İş başlangıç tarihi: " + baslangicSaat);
            listBox1.Items.Add("İş bitiş tarihi: " + bitisSaat);
            listBox1.Items.Add("İş türü: " + isTur);
            listBox1.Items.Add("Toplam Ücret: " + toplamUcret);
            listBox1.Items.Add("Toplam Fiş Ücreti: " + fisToplam);       

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
            if (checkBox1.Checked == true)
            {
                label5.Enabled = true;
                label6.Enabled = true;
                fisTutarBox.Enabled = true;
                fisTuruBox.Enabled = true;
                button2.Enabled = true;                
            }
            else
            {
                label5.Enabled = false;
                label6.Enabled = false;
                fisTutarBox.Enabled = false;
                fisTuruBox.Enabled = false;
                button2.Enabled = false;
            }           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Fiş Tutar Sekmesi
            fisTutari = Convert.ToInt32(fisTutarBox.Text);           
            string fisTuru = fisTuruBox.Text;                   
            fisTutariList.Add(fisTutari);            
            fisTutarBox.Clear();      
                       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calisanComboX.Items.Add(calisanEkleBox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calisanComboX.Items.Remove(calisanComboX.SelectedItem);
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Tablo1 WHERE Ad_Soyad=" + calisanComboX.SelectedItem + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hesapDataSet1.Tablo1' table. You can move, or remove it, as needed.
            this.tablo1TableAdapter.Fill(this.hesapDataSet1.Tablo1);

        }
    }
}
