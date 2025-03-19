
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandX
{
    class Program
    {
        const int gridSize = 3;
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            numbers[3] = 77;
            string[,] grid = new string[3, 3]; //row,col
            Initialise(ref grid);
            char go = 'O';
            int col = 0, row = 0;
            DisplayGrid(grid);
            do
            {
                int count = 0;
                bool a = true;
                while (a == true)
                {
                    a = false;
                    //if (count == 0)
                    {

                        GetGo(ref col, ref row);
                        count++;
                    }
                    if (grid[row, col] != " ")
                    {
                        Console.WriteLine("You cant over take someones turn please re enter your position");
                        //GetGo(ref col, ref row);
                        a = true;
                    }
                }

                grid[row, col] = Convert.ToString(go);
                if (go == 'O')
                {
                    go = 'X';
                }
                else
                {
                    go = 'O';
                }

                DisplayGrid(grid);
            } while (!Won(grid));
            if (go == 'O')
            {
                go = 'X';
            }
            else
            {
                go = 'O';
            }
            Console.WriteLine(go + " has won");
            Console.ReadLine();
        }

        private static bool Won(string[,] grid)
        {

            //check 3 vertically
            for (int col = 0; col < gridSize; col++)
            {
                if (grid[0, col] == grid[1, col] && grid[1, col] == grid[2, col])
                {
                    // they are all the same but are they an X or O
                    if (grid[0, col] == "X" || grid[0, col] == "O")
                    {
                        return true;
                    }
                }
            }
            //check horizonally
            for (int row = 0; row < gridSize; row++)
            {
                if (grid[row, 0] == grid[row, 1] && grid[row, 1] == grid[row, 2])
                {
                    // they are all the same but are they an X or O
                    if (grid[row, 0] == "X" || grid[row, 0] == "O")
                    {
                        return true;
                    }
                }
            }

            //// check diag \
            if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2])
            {
                for (int row = 0; row < gridSize; row++)
                {

                    if (grid[row, 0] == "X" || grid[0, 0] == "O")
                    {
                        return true;
                    }
                }
                // they are all the same but are they an X or O
            }



            //// check diag /
            if (grid[2, 0] == grid[1, 1] && grid[1, 1] == grid[0, 2])
            {
                if (grid[2, 0] == "X" || grid[2, 0] == "O")
                {
                    return true;
                }
                // they are all the same but are they an X or O
            }


            return false;
        }

        static void GetGo(ref int col, ref int row)
        {
            int check = 0;
            while (check == 0)
            {
                int colrow = 0;
                Console.WriteLine("please enter the row followed column");
                string strcolrow = Console.ReadLine();
                if (strcolrow == "01" || strcolrow == "02" || strcolrow == "00" ||
                    strcolrow == "11" || strcolrow == "12" || strcolrow == "10" ||
                        strcolrow == "21" || strcolrow == "22" || strcolrow == "20")
                {
                    colrow = Convert.ToInt32(strcolrow);
                    col = colrow % 10;
                    row = colrow / 10;
                    check = 1;
                }
                else
                {
                    Console.WriteLine("INVALID INPUT TRY AGAIN");
                }
            }
        }

        static void DisplayGrid(string[,] grid)
        {
            Console.WriteLine("   0 1 2");
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine(row + " |" + grid[row, 0] + "|" + grid[row, 1] + "|" + grid[row, 2] + "|");
                Console.WriteLine("  _______");
            }

        }


        static void Initialise(ref string[,] grid)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    grid[row, col] = " ";
                }
            }
        }


    }
}






