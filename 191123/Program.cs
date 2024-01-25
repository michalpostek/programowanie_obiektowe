using System.IO.Compression;

class Program
{

    public static void Main()
    {
        int[][] matrix = new int[4][] { new int[4], new int[4], new int[4], new int[4] };
        Wczytaj(matrix);
        ShowMatrix(matrix);

        int min = matrix[0][0];
        Znajdz(matrix, ref min);

        Console.WriteLine("Najmeniejsza wartosc: {0}", min);
    }

    private static void Wczytaj(int[][] matrix)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("Podaj liczbe");
                matrix[i][j] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static void Znajdz(int[][] matrix, ref int minRef)
    {
        int minCol = 0;
        int minRow = 0;
        int min = matrix[minRow][minCol];

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] < min)
                {
                    min = matrix[i][j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        minRef = min;

        Console.WriteLine("Najmniejszy element jest w wierszu {0} i kolumnie {1}", ++minRow, ++minCol);
    }

    private static void ShowMatrix(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            Console.WriteLine("{0}", string.Join(", ", matrix[i]));
        }
    }
}
