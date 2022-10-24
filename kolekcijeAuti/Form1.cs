using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolekcijeAuti
{
    public partial class Form1 : Form
    {
        List<Auti> listAuta = new List<Auti>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxKotaci.Text) % 2 == 0)
            {
                try
                {
                    Auti auti = new Auti(textBoxModel.Text, Convert.ToInt32(textBoxGodina.Text), Convert.ToInt32(textBoxKotaci.Text), "");
                    listAuta.Add(auti);
                    textBoxModel.Clear();
                    textBoxKotaci.Clear();
                    textBoxGodina.Clear();
                    MessageBox.Show("Uspješan unos!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception greska)
                {
                    MessageBox.Show("Pogrešan unos! \r\n" + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
               
                MessageBox.Show("nije dovzoljeno upisati neparni broj kotaca! \r\n", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonispisi_Click(object sender, EventArgs e)
        {
            textBoxIspis.Text = "Model" + "\tGodPro" + "\tBr Kotaca"  + "\t\tKategorija\r\n";
            foreach (Auti auti in listAuta)
            {
                textBoxIspis.AppendText(auti.ToString() + "\r\n");
            }
        }

        private void buttonObradi_Click(object sender, EventArgs e)
        {

            textBoxIspis.AppendText("___________________Obradivanje_________________________\r\n");
            foreach (Auti auti in listAuta)
            {
                

                if (auti.BrojKotaca ==2)
                {
                    auti.Dodatak = "Motocikl";
                }
                if (auti.BrojKotaca == 4 )
                {
                    auti.Dodatak = "auto";
                }
                if (auti.BrojKotaca > 4)
                {
                    if (auti.BrojKotaca % 2 != 0)
                    {
                        auti.Dodatak = "Nepoznato vozilo";
                    }
                    else
                    {
                        auti.Dodatak = "kamion";
                    }
                        
                }
            }
            foreach (Auti auti in listAuta)
            {
                textBoxIspis.AppendText(auti.ToString() + "\r\n");
            }
        }
    }
}
