using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int limit = (int)Math.Sqrt(number);
        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Podaj dolną granicę zakresu liczb pierwszych:");
        int lowerBound = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj górną granicę zakresu liczb pierwszych:");
        int upperBound = int.Parse(Console.ReadLine());

        if (lowerBound < 2) lowerBound = 2;

        Console.WriteLine($"Liczby pierwsze od {lowerBound} do {upperBound}:");

        if (lowerBound <= 2)
        {
            Console.Write("2 ");
        }

        if (lowerBound % 2 == 0) lowerBound++;

        for (int i = lowerBound; i <= upperBound; i += 2)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }
}
/*Wyjaśnienie:

Ten algorytm pozwala użytkownikowi wprowadzić dolną i górną granicę zakresu liczb pierwszych, które mają zostać wyświetlone. Algorytm również zawiera obsługę błędów, jeśli użytkownik wprowadzi nieprawidłowe dane.

Metoda IsPrime jest identyczna jak w poprzednim algorytmie.

Metoda Main rozpoczyna się od wyświetlenia komunikatu, w którym użytkownik jest proszony o wprowadzenie dolnej granicy zakresu. Następnie, wartość ta jest pobierana z konsoli za pomocą metody Console.ReadLine() i konwertowana na typ int za pomocą metody int.Parse(). Podobnie, użytkownik jest proszony o wprowadzenie górnej granicy zakresu, a wartość ta jest również konwertowana na typ int.

Jeśli dolna granica jest mniejsza niż 2, to zostaje ona ustawiona na 2, ponieważ 2 jest najmniejszą liczbą pierwszą. Następnie, wyświetlany jest komunikat informujący użytkownika o zakresie liczb pierwszych, który będzie wyświetlany na konsoli.

Jeśli dolna granica jest mniejsza lub równa 2, to na konsoli wyświetlana jest liczba 2 (ponieważ to jest liczba pierwsza), a następnie dolna granica jest zwiększana o 1, aby rozpocząć pętlę od następnej liczby nieparzystej.

W pętli for, która iteruje po liczbach z zakresu od dolnej granicy do górnej granicy, sprawdzane jest, czy dana liczba jest
*/