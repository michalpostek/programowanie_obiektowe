using ThreadsNS;

class Program {
    public static void Main(string[] args) {
        // CatchDivisionException(3);
        // InvokeNotImplementedMethod();
        Threads threads = new Threads();
    }

    public static void CatchDivisionException(int x) {
        try {
            int y = x / 0;
        } catch (Exception e) {
            if (e is System.DivideByZeroException) {
                Console.WriteLine("Do not divide by 0!!!");
            }
        }
    }

    public static void InvokeNotImplementedMethod() {
        try {
            NotImplementedMethod();
        } catch (Exception e) {
            if (e is System.NotImplementedException) {
                Console.WriteLine("This method is not implemented yet!");
            }
        }
    }

    public static void NotImplementedMethod() {
        throw new System.NotImplementedException();
    }
}
