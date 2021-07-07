using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOO_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AirCraft Abs = new AirCraft("Транспортний", 10, 2);
            Abs.ShowInfo();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Поточна кількість об'єктів: {AirCraft.Count}", "Увага!", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CivilAir civilAbs = new CivilAir("Транспортний", 10, 2, 10000);
            civilAbs.ShowInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MilitaryAir militaryAbs = new MilitaryAir("Винищувач", 40, 4);
            militaryAbs.ShowInfo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CivilAir civilParam = new CivilAir();
            civilParam.ShowInfo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MilitaryAir militaryParam = new MilitaryAir();
            militaryParam.ShowInfo();
        }
    }
}
