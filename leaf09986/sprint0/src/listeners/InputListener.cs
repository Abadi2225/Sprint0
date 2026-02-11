using Microsoft.Xna.Framework;

namespace sprint0;

public interface InputListener
{
    public void onUpdate(Game game, GameClient client);
    public void toggleInput(bool isActive);
}
