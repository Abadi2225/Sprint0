# The Legend of Zilda

A 2D action-adventure game inspired by *The Legend of Zelda*, built in C# using the MonoGame framework.

---

## Program Controls

### Movement
| Key(s) | Action |
|--------|--------|
| `Up Arrow` | Move up |
| `Down Arrow` | Move down |
| `Left Arrow` | Move left |
| `Right Arrow` | Move right |

### Combat
| Key(s) | Action |
|--------|--------|
| `X` | Attack with sword |

### Items
| Key | Action |
|-----|--------|
| `1` | Use item in slot B |

### Navigation
| Key(s) | Action |
|--------|--------|
| `Left Mouse` | Go to previous room |
| `Right Mouse` | Go to next room |

### Demo Controls
| Key(s) | Action |
|--------|--------|
| `E` | Trigger damage animation on Link |
| `Enter` | Start game from title screen |
| `Q` | Quit game |
| `R` | Reset game to title screen |
| `K` | Link Dies |
| `M` | Mute Game Sound |

---

## Sprint 4 — New Features

### Inventory System
Link now has an inventory that holds up to three usable items. Items can be used by assigning one to B slot and using `1`.

### Item Pickups
Collectible items are placed in the world. Walking over them triggers a pickup animation and applies their effect immediately:
- **Heart** — Restores 1 heart
- **Fairy** — Fully restores all hearts
- **Gold Rupee** / **Purple Rupee** — Increases Link's ruby count
- **Key, Bow, Map, Compass, etc.** — Collected into the inventory

### Active Item Combat
Throwable/usable items now deal damage to enemies:
| Item | Damage | Behaviour |
|------|--------|-----------|
| **Arrow** | 1 | Travels in a straight line; disappears on first enemy hit |
| **Boomerang** | 1 | Travels out and returns; passes through enemies |
| **Bomb** | 2 | Placed in front of Link; explodes after 3 seconds in a 128 × 128 area |

---

## Game Features

- **Link** — Four directional movement and sword-attack animations with a 0.5 second damage state on being hit.
- **12 Enemy Types** — Including standard enemies (Gel, Keese, Stalfos, Zol, Rope, Goriya, WallMaster, Trap), two bosses (Aquamentus, Dodongo), a boss projectile (AquamentusFireball), and an NPC (OldMan).
- **18 Item Types** — Usable items (Boomerang, Bow, Bomb) and collectibles (Heart, HeartContainer, Fairy, Clock, Rupee variants, Potions, Map, Candle, Key, Compass, Triforce).
- **10 Block/Tile Types** — Blank, Square, StatueRight, StatueLeft, Black, Sand, Water, Stairs, Bricks, Ladder.
- **Multiple Rooms** — Rooms are loaded from data files and can be cycled with the mouse.
- **Start Screen** — Title screen with Enter-to-start option.

---

## Known Bugs

- Room transition was supposed to be done but member assigned faced problems before submitting
- Not all sounds are linked up or working as supposed to
- Underground room boundaries feels a bit off
- No way to get to NPC room through the implemented game

---

## Technology Stack

| Tool / Library | Purpose |
|---------------|---------|
| **C#** | Primary programming language |
| **MonoGame 3.8.5** | Game framework |
| **MonoGame Content Builder** | Compiling sprite sheets and other assets |
| **Git / GitHub** | Version control and team collaboration |
| **Visual Studio / VS Code** | IDE |

---

## Project Structure

```
CODE_METRICS            # Shows the code metrics for all the project
totally_not_zelda/
├── Character/          # Link player character with movement/attack states
├── Commands/           # Command actions
├── Block/              # Tile management
├── Collisions/         # All collision handler implementations
├── Controllers/        # Keyboard and mouse input controllers
├── Doors/              # Implementation for Doors
├── Enemies/
│   ├── Base/           # Abstract enemy base class and manager
│   └── Concrete/       # 12 concrete enemy implementations
├── GameStates/         # StartScreenState and GameplayState
├── Interfaces/         # All shared interface definitions
├── InputHandling/      # Handles keybinds
├── Item/
│   ├── Active/         # Throwable/usable items (Arrow, Boomerang, Bomb)
│   └── Still/          # Collectible world items (Hearts, Rupees, etc.)
├── Levels/             # Building rooms and levels from json file
├── Sprites/            # Sprite types (animated, directional, static, projectile)
├── Sound/              # Sounds for the game
├── UI/                 # UIManager, HUD, and title screen UI
├── Content/            # Game assets (sprite sheets, block images, fonts)
├── Game1.cs            # Main game class
└── GameServices.cs     # Service locator for shared dependencies
```
