using Sprint.Enemies;
using Sprint.Interfaces;

namespace Sprint.Commands
{
    public class CycleEnemyCommand : ICommand
    {
        private EnemyManager enemyManager;
        private readonly bool forward;

        public CycleEnemyCommand(EnemyManager enemyManager, bool forward)
        {
            this.enemyManager = enemyManager;
            this.forward = forward;
        }

        public void Execute()
        {
            if (forward)
                enemyManager?.CycleNext();
            else
                enemyManager?.CyclePrevious();
        }
    }
}
