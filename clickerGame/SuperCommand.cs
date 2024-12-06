namespace GameClicker {


    class SuperComman : Icommand {

        ClickerGame game;

        public char character { get; } = 's';

        public SuperComman(ClickerGame game) {
            this.game = game;
        }

        public void run() {
            game.superUpgrade();
        }
    }
    
}
