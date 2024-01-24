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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reg_Click(object sender, EventArgs e)
        {
            registresanas registresanas1 = new registresanas();
            registresanas1.lietotajvards = lietotajvreg.Text;
            registresanas1.parole = parolereg.Text;
            registresanas1.vards = vards.Text;
            registresanas1.uzvards = uzvards.Text;
            registresanas1.epasts = epasts.Text;
            registresanas1.registrelietotaju();
            Form form1 = new Form();
            form1.Show();
            this.Dispose();
        }
      

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

    class registresanas
    {
        public string lietotajvards { get; set; }
        public string parole { get; set; }
        public string vards { get; set; }
        public string uzvards { get; set; }
        public string epasts { get; set; }
        public void registrelietotaju()
        {
            Konekcija();
            using (SQLiteConnection connection = Konekcija())
            {
                //Pārbauda vai ir izveidots savienojums
                if (connection.State == ConnectionState.Open)
                {
                    string query = "INSERT INTO Lietotajs (Lietotajvards, Parole, Vards, Uzvards, Epasts) " +
                           "VALUES (@Lietotajvards, @Parole, @Vards, @Uzvards, @Epasts)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@Lietotajvards", lietotajvards);
                        command.Parameters.AddWithValue("@Parole", parole);
                        command.Parameters.AddWithValue("@Vards", vards);
                        command.Parameters.AddWithValue("@Uzvards", uzvards);
                        command.Parameters.AddWithValue("@Epasts", epasts);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Handle the case where the connection couldn't be opened
                    // (e.g., display an error message or log the issue).
                }
            }
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
