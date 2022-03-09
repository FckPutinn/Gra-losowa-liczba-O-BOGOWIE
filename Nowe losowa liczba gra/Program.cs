// See https://aka.ms/new-console-template for more information
Random r = new Random();
int num1 = r.Next(1, 10);
int num2;
Console.WriteLine("Wylosowałem liczbę całkowitą od 1 do 10");
Console.WriteLine("Spróbuj zgadnąć co to za liczba");
num2 = Convert.ToInt32(Console.ReadLine());
while (num1 != num2)
{
    if (num1 < num2)
    {
        Console.WriteLine("Wylosowana liczba jest mniejsz od tej którą podałeś\nPodaj mniejszą liczbę");
        num2 = Convert.ToInt32(Console.ReadLine());
    }
    else
    if (num1 > num2)
    {
        Console.WriteLine("Wylosowana liczba jest większa od tej którą podałeś\nPodaj większą liczbę");
        num2 = Convert.ToInt32(Console.ReadLine());
    }
}
if (num1 == num2)
    Console.WriteLine("Brawo brawo brawissimo, wygrałeś\nWylosowana liczba to " + num1);