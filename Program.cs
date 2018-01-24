using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks; 
namespace Application
{
    class MainClass
    {
        static void Main(string[] args)
        {             Magazyn obj1 = new Magazyn("Deskorolka");             Magazyn obj2 = new Magazyn("Rower");             Magazyn obj3 = new Magazyn("Komputer");
            Stack<Magazyn> mag = new Stack<Magazyn>();             mag.Push(obj1);             mag.Push(obj2);             mag.Push(obj3);             foreach (var element in mag)
            {                 Console.WriteLine(element);             }              List<Magazyn> maga = new List<Magazyn>(mag);             maga.Add(obj1);             maga.Add(obj2);             maga.Add(obj3);             maga.Reverse();                maga.Sort();              List<Bohater> hero = new List<Bohater>();             hero.Add(new Ork(1, 1234, "krikk"));             hero.Add(new Ork(1, 12354, "krikk"));             hero.Add(new Elf("czarna", 23432, "Mergi"));             hero.Add(new Elf("biala", 32432, "Kolos"));             foreach(var element in hero)             {                 Console.WriteLine(element);             }             double wynik1 = Prostokat.Pole(4, 5);             Console.WriteLine(wynik1);             double wynik2 = Prostokat.Obwod(4, 5);             Console.WriteLine(wynik2); 
        }     
    }
}