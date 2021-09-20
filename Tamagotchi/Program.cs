using System;


class Program
{
    static void Main(string[] args)
    {
        Tamagotchi tama = new Tamagotchi();
        while (tama.GetAlive())
        {
            Console.WriteLine("Choose an action OvO");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "feed":
                    Console.WriteLine("Thank you Dommy Mommy");
                    tama.Feed();
                    tama.Tick();
                    break;
                case "teach":
                    Console.WriteLine("What word would you like to teach me Mommy?");
                    string word = Console.ReadLine();
                    tama.Teach(word);
                    tama.Tick();
                    break;
                case "hi":
                    tama.Hi();
                    tama.Tick();
                    break;
                case "stats":
                    tama.PrintStats();
                    break;
                default:
                    Console.WriteLine("U R WROOOOOONNKKKKKK!");
                    break;
            }
        }
    }
}