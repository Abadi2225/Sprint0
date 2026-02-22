using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Item;

public class Compass : AbstractItem, ItemSprite
{
    private const string ResourceName = "items/compass";

    private Texture2D texture;

    public Vector2 DrawPos { get; set; }

    private Compass() : base("compass", "compass", 1) { }

    public Compass(ContentManager contentManager) : this()
    {
        texture = contentManager.Load<Texture2D>(ResourceName);
        DrawPos = new Vector2(0f, 0f);
    }

    public Compass(ContentManager contentManager, Vector2 pos) : this(contentManager)
    {
        DrawPos = pos;
    }

    public Compass(Texture2D texture) : this()
    {
        DrawPos = new Vector2(0f, 0f);
        this.texture = texture;
    }

    public Compass(Texture2D texture, Vector2 pos) : this()
    {
        DrawPos = pos;
        this.texture = texture;
    }

    public void Draw(SpriteBatch sb)
    {
        sb.Draw(
                texture,
                DrawPos,
                sourceRectangle: null,
                color: Color.White,
                rotation: 0f,
                origin: Vector2.Zero,
                scale: 0.2f,
                effects: SpriteEffects.None,
                layerDepth: 0f
       );
    }

    public override void Use()
    {

    }
}
