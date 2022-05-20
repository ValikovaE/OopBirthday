using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_6___OOP3
{
    abstract class BirthdayCost
    {
        protected int guestNumber;
        protected string offer;


        public abstract int Birthdaycost();
        public abstract void BirthdayInformation();
        public abstract void BirthdayOffer();


        public void NumberofGuests()
        {
            Console.WriteLine(" Number of guest: " + guestNumber);
        }

    }
}