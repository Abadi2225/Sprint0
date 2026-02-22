using Sprint.Interfaces;

namespace Sprint.Commands
{
    public class CycleItemCommand : ICommand
    {
        private readonly Game1 game;
        private readonly bool forward;

        public CycleItemCommand(Game1 game, bool forward)
        {
            this.game = game;
            this.forward = forward;
        }

        public void Execute(int id)
        {
            var itemManager = game.GetItemManager();
            if (forward)
                itemManager?.CycleNext();
            else
                itemManager?.CyclePrevious();
        }

        public void Unexecute() { }
    }
}
