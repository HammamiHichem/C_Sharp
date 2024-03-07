using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans le rouleur de dés interactif!");

        bool rollAgain = true;
        while (rollAgain)
        {
            Console.WriteLine("Quel type de dé voulez-vous lancer ? (6, 12, 20, etc...) : ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int sides) && sides > 0)
            {
                int result = RollDice(sides);
                Console.WriteLine($"Le résultat du lancer du dé {sides}-côtés est : {result}");
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier positif.");
            }

            Console.WriteLine("Voulez-vous lancer un autre dé ? (Oui/Non) : ");
            string response = Console.ReadLine().ToLower();

            if (response != "oui")
            {
                rollAgain = false;
            }
        }

        Console.WriteLine("Merci d'avoir utilisé le rouleur de dés interactif!");
    }

    static int RollDice(int sides)
    {
        Random random = new Random();
        return random.Next(1, sides + 1);
    }
}
