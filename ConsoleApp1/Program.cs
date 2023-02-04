using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    class TikTakToeBoard
    {
        private char[,] box = { };
        public int len { get; set; }
       
        public void Start()
        {
            box = new char[len, len];
            for(int i = 0; i < len; i++)
            {
                for(int j = 0; j<len; j++)
                {
                    box[i,j] = 'x';
                }
            }
            for (int i = 0; i < len; i++)
            {
                
                for (int j = 0; j < len; j++)
                {
                    Console.Write(box[i,j]);
                    if (j<len-1)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine("\n");
               
                
            }
        }


        public bool Set(int x, int y, char l)
        {
            if (box[x, y] == null)
            {
                box[x, y] = l;
                return true;
            }
            return false;

        }

        public void WriteBoard()
        {
            foreach(char c in box)
            {
                Console.WriteLine(c);
            }
        }

        public void CheckWin()
        {

        }

        public void NotVacantError()
        {
            Console.WriteLine();
            Console.WriteLine("Error: box not vacant!");
            Console.WriteLine("Press any key to try again..");
            Console.ReadKey();
            return;
        }

        public void DisplayLoss()
        {
            Console.WriteLine();
            Console.WriteLine("No one won.");
            Console.ReadKey();
            Environment.Exit(1);
        }
    }

    static void Main()
    {
        Console.WriteLine(" -- Tic Tac Toe -- ");
        Console.WriteLine("Podaj wielkość planszy(x,x): ");
        int x = int.Parse(Console.ReadLine());
        TikTakToeBoard tikTakToeBoard = new TikTakToeBoard();
        tikTakToeBoard.len = x;
        tikTakToeBoard.Start();
        
        //Console.Clear();

    }
}