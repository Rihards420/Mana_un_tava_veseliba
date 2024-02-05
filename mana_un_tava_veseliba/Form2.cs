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
using System.Security.Cryptography;
using System.IO;
using System.Security.Policy;

namespace mana_un_tava_veseliba
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void reg_Click(object sender, EventArgs e)
        {
            registresanas registresanas1 = new registresanas();
            registresanas1.lietotajvards = lietotajvreg.Text;
            registresanas1.parole = parolereg.Text;
            registresanas1.vards = vards.Text;
            registresanas1.uzvards = uzvards.Text;
            registresanas1.epasts = epasts.Text;

            if (Vaivisilaukiaizpilditi() == false)
            {
                registresanas1.registrelietotaju();

                Form form1 = new Form();
                form1.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Aizpildiet visus laukus");
            }
        }
        private bool Vaivisilaukiaizpilditi()
        {
            return string.IsNullOrWhiteSpace(lietotajvreg.Text) ||
                   string.IsNullOrWhiteSpace(parolereg.Text) ||
                   string.IsNullOrWhiteSpace(vards.Text) ||
                   string.IsNullOrWhiteSpace(uzvards.Text) ||
                   string.IsNullOrWhiteSpace(epasts.Text);
        }


        private void Form2_Load(object sender, EventArgs e)
        {

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
                using (SQLiteConnection connection = Konekcija())
                {
                    //Pārbauda vai ir izveidots savienojums
                    if (connection.State == ConnectionState.Open)
                    {
                        string query = "INSERT INTO Lietotajs (Lietotajvards, Parole, Vards, Uzvards, Epasts) " +
                               "VALUES (@Lietotajvards, @Parole, @Vards, @Uzvards, @Epasts)";

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            using (Aes myAes = Aes.Create())
                            {
                                //Ievieto vērtības parametros
                                command.Parameters.AddWithValue("@Lietotajvards", lietotajvards);
                                command.Parameters.AddWithValue("@Parole", EncryptStringToBytes_Aes(parole, myAes.Key, myAes.IV));
                                command.Parameters.AddWithValue("@Vards", vards);
                                command.Parameters.AddWithValue("@Uzvards", uzvards);
                                command.Parameters.AddWithValue("@Epasts", epasts);

                                //Ievieto datus datubāzē
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Savienojums netika izveidots");
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

            public byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
            {
                // Check arguments.
                if (plainText == null || plainText.Length <= 0)
                    throw new ArgumentNullException("plainText");
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("IV");
                byte[] encrypted;

                // Create an Aes object
                // with the specified key and IV.
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;

                    // Create an encryptor to perform the stream transform.
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    // Create the streams used for encryption.
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                //Write all data to the stream.
                                swEncrypt.Write(plainText);
                            }
                            encrypted = msEncrypt.ToArray();
                        }
                    }
                }

                // Return the encrypted bytes from the memory stream.
                return encrypted;
            }

            }
        }

    }

