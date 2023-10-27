namespace Zadanie9
{
    class Zadanie9
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj liczbe wierszy");
            int rows = Convert.ToInt32(Console.ReadLine());

            Zadanie9.PrintFigure1(rows);
            Zadanie9.PrintFigure2(rows);
            Zadanie9.PrintFigure3(rows);
            Zadanie9.PrintFigure4(rows);
        }

        private static void PrintFigure1(int rowsAmount)
        {
            string[] rows = Zadanie9.GetRows(rowsAmount);

            for (int i = 0; i < rows.Length; i++)
            {
                Console.WriteLine("{0}", rows[i]);
            }
        }

        private static void PrintFigure2(int rowsAmount)
        {
            string[] rows = Zadanie9.GetRows(rowsAmount);

            for (int i = rows.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}", rows[i]);
            }
        }

        private static void PrintFigure3(int rowsAmount)
        {
            string[] rows = Zadanie9.GetRows(rowsAmount);

            for (int i = 0; i < rows.Length; i++)
            {
                char[] chars = rows[i].ToCharArray();
                Array.Reverse(chars);

                Console.WriteLine("{0}", new string(chars));
            }
        }

        private static void PrintFigure4(int rowsAmount)
        {
            for (int i = 0; i < rowsAmount; i++)
            {
                string row = "";

                for (int j = 0; j < rowsAmount; j++)
                {
                    if (j == 0 || j == rowsAmount - 1 || i == 0 || i == rowsAmount - 1)
                    {
                        row += "*";
                    } else {
                        row += " ";
                    }
                }

                Console.WriteLine("{0}", row);
            }   
        }

        private static string[] GetRows(int rowsAmount)
        {
            string[] rows = new string[rowsAmount];

            for (int i = 1; i <= rowsAmount; i++)
            {
                string row = "";

                for (int j = 0; j < rowsAmount; j++)
                {
                    row += j < i ? "*" : " ";
                }

                rows[i - 1] = row;
            }

            return rows;
        }
    }
}