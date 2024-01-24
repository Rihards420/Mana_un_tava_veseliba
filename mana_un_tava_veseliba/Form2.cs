using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                //ievada un saglabā visus lietotāja datus datubāzē, paroli šifrē
            }
        }
    }
}
