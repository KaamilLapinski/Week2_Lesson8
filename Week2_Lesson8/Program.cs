using System.Security.Cryptography;

namespace Week2_Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Lesson 8
                //Task 1 --- Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100
                Console.WriteLine("----------Zadanie 1----------");
                int sumPrimNumbers = 0;
                int number = 0;      

                while (number <= 100)
                {
                    int counter = 0;
                    for (int j = 1; j <= number; j++)
                    {                  
                        if (number % j == 0)
                        {
                            counter++; 
                        }                
                    }
                    if(counter == 2) 
                    {                  
                        sumPrimNumbers++;
                    }
                    number++;
                 }
                Console.WriteLine($"W zakresie 0-100 jest {sumPrimNumbers} liczb pierwszych");

                //Task 2 --- Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.
                Console.WriteLine("----------Zadanie 2----------");
                int number2 = 0;
                do
                {
                    if(number2 % 2  == 0)
                    {
                        Console.WriteLine($"Liczba {number2} jest parzysta");
                    }
                    number2++;
                }
                while (number2 <= 1000);

                //Task 3 --- Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
                //0,1,1,2,3,5,8,13,21... 

                Console.WriteLine("----------Zadanie 3----------");
                int n = 5,
                    temp,
                    x = 0, 
                    y = 1;

                for(int i = 0; i < n;i++)
                {
                    temp = x;   
                    x = x + y; 
                    y = temp;    
                    Console.WriteLine($"{i+1} wyraz ciągu równa sie: {x}");
                }

                //Task 4 --- Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
                //1
                //2 3
                //4 5 6
                //7 8 9 10
                Console.WriteLine("----------Zadanie 4----------");
                Console.WriteLine("Podaj liczbe:");
                int num = Int32.Parse(Console.ReadLine());

                int c = 0;
                for (int i = 1; i < num; i++)
                {            
                        for (int j = 0; j < i; j++)
                        {
                            if (c < num) 
                            { 
                                c++;
                                Console.Write($" {c}");
                            }
                        }              
                    Console.WriteLine("");
                }


                //Task 5 --- Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę
                Console.WriteLine("----------Zadanie 5----------");
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine($"{i} do potęgi 3 równa sie {Math.Pow(i, 3)}");
                }

                //Task 6 --- Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + ½ +1 / 3 + ¼ itd. Wynik: 3.597739657
                Console.WriteLine("----------Zadanie 6----------");
                double sum = 1;

                for (double i = 2; i <= 20; i++)
                {
                    sum += (1.0 / i);
                }

                Console.WriteLine($"Suma= {sum}");

                //Task 7 --- Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej 
                //przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
                 /* 
                      *
                     ***
                    *****
                   *******
                  *********
                   *******
                    *****
                     ***
                     *
                 */
            Console.WriteLine("----------Zadanie 7----------");

            Console.WriteLine("Podaj liczbe:");
            int diagonal = Int32.Parse(Console.ReadLine());
            int rows = diagonal / 2; ;                 
            if (diagonal % 2 != 0 )
            {
                
                for (int i = rows; i > 0; i--)
                {
                    for (int j = i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = (rows - i) * 2 + 1; k > 0; k--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }

                for (int i = 0; i < rows + 1; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = (rows - i) * 2 + 1; k > 0; k--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            else
            {               
                for (int i = rows; i > 1; i--)
                {
                    for (int j = i; j > 1; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = (rows - i) * 2 + 1; k >= 0; k--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }

                for (int i = 1; i < rows + 1; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = (rows - i) * 2 + 1; k >= 0; k--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            

            
            }
            //Task 8 --- Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
            /*
            Testowe dane:
                Abcdefg
                Rezultat
                Gfedcba
            */
            Console.WriteLine("----------Zadanie 8----------");
            Console.WriteLine("Podaj wyraz:");
            string str = Console.ReadLine();
            string revString = "";
        
            for (int i = str.Length; i > 0; i--)
            {
                revString += str[i-1];
            }
            Console.WriteLine($"Wprowadzony napis: {str}");
            Console.WriteLine($"Odwrócony napis: {revString}");



            //Task 9 --- Napisz program, który zamieni liczbę dziesiętną na liczbę binarną
            Console.WriteLine("----------Zadanie 9----------");
            Console.WriteLine("Podaj liczbe:");
            int number3 = Int32.Parse(Console.ReadLine());
            string binNumber = "";
            string binNumber2 = "";
            while(number3 >= 1)
            {
                if (number3 % 2 == 0)
                {
                    binNumber += 0;
                    number3 /= 2;
                }
                else if(number3 % 2 == 1)
                {
                    binNumber += 1;
                    number3 /= 2;
                }
            }
            for (int i = binNumber.Length; i > 0; i--)
            {
                binNumber2 += binNumber[i - 1];
            }
            Console.WriteLine($"LIczba dziesietna {number3} w postaci binarnej: {binNumber2}");


            //Task 10 --- Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb
            Console.WriteLine("----------Zadanie 9----------");

            Console.WriteLine("Podaj liczbe 1:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe 2:");
            int b = Int32.Parse(Console.ReadLine());
            int temp2;
            int nww;
            int nwd_a = a;
            int  nwd_b = b;
            while (nwd_b != 0)
            {
                temp2 = nwd_b;
                nwd_b = nwd_a % nwd_b;
                nwd_a = temp2;
            }

            nww = (a * b) / nwd_a;
            Console.WriteLine($"NWW liczb :{a} i {b} jest {nww}");
        }
    }
            
}