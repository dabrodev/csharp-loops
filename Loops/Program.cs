using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeNumbers();
            //EvenNumbers();
            //Fibonacci();
            //Pyramid();
            //PowerThree();
            //Fractions();
            //Diamond();
            //ReversedWord()
            //Binary();
            //LCM();


        }

        // 1. Napisz program, który sprawdzi,
        // ile jest liczb pierwszych w zakresie 0 – 100.
        
        // Ex1
        static void PrimeNumbers()
        {
            int counter = 0;
            int primeNumbersTotal = 0;
            for (int n = 0; n <= 100; n++)
            {
                counter = 0;
                for (int i = 1; i <= n; i++)
                {
                   if(n % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    //print all prime numbers
                    Console.WriteLine(n); 
                    primeNumbersTotal++;
                }    
            }
            Console.WriteLine("Prime Numbers TOTAL:");
            Console.WriteLine(primeNumbersTotal);  
        }

        // 

        // 2. Napisz program, w którym za pomocą pętli do…while 
        // znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.

        // Ex2
        static void EvenNumbers()
        {
            int i = 0;
            do
            {
                if (i % 2 == 0 && i != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i <= 1000);
        }
        //

        // 3. Napisz program, który zaimplementuje ciąg Fibonacciego
        // i wyświetli go na ekranie.

        // Ex3
        static void Fibonacci()
        {
            long a=0;
            long b = 1;
            for(int i = 0; i < 100; i++)
            { 
                Console.Write(b + " ");
                
                b += a;
                a = b - a;
            }
        }
        //

        // 4. Napisz program, który po podaniu liczby całkowitej
        // wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
        // 1 
        // 2 3 
        // 4 5 6
        // 7 8 9 10

        // Ex4
        static void Pyramid()
        {
            int number = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number);
                    number++;
                }
                Console.WriteLine();
            }
        }
        //

        // 5. Napisz program, który dla liczb od 1 do 20 
        // wyświetli na ekranie ich 3 potęgę.

        // Ex5
        static void PowerThree()
        {
            for(int i=1; i<=20; i++)
            {
                Console.WriteLine(i * i * i);
            }
        }
        //

        // 6.  Napisz program, który dla liczb od 0 do 20 
        // obliczy sumę wg wzoru: 1 + ½ + 1/3 + ¼ itd.

        // Ex6
        static void Fractions()
        {
            double sum = 0;
            for( double i=1; i<=20; i++)
            {
                sum += 1/i;
            }
            Console.WriteLine(sum);
        }
        //

        // 7. Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej
        // o długości wprowadzonej przez użytkownika i wg wzoru:
        //     *
        //    ***
        //   *****
        //  *******
        // *********
        //  *******
        //   *****
        //    ***
        //     *

        // Ex7
        static void Diamond()
        {
            int n = 9;
            for( int i=0; i<=n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= 2*i-1; star++) 
                {
                    Console.Write("*");
                }
            Console.WriteLine();
            }
            for (int i = n-1; i >= 1; i--)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= 2 * i - 1; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //

        // Napisz program, który odwróci wprowadzony
        // przez użytkownika ciąg znaków. Np.
        // Testowe dane:
        // Abcdefg
        // Rezultat
        // Gfedcba

        // Ex8
        static void ReversedWord()
        {
            Console.WriteLine("Write a word:");
            string word = Console.ReadLine();
            string wordReverse = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                wordReverse += word[i];
            }
            Console.WriteLine(wordReverse);
        }
        //

        // 9.Napisz program, który zamieni liczbę dziesiętną 
        // na liczbę binarną.

        // Ex9
        static void Binary()
        {
            int number = 34;

            while (number > 0)
            {
                Console.Write(number % 2);
                number /= 2;
            }
        }
        //

        // 10.Napisz program, który znajdzie
        // najmniejszą wspólną wielokrotność dla zadanych 2 liczb.

        // Ex10
        static void LCM()
        {
            int num1 = 5;
            int num2 = 10;
            int lcm = num1 * num2;

            for(int i = 1; i <=num1*num2; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    lcm = num1 * num2 / i;
                }
            }
            Console.WriteLine(lcm);    
        } 
    }
}
