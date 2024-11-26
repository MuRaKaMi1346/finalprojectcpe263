using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Finalproject
{
    public partial class Form5 : Form
    {
        private Form3 form3;


        public double discount1;

        public Form5(Form3 linkedForm3)
        {
            InitializeComponent();
            form3 = linkedForm3;
           
        }
        public void sentvalue()
        {
            form3.UpdatePromotionValue(discount1);
            form3.calculate();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            discount1 = 0.1;
            sentvalue();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            discount1 = 0.15;
            sentvalue();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            discount1 = 0.20;
            sentvalue();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            discount1 = 0.30;
            sentvalue();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            discount1 = 0.40;
            sentvalue();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            discount1 = 0.50;
            sentvalue();
        }
    }
}
