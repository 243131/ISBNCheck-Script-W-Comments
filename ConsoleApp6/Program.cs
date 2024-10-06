using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input ISBN number (Must be 13 digits)");
            string ISBN = Console.ReadLine(); // input is stored as a string so that later on it can be indexed
            
            if (ISBN.Length != 13) // checks to see if the Value inputted has a length of 13 
            {
                Console.WriteLine("Invalid ISBN, Please use only 13 digits");
                Console.ReadKey();
            }
            else // Starts the check for the ISBN number
            {


                double ISBNcheck =((char.GetNumericValue(ISBN[0]) * 1) +
                                (char.GetNumericValue(ISBN[1]) * 3) +
                                (char.GetNumericValue(ISBN[2]) * 1) +
                                (char.GetNumericValue(ISBN[3]) * 3) +
                                (char.GetNumericValue(ISBN[4]) * 1) +
                                (char.GetNumericValue(ISBN[5]) * 3) +  // adds all the values of the ISBN string together and converts to numerical values
                                (char.GetNumericValue(ISBN[6]) * 1) +
                                (char.GetNumericValue(ISBN[7]) * 3) +
                                (char.GetNumericValue(ISBN[8]) * 1) +
                                (char.GetNumericValue(ISBN[9]) * 3) +
                                (char.GetNumericValue(ISBN[10]) * 1) +
                                (char.GetNumericValue(ISBN[11]) * 3));
                int ISBNcheckSingle = Convert.ToInt32(ISBNcheck % 10); // does the operation modulo 10
                int ISBNcheckDefault; //checks if the Modulo is = to 0 if so sets the value to 0 if not it takes the ISBNcheckSingle value and subtracts 10 from it 
                if (ISBNcheckSingle == 0)
                {
                    ISBNcheckDefault = 0; 
                }
                else
                {
                    ISBNcheckDefault = 10 - ISBNcheckSingle;
                }
                if (char.GetNumericValue(ISBN[12]) == ISBNcheckDefault) // checks if the final value of the ISBN value is equal to the ISBNcheck value 
                {
                    Console.WriteLine("Valid ISBN");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid ISBN, Try Again");
                    Console.ReadKey();
                }
            }

        }
    }
}
