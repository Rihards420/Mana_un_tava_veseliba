using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace mana_un_tava_veseliba
{
    public partial class Pierakstisanas : Form
    {
       
        public Pierakstisanas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pierakstities_Click(object sender, EventArgs e)
        {

            ielogosanas ielogosanas1 = new ielogosanas();
            ielogosanas1.lietotajvards = Lietotajvards.Text;
            ielogosanas1.parole = parole.Text;
            if (string.IsNullOrEmpty(Lietotajvards.Text) == false)
            { 
                
            }
            else
            {
                MessageBox.Show("Ievadiet vardu!");
            }
            

            if (string.IsNullOrEmpty(parole.Text) ==false)
            {
                    ielogosanas1.ParbaudaLietotaju();
            }
            else
            {
                MessageBox.Show("Ievadiet paroli!");
            }

            Form3 form3 = new Form3();
            form3.Show();
        }

        private void reg_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Pierakstisanas_Load(object sender, EventArgs e)
        {

        }
    }
    class ielogosanas
    {

        public string lietotajvards { get; set; }
        public string parole { get; set; }
       
        public void ParbaudaLietotaju()
        {
            //pārbauda ievadīto lietotājvārdu un paroli, kura tiek šifrēta, ja kau kas nesakrīt, tiek izvadīts paziņojums, ka ievadītie dati ir nepareizi

        }
        static SQLiteConnection Konekcija()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=Mana_Tava_Veseliba.db; Version = 3; New = True; Compress =  True;");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

    }
    

}
