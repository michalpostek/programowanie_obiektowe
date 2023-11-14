namespace Zadanie2
{

    class Zadanie2
    {
        public static void ShowExample()
        {
            const int arrSize = 10;

            int[] tab1 = new int[arrSize] { 1, -22, 33, 4, -63, 632, -332, 2, 6, 66 };
            int[] tab2 = new int[arrSize];

            for (int i = 0; i < arrSize; i++) {
                if (tab1[i] > 0) {
                    tab2[i] = tab1[i];
                }
            }

            Console.WriteLine("{0}", string.Join(", ", tab1));
            Console.WriteLine("{0}", string.Join(", ", tab2));
        }
    }
}
