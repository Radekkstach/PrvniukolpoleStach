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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zadej N náhodných čísel (0,100) a B. Ukaze se pole, které bude obsahovat všechna čísla menší než číslo B, pole bude setříděné. Nové pole, které bude obsahovat všechna čísla větší než zadané číslo B, pole je setříděné.", "Prvni ukol");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nezáporná celá čísla, mezi nimi se vyskytuje alespoň minimálně jedna 0.Kladná čísla z ListBox až po první 0 uložte do pole.Vypíše se podíl prvního prvku a posledního prvku pole. Všechny prvky včetně jejich pořadí v poli, které jsou menší než poslední prvek pole.", "Druhy ukol");

        }
    }
}
