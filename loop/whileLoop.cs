namespace whileTrue {


    class WhileLoop {

        bool x = true;
        int i;


        public void loopWhile() {

            while (x == true) {
                if (i < 10) {
                    Console.WriteLine($"Runde: {i}");
                    i++;
                }
                else {
                    x = false;
                }
            }
        }
    }
    
}
