namespace GameClicker {


    class ExitCommand : Icommand {

        public char character { get; } = 'q';

        public void run() {
            Environment.Exit(0);
        }
    }
    
}
