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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edienreizie ed = new edienreizie();
            ed.edveids = comboBox1.Text;
            ed.uzndaudz = textBox1.Text;
            ed.ievadeed();
            Form3 form3 = new Form3();
            form3.Show();
            this.Dispose();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
    class edienreizie
    {
        public string edveids { get; set; }
        public string uzndaudz { get; set; }
        public void ievadeed()
        {
            //ievada datus datubāzē, aprēķina kopējo uzņemot pārtikas daudzumu, aiznes uz lietotaja profilu atpakaļ
        }

    }
}
