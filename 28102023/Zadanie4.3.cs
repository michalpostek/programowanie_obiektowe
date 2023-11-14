namespace Zadanie3 {
    class Zadanie3 {
        public static void ShowExample() {
            int[] arr = Zadanie1.Zadanie1.GetIntArray();

            if (arr.Length == 0) {
                return;
            }

            int min = arr[0];
            int minIndex = 0;
            int max = arr[0];
            int maxIndex = 0;
            int sum = 0;
            int positiveItemsAmount = 0;
            
            for (int i = 0; i < arr.Length; i++) {
                if (i > 0) {
                    if (arr[i] > max) {
                        maxIndex = i;
                        max = arr[i];
                    } else if (arr[i] < min) {
                        minIndex = i;
                        min = arr[i];
                    }
                }

                sum += arr[i];

                if (arr[i] > 0) {
                    positiveItemsAmount++;
                }
            }

            Console.WriteLine("Najmniejszy element to {0} na pozycji {1}", min, minIndex + 1);
            Console.WriteLine("Najwiekszy element to {0} na pozycji {1}", max, maxIndex + 1);
            Console.WriteLine("Srednia elementow to {0}", sum / arr.Length);
            Console.WriteLine("Liczba dodatnich elementow to {0}", positiveItemsAmount);
        } 
    }
}