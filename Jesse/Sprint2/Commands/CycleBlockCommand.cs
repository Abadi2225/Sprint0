using Sprint.Interfaces;

namespace Sprint.Commands
{
    public class CycleBlockCommand : ICommand
    {
        private readonly Game1 game;
        private readonly bool forward;

        public CycleBlockCommand(Game1 game, bool forward)
        {
            this.game = game;
            this.forward = forward;
        }

        public void Execute(int id)
        {
            // Logic for cycling through blocks
        }

        public void Unexecute() { }
    }
}
