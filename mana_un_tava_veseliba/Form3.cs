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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        { int a = 0;//Šie skaitļi ir dati, ko iegūst no viedpulksteņa
            int b = 0;//Šie skaitļi ir dati, ko iegūst no viedpulksteņa
            int c = 0;//Šie skaitļi ir dati, ko iegūst no viedpulksteņa
            int d = 0;//Šie skaitļi ir dati, ko iegūst no viedpulksteņa
            int h = 0;//Šie skaitļi ir dati, ko iegūst no viedpulksteņa
            int f = 0;//Šie skaitļi ir dati, ko iegūst no viedpulksteņa
            miegs miegs1 = new miegs();
            miegs1.miegadaudzums = a;
            miegs1.miegakvalitate = b;
            miegs1.izvademiegs();
            miegs1.ieteikums();
            aktivitates akt = new aktivitates();
            akt.aktivitasuilgums = c;
            akt.nodedzinataskalorijas = d;
            akt.izvadeaktivitates();
            akt.ieteikums();
            uzturs uzt = new uzturs();
            uzt.uznemtaskal = h;
            uzt.uznemtaisudens = f;
            uzt.izvadeuzturs();
            uzt.ieteikums();

        }

        private void uzt_ievade_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Miega_ievade_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Dispose();
        }
    }
    class miegs
    {
        public int miegadaudzums { get; set; }
        public int miegakvalitate { get; set; }
        public void izvademiegs()
        {
            //izvada iegūtos datus uz ekrāna
        }
        public void ieteikums()
        {
            //pēc noteiktiem nosacījumiem izlasa no DB ieteikumu un izvada to uz ekrāna
        }
    }
    class aktivitates
    {
        public int aktivitasuilgums { get; set; }
        public int nodedzinataskalorijas { get; set; }
        public void izvadeaktivitates()
        {
            //izvada iegūtos datus uz ekrāna
        }
        public void ieteikums()
        {
            //pēc noteiktiem nosacījumiem izlasa no DB ieteikumu un izvada to uz ekrāna
        }
    }
    class uzturs
    {
        public int uznemtaskal { get; set; }
        public int uznemtaisudens { get; set; }
        public void izvadeuzturs()
        {
            //izvada iegūtos datus uz ekrāna
        }
        public void ieteikums()
        {
            //pēc noteiktiem nosacījumiem izlasa no DB ieteikumu un izvada to uz ekrāna
        }
    }
}
