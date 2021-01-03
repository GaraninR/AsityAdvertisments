using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsityAdvertisments.Models
{
    public class Advertisment
    {
        public int id;
        public String firstName;
        public String lastName;
        public String patronimic;

        public String phoneNumber;
        public String email;
        public int age;

        public String advText;

        public float priceUSD;
        public float courseOfUSD;
        public float priceBYN;

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
    }
}
