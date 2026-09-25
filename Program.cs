namespace FunNameGenerator;

class Program
{
    static void Main(string[] args)
    {
        // Du ska skapa ett program som gör ett “random—fun-namegeneration” åt användaren.
        Console.WriteLine("/// WELCOME TO FUN NAME GENERATOR ///");
        // Instruktioner:
        // Be användaren skriva in sitt förnamn.
        Console.WriteLine("Please provide your name:");
        string name = Console.ReadLine()!;

        Console.WriteLine($"Your name is: {name}");
        // Be användaren skriva in sin favoritfärg.

        Console.WriteLine("Please provide your favorite color:");
        string color = Console.ReadLine()!;

        Console.WriteLine($"Your favorite color is: {color}");
        // Sätt ihop dessa två till ett roligt namn.
        // Exempel: “Anna” + “Blå” → Lil Anna of Blå Angeles

        string funName = "Dude " + name + " of " + color + " Estocolmo ";
        // Skriv ut resultatet på skärmen.
        Console.WriteLine("Your fun name is:" + funName);
        // Tips:
        // Använd Console.ReadLine() för att ta in text.
        // Använd Console.WriteLine() för att skriva ut text.
        // Du kan använda + för att slå ihop strängar
    }
}
