namespace GameClicker {


    class ClickCommand : Icommand {

        private ClickerGame game;

        public char character { get; } = ' ';

        public ClickCommand(ClickerGame game) {
            this.game = game;
        }

        public void run() {
            game.click();
        }
    }
    
}
