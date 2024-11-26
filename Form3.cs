using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finalproject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Finalproject
{
    
    public partial class Form3 : Form 
    {
        private List<Product> addedProducts = new List<Product>();
        
        private Login objLogin;
        private ProductDatabase productDatabase;
        private double totalPrice = 0;
        private string productCode; 
        private bool productFound;
        public double PromotionValue = 0 ;
        double recieve;
        double tangtorn;


        public Form3(Login paa,double value1)
        {
            InitializeComponent();
            objLogin = paa;
            productDatabase = new ProductDatabase();

            PromotionValue = value1;



        }
        public void UpdatePromotionValue(double newPromotionValue)
        {
            PromotionValue = newPromotionValue;
            


        }
        double discountedTotalPrice;
        public void calculate()
        {
           discountedTotalPrice = 0;

            foreach (var product in addedProducts)
            {
                double discountedPrice = product.Price*(1 - PromotionValue);
                discountedTotalPrice += discountedPrice;
            }
            
            label3.Text = "ราคาหลังหักส่วนลด: " + discountedTotalPrice.ToString("C"); 
        }

        public void process()
        {
            
            productCode = textBox2.Text;
            

            foreach (var product in productDatabase.Products)
            {
                if (product.ProductCode == productCode)
                {
                    
                    textBox1.Text = product.ProductName;
                    textBox3.Text = product.Price.ToString();


                    addedProducts.Add(product);

                    string productDetails = product.ProductCode + " - " + product.ProductName + " - " + product.Price.ToString("C");
                    listBox1.Items.Add(productDetails);
                    totalPrice += product.Price;
                    label7.Text = "ราคารวม = " + totalPrice;
                    productFound = true;
                    break;
                }
                
            }

            if (!productFound)
            {

                MessageBox.Show("ไม่พบสินค้าตามรหัสที่กรอก", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox3.Clear();

            }
            textBox2.Clear();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

            label1.Text = "ชื่อพนักงงาน: " + objLogin.Name;
            pictureBox1.ImageLocation = Application.StartupPath + "\\ploy.PNG";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            process();
            calculate();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox3.Clear();
            label3.Text = "";
            totalPrice = 0;
            label7.Text = "";
            textBox5.Clear();


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    process();
                    calculate();
                    e.Handled = true;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form5 form5 = new Form5(this);
            form5.ShowDialog();
            



        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (addedProducts.Count == 0)
            {
                MessageBox.Show("ไม่มีสินค้าในรายการ!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form6 form6 = new Form6(addedProducts, discountedTotalPrice);
            form6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)//ตั้งค่าดป็นกดenter แทน กดปุ่ม
        {
             recieve = 0;
            if (e.KeyChar == (char)13)//
            {
                recieve = 0;
                if (productFound)
                {
                    recieve = Convert.ToInt64(textBox4.Text);
                    tangtorn = recieve - discountedTotalPrice;
                    textBox5.Text = tangtorn.ToString();
                    
                }
                else
                {
                    MessageBox.Show("กรุณากรอกสินค้า");
                }
                textBox4.Clear();
            }
        }
    }
}
 

    


