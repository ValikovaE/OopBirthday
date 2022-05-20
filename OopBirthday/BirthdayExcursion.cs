using C_Sharp_Lesson_6___OOP3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_6___OOP3
{
    class BirthdayExcursion : BirthdayCost //derived
    {
        private int price;


        public BirthdayExcursion(string offer, int guestNumber, int price)
        {
            this.price = price;
            this.offer = offer;
            this.guestNumber = guestNumber;
        }
        public override void BirthdayOffer()
        {
            Console.WriteLine(" Offer : " + offer);
        }
        public override int Birthdaycost()
        {
            return price * guestNumber;
        }

        public override void BirthdayInformation()
        {
            Console.WriteLine(" Please, inform us about guest age and special reqiurements!");
        }

    }
}