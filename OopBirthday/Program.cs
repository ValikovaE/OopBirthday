using System;

namespace C_Sharp_Lesson_6___OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            BirthdayExcursion birthdayExcursion1 = new BirthdayExcursion(" Excursion to Zoo", 4, 5);
            BirthdayFoodAnimation birthdayFoodAniamation1 = new BirthdayFoodAnimation("Mc Donalds + animation", 10, 2, 3, 4);

            birthdayExcursion1.NumberofGuests();
            birthdayExcursion1.BirthdayOffer();
            Console.WriteLine(" Total sum of birthday: " + birthdayExcursion1.Birthdaycost());
            birthdayExcursion1.BirthdayInformation();
            birthdayFoodAniamation1.NumberofGuests();
            birthdayFoodAniamation1.BirthdayOffer();
            Console.WriteLine(" Total sum of birthday: " + birthdayFoodAniamation1.Birthdaycost());
            birthdayFoodAniamation1.BirthdayInformation();





        }
    }
}