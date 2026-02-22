using Sprint.Interfaces;

namespace Sprint.Commands
{
    public class CycleEnemyCommand : ICommand
    {
        private readonly Game1 game;
        private readonly bool forward;

        public CycleEnemyCommand(Game1 game, bool forward)
        {
            this.game = game;
            this.forward = forward;
        }

        public void Execute(int id)
        {
            /*var enemyManager = game.GetEnemyManager();
            if (forward)
                enemyManager?.CycleNext();
            else
                enemyManager?.CyclePrevious();*/
        }

        public void Unexecute() { }
    }
}
