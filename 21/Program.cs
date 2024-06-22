using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, welcom to 21 GAME");
            WriteLine("\n\nEnter how meny cards do you have in your hand: ");


            int quantity = int.Parse(ReadLine());
            int sum = 0;



            for (int i = 0; i < quantity; i++)
            {

                Write($"\nEnter the value {i + 1} of card (2-10, J, Q, K, T): ");
                string cards = ReadLine();

                switch (cards)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        int numCards;
                        if (int.TryParse(cards, out numCards))
                        {
                            sum += numCards;
                        }
                        else
                        {
                            Write("Unknown card value ! Try again");
                            i--;
                        }
                        break;
                }

            }

            WriteLine($"\nValue of your card {sum}");

            ReadLine();

        }
    }
}
