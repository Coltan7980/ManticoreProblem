//Written by Coltan Paul
//2/11/25
namespace HuntingTheManticore
{
    internal class Program
    {
        static void Main(string[] args)

        {   
            Player city = new Player(15,-1);
            Player manticore = new Player(10,-1);

            //Establish Variables
            city.Health = 15;
            manticore.Health = 10;

            int roundNumber = 1;
            int expectedDamage = -1;

            ConsoleColor originalColor = Console.ForegroundColor;



            Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
            manticore.Decision = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Player 2 it is your turn.");
            Console.WriteLine("___________________________________________________________________________________________________");


            //main game loop
            while (city.Health != 0 && manticore.Health != 0)
            {
                if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
                { expectedDamage = 10; }
                else if (roundNumber % 3 == 0 || roundNumber % 5 == 0)
                { expectedDamage = 3; }
                else
                { expectedDamage = 1; }

                Console.WriteLine($"STATUS: Round {roundNumber} City: {city.Health}/15 Manticore {manticore.Health}/10");
                Console.WriteLine($"The Canon is expected to deal {expectedDamage} damage this round.");

                Console.Write("Enter desired range: ");
                city.Decision = Convert.ToInt32(Console.ReadLine());

                //Check if hit
                if (city.Decision == manticore.Decision)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("the round was a DIRECT HIT!");
                    manticore.Health -= expectedDamage;
                    Console.ForegroundColor = originalColor;
                }
                //handle overshoot
                else if (city.Decision > manticore.Decision)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("the round OVERSHOT the target.");
                    Console.ForegroundColor = originalColor;

                }
                //handle undershoot
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("the round FELL SHORT of the target.");
                    Console.ForegroundColor = originalColor;
                }
                //handle City Health if Manticore is still alive
                if (manticore.Health != 0)
                {
                    city.Health -= 1;
                }
                roundNumber += 1;
                Console.WriteLine("___________________________________________________________________________________________________");
            }
            if (manticore.Health == 0)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("The Manticore has been destroyed! The City of Consolas been Saved!");
                Console.ForegroundColor = originalColor;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The City has been destroyed! The Manticore has won!");
                Console.ForegroundColor = originalColor;
            }

        }
    }
}
