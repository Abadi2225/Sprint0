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

### Demo Controls
| Key(s) | Action |
|--------|--------|
| `P` / `O` | Cycle to next / previous enemy |
| `I` / `U` | Cycle to next / previous item |
| `Y` / `T` | Cycle to next / previous block type |
| `E` | Trigger damage animation on Link |
| `Enter` | Start game from title screen |
| `Q` | Quit game |
| `R` | Reset Game to title screen

---

## Game Features

- **Link** — Four directional movement and sword-attack animations with a 0.5 second damage state on being hit.
- **12 Enemy Types** — Including standard enemies (Gel, Keese, Stalfos, Zol, Rope, Goriya, WallMaster, Trap), two bosses (Aquamentus, Dodongo), a boss projectile (AquamentusFireball), and an NPC (OldMan).
- **18 Item Types** — Usable items (Boomerang, Bow, Bomb) and collectibles (Heart, HeartContainer, Fairy, Clock, Rupee variants, Potions, Map, Candle, Key, Compass, Triforce).
- **10 Block/Tile Types** — Blank, Square, StatueRight, StatueLeft, Black, Sand, Water, Stairs, Bricks, Ladder.
- **Start Screen** — Title screen with Enter-to-start option.

---

## Known Bugs

| Location | Description |
|----------|-------------|
| `Rope.cs:54` | Rope's charge-trigger currently uses a timer instead of checking Link's actual position along the same axis. |
| `Trap.cs:75` | Trap activation is timer-based, it should instead trigger when Link aligns with the trap on the correct axis. |
| `Trap.cs:121` | Trap movement direction is hardcoded, it should continusly point toward Link's current position. |
| `WallMaster.cs:87, 137` | WallMaster moves in a fixed direction rather than tracking Link's position. |
| `ItemManager.cs:28` | Link uses sword attack animation when using items, should be fixed to use the use item animation. |
| `TimeBomb.cs:28` | Bomb does disappear but there is still no animation of an explosion.

---

## Design Patterns Used

The project was built around recommended software design patterns to keep the code maintainable across sprints:

### Command Pattern
All keyboard/mouse input is wrapped in `ICommand` objects (`QuitCommand`, `CycleEnemyCommand`, `CycleItemCommand`, `CycleBlockCommand`, `UseItemCommand`, `SetStateCommand`). This decouples input handling from game logic and makes keybinding changes easier.

### State Pattern
Game flow is managed through `IGameState` implementations (`StartScreenState`, `GameplayState`). Link's animation is similar with (`Idle`, `Walking`, `Attacking`), cleanly separating each state's update and draw logic.

### Factory Pattern
`EnemyFactory`, `ItemFactory`, and `MapManager` centralise object creation. Adding a new enemy or item type only requires changes in one place.

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
CODE_METRICS            # Shows the code matrics for all the project
totally_not_zelda/
├── Character/          # Link player character with movement/attack states
├── Commands/           # Command actions
├── Block/              # Tile management
├── Controllers/        # Keyboard and mouse input controllers
├── Enemies/
│   ├── Base/           # Abstract enemy base class and manager
│   └── Concrete/       # 12 concrete enemy implementations
├── Factories/          # Link's Factory class
├── Game States/        # StartScreenState and GameplayState
├── Interfaces/         # All shared interface definitions
├── Item/               # Item manager, factory, and item implementations
├── Sprites/            # Sprite types (animated, directional, etc.)
├── UI/                 # UIManager and title screen UI
├── Content/            # Game assets (sprite sheets, block images, fonts)
├── Game1.cs            # Main game class
└── GameServices.cs     # Service locator for shared dependencies
```