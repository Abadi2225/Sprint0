namespace Sprint.Interfaces
{
    public interface IGameActions
        {
            void Quit();
            void ChangeState(IGameState newState);
        }
}