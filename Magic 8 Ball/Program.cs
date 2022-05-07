using System;

namespace MagicBall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Magic 8 ball!\n");
            game();
        }

        // Method for making the user avaliable to ask a question
        static void game()
        {
            Console.WriteLine("Enter your question and I will answer it: ");
            string userInput = Console.ReadLine();


            // generate a random comment, for the answer
            // uncomment 
            /*Random random = new Random();

            int rndNum = random.Next(1, 4);

            if (rndNum == 1)
            {
                Console.WriteLine("Interresting...\n");
            }
            else if (rndNum == 2)
            {
                Console.WriteLine("Great question!\n");
            }
            else if (rndNum == 3)
            {
                Console.WriteLine("Weird ಥ_ಥ, i'll try");
            }
            else if (rndNum == 4)
            {
                Console.WriteLine("I don't know!");
                Thread.Sleep(1000);
                Console.WriteLine("Okay, i'll try answering..");
            }*/

            Thread.Sleep(1000);

            Console.WriteLine("\nThinking...\n");

            Thread.Sleep(5000);

            answer();
        }

        // Method for generating a random answer
        static void answer()
        {
            Random random = new Random();

            int rndNum = random.Next(1, 20);

            if (rndNum == 1)
            {
                Console.WriteLine("As I see it, yes");
            }
            else if (rndNum == 2)
            {
                Console.WriteLine("Ask again later");
            }
            else if (rndNum == 3)
            {
                Console.WriteLine("Better not tell you now");
            }
            else if (rndNum == 4)
            {
                Console.WriteLine("Cannot predict now");
            }
            else if (rndNum == 5)
            {
                Console.WriteLine("Concentrate and ask again");
            }
            else if (rndNum == 6)
            {
                Console.WriteLine("Don’t count on it");
            }
            else if (rndNum == 7)
            {
                Console.WriteLine("It is certain");
            }
            else if (rndNum == 8)
            {
                Console.WriteLine("It is decidedly so");
            }
            else if (rndNum == 9)
            {
                Console.WriteLine("Most likely");
            }
            else if (rndNum == 10)
            {
                Console.WriteLine("My reply is no");
            }
            else if (rndNum == 11)
            {
                Console.WriteLine("My sources say no");
            }
            else if (rndNum == 12)
            {
                Console.WriteLine("Outlook good");
            }
            else if (rndNum == 13)
            {
                Console.WriteLine("Outlook not so good");
            }
            else if (rndNum == 14)
            {
                Console.WriteLine("Reply hazy try again");
            }
            else if (rndNum == 15)
            {
                Console.WriteLine("Signs point to yes");
            }
            else if (rndNum == 16)
            {
                Console.WriteLine("Very doubtful");
            }
            else if (rndNum == 17)
            {
                Console.WriteLine("Without a doubt");
            }
            else if (rndNum == 18)
            {
                Console.WriteLine("Yes");
            }
            else if (rndNum == 19)
            {
                Console.WriteLine("Yes, definitely");
            }
            else if (rndNum == 20)
            {
                Console.WriteLine("You may rely on it");
            }

            askAgain();
        }

        // Method for asking if the user wants to play again
        static void askAgain()
        {
            Console.WriteLine("\n\nAsk again? (y/n): ");
            string askAgain = Console.ReadLine();

            if (askAgain.ToLower() == "y")
            {
                game();
            }
            else
            {
                
            }
        }
    }
}