using Hermetyzacja2;

class DaneUżytkownika
{
    static void Main(string[] args)
    {
        Użytkownik Gosciu = new Użytkownik();

        Console.WriteLine("Podaj swoje Imie");

        Gosciu.imie = Console.ReadLine();

        Console.WriteLine("Podaj swój wiek");
        Gosciu.wiekProp =  Convert.ToInt32(Console.ReadLine());




    Console.WriteLine($"Jestem {Gosciu.imie} i mam {Gosciu.wiekProp} lat");
    }
}
