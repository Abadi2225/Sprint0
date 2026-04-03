using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;

namespace Sprint.Sound;

internal class SoundPlayer
{
    private static Dictionary<SoundType, string> soundLookup = new Dictionary<SoundType, string>()
    {
        { SoundType.ARROW_BOOMERANG, "sounds/LOZ_Arrow_Boomerang" },
        { SoundType.BOMB_EXPLODE, "sounds/LOZ_Bomb_Blow" },
        { SoundType.BOMB_PLACE, "sounds/LOZ_Bomb_Drop" },
        { SoundType.BOSS_HURT, "sounds/LOZ_Boss_Hit" },
        { SoundType.BOSS_SCREAM1, "sounds/LOZ_Boss_Scream1" },
        { SoundType.BOSS_SCREAM2, "sounds/LOZ_Boss_Scream2" },
        { SoundType.BOSS_SCREAM3, "sounds/LOZ_Boss_Scream3" },
        { SoundType.CANDLE, "sounds/LOZ_Candle" },
        { SoundType.DOOR_UNLOCK, "sounds/LOZ_Door_Unlock" },
        { SoundType.ENEMY_DEATH, "sounds/LOZ_Enemy_Die" },
        { SoundType.ENEMY_HURT, "sounds/LOZ_Enemy_Hit" },

        { SoundType.PICKUP_VALUABLE, "sounds/LOZ_Fanfare" },
        { SoundType.LINK_HEALED, "sounds/LOZ_Get_Heart" },
        { SoundType.PICKUP_ITEM, "sounds/LOZ_Get_Item" },
        { SoundType.PICKUP_RUPEE, "sounds/LOZ_Get_Rupee" },
        { SoundType.KEY_APPEAR, "sounds/LOZ_Key_Appear" },

        { SoundType.LINK_DEATH, "sounds/LOZ_Link_Die" },
        { SoundType.LINK_HURT, "sounds/LOZ_Link_Hurt" },
        { SoundType.LOW_HEALTH, "sounds/LOZ_LowHealth" },

        { SoundType.SECRET_UNLOCKED, "sounds/LOZ_Secret" },

        { SoundType.SWORD_COMBINED, "sounds/LOZ_Sword_Combined" },
        { SoundType.SWORD_SHOOT, "sounds/LOZ_Sword_Shoot" },
        { SoundType.SWORD_SWING, "sounds/LOZ_Sword_Slash" }
    };

    public static void Play(SoundType type)
    {
        string filename = soundLookup[type];
        if (filename == null) return;

        Game1.Instance.Content.Load<SoundEffect>(filename).Play();
    }
}
