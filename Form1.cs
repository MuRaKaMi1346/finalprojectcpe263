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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int i;
        async void StartProgressBar() //method ตรงหลอดดาวน์โหลด
        {
            await Task.Delay(1000);//ตั้งเวลาดีเลย์ 1000 millisecก่อนจะโหลด
            progressBar1.Style = ProgressBarStyle.Continuous;//เลือกรูปแบบการโหลด
            progressBar1.Value = 0;
            for (i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)//Loopเพื่ออัปเดตค่า ProgressBar
            {
                progressBar1.Value = i;
                this.Text = i.ToString() + "%";
                System.Threading.Thread.Sleep(40);

                if(i == progressBar1.Maximum)//ถ้าโหลดเสร็จแล้ว
                {
                    await Task.Delay(1000);// ตั้งเวลาดีเลย์ 1000 millisecก่อนเปิดฟอร์มถัดไป
                    this.Hide();//ซ่อนฟอร์มเดิม
                    Form2 form2 = new Form2();//สร้างออบเจกต์ฟอร์มสอง
                    form2.ShowDialog();//แสดงฟอร์มสอง
                    this.Close();//ปิดฟอร์มเดิม
                }

            }
            
        }
       


        private void Form1_Load(object sender, EventArgs e)
        {
            StartProgressBar();//method หลอดดาวน์โหลดเพื่อเรียกใช้เวลาเปิดฟอร์มขึ้นมา

        }
    }
}

 

