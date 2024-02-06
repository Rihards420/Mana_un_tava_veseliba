using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace mana_un_tava_veseliba
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void edienreizeREG()
        {
            if (EdienaIZV.SelectedItem != null && !string.IsNullOrWhiteSpace(Kalorijas.Text))
            {
                using (SQLiteConnection connection = Konekcija())
                {
                    try
                    {
                        connection.Open();

                        // parbauda konekciju vai ta ir atverta
                        if (connection.State == ConnectionState.Open)
                        {
                            string query = "INSERT INTO Uzturs (Edienreize_Veids, Uznemto_Kal_Daudz, Uznemtais_Udens_Daudz) " +
                                           "VALUES (@Edienreize_Veids, @Uznemto_Kal_Daudz, @Uznemtais_Udens_Daudz)";

                            using (SQLiteCommand command = new SQLiteCommand(query, connection))
                            {
                                // ievada parametrus
                                command.Parameters.AddWithValue("@Edienreize_Veids", EdienaIZV.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@Uznemto_Kal_Daudz", Kalorijas.Text);
                                command.Parameters.AddWithValue("@Uznemtais_Udens_Daudz", UdensD.Text);

                                // ievieto datus datubaze
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Dati ievadīti veiksmīgi.");
                                }
                                else
                                {
                                    MessageBox.Show("Neviena tabula nav izmainīta.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Konekcija neizdevās.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection after use
                    }
                }
            }
            else
            {
                MessageBox.Show("Lūdzu izvēlaties ēdienreizes veidu un ievadiet kaloriju daudzumu.");
            }
        }




        static SQLiteConnection Konekcija()
        {
            return new SQLiteConnection("Data Source=Mana_Tava_Veseliba.db; Version = 3; New = True; Compress =  True;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edienreizeREG();
            Form3 form3 = new Form3();
            form3.Show();
            this.Dispose();
        }
    }
}
