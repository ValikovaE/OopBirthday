using C_Sharp_Lesson_6___OOP3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_6___OOP3
{
    class BirthdayFoodAnimation : BirthdayCost //derived
    {
        private int priceFood;
        private int priceAnimation;
        private int priceTransport;


        public BirthdayFoodAnimation(string offer, int guestNumber, int priceFood, int priceAnimation, int priceTransport)
        {
            this.priceFood = priceFood;
            this.priceAnimation = priceAnimation;
            this.priceTransport = priceTransport;
            this.offer = offer;
            this.guestNumber = guestNumber;
        }
        public override void BirthdayOffer()
        {
            Console.WriteLine(" Offer : " + offer);
        }
        public override int Birthdaycost()
        {
            return (priceFood + priceAnimation + priceTransport) * guestNumber;
        }

        public override void BirthdayInformation()
        {
            Console.WriteLine(" Please, inform us about your guest food preferations!");
        }

    }
}
