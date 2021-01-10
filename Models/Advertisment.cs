using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsityAdvertisments.Models
{
    public class Advertisment
    {
        public int id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String patronimic { get; set; }

        public String phoneNumber { get; set; }
        public String email { get; set; }
        public int age { get; set; }

        public String advText { get; set; }

        public float priceUSD { get; set; }
        public float courseOfUSD { get; set; }
        public float priceBYN { get; set; }

        public Advertisment(int id, String firstName, String lastName, String patronimic, 
            String phoneNumber, String email, int age, String advText, float priceUSD, float courseOfUSD, float priceBYN)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronimic = patronimic;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.age = age;
            this.advText = advText;
            this.priceUSD = priceUSD;
            this.courseOfUSD = courseOfUSD;
            this.priceBYN = priceBYN;

        }

        public Advertisment()
        {
            this.id = 0;
            this.firstName = "";
            this.lastName = "";
            this.patronimic = "";
            this.phoneNumber = "";
            this.email = "";
            this.age = 0;
            this.advText = "";
            this.priceUSD = 0;
            this.courseOfUSD = 0;
            this.priceBYN = 0;

        }
    }
}
