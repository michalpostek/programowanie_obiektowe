namespace Zadanie12
{
    class Zadanie12
    {
        public static void ShowExample()
        {
            int sum = 0;
            int input = 1;

            while (input != 0)
            {
                Console.WriteLine("Podaj liczbe");
                input = Convert.ToInt32(Console.ReadLine());
                sum += input;
            }

            Console.WriteLine("Suma wprowadzonych liczb to {0}", sum);
        }
    }
}