using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject
{
    public class Product
    {
        public string ProductCode {  get; set; }
        public string ProductName { get; set; }
        public double Price {  get; set; }

        public Product(string code,string name, double price)
        {
            ProductCode
                = code;
            ProductName = name;
            Price = price;
        }
    }
    public class ProductDatabase
    {
        public Product[] Products { get; set; }
        public ProductDatabase()
        {
            Products = new Product[]
            {
                new Product("001", "น้ำดื่ม", 10),
                new Product("002", "ขนมปัง", 25),
                new Product("003", "นมกล่อง", 15),
                new Product("004", "ข้าวโพด", 30),
                new Product("005", "สบู่", 20),
                new Product("006", "แชมพู", 40),
                new Product("007", "ยาสีฟัน", 35),
                new Product("008", "กระดาษทิชชู", 45),
                new Product("009", "น้ำมันพืช", 50),
                new Product("010", "ขนมขบเคี้ยว", 12),
                new Product("011", "ชาเขียว", 20),
                new Product("012", "กาแฟ", 35),
                new Product("013", "น้ำผลไม้", 25),
                new Product("014", "โค้ก", 15),
                new Product("015", "ขนมเค้ก", 50),
                new Product("016", "อาหารสำเร็จรูป", 30),
                new Product("017", "กระดาษ A4", 60),
                new Product("018", "ปากกา", 10),
                new Product("019", "ดินสอ", 5),
                new Product("020", "ไม้บรรทัด", 15),
                new Product("021", "ไฟฉาย", 100),
                new Product("022", "ถ่านไฟฉาย", 25),
                new Product("023", "รองเท้าผ้าใบ", 600),
                new Product("024", "กระเป๋า", 350),
                new Product("025", "เสื้อยืด", 150),
                new Product("026", "กางเกงยีนส์", 400),
                new Product("027", "หมวก", 120),
                new Product("028", "เครื่องเล่นเกม", 3000),
                new Product("029", "โทรศัพท์มือถือ", 10000),
                new Product("030", "หูฟัง", 500),
                new Product("031", "สายชาร์จ", 100),
                new Product("032", "แว่นตากันแดด", 200),
                new Product("033", "นาฬิกาข้อมือ", 800),
                new Product("034", "เครื่องปั่น", 1000),
                new Product("035", "เตารีด", 600),
                new Product("036", "ตู้เย็น", 5000),
                new Product("037", "เครื่องซักผ้า", 7000),
                new Product("038", "ไมโครเวฟ", 2500),
                new Product("039", "เครื่องฟอกอากาศ", 3500),
                new Product("040", "แอร์", 12000),
                new Product("041", "ทีวี", 8000),
                new Product("042", "เครื่องเสียง", 5000),
                new Product("043", "คอมพิวเตอร์", 15000),
                new Product("044", "ปริ้นเตอร์", 2500),
                new Product("045", "แท็บเล็ต", 12000),
                new Product("046", "โน๊ตบุ๊ค", 20000),
                new Product("047", "กล้องถ่ายรูป", 15000),
                new Product("048", "กล้องวงจรปิด", 5000),
                new Product("049", "เครื่องเล่นดีวีดี", 1000),
                new Product("050", "เครื่องชงกาแฟ", 3500),
                new Product("051", "กระติกน้ำร้อน", 700),
                new Product("052", "หุ่นยนต์ดูดฝุ่น", 4500),
                new Product("053", "เครื่องดูดฝุ่น", 2000),
                new Product("054", "เครื่องซักผ้าพร้อมอบผ้า", 8000),
                new Product("055", "ตู้แช่แข็ง", 12000),
                new Product("056", "เครื่องตรวจจับควัน", 800),
                new Product("057", "เครื่องตั้งเวลาปิดไฟ", 100),
                new Product("058", "สายไฟยาว", 150),
                new Product("059", "กล้องวงจรปิดไร้สาย", 4000),
                new Product("060", "เครื่องบดกาแฟ", 1500),
                new Product("061", "เครื่องพิมพ์บัตร", 2000),
                new Product("062", "จอคอมพิวเตอร์", 3000),
                new Product("063", "เครื่องดูดฝุ่นไร้สาย", 1200),
                new Product("064", "จอทีวี 4K", 10000),
                new Product("065", "เตาแก๊ส", 2000),
                new Product("066", "เครื่องปรับอากาศพกพา", 3500),
                new Product("067", "ปิ่นโต", 500),
                new Product("068", "เครื่องซักผ้าระบบอัตโนมัติ", 7000),
                new Product("069", "เครื่องปั่นน้ำผลไม้", 900),
                new Product("070", "กระติกน้ำร้อนแบบพกพา", 500),
                new Product("071", "เครื่องดูดฝุ่นแบบมือถือ", 1200),
                new Product("072", "เครื่องชาร์จแบตเตอรี่", 300),
                new Product("073", "เครื่องคั้นน้ำผลไม้", 800),
                new Product("074", "เตาไฟฟ้า", 1500),
                new Product("075", "กระทะไฟฟ้า", 2500),
                new Product("076", "เครื่องทำโยเกิร์ต", 1200),
                new Product("077", "เครื่องบดเนื้อ", 2000),
                new Product("078", "เตาอบ", 5000),
                new Product("079", "เครื่องชงชา", 1000),
                new Product("080", "เครื่องฟอกอากาศพกพา", 1200),
                new Product("081", "หุ่นยนต์ทำความสะอาด", 5000),
                new Product("082", "เครื่องซักผ้าขนาดเล็ก", 3500),
                new Product("083", "เครื่องเจาะดิน", 1000),
                new Product("084", "เครื่องมือช่าง", 1500),
                new Product("085", "ที่นอนเป่าลม", 600),
                new Product("086", "โต๊ะทำงาน", 2000),
                new Product("087", "เก้าอี้สำนักงาน", 1500),
                new Product("088", "กล่องเครื่องมือ", 800),
                new Product("089", "เครื่องวัดอุณหภูมิ", 300),
                new Product("090", "ปั๊มน้ำ", 2500),
                new Product("091", "เครื่องเป่าผม", 1500),
                new Product("092", "หม้อหุงข้าว", 1200),
                new Product("093", "กระติกน้ำร้อนแบบอัตโนมัติ", 800),
                new Product("094", "เครื่องทำน้ำแข็ง", 5000),
                new Product("095", "เครื่องฟอกอากาศสำหรับห้องเล็ก", 1200),
                new Product("096", "เครื่องฆ่าเชื้อ UV", 2500),
                new Product("097", "เตาทอดไร้น้ำมัน", 3500),
                new Product("098", "ตู้เย็นขนาดเล็ก", 4000),
                new Product("099", "เครื่องตัดหญ้า", 4500),
                new Product("100", "เครื่องตัดผม", 1200)
            };
        }
    }
}
