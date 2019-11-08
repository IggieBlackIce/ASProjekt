using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verarbeitung_und_Interfaces;

namespace GUI
{
    public partial class Form1 : Form
    {
        string suche, regal, produkt, verschiebe;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IFachkonzept.GetRegalNr(new Regal r);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suche = Convert.ToString(textBox1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            regal = Convert.ToString(textBox2.Text);
            IFachkonzept.SchreibeRegal(new Regal(regal));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            regal = Convert.ToString(textBox2.Text);
            IFachkonzept.LöscheRegal(new Regal regal);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            regal = Convert.ToString(textBox2.Text);
            IFachkonzept.AktualisiereRegal(new Regal regal);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            produkt = Convert.ToString(textBox3.Text);
            IFachkonzept.SchreibeProdukt(new Regal produkt);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            produkt = Convert.ToString(textBox3.Text);
            IFachkonzept.LöscheProdukt(new Regal produkt);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            produkt = Convert.ToString(textBox3.Text);
            IFachkonzept.AktualisiereProdukt(new Regal produkt);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            verschiebe = Convert.ToString(textBox4.Text);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
