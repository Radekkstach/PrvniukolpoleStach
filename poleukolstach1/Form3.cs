using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poleukolstach1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //V komponentě ListBox jsou nezáporná celá čísla, mezi nimi se vyskytuje alespoň minimálně jedna 0. 
        //    Kladná čísla z ListBox až po první 0 uložte do pole.Vypište podíl prvního prvku a posledního prvku pole.
        //    Vypište všechny prvky včetně jejich pořadí v poli, které jsou menší než poslední prvek pole.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();

        }
        double[] pole1;
        double[] pole2;
        private void button2_Click(object sender, EventArgs e)
        {
            int pozice = 0;
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            pole1 = new double[listBox1.Items.Count];
            bool prasik = false;
            pole2 = new double[listBox1.Items.Count];
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                double cislo = Convert.ToInt32(listBox1.Items[i]);
                pole2[i] = cislo;
            }
            for(int i = 0; i <= listBox1.Items.Count && !prasik; i++)
            {
                double cislo = Convert.ToInt32(listBox1.Items[i]);
                if (cislo == 0)
                {
                    prasik = true;
                    pozice = i +1;
                }
                
            }
            pole1 = pole2.Skip(pozice).ToArray();
            foreach(int wasik in pole1)
            {
                listBox2.Items.Add(wasik);
            }
            double podil = pole1[0] / pole1[pole1.Length -1];
            MessageBox.Show("" + podil);

            double posledni = pole1[pole1.Length - 1];
            for(int i = 0; i < pole1.Length; i++)
            {
                if(pole1[i] < posledni)
                {
                    listBox3.Items.Add(pole1[i] + " Poradi: " + (i+1));
                }
            }

        }
        
    }
}
