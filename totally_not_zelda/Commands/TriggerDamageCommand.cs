using Sprint.Interfaces;
using Sprint.Character;

namespace Sprint.Commands
{
    public class TriggerDamageCommand : ICommand
    {
        private Link link;

        public TriggerDamageCommand(Link link)
        {
            this.link = link;
        }

        public void Execute()
        {
            link.StartDamaged();
        }
    }
}