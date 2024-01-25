namespace ThreadsNS {
    class Threads {
        public Threads() {
            Thread thread = new Thread(RunLoop);
            thread.Start();
        }

        public static void RunLoop() {
            for (int i = 0; i < 10000; i++) {
                Console.WriteLine("program1: {0}", i);
            }
        }
    }
}