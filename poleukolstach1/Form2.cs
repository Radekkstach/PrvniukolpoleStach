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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        //Do pole načtěte N náhodných čísel(0,100). Pole zobrazte.Vytvořte nové pole, které bude obsahovat všechna čísla menší než zadané číslo B, 
        //    pole bude setříděné.Pole zobrazte. Vytvořte nové pole, které bude obsahovat všechna čísla větší než zadané číslo B, pole bude setříděné.
        //    Použijte metodu Sort, Skip a Take.

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
        int[] pole1;
        int[] pole2;
        int[] pole3;
        Random rnd = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            try
            {
                int ncislo = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                pole1 = new int[ncislo];
                for (int i = 0; i < ncislo; i++)
                {
                    int nahodnecislo = rnd.Next(0, 100);
                    pole1[i] = nahodnecislo;
                    listBox1.Items.Add(pole1[i]);

                }
                pole2 = pole1;
                Array.Sort(pole2);
                int pozice = 0;
                bool picus = false;
                for (int i = 0; i <= pole2.Length && !picus; i++)
                {
                    if (pole2[i] >= b)
                    {
                        pozice = i;
                        picus = true;
                    }

                }
                pole2 = pole2.Take(pozice).ToArray();
                foreach (int mrdka in pole2)
                {
                    listBox2.Items.Add(mrdka);
                }

                pole3 = pole1;
                Array.Sort(pole3);
                int pozice3 = 0;
                bool picus3 = false;
                for (int i = 0; i <= pole3.Length && !picus3; i++)
                {
                    if (pole3[i] > b)
                    {
                        pozice = i;
                        picus3 = true;
                    }

                }
                pole3 = pole3.Skip(pozice).ToArray();
                foreach (int mrdka in pole3)
                {
                    listBox3.Items.Add(mrdka);
                }
            }
            catch {
                MessageBox.Show("Neco si nezadal");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zadej N náhodných čísel (0,100) a B. Ukaze se pole, které bude obsahovat všechna čísla menší než číslo B, pole bude setříděné. Nové pole, které bude obsahovat všechna čísla větší než zadané číslo B, pole je setříděné.", "Prvni ukol");

        }
    }
}
