using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finalproject;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Finalproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        Login objLogin;
        private object value1;

        public void StartLoading()//method ปิดฟร์อมปัจจุบันและส่งค่าไปฟอร์มหน้าใหม่
        {
         


            this.Hide();// ซ่อนฟอร์มปัจจุบัน (Form2)
            Form3 form3 = new Form3(objLogin,0);//สร้างฟอร์มใหม่ Form3 โดยส่งอ็อบเจ็กต์ objLogin และค่า 0
            form3.ShowDialog();//เปิดฟอร์ม3
            this.Close();//ปิดหน้าฟอร์มปัจจุบัน

        }
        public void loginProcess()//method การรับค่าของLogin มาเก็บไว้ในตัวแปร
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            objLogin = new Login(name, password);
        }

        public void loginProcessEnter()//method เวลากดปุ่มlogin  ต้องกรอกข้อมูลให้ครบถ้วนก่อน
        {
            
                if (!(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)))//เมื่อ textbox 
                {
                    loginProcess();
                    StartLoading();
                    
                }
                else
                {
                    MessageBox.Show("กรอกข้อมูลให้ครบถ้วน");
                    
                }
            
        }

        public void updatestate()//method กำหนดการทำงานของปุ่ม ปุ่มจะใช้งานได้ต่อเม
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            updatestate();
            

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSlateBlue;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.CornflowerBlue;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updatestate();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            updatestate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            loginProcess();
            StartLoading();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginProcessEnter();
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginProcessEnter();
                e.Handled = true;
            }
        }
    }
}

