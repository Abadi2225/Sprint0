namespace Sprint.Interfaces;

public interface IGameActions
{
    public void Quit();
    public void ChangeState(IGameState newState);
}