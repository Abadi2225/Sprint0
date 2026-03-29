using Sprint.Interfaces;
using Sprint.Character;

namespace Sprint.Commands
{
    public class AttackCommand : ICommand
    {
        private Link link;

        public AttackCommand(Link link)
        {
            this.link = link;
        }

        public void Execute()
        {
            link.StartAttack();
        }
    }
}