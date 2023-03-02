using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicjalizacja zmiennej losowej
        Random rand = new Random();

        // Wylosowanie liczby z zakresu 1-100
        int number = rand.Next(1, 101);

        // Inicjalizacja zmiennej do przechowywania odpowiedzi gracza
        int guess = 0;

        // Główna pętla gry
        while (guess != number)
        {
            // Wyświetlenie instrukcji
            Console.WriteLine("Zgadnij liczbę z zakresu 1-100:");

            // Wczytanie odpowiedzi gracza
            string input = Console.ReadLine();

            // Sprawdzenie, czy wprowadzony tekst jest liczbą
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Nieprawidłowe dane. Wprowadź liczbę.");
                continue;
            }

            // Sprawdzenie, czy liczba jest w zakresie 1-100
            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Liczba musi być z zakresu 1-100.");
                continue;
            }

            // Porównanie liczby gracza z wylosowaną liczbą
            if (guess < number)
            {
                Console.WriteLine("Za mało.");
            }
            else if (guess > number)
            {
                Console.WriteLine("Za dużo.");
            }
            else
            {
                Console.WriteLine("Brawo, zgadłeś!");
            }
        }

        // Oczekiwanie na wciśnięcie klawisza przed zakończeniem programu
        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć.");
        Console.ReadKey();
    }
}
