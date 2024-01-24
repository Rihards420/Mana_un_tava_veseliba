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
        public Pierakstisanas()
        {
            InitializeComponent();
        }

        private void pierakstities_Click(object sender, EventArgs e)
        {

            Konekcija();


            ielogosanas ielogosanas1 = new ielogosanas();
            ielogosanas1.lietotajvards = Lietotajvards.Text;
            ielogosanas1.parole = parole.Text;
            if (string.IsNullOrEmpty(Lietotajvards.Text))
            { }
            else
            {
                if (string.IsNullOrEmpty(parole.Text))
                { }
                else
                {
                    ielogosanas1.parbaudalietotajvardu();

                }

            }
        }

        private void reg_Click(object sender, EventArgs e)
        {
            Konekcija();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
    class ielogosanas
    {

        public string lietotajvards { get; set; }
        public string parole { get; set; }
       
        public void parbaudalietotajvardu()
        {
            //pārbauda ievadīto lietotājvārdu un paroli, kura tiek šifrēta, ja kau kas nesakrīt, tiek izvadīts paziņojums, ka ievadītie dati ir nepareizi

        }
      
    }
    

}
