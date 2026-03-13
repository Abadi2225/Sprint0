# The Legend of Zilda

A 2D action-adventure game inspired by *The Legend of Zelda*, built in C# using the MonoGame framework.

---

## Program Controls

### Movement
| Key(s) | Action |
|--------|--------|
| `W` / `Up Arrow` | Move up |
| `S` / `Down Arrow` | Move down |
| `A` / `Left Arrow` | Move left |
| `D` / `Right Arrow` | Move right |

### Combat
| Key(s) | Action |
|--------|--------|
| `Z` / `N` | Attack with sword |

### Items
| Key | Action |
|-----|--------|
| `1` | Use item in slot 1 (Boomerang) |
| `2` | Use item in slot 2 (Bow / Arrow) |
| `3` | Use item in slot 3 (Bomb) |

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

---

## Sprint 3 — New Features

### Inventory System
Link now has an inventory that holds up to three usable items. Items can be used with `1`, `2`, `3`.

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

### Enemy Projectile Damage
Enemy-fired projectiles now hurt Link:
| Source | Projectile | Damage |
|--------|-----------|--------|
| **Aquamentus** | Fireball (3 shots) | 1 |
| **Goriya** | Boomerang | 1 |

### Collision System
Six collision handlers now run every frame:

| Handler | What it does |
|---------|-------------|
| `LinkEnemyCollision` | Link takes damage on contact with an enemy |
| `SwordEnemyCollision` | Sword swing damages enemies |
| `EnemyBlockCollisionHandler` | Enemies are pushed out of solid tiles |
| `LinkItemCollision` | Link picks up world items on contact |
| `ActiveItemEnemyCollision` | Arrow / Boomerang / Bomb damage enemies |
| `LinkEnemyProjectileCollision` | Enemy projectiles (fireballs, Goriya boomerang) damage Link |

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

*TODO*

---

## Design Patterns Used

The project was built around recommended software design patterns to keep the code maintainable across sprints:

### Command Pattern
All keyboard/mouse input is wrapped in `ICommand` objects (`QuitCommand`, `CycleEnemyCommand`, `CycleItemCommand`, `CycleBlockCommand`, `UseItemCommand`, `SetStateCommand`). This decouples input handling from game logic and makes keybinding changes easier.

### State Pattern
Game flow is managed through `IGameState` implementations (`StartScreenState`, `GameplayState`). Link's animation is similar with (`Idle`, `Walking`, `Attacking`), cleanly separating each state's update and draw logic.

### Factory Pattern
`EnemyFactory`, `ItemFactory`, and `MapManager` centralise object creation. Adding a new enemy or item type only requires changes in one place.

### Decorator Pattern
`EnemyEffectWrapper` wraps any `IEnemy` to add spawn and death particle animations without modifying the enemy classes themselves.

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
├── Enemies/
│   ├── Base/           # Abstract enemy base class and manager
│   └── Concrete/       # 12 concrete enemy implementations
├── Factories/          # Link's Factory class
├── Game States/        # StartScreenState and GameplayState
├── Interfaces/         # All shared interface definitions
├── Item/
│   ├── Active/         # Throwable/usable items (Arrow, Boomerang, Bomb)
│   └── Still/          # Collectible world items (Hearts, Rupees, etc.)
├── Sprites/            # Sprite types (animated, directional, static, projectile)
├── UI/                 # UIManager, HUD, and title screen UI
├── Content/            # Game assets (sprite sheets, block images, fonts)
├── Game1.cs            # Main game class
└── GameServices.cs     # Service locator for shared dependencies
```
