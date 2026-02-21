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
            // Logic for cycling through items in the inventory
        }

        public void Unexecute() { }
    }
}
