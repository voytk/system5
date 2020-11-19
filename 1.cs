using System;

namespace ConsoleApp7
{
              class Program
        {
            public static void Main(string[] args)
            {
                Square(5);
                Console.ReadKey();
            }

            static void Square(int N)
            {
                for (int i = 0; i < N; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write('*');
                    Console.SetCursorPosition(i, 0);
                    Console.Write('*');
                    Console.SetCursorPosition(N - 1, i);
                    Console.Write('*');
                    Console.SetCursorPosition(i, N - 1);
                    Console.Write('*');
                }
            }
        
        
    } 
    } 

    
