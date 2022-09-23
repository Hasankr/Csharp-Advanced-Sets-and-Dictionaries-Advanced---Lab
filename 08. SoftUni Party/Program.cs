using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularGuests = new List<string>();
            var vipGuests = new List<string>();
            string input = Console.ReadLine();
            int count = 0;

            while (input.ToUpper() != "PARTY")
            {
                //if (input == "END")
                //{
                //    count = vipGuests.Count + regularGuests.Count;
                //    Console.WriteLine(count);
                //    foreach (var guest in vipGuests)
                //    {
                //        Console.WriteLine(guest);
                //    }
                //    foreach (var guest in regularGuests)
                //    {
                //        Console.WriteLine(guest);
                //    }
                //    return;
                //}
                //if (input.Length == 8 && (input[0] >= 48 && input[0] <= 67))
                char firstChar = input[0];
                if (char.IsDigit(firstChar))
                {
                    if (!vipGuests.Contains(input))
                    {
                        vipGuests.Add(input);
                    }
                }
                //else if (input.Length == 8)
                else
                {
                    if (!regularGuests.Contains(input))
                    {
                        regularGuests.Add(input);
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input.ToUpper() != "END")
            {
                if (vipGuests.Contains(input))
                {
                    vipGuests.Remove(input);
                }
                else if (regularGuests.Contains(input))
                {
                    regularGuests.Remove(input);
                }
                input = Console.ReadLine();
            }
            count = vipGuests.Count + regularGuests.Count;
            Console.WriteLine(count);
            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}

