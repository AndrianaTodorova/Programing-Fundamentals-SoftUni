using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  
namespace _06.TheatrePromotion
    {
        class Program
        {
            static void Main(string[] args)
            {
                string typeOfDay = Console.ReadLine().ToLower();
                int age = int.Parse(Console.ReadLine());
                int money = 0;

                if (typeOfDay == "weekday")
                {
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        money = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        money = 18;
                    }
                   
                }
                else if (typeOfDay == "weekend")
                {
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        money = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        money = 20;
                    }
                    
                }
                else if (typeOfDay == "holiday")
                {
                    if (age >= 0 && age <= 18)
                    {
                        money = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        money = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        money = 10;
                    }

                }
                if (money != 0)
                {
                    Console.WriteLine(money + "$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }

            }
        }
    }


