using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace worktod
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Введите строку от 0 до 9 : "); 
            //string n = Console.ReadLine(); 
            //try 
            //{ 
            //    int num = Convert.ToInt32(n); 
            //    if(num < int.MinValue || num > int.MaxValue) 
            //    { 
            //        throw new OverflowException("Число вышло за пределы int"); 
            //    } 
            //    Console.WriteLine(num); 
            //} 
            //catch (FormatException) 
            //{ 
            //    Console.WriteLine("This is not number"); 
            //} 
            //catch (OverflowException ex) 
            //{ 
            //    Console.WriteLine(ex.Message); 
            //} 

            //    Console.WriteLine("Введите строку от 0 до 1 : "); 
            //    string n = Console.ReadLine(); 
            //    try 
            //    { 
            //        int num = Converting(n); 
            //        Console.WriteLine(n); 
            //    } 
            //    catch (FormatException) 
            //    { 
            //        Console.WriteLine("This is not number"); 
            //    } 
            //    catch (OverflowException) 
            //    { 
            //        Console.WriteLine("выход за границы диапазона"); 
            //    } 

            //} 
            //static int Converting(string binry) 
            //{ 
            //    int num = Convert.ToInt32(binry, 2); 
            //    return num; 

            try
            {
                CreditCard card = new CreditCard("2200123443215678", "Egor Linch", 343, 5);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        class CreditCard
        {
            string numberCard;
            string fullname;
            int cvc;
            int dateEndWork;


            public CreditCard(string numberCard, string fullname, int cvc, int dateEndWork)
            {
                if (string.IsNullOrEmpty(numberCard) || numberCard.Length != 16)
                {
                    throw new ArgumentException("Invalid card number");
                }
                if (string.IsNullOrEmpty(fullname)
                {
                    throw new ArgumentException("Invalid full name");
                }
                if (cvc.ToString().Length != 3)
                {
                    throw new ArgumentException("Invalid CVC");
                }
                if (dateEndWork < 3)
                {
                    throw new ArgumentException("Invalid date of ending work");
                }
                this.numberCard = numberCard;
                this.fullname = fullname;
                this.cvc = cvc;
                this.dateEndWork = dateEndWork;

            }

        }


    }
}