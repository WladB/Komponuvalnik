using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komponuvalnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gPizza = panel5.CreateGraphics();
            gShar = panel6.CreateGraphics();
        }
        Graphics gPizza;
        Graphics gShar;
        Container pizza = new Container();
        Container shar; 
        byte s;

        private void Form1_Load(object sender, EventArgs e)
        {
            pizza.size = new Size(170, 170);
            pizza.p = new Point(20, 20);
            pizza.components.Add(new PizzaBase());
            panel1.Enabled = true;
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            s = Convert.ToByte(((Button)sender).Tag);
            groupBox1.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (shar != null)
            {
                switch (s)
                {
                    case 0: shar.components.Add(new Onion()); break;
                    case 1: shar.components.Add(new Hunting_sausages()); break;
                    case 2: shar.components.Add(new Mushrooms()); break;
                    case 3: shar.components.Add(new Provencal_herbs()); break;
                    case 4: shar.components.Add(new Tomato()); break;
                    case 5: shar.components.Add(new Souse_tomato()); break;
                    case 6: shar.components.Add(new Souse_green()); break;
                    case 7: shar.components.Add(new Souse_chise()); break;
                }
                Component.g = gShar;
                shar.draw();
                groupBox1.Enabled = false;
            }
            else {
                MessageBox.Show("Створіть шар для додавання на нього компонентів");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            gShar.Clear(Color.Silver);
            shar = new Container();
            shar.size = new Size(135, 135);
            shar.p = new Point(9, 10);
            button11.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pizza.components.Add(shar.Clone());
            Component.g = gPizza;
            gShar.Clear(Color.Silver);
            shar = null;
            pizza.draw();
            button11.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (s)
            {
                case 0: pizza.components.Add(new Onion(135,135,17, 17)); break;
                case 1: pizza.components.Add(new Hunting_sausages(135, 135, 17, 17)); break;
                case 2: pizza.components.Add(new Mushrooms(135, 135, 17, 17)); break;
                case 3: pizza.components.Add(new Provencal_herbs(135, 135, 17, 17)); break;
                case 4: pizza.components.Add(new Tomato(135, 135, 17, 17)); break;
                case 5: pizza.components.Add(new Souse_tomato(135, 135, 17, 17)); break;
                case 6: pizza.components.Add(new Souse_green(135, 135, 17, 17)); break;
                case 7: pizza.components.Add(new Souse_chise(135, 135, 17, 17)); break;
            }
            Component.g = gPizza;
            pizza.draw();
            groupBox1.Enabled = false;
        }
    }
}
