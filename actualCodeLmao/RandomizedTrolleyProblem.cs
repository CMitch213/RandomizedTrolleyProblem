using System;

namespace RandomizedTrolleyProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int item;
            string items = "";
            int item2;
            string items2 = "";
            int amount;
            int amount2;

            Random random = new Random();
            string input;
            bool hasMadeInput;

            int runs = 0;

            Console.WriteLine("-----       Trolley Problem v1.14       -----");
            Console.WriteLine("Hello Welcome to the Trolley Problem!");
            System.Threading.Thread.Sleep(420);
            while(runs < 1)
            {
                hasMadeInput = false;
                input = "";
                Console.Clear();
                randomizeStage();

                Console.WriteLine("-- Do you pull the lever and kill " + amount + " " + items + " or do you do nothing and kill " + amount2 + " " + items2 + " --");
                Console.WriteLine("'Q' to pull lever; 'E' to do nothing");
                while (!hasMadeInput)
                {
                    input = Console.ReadLine();
                    if(input == "q" || input == "Q")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You decided to pull the lever, you killed " + amount + " " + items);
                        hasMadeInput = true;
                    }
                    else if(input == "e" || input == "E")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You decided to silently observe, you killed " + amount2 + " " + items2);
                        hasMadeInput = true;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("ERROR; Invalid input. Press the actual buttons I told you to (:");
                    }
                }



                System.Threading.Thread.Sleep(800);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("NEW ROUND!!!!");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(500);

            }


            void randomizeStage()
            {
                //set values
                amount = random.Next(1, 26);
                amount2 = random.Next(1, 26);
                item = random.Next(1, 6);
                item2 = random.Next(1, 6);

                //first object
                if(item == 1)
                {
                    items = "adult(s)";
                }
                else if(item == 2)
                {
                    items = "old person(s)";
                }
                else if(item == 3)
                {
                    items = "teen(s)";
                }
                else if(item == 4)
                {
                    items = "baby(s)";
                }
                else
                {
                    items = "dogs";
                }

                //second object
                if (item2 == 1)
                {
                    items2 = "adult(s)";
                }
                else if (item2 == 2)
                {
                    items2 = "old person(s)";
                }
                else if (item2 == 3)
                {
                    items2 = "teen(s)";
                }
                else if (item2 == 4)
                {
                    items2 = "baby(s)";
                }
                else
                {
                    items2 = "dogs";
                }

                //runs += 1;
            }
        }
    }
}