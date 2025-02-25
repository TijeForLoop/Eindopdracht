using System;
using System.Linq;

class MijnProgramma
{
    static void Main()
    {
        int teRadenGetal, geradenGetal;
        int ondergrens = 1;
        int bovengrens = 100;
        int aantalpogingen = 0;
        int aantalKeerGeraden = 0;
        bool gameOver = false;
        Random dobbelsteen = new Random();
        Console.WriteLine("Kies een boven- en ondergrens,geef eerst de ondergrens in. ");
        ondergrens = int.Parse(Console.ReadLine());
        Console.WriteLine("Kies nu de bovengrens. ");
        bovengrens = int.Parse(Console.ReadLine());
        teRadenGetal = dobbelsteen.Next(ondergrens, bovengrens);
        Console.WriteLine("kies nu hoeveel pogingen je wilt krijgen. 0 = onbeperkt. ");
        aantalpogingen = int.Parse(Console.ReadLine());
        while (!gameOver)
        {
            Console.WriteLine("Raad een getal tussen de " + ondergrens + " en de " + bovengrens);
            geradenGetal = int.Parse(Console.ReadLine());
            if (geradenGetal > bovengrens || geradenGetal < ondergrens) {
                Console.WriteLine("Dit getal is niet tussen de onder- en bovengrens. ");
                continue;
            }
            
            aantalKeerGeraden++;

            if (teRadenGetal < geradenGetal)
            {
                Console.WriteLine("Het getal is kleiner! je hebt al " + aantalKeerGeraden + " keer geraden");
              bovengrens = geradenGetal;
            }
          else if (aantalKeerGeraden == aantalpogingen)
            {
                Console.WriteLine("Game over!");
                gameOver = true;
            }
            else if (teRadenGetal > geradenGetal)
            {
                Console.WriteLine("Het getal is groter! je hebt al " + aantalKeerGeraden + " keer geraden");
              ondergrens = geradenGetal;
            }
            else
            {
                Console.WriteLine("Je hebt het goed geraden! na " + aantalKeerGeraden + " keer geraden");
                gameOver = true;
            }

        }
    }
}
