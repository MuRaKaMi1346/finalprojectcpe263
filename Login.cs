using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Finalproject
{
    public class Login
    {
        private string name;
        private string password;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public Login(string userName, string userId)
        {
            Name = userName;
            Password = userId;
        }
        public class Promotion
        {
            public double PromotionValue { get; set; }

            public Promotion(double promotion)
            {
                PromotionValue = promotion;
            }
        }


    }
}
     

            
    

