# The Legend of Zilda

A 2D action-adventure game inspired by *The Legend of Zelda*, built in C# using the MonoGame framework.

---

## Controls

### Movement
| Key | Action |
|-----|--------|
| `Up Arrow` | Move up |
| `Down Arrow` | Move down |
| `Left Arrow` | Move left |
| `Right Arrow` | Move right |

### Combat & Items
| Key | Action |
|-----|--------|
| `X` | Attack with sword |
| `1` / `Z` | Use item in slot B |
| `I` / `S` | Open inventory screen |

### Title Screen
| Key | Action |
|-----|--------|
| `Enter` | Start game |
| `Q` | Quit game |

### In-Game
| Key | Action |
|-----|--------|
| `R` | Reset to title screen |
| `Q` | Quit game |
| `M` | Mute / unmute sound |
| `Left Mouse` | Go to previous room (debug) |
| `Right Mouse` | Go to next room (debug) |
| `H` | Switch to Dungeon 1 (debug) |
| `J` | Switch to Dungeon 2 (debug) |
| `K` | Kill Link (debug) |
| `E` | Trigger damage animation (debug) |
| `C` | Debug toggle mode |

---

## Game Overview

The Legend of Zilda is an action game where Link explores two distinct dungeons, fights enemies, collects items, and faces a boss at the end of each dungeon. The game has inventory system, combat items, an 12 enemy types, and a HUD that tracks hearts, rupees, keys, and the dungeon map. Take the Triforce to Advance!

---

## The Two Dungeons

### Dungeon 1 — Stone Keep
The first dungeon has 18 different rooms, including an underground staircase room accessible by pushing a block and going down the stairs. The dungeon's boss is **Aquamentus**, a dragon that fires fireballs. Defeating it and collecting the Triforce completes the dungeon and transforms you to the next.

- Boss: **Aquamentus** (No special way to defeat it)
- Special room: underground staircase reached by a pushable block
- NPC room: an Old Man who gives hints

### Dungeon 2 — Desert Ruins
The second dungeon has 18 rooms including desert, statue corridors, and more. The boss is **Dodongo**, a large dinosaur or rihno-like enemy that must be fed bombs to damage.

- Boss: **Dodongo** (immune to all attacts, must be damaged with bombs)
- NPC room: a second Old Man with dialogue

---

## Key Design Choices

### State Machine for Link
Link's behavior is modelled as a state machine (`LinkStateMachine`). States: Idle, Walking, Attacking, Damaged, Dead, PickingUp, UsingItem, Grabbed are objects that own their own update and draw logic.

### Command Pattern for Input
All player actions are wrapped in command objects (in [Commands/](totally_not_zelda/Commands/)). The input handler creates a command and executes it rather than directly calling methods on Link.

### Collision Handler
Collision detection is split into handler classes (e.g. `LinkBlockCollisionHandler`, `SwordEnemyCollision`, `ProjectileCollision`) rather than a single check. The `CollisionManager` calls each handler every frame. This makes it easy to add or remove a collision type.

### Service Locator (`GameServices`)
Shared singletons the input system, the sound manager, the scale factor, the current dungeon index, are accessed through a static `GameServices` class.

### Factory Pattern for Enemies and Link
`EnemyFactory` maps tile IDs from room JSON to enemy instances, and `LinkFactory` constructs Link with all its dependencies.

---

## Combat Items

| Item | Damage | Behaviour |
|------|--------|-----------|
| **Arrow** | 1 | Travels in a straight line, disappears on first enemy hit |
| **Boomerang** | 1 | Travels out and returns, passes through enemies |
| **Bomb** | 2 | Placed in front of Link, explodes after 3 seconds in a 128×128 area. Required to damage Dodongo |

---

## Known Issues

- Underground room boundaries feel slightly off

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
CODE_METRICS            # Automated code metrics report
totally_not_zelda/
├── Character/          # Link player character and state machine
│   └── States/         # Idle, Walking, Attacking, Damaged, Dead, etc.
├── Commands/           # Command pattern — one class per player action
├── Block/              # Tile types and tile management
├── Collisions/         # Per-pair collision handler classes
├── Controllers/        # Keyboard and mouse input controllers
├── Doors/              # Door types, door manager, dungeon outer walls
├── Enemies/
│   ├── Base/           # Abstract enemy base and EnemyFactory
│   └── Concrete/       # 12 concrete enemy implementations
├── GameStates/         # Title, Gameplay, Inventory, GameOver, GameComplete, RoomTransition
├── InputHandling/      # Maps raw key presses to commands
├── Interfaces/         # Shared interface definitions (ILink, IEnemy, ISprite, …)
├── Item/
│   ├── Active/         # Throwable/usable items (Arrow, Boomerang, Bomb)
│   └── Still/          # Collectible world items (Hearts, Rupees, etc.)
├── Levels/             # LevelLoader, LevelBuilder, LevelData — JSON → live objects
├── Saving/             # Save/load state
├── Sound/              # SoundManager and all sound effect bindings
├── Sprites/            # Sprite variants (animated, directional, static, projectile)
├── UI/                 # UIManager, HUD, minimap, title screen
├── Content/            # Assets (sprite sheets, fonts, room JSON files)
│   └── rooms/
│       ├── dungeon1/   # 18 room JSON files for Dungeon 1
│       └── dungeon2/   # 18 room JSON files for Dungeon 2
├── Game1.cs            # MonoGame entry point
└── GameServices.cs     # Service locator for shared singletons
```
