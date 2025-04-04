using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int poging;
        bool goed = false;
        string invoer;
        Console.WriteLine("Hoger of lager? denk aan een getal tussen 2 waarden. geef eerst de ondergrens en daarna de bovengrens \n");
        Console.WriteLine("ondergrens is:...");
        int ondergrens = int.Parse(Console.ReadLine());
        Console.WriteLine("bovengrens is:...");
        int bovengrens = int.Parse(Console.ReadLine());
        Console.WriteLine("hoe slim wil je dat ik speel? Kies uit: Dom(d), beetje slim...ish(b), strategisch(s) \n");
        string slimheid = Console.ReadLine().ToLower();

        if (slimheid == "b") {
            while (!goed){
                Random dobbelsteen = new Random();
                poging = dobbelsteen.Next(ondergrens,bovengrens);
                Console.WriteLine($"Ik raad: {poging}");
                Console.WriteLine("Is het juist (j), is het correcte getal groter (g) of kleiner (k)?");
                invoer = Console.ReadLine().Trim().ToLower();

                if(invoer == "j") {    
                    Console.WriteLine("dan heb ik gewonnen! :3");
                    goed = true;
                }
                else if(invoer == "g") {
                    Console.WriteLine($"gebruiker geeft aan: het getal is groter dan {poging}");
                    ondergrens = poging + 1;
                }
                else if(invoer == "k") {
                    Console.WriteLine($"gebruiker geeft aan: het getal is kleiner dan {poging}");
                    bovengrens = poging - 1;
                }
                else {
                    Console.WriteLine("ongeldige invoer");
                }
                if(ondergrens > bovengrens) {
                    Console.WriteLine("nu zit je gwn te liegen :c");
                    goed = true;
                }
            }
        } 
        else if (slimheid == "d") {
            while (!goed){
                poging = ondergrens;
                Console.WriteLine($"Ik raad: {poging}");
                Console.WriteLine("Is het juist (j), is het correcte getal groter (g) of kleiner (k)?");
                invoer = Console.ReadLine().Trim().ToLower();

                if(invoer == "j") {    
                    Console.WriteLine("dan heb ik gewonnen! :3");
                    goed = true;
                }
                else if(invoer == "g") {
                    Console.WriteLine($"gebruiker geeft aan: het getal is groter dan {poging}");
                    ondergrens = poging + 1;
                }
                else if(invoer == "k") {
                    Console.WriteLine($"gebruiker geeft aan: het getal is kleiner dan {poging}");
                    bovengrens = poging - 1;
                }
                else {
                    Console.WriteLine("ongeldige invoer");
                }
                if(ondergrens > bovengrens) {
                    Console.WriteLine("nu zit je gwn te liegen :c");
                    goed = true;
                }
            }
        }
        else if (slimheid == "s") {
            while (!goed){
                poging = (ondergrens + bovengrens) / 2;
                Console.WriteLine($"Ik raad: {poging}");
                Console.WriteLine("Is het juist (j), is het correcte getal groter (g) of kleiner (k)?");
                invoer = Console.ReadLine().Trim().ToLower();

                if(invoer == "j") {    
                    Console.WriteLine("dan heb ik gewonnen! :3");
                    goed = true;
                }
                else if(invoer == "g") {
                    Console.WriteLine($"gebruiker geeft aan: het getal is groter dan {poging}");
                    ondergrens = poging + 1;
                }
                else if(invoer == "k") {
                    Console.WriteLine($"gebruiker geeft aan: het getal is kleiner dan {poging}");
                    bovengrens = poging - 1;
                }
                else {
                    Console.WriteLine("ongeldige invoer");
                }
                if(ondergrens > bovengrens) {
                    Console.WriteLine("nu zit je gwn te liegen :c");
                    goed = true;
                }
            }
        }
        else {
            Console.WriteLine("Ongeldige invoer!");
        }
    }
    
}
