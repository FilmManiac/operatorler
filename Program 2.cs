﻿using System;

namespace Operators
{
    Class Program
    {
        static void Main(string[] args)
        {
            

            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }
            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great !");
            }
             if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine !");
            }

            
            

            int a = 3;
            int b = 4;
            bool result = a < b;
            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);

           
            
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc = sayi1 / sayi2;
            Console.WriteLine(sonuc);
            sonuc = sayi1 * sayi2;
            Console.WriteLine(sonuc);
            sonuc = sayi1 - sayi2;
            Console.WriteLine(sonuc);
            sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            sonuc = sayi1 % sayi2;
            Console.WriteLine(sonuc);
        }
    }
}

