using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = GetInteger("Enter number of rounds only in odd value");

            int PlayerWins = 0;
            int ComputerWins = 0;
            int MatchDraw = 0;
            string Computer = "";
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("The Round " + i);
                Console.WriteLine(" ");

                string Player = GetString("Enter Rock or Paper or Scissor");
                Player = Player.ToUpper();

                if (Player != "ROCK" && Player != "PAPER" && Player != "SCISSOR")
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    Console.WriteLine("PLAYER : " + Player);

                    int X = RandomNumber();                          // Random Number Generation Code Starts

                    if (X == 1)
                    {
                        Computer = "ROCK";
                    }
                    else if (X == 2)
                    {
                        Computer = "PAPER";
                    }
                    else if (X == 3)
                    {
                        Computer = "SCISSOR";
                    }

                    Console.WriteLine("Computer : " + Computer);       // Random Number Generation Code Ends


                    if (Player == "ROCK" && Computer == "ROCK")      // Result Comparison Code Starts
                    {
                        Console.WriteLine("Match Draw");
                        int temp1 = 1;
                        MatchDraw += temp1;
                    }
                    if (Player == "ROCK" && Computer == "PAPER")
                    {
                        Console.WriteLine("Computer Wins");
                        int temp2 = 1;
                        ComputerWins += temp2;
                    }
                    if (Player == "ROCK" && Computer == "SCISSOR")
                    {
                        Console.WriteLine("Player Wins");
                        int temp3 = 1;
                        PlayerWins += temp3;
                    }

                    if (Player == "PAPER" && Computer == "PAPER")
                    {
                        Console.WriteLine("Match Draw");
                        int temp4 = 1;
                        MatchDraw += temp4;
                    }
                    if (Player == "PAPER" && Computer == "SCISSOR")
                    {
                        Console.WriteLine("Computer Wins");
                        int temp5 = 1;
                        ComputerWins += temp5;
                    }
                    if (Player == "PAPER" && Computer == "ROCK")
                    {
                        Console.WriteLine("Player Wins");
                        int temp6 = 1;
                        PlayerWins += temp6;
                    }

                    if (Player == "SCISSOR" && Computer == "SCISSOR")
                    {
                        Console.WriteLine("Match Draw");
                        int temp7 = 1;
                        MatchDraw += temp7;
                    }
                    if (Player == "SCISSOR" && Computer == "ROCK")
                    {
                        Console.WriteLine("Computer Wins");
                        int temp8 = 1;
                        ComputerWins += temp8;
                    }
                    if (Player == "SCISSOR" && Computer == "PAPER")
                    {
                        Console.WriteLine("Player Wins");
                        int temp9 = 1;
                        PlayerWins += temp9;
                    }                                                 // Result Comparison Code Ends
                }
                Console.WriteLine("The Win Score of Player is " + PlayerWins);
                Console.WriteLine("The Win Score of Computer is " + ComputerWins);
                Console.WriteLine("The Draw Score is " + MatchDraw);
                Console.WriteLine(" ");
                Console.WriteLine("........................................................................................................................");
            }

            Console.WriteLine("The Win Score of Player is " + PlayerWins);
            Console.WriteLine("The Win Score of Computer is " + ComputerWins);
            Console.WriteLine("The Draw Score is " + MatchDraw);
            Console.WriteLine(" ");

            if (PlayerWins < ComputerWins)
            {
                Console.WriteLine("The Computer Wins at point of " + ComputerWins);
            }
            if (PlayerWins > ComputerWins)
            {
                Console.WriteLine("The Player Wins at point of " + PlayerWins);
            }
            if (PlayerWins == ComputerWins)
            {
                Console.WriteLine("The Match Draw");
            }
            Console.WriteLine(" ");
        }

        public static string GetString(string message)
        {
            Console.WriteLine(message);
            string temp = (Console.ReadLine());
            return temp;
        }

        public static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int temp = int.Parse(Console.ReadLine());
            return temp;
        }

        public static int RandomNumber()
        {
            Random A = new Random();
            int temp = A.Next(1, 4);
            return temp;
        }
    }
}
