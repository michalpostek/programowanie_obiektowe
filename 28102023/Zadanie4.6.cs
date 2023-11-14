namespace Zadanie6
{
    class Zadanie6
    {
        public static void ShowExample()
        {
            Random random = new Random();
            int n = 5;
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] row = new int[n];

                for (int j = 0; j < n; j++)
                {
                    row[j] = random.Next(1, 100);
                }

                matrix[i] = row;
            }

            Zadanie6.PrintMatrix(matrix);

            Console.WriteLine("Suma: {0}", Zadanie6.GetDiagonalSum(matrix));
        }

        private static int GetDiagonalSum(int[][] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                sum += matrix[i][i];
            }

            return sum;
        }

        private static void PrintMatrix(int[][] matrix)
        {
            foreach (int[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}