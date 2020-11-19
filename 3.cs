using System;

namespace ConsoleApp5
{
  
    class Matrix
    {
        // Скрытые поля
        private int n;
        private int[,] mass;

        // Создаем конструкторы матрицы
        public Matrix() { }
        public int N
        {
            get { return n; }
            set { if (value > 0) n = value; }
        }

        // Задаем аксессоры для работы с полями вне класса Matrix
        public Matrix(int n)
        {
            this.n = n;
            mass = new int[this.n, this.n];
        }
        public int this[int i, int j]
        {
            get
            {
                return mass[i, j];
            }
            set
            {
                mass[i, j] = value;
            }
        }


        // Ввод матрицы с клавиатуры
        public void WriteMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
                    mass[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        // Вывод матрицы с клавиатуры
        public void ReadMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы: ");
            int nn = Convert.ToInt32(Console.ReadLine());
            // Инициализация
            Matrix mass1 = new Matrix(nn);
            Matrix mass2 = new Matrix(nn);
            Matrix mass3 = new Matrix(nn);
            Matrix mass4 = new Matrix(nn);
            Matrix mass5 = new Matrix(nn);
            Matrix mass6 = new Matrix(nn);
            Matrix mass7 = new Matrix(nn);
            Matrix mass8 = new Matrix(nn);
            Console.WriteLine("ввод Матрица А: ");
            mass1.WriteMat();
            Console.WriteLine("Ввод Матрица B: ");
            mass2.WriteMat();

            Console.WriteLine("Матрица А: ");
            mass1.ReadMat();
            Console.WriteLine();
            Console.WriteLine("Матрица В: ");
            Console.WriteLine();
            mass2.ReadMat();
            Console.ReadKey();
            Console.Write("Input N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            int[][] matrix = MakeMatrix(n);
            PrintMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine("Press any key for exit ...");
            Console.ReadKey();
        }

        private static int[][] MakeMatrix(int n)
        {
            int[][] matrix = new int[n][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[n];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = i == j ? 1 : 0;
                }
            }
            return matrix;
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
        

        

