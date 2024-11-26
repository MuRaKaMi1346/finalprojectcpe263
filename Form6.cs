using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproject
{
    public partial class Form6 : Form
    {
        private List<Product> products;  
        private double totalPrice;
        public Form6(List<Product> products, double totalPrice)
        {
            InitializeComponent();
            this.products = products;
            this.totalPrice = totalPrice;
        }
        
        private void Form6_Load(object sender, EventArgs e)
        {
            foreach (var product in products)
            {
                listBox1.Items.Add(product.ProductCode + " - " + product.ProductName + " - " + product.Price.ToString("C"));
            }
            label1.Text = "ราคาหลังหักส่วนลด : " + totalPrice.ToString("C");
        }
    }
}
