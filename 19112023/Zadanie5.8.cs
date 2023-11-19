namespace Zadanie8 {
    class Zadanie8 {
        public static void ShowExample() {
            Console.WriteLine("Podaj liczbe");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma cyfr liczby {0} = {1}", n, Zadanie8.GetSumOfNumberDigits(n));
        }

        private static int GetSumOfNumberDigits(int number) {
            string stringifiedNumber = number.ToString();
            int sum = 0;

            for (int i = 0; i < stringifiedNumber.Length; i++)
            {
                sum += (stringifiedNumber[i] - '0');
            }

            return sum;
        }
    }
}