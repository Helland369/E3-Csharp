namespace GameClicker {


    class UpgradeCommand : Icommand {

        ClickerGame game;

        public char character { get; } = 'u';

        public UpgradeCommand(ClickerGame game) {
            this.game = game;
        }

        public void run() {
            game.upgrade();
        }
    }

}
