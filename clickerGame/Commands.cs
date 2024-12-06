namespace GameClicker
{


    class Commands
    {

        private Icommand[] commands;

        public Commands(ClickerGame game)
        {

            commands = new Icommand[] {

                new ClickCommand(game),
                new UpgradeCommand(game),
                new SuperComman(game),
                new ExitCommand(),
            };
        }

        private Icommand FindCmd(char charCmd)
        {
            foreach (Icommand cmd in commands)
            {
                if (cmd.character == charCmd)
                    return cmd;
            }
            return null;
        }

        public void run(char charCmd)
        {
            var command = FindCmd(charCmd);
            if (command != null)
                command.run();
        }
    }
}
