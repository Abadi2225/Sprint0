<!-- markdownlint-capture -->
<!-- markdownlint-disable -->

# Code Metrics

This file is dynamically maintained by a bot, *please do not* edit this by hand. It represents various [code metrics](https://aka.ms/dotnet/code-metrics), such as cyclomatic complexity, maintainability index, and so on.

<div id='sprint'></div>

## Sprint :exploding_head:

The *Sprint.csproj* project file contains:

- 18 namespaces.
- 103 named types.
- 5,474 total lines of source code.
- Approximately 1,672 lines of executable code.
- The highest cyclomatic complexity is 20 :exploding_head:.

<details>
<summary>
  <strong id="global+namespace">
    &lt;global namespace&gt; :exploding_head:
  </strong>
</summary>
<br>

The `<global namespace>` namespace contains 7 named types.

- 7 named types.
- 406 total lines of source code.
- Approximately 184 lines of executable code.
- The highest cyclomatic complexity is 20 :exploding_head:.

<details>
<summary>
  <strong id="program$">
    &lt;Program&gt;$ :heavy_check_mark:
  </strong>
</summary>
<br>

- The `<Program>$` contains 1 members.
- 2 total lines of source code.
- Approximately 4 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Program.cs#L1' title='<top-level-statements-entry-point>'>1</a> | 88 | 1 :heavy_check_mark: | 0 | 2 | 2 / 2 |

<a href="#global+namespace">:top: back to &lt;global namespace&gt;</a>

</details>

<details>
<summary>
  <strong id="gameplaystate">
    GameplayState :exploding_head:
  </strong>
</summary>
<br>

- The `GameplayState` contains 27 members.
- 203 total lines of source code.
- Approximately 116 lines of executable code.
- The highest cyclomatic complexity is 20 :exploding_head:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L41' title='GameplayState.GameplayState()'>41</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 3 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L19' title='Texture2D GameplayState.BossesSheet'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L35' title='CollisionManager GameplayState.collisionManager'>35</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L33' title='Level GameplayState.currentLevel'>33</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L207' title='void GameplayState.Draw(SpriteBatch spriteBatch)'>207</a> | 68 | 1 :heavy_check_mark: | 0 | 7 | 10 / 7 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L23' title='Texture2D GameplayState.dungeonBackground'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L39' title='DungeonWalls GameplayState.dungeonWalls'>39</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L20' title='Texture2D GameplayState.dustSheet'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L18' title='Texture2D GameplayState.enemiesSheet'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L31' title='EnemyFactory GameplayState.enemyFactory'>31</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L30' title='EnemyManager GameplayState.enemyManager'>30</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L47' title='void GameplayState.Enter()'>47</a> | 84 | 1 :heavy_check_mark: | 0 | 14 | 16 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L45' title='void GameplayState.Exit()'>45</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L24' title='Texture2D GameplayState.hudElements'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L29' title='Inventory GameplayState.inventory'>29</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L28' title='ItemManager GameplayState.items'>28</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L32' title='LevelLoader GameplayState.levelLoader'>32</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L26' title='Link GameplayState.link'>26</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L17' title='Texture2D GameplayState.linkSheet'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L37' title='bool GameplayState.lmbReleased'>37</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L64' title='void GameplayState.LoadContent()'>64</a> | 36 | 1 :heavy_check_mark: | 0 | 42 | 75 / 60 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L21' title='Texture2D GameplayState.NPCSheet'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L27' title='Dictionary<Keys, ICommand> GameplayState.pressedKeys'>27</a> | 100 | 0 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L38' title='bool GameplayState.rmbReleased'>38</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L22' title='Texture2D GameplayState.tileSheet'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L34' title='UIManager GameplayState.uiManager'>34</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L140' title='void GameplayState.Update(GameTime gameTime)'>140</a> | 38 | 20 :exploding_head: | 0 | 36 | 66 / 46 |

<a href="#GameplayState-class-diagram">:link: to `GameplayState` class diagram</a>

<a href="#global+namespace">:top: back to &lt;global namespace&gt;</a>

</details>

<details>
<summary>
  <strong id="gameservices">
    GameServices :heavy_check_mark:
  </strong>
</summary>
<br>

- The `GameServices` contains 10 members.
- 21 total lines of source code.
- Approximately 4 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L23' title='Texture2D GameServices.BoomerangSheet'>23</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L12' title='ContentManager GameServices.Content'>12</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L15' title='IGameActions GameServices.GameActions'>15</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L19' title='int GameServices.GameHeight'>19</a> | 93 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L18' title='int GameServices.GameWidth'>18</a> | 93 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L22' title='Texture2D GameServices.ItemSheet'>22</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L13' title='IController GameServices.KeyInput'>13</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L25' title='ILink GameServices.Link'>25</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L17' title='float GameServices.ScaleFactor'>17</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L21' title='Texture2D GameServices.TileSheet'>21</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#GameServices-class-diagram">:link: to `GameServices` class diagram</a>

<a href="#global+namespace">:top: back to &lt;global namespace&gt;</a>

</details>

<details>
<summary>
  <strong id="level">
    Level :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Level` contains 7 members.
- 33 total lines of source code.
- Approximately 11 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L16' title='Level.Level(BlockManager blockManager, EnemyManager enemyManager)'>16</a> | 85 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L12' title='BlockManager Level.Blocks'>12</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L30' title='void Level.Draw(SpriteBatch spriteBatch)'>30</a> | 75 | 2 :heavy_check_mark: | 0 | 6 | 8 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L38' title='void Level.DrawOnTop(SpriteBatch spriteBatch)'>38</a> | 96 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L13' title='EnemyManager Level.Enemies'>13</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L22' title='void Level.Update(GameTime gameTime)'>22</a> | 79 | 2 :heavy_check_mark: | 0 | 5 | 7 / 3 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L14' title='List<AbstractItem> Level.WorldItems'>14</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 1 |

<a href="#Level-class-diagram">:link: to `Level` class diagram</a>

<a href="#global+namespace">:top: back to &lt;global namespace&gt;</a>

</details>

<details>
<summary>
  <strong id="levelbuilder">
    LevelBuilder :heavy_check_mark:
  </strong>
</summary>
<br>

- The `LevelBuilder` contains 2 members.
- 48 total lines of source code.
- Approximately 26 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelBuilder.cs#L11' title='Level LevelBuilder.Build(LevelData data, EnemyFactory enemyFactory)'>11</a> | 48 | 6 :heavy_check_mark: | 0 | 13 | 44 / 25 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelBuilder.cs#L10' title='int LevelBuilder.TILE_SIZE'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#LevelBuilder-class-diagram">:link: to `LevelBuilder` class diagram</a>

<a href="#global+namespace">:top: back to &lt;global namespace&gt;</a>

</details>

<details>
<summary>
  <strong id="levelloader">
    LevelLoader :heavy_check_mark:
  </strong>
</summary>
<br>

- The `LevelLoader` contains 6 members.
- 43 total lines of source code.
- Approximately 13 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelLoader.cs#L16' title='int LevelLoader.currentLevel'>16</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelLoader.cs#L17' title='LevelData LevelLoader.CycleNext()'>17</a> | 78 | 2 :heavy_check_mark: | 0 | 3 | 8 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelLoader.cs#L25' title='LevelData LevelLoader.CyclePrevious()'>25</a> | 80 | 2 :heavy_check_mark: | 0 | 3 | 8 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelLoader.cs#L33' title='LevelData LevelLoader.GetCurrentLevel()'>33</a> | 95 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelLoader.cs#L10' title='List<string> LevelLoader.levels'>10</a> | 87 | 0 :heavy_check_mark: | 0 | 2 | 5 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelLoader.cs#L38' title='LevelData LevelLoader.Load(string levelName)'>38</a> | 77 | 1 :heavy_check_mark: | 0 | 2 | 11 / 4 |

<a href="#LevelLoader-class-diagram">:link: to `LevelLoader` class diagram</a>

<a href="#global+namespace">:top: back to &lt;global namespace&gt;</a>

</details>

<details>
<summary>
  <strong id="startscreenstate">
    StartScreenState :heavy_check_mark:
  </strong>
</summary>
<br>

- The `StartScreenState` contains 10 members.
- 56 total lines of source code.
- Approximately 10 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/StartScreenState.cs#L20' title='StartScreenState.StartScreenState()'>20</a> | 95 | 1 :heavy_check_mark: | 0 | 1 | 6 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/StartScreenState.cs#L62' title='void StartScreenState.Draw(SpriteBatch spriteBatch)'>62</a> | 96 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/StartScreenState.cs#L29' title='void StartScreenState.Enter()'>29</a> | 93 | 1 :heavy_check_mark: | 0 | 8 | 9 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/StartScreenState.cs#L27' title='void StartScreenState.Exit()'>27</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/StartScreenState.cs#L39' title='void StartScreenState.LoadContent()'>39</a> | 78 | 1 :heavy_check_mark: | 0 | 7 | 8 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/StartScreenState.cs#L18' title='Dictionary<Keys, ICommand> StartScreenState.pressedKeys'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/StartScreenState.cs#L16' title='TitleScreen StartScreenState.titleScreen'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/StartScreenState.cs#L15' title='Texture2D StartScreenState.titleSheet'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/StartScreenState.cs#L14' title='UIManager StartScreenState.uiManager'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/StartScreenState.cs#L48' title='void StartScreenState.Update(GameTime gameTime)'>48</a> | 77 | 3 :heavy_check_mark: | 0 | 9 | 13 / 4 |

<a href="#StartScreenState-class-diagram">:link: to `StartScreenState` class diagram</a>

<a href="#global+namespace">:top: back to &lt;global namespace&gt;</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-enemies-base">
    Sprint.Enemies.Base :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Enemies.Base` namespace contains 1 named types.

- 1 named types.
- 134 total lines of source code.
- Approximately 57 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

<details>
<summary>
  <strong id="enemy">
    Enemy :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Enemy` contains 26 members.
- 131 total lines of source code.
- Approximately 57 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L52' title='Enemy.Enemy(Texture2D texture, Vector2 position, int health, int damage, bool isInvincible = false)'>52</a> | 63 | 1 :heavy_check_mark: | 0 | 2 | 11 / 9 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L113' title='Vector2 Enemy.ChooseValidStep(List<Block> solidBlocks, float stepSize, int minSteps = 1, int maxSteps = 2, int maxAttempts = 4)'>113</a> | 55 | 4 :heavy_check_mark: | 0 | 7 | 28 / 13 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L19' title='int Enemy.damage'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L49' title='int Enemy.Damage'>49</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L78' title='void Enemy.Die()'>78</a> | 84 | 3 :heavy_check_mark: | 0 | 1 | 7 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L107' title='void Enemy.Draw(SpriteBatch spriteBatch, Vector2 location)'>107</a> | 84 | 3 :heavy_check_mark: | 0 | 4 | 6 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L23' title='float Enemy.DYING_DURATION'>23</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L22' title='float Enemy.dyingTimer'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L25' title='bool Enemy.FlipsOnVertical'>25</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L17' title='int Enemy.health'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L39' title='int Enemy.Health'>39</a> | 96 | 2 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L20' title='bool Enemy.isAlive'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L50' title='bool Enemy.IsAlive'>50</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L21' title='bool Enemy.isInvincible'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L18' title='int Enemy.maxHealth'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L48' title='int Enemy.MaxHealth'>48</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L14' title='Vector2 Enemy.position'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L27' title='Vector2 Enemy.Position'>27</a> | 88 | 3 :heavy_check_mark: | 0 | 4 | 11 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L24' title='Random Enemy.random'>24</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L46' title='Rectangle Enemy.Rect'>46</a> | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L86' title='void Enemy.Reset()'>86</a> | 79 | 1 :heavy_check_mark: | 0 | 0 | 6 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L13' title='IPositionedSprite Enemy.sprite'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L64' title='void Enemy.TakeDamage(int damageAmount)'>64</a> | 72 | 4 :heavy_check_mark: | 0 | 1 | 13 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L15' title='Texture2D Enemy.texture'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L45' title='Texture2D Enemy.Texture'>45</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Base/Enemy.cs#L93' title='void Enemy.Update(GameTime gameTime)'>93</a> | 74 | 4 :heavy_check_mark: | 0 | 3 | 13 / 4 |

<a href="#Enemy-class-diagram">:link: to `Enemy` class diagram</a>

<a href="#sprint-enemies-base">:top: back to Sprint.Enemies.Base</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-block">
    Sprint.Block :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Block` namespace contains 4 named types.

- 4 named types.
- 124 total lines of source code.
- Approximately 22 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="block">
    Block :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Block` contains 10 members.
- 33 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L18' title='Block.Block(Texture2D texture, Vector2 pos, Rectangle sourceRect, bool walkable, bool pushable)'>18</a> | 70 | 1 :heavy_check_mark: | 0 | 5 | 8 / 5 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L27' title='void Block.Draw(SpriteBatch spriteBatch)'>27</a> | 93 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L14' title='Vector2 Block.position'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L37' title='Vector2 Block.Position'>37</a> | 98 | 2 :heavy_check_mark: | 0 | 1 | 4 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L15' title='bool Block.pushAble'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L16' title='Rectangle Block.Rect'>16</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L12' title='StaticSprite Block.sprite'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L11' title='int Block.tileWidth'>11</a> | 87 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L32' title='void Block.Update(GameTime time)'>32</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L13' title='bool Block.walkAble'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#Block-class-diagram">:link: to `Block` class diagram</a>

<a href="#sprint-block">:top: back to Sprint.Block</a>

</details>

<details>
<summary>
  <strong id="blockfactory">
    BlockFactory :heavy_check_mark:
  </strong>
</summary>
<br>

- The `BlockFactory` contains 5 members.
- 63 total lines of source code.
- Approximately 7 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L28' title='Block BlockFactory.Create(int tileId, Vector2 pos)'>28</a> | 84 | 1 :heavy_check_mark: | 0 | 3 | 17 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L46' title='Block BlockFactory.CreateBlock(BlockType type, Vector2 pos)'>46</a> | 70 | 1 :heavy_check_mark: | 0 | 7 | 25 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L11' title='int BlockFactory.SHEET_COLUMNS'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L12' title='int BlockFactory.TILE_SIZE'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L13' title='int BlockFactory.TILE_SPACING'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#BlockFactory-class-diagram">:link: to `BlockFactory` class diagram</a>

<a href="#sprint-block">:top: back to Sprint.Block</a>

</details>

<details>
<summary>
  <strong id="blockmanager">
    BlockManager :heavy_check_mark:
  </strong>
</summary>
<br>

- The `BlockManager` contains 5 members.
- 21 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockManager.cs#L11' title='void BlockManager.Add(Block block)'>11</a> | 97 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockManager.cs#L9' title='List<Block> BlockManager.blocks'>9</a> | 93 | 0 :heavy_check_mark: | 0 | 3 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockManager.cs#L10' title='List<Block> BlockManager.blocksList'>10</a> | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockManager.cs#L22' title='void BlockManager.Draw(SpriteBatch spriteBatch)'>22</a> | 94 | 2 :heavy_check_mark: | 0 | 5 | 5 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockManager.cs#L16' title='void BlockManager.Update(GameTime gameTime)'>16</a> | 94 | 2 :heavy_check_mark: | 0 | 5 | 5 / 1 |

<a href="#BlockManager-class-diagram">:link: to `BlockManager` class diagram</a>

<a href="#sprint-block">:top: back to Sprint.Block</a>

</details>

<details>
<summary>
  <strong id="blockfactory-blocktype">
    BlockFactory.BlockType :heavy_check_mark:
  </strong>
</summary>
<br>

- The `BlockFactory.BlockType` contains 10 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L20' title='BlockType.Black'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L16' title='BlockType.Blank'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L24' title='BlockType.Bricks'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L25' title='BlockType.Ladder'>25</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L21' title='BlockType.Sand'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L17' title='BlockType.Square'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L23' title='BlockType.Stairs'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L19' title='BlockType.StatueLeft'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L18' title='BlockType.StatueRight'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L22' title='BlockType.Water'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#BlockFactory.BlockType-class-diagram">:link: to `BlockFactory.BlockType` class diagram</a>

<a href="#sprint-block">:top: back to Sprint.Block</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-character">
    Sprint.Character :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Character` namespace contains 12 named types.

- 12 named types.
- 882 total lines of source code.
- Approximately 257 lines of executable code.
- The highest cyclomatic complexity is 7 :heavy_check_mark:.

<details>
<summary>
  <strong id="attacking">
    Attacking :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Attacking` contains 15 members.
- 124 total lines of source code.
- Approximately 34 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L50' title='Attacking.Attacking(Texture2D texture, SpriteEffects effect, Frame[] frames, double secondsPerFrame, double totalAttackSeconds, Action onFinished)'>50</a> | 62 | 1 :heavy_check_mark: | 0 | 5 | 20 / 10 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L45' title='int Attacking.currentFrame'>45</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L118' title='void Attacking.Draw(SpriteBatch spriteBatch, Vector2 location)'>118</a> | 69 | 2 :heavy_check_mark: | 0 | 8 | 12 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L35' title='SpriteEffects Attacking.effect'>35</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L48' title='bool Attacking.finished'>48</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L36' title='Frame[] Attacking.frames'>36</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L104' title='Rectangle Attacking.GetWeaponWorldRect(Vector2 position)'>104</a> | 71 | 2 :heavy_check_mark: | 0 | 5 | 14 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L43' title='Action Attacking.onFinished'>43</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L73' title='void Attacking.Reset()'>73</a> | 75 | 1 :heavy_check_mark: | 0 | 0 | 9 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L37' title='double Attacking.secondsPerFrame'>37</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L34' title='Texture2D Attacking.texture'>34</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L46' title='double Attacking.timer'>46</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L40' title='double Attacking.totalAttackSeconds'>40</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L47' title='double Attacking.totalTimer'>47</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L81' title='void Attacking.Update(GameTime gameTime)'>81</a> | 60 | 6 :heavy_check_mark: | 0 | 3 | 21 / 11 |

<a href="#Attacking-class-diagram">:link: to `Attacking` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

<details>
<summary>
  <strong id="directions">
    Directions :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Directions` contains 4 members.
- 7 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Directions.cs#L10' title='Directions.Down'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Directions.cs#L7' title='Directions.Left'>7</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Directions.cs#L8' title='Directions.Right'>8</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Directions.cs#L9' title='Directions.Up'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#Directions-class-diagram">:link: to `Directions` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

<details>
<summary>
  <strong id="directionsutils">
    DirectionsUtils :heavy_check_mark:
  </strong>
</summary>
<br>

- The `DirectionsUtils` contains 1 members.
- 11 total lines of source code.
- Approximately 1 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Directions.cs#L15' title='Vector2 DirectionsUtils.CreateVector(Directions direction, float magnitude)'>15</a> | 89 | 1 :heavy_check_mark: | 0 | 3 | 8 / 1 |

<a href="#DirectionsUtils-class-diagram">:link: to `DirectionsUtils` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

<details>
<summary>
  <strong id="attacking-frame">
    Attacking.Frame :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Attacking.Frame` contains 6 members.
- 24 total lines of source code.
- Approximately 8 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L19' title='Frame.Frame(Rectangle bodyRect)'>19</a> | 80 | 1 :heavy_check_mark: | 0 | 3 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L26' title='Frame.Frame(Rectangle bodyRect, Rectangle weaponRect, Vector2 weaponOffset)'>26</a> | 79 | 1 :heavy_check_mark: | 0 | 2 | 6 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L11' title='Rectangle Frame.BodyRect'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L17' title='bool Frame.HasWeapon'>17</a> | 97 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L15' title='Vector2 Frame.WeaponOffset'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Attacking.cs#L12' title='Rectangle Frame.WeaponRect'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#Attacking.Frame-class-diagram">:link: to `Attacking.Frame` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

<details>
<summary>
  <strong id="pickupitem-frame">
    PickUpItem.Frame :heavy_check_mark:
  </strong>
</summary>
<br>

- The `PickUpItem.Frame` contains 5 members.
- 20 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L15' title='Frame.Frame(Rectangle bodyRect)'>15</a> | 80 | 1 :heavy_check_mark: | 0 | 4 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L22' title='Frame.Frame(Rectangle bodyRect, Rectangle itemRect, Vector2 itemOffset)'>22</a> | 79 | 1 :heavy_check_mark: | 0 | 3 | 6 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L11' title='Rectangle Frame.BodyRect'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L13' title='Vector2 Frame.ItemOffset'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L12' title='Rectangle? Frame.ItemRect'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |

<a href="#PickUpItem.Frame-class-diagram">:link: to `PickUpItem.Frame` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

<details>
<summary>
  <strong id="useitem-frame">
    UseItem.Frame :heavy_check_mark:
  </strong>
</summary>
<br>

- The `UseItem.Frame` contains 2 members.
- 11 total lines of source code.
- Approximately 1 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L14' title='Frame.Frame(Rectangle bodyRect)'>14</a> | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L11' title='Rectangle Frame.BodyRect'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#UseItem.Frame-class-diagram">:link: to `UseItem.Frame` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

<details>
<summary>
  <strong id="idle">
    Idle :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Idle` contains 6 members.
- 20 total lines of source code.
- Approximately 4 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Idle.cs#L13' title='Idle.Idle(Texture2D texture, Rectangle sourceRect, SpriteEffects effect)'>13</a> | 79 | 1 :heavy_check_mark: | 0 | 3 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Idle.cs#L22' title='void Idle.Draw(SpriteBatch spriteBatch, Vector2 location)'>22</a> | 89 | 1 :heavy_check_mark: | 0 | 7 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Idle.cs#L11' title='SpriteEffects Idle.effect'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Idle.cs#L10' title='Rectangle Idle.sourceRect'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Idle.cs#L9' title='Texture2D Idle.texture'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Idle.cs#L20' title='void Idle.Update(GameTime gameTime)'>20</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#Idle-class-diagram">:link: to `Idle` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

<details>
<summary>
  <strong id="link">
    Link :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Link` contains 63 members.
- 331 total lines of source code.
- Approximately 104 lines of executable code.
- The highest cyclomatic complexity is 7 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L98' title='Link.Link(Texture2D texture, Vector2 position)'>98</a> | 52 | 1 :heavy_check_mark: | 0 | 7 | 29 / 21 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L29' title='Attacking Link.AttackDown'>29</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L52' title='bool Link.attackHitLanded'>52</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L30' title='Attacking Link.AttackLeft'>30</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L31' title='Attacking Link.AttackRight'>31</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L28' title='Attacking Link.AttackUp'>28</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L15' title='double Link.BLINK_INTERVAL'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L11' title='int Link.BODY_SIZE'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L14' title='double Link.DAMAGED_DURATION'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L45' title='double Link.damagedTimer'>45</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L44' title='Directions Link.direction'>44</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L160' title='void Link.Draw(SpriteBatch spriteBatch)'>160</a> | 64 | 4 :heavy_check_mark: | 0 | 8 | 34 / 7 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L55' title='Directions Link.Facing'>55</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L295' title='void Link.FinishAttack()'>295</a> | 88 | 1 :heavy_check_mark: | 0 | 0 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L301' title='void Link.FinishPickUpItem()'>301</a> | 81 | 1 :heavy_check_mark: | 0 | 2 | 7 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L309' title='void Link.FinishUseItem()'>309</a> | 88 | 1 :heavy_check_mark: | 0 | 0 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L315' title='void Link.GetHealed(int amount)'>315</a> | 83 | 1 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L12' title='int Link.HAND_X'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L13' title='int Link.HAND_Y'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L46' title='int Link.health'>46</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L56' title='int Link.Health'>56</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L19' title='ISprite Link.IdleDown'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L20' title='ISprite Link.IdleLeft'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L21' title='ISprite Link.IdleRight'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L18' title='ISprite Link.IdleUp'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L321' title='void Link.IncreaseRubies(int amount)'>321</a> | 86 | 1 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L48' title='bool Link.isAttacking'>48</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L50' title='bool Link.isDamaged'>50</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L49' title='bool Link.isUsingItem'>49</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L51' title='bool Link.isVisible'>51</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L16' title='int Link.MAX_HEALTH'>16</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L57' title='int Link.MaxHealth'>57</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L43' title='Vector2 Link.move'>43</a> | 93 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L53' title='Rectangle? Link.pickUpItemRect'>53</a> | 93 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L39' title='PickUpItem Link.PickUpTriforce'>39</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L38' title='PickUpItem Link.PickUpWeapon'>38</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L42' title='Vector2 Link.position'>42</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L82' title='Vector2 Link.Position'>82</a> | 90 | 2 :heavy_check_mark: | 0 | 3 | 9 / 3 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L59' title='Rectangle Link.Rect'>59</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L80' title='void Link.RegisterSwordHit()'>80</a> | 96 | 1 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L47' title='int Link.rubies'>47</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L92' title='int Link.Rubies'>92</a> | 98 | 2 :heavy_check_mark: | 0 | 0 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L327' title='void Link.SetIdleSprite()'>327</a> | 87 | 1 :heavy_check_mark: | 0 | 2 | 11 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L238' title='void Link.SetMove(Directions dir)'>238</a> | 69 | 7 :heavy_check_mark: | 0 | 5 | 15 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L10' title='float Link.SPEED'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L41' title='ISprite Link.sprite'>41</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L259' title='void Link.StartAttack()'>259</a> | 68 | 6 :heavy_check_mark: | 0 | 5 | 16 / 5 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L284' title='void Link.StartDamaged()'>284</a> | 68 | 1 :heavy_check_mark: | 0 | 2 | 10 / 7 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L226' title='void Link.StartPickUpTriforce()'>226</a> | 71 | 4 :heavy_check_mark: | 0 | 4 | 11 / 5 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L211' title='void Link.StartPickUpWeapon(Rectangle itemRect)'>211</a> | 67 | 4 :heavy_check_mark: | 0 | 7 | 14 / 7 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L195' title='void Link.StartUseItem()'>195</a> | 70 | 6 :heavy_check_mark: | 0 | 5 | 15 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L254' title='void Link.StopMove()'>254</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L61' title='Rectangle Link.SwordRect'>61</a> | 75 | 3 :heavy_check_mark: | 0 | 5 | 18 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L276' title='void Link.TakeDamage(int amount)'>276</a> | 79 | 2 :heavy_check_mark: | 0 | 1 | 7 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L128' title='void Link.Update(GameTime gameTime)'>128</a> | 59 | 7 :heavy_check_mark: | 0 | 4 | 31 / 11 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L34' title='UseItem Link.UseItemDown'>34</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L35' title='UseItem Link.UseItemLeft'>35</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L36' title='UseItem Link.UseItemRight'>36</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L33' title='UseItem Link.UseItemUp'>33</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L24' title='ISprite Link.WalkDown'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L25' title='ISprite Link.WalkLeft'>25</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L26' title='ISprite Link.WalkRight'>26</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L23' title='ISprite Link.WalkUp'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#Link-class-diagram">:link: to `Link` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

<details>
<summary>
  <strong id="linkfactory">
    LinkFactory :heavy_check_mark:
  </strong>
</summary>
<br>

- The `LinkFactory` contains 18 members.
- 114 total lines of source code.
- Approximately 32 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L74' title='Attacking LinkFactory.AttackDown(Texture2D texture, Action onFinished)'>74</a> | 77 | 1 :heavy_check_mark: | 0 | 8 | 11 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L98' title='Attacking LinkFactory.AttackLeft(Texture2D texture, Action onFinished)'>98</a> | 77 | 1 :heavy_check_mark: | 0 | 8 | 11 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L110' title='Attacking LinkFactory.AttackRight(Texture2D texture, Action onFinished)'>110</a> | 77 | 1 :heavy_check_mark: | 0 | 8 | 11 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L86' title='Attacking LinkFactory.AttackUp(Texture2D texture, Action onFinished)'>86</a> | 77 | 1 :heavy_check_mark: | 0 | 8 | 11 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L10' title='ISprite LinkFactory.IdleDown(Texture2D texture)'>10</a> | 93 | 1 :heavy_check_mark: | 0 | 5 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L12' title='ISprite LinkFactory.IdleLeft(Texture2D texture)'>12</a> | 93 | 1 :heavy_check_mark: | 0 | 5 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L13' title='ISprite LinkFactory.IdleRight(Texture2D texture)'>13</a> | 93 | 1 :heavy_check_mark: | 0 | 5 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L11' title='ISprite LinkFactory.IdleUp(Texture2D texture)'>11</a> | 93 | 1 :heavy_check_mark: | 0 | 5 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L68' title='PickUpItem LinkFactory.PickUpTriforce(Texture2D texture, Action onFinished)'>68</a> | 82 | 1 :heavy_check_mark: | 0 | 7 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L63' title='PickUpItem LinkFactory.PickUpWeapon(Texture2D texture, Action onFinished)'>63</a> | 82 | 1 :heavy_check_mark: | 0 | 7 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L39' title='UseItem LinkFactory.UseItemDown(Texture2D texture, Action onFinished)'>39</a> | 82 | 1 :heavy_check_mark: | 0 | 7 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L51' title='UseItem LinkFactory.UseItemLeft(Texture2D texture, Action onFinished)'>51</a> | 82 | 1 :heavy_check_mark: | 0 | 7 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L57' title='UseItem LinkFactory.UseItemRight(Texture2D texture, Action onFinished)'>57</a> | 82 | 1 :heavy_check_mark: | 0 | 7 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L45' title='UseItem LinkFactory.UseItemUp(Texture2D texture, Action onFinished)'>45</a> | 82 | 1 :heavy_check_mark: | 0 | 7 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L15' title='ISprite LinkFactory.WalkingDown(Texture2D texture)'>15</a> | 82 | 1 :heavy_check_mark: | 0 | 5 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L27' title='ISprite LinkFactory.WalkingLeft(Texture2D texture)'>27</a> | 82 | 1 :heavy_check_mark: | 0 | 5 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L33' title='ISprite LinkFactory.WalkingRight(Texture2D texture)'>33</a> | 82 | 1 :heavy_check_mark: | 0 | 5 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L21' title='ISprite LinkFactory.WalkingUp(Texture2D texture)'>21</a> | 82 | 1 :heavy_check_mark: | 0 | 5 | 5 / 2 |

<a href="#LinkFactory-class-diagram">:link: to `LinkFactory` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

<details>
<summary>
  <strong id="pickupitem">
    PickUpItem :heavy_check_mark:
  </strong>
</summary>
<br>

- The `PickUpItem` contains 14 members.
- 125 total lines of source code.
- Approximately 29 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L46' title='PickUpItem.PickUpItem(Texture2D texture, SpriteEffects effect, Frame[] frames, double secondsPerFrame, double totalItemSeconds, Action onFinished)'>46</a> | 62 | 1 :heavy_check_mark: | 0 | 5 | 20 / 10 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L41' title='int PickUpItem.currentFrame'>41</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L99' title='void PickUpItem.Draw(SpriteBatch spriteBatch, Vector2 location)'>99</a> | 71 | 2 :heavy_check_mark: | 0 | 9 | 32 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L31' title='SpriteEffects PickUpItem.effect'>31</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L44' title='bool PickUpItem.finished'>44</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L32' title='Frame[] PickUpItem.frames'>32</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L39' title='Action PickUpItem.onFinished'>39</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L69' title='void PickUpItem.Reset()'>69</a> | 75 | 1 :heavy_check_mark: | 0 | 0 | 9 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L33' title='double PickUpItem.secondsPerFrame'>33</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L30' title='Texture2D PickUpItem.texture'>30</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L42' title='double PickUpItem.timer'>42</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L36' title='double PickUpItem.totalItemSeconds'>36</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L43' title='double PickUpItem.totalTimer'>43</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/PickUpItem.cs#L77' title='void PickUpItem.Update(GameTime gameTime)'>77</a> | 60 | 6 :heavy_check_mark: | 0 | 3 | 21 / 11 |

<a href="#PickUpItem-class-diagram">:link: to `PickUpItem` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

<details>
<summary>
  <strong id="useitem">
    UseItem :heavy_check_mark:
  </strong>
</summary>
<br>

- The `UseItem` contains 14 members.
- 90 total lines of source code.
- Approximately 27 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L37' title='UseItem.UseItem(Texture2D texture, SpriteEffects effect, Frame[] frames, double secondsPerFrame, double totalItemSeconds, Action onFinished)'>37</a> | 62 | 1 :heavy_check_mark: | 0 | 5 | 20 / 10 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L32' title='int UseItem.currentFrame'>32</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L90' title='void UseItem.Draw(SpriteBatch spriteBatch, Vector2 location)'>90</a> | 81 | 1 :heavy_check_mark: | 0 | 8 | 6 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L22' title='SpriteEffects UseItem.effect'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L35' title='bool UseItem.finished'>35</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L23' title='Frame[] UseItem.frames'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L30' title='Action UseItem.onFinished'>30</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L60' title='void UseItem.Reset()'>60</a> | 75 | 1 :heavy_check_mark: | 0 | 0 | 9 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L24' title='double UseItem.secondsPerFrame'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L21' title='Texture2D UseItem.texture'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L33' title='double UseItem.timer'>33</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L27' title='double UseItem.totalItemSeconds'>27</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L34' title='double UseItem.totalTimer'>34</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/UseItem.cs#L68' title='void UseItem.Update(GameTime gameTime)'>68</a> | 60 | 6 :heavy_check_mark: | 0 | 3 | 21 / 11 |

<a href="#UseItem-class-diagram">:link: to `UseItem` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

<details>
<summary>
  <strong id="walking">
    Walking :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Walking` contains 9 members.
- 35 total lines of source code.
- Approximately 11 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Walking.cs#L16' title='Walking.Walking(Texture2D texture, SpriteEffects effect, Rectangle[] frames, double secondsPerFrame)'>16</a> | 69 | 1 :heavy_check_mark: | 0 | 3 | 9 / 6 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Walking.cs#L13' title='int Walking.currentFrame'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Walking.cs#L37' title='void Walking.Draw(SpriteBatch spriteBatch, Vector2 location)'>37</a> | 88 | 1 :heavy_check_mark: | 0 | 7 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Walking.cs#L10' title='SpriteEffects Walking.effect'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Walking.cs#L11' title='Rectangle[] Walking.frames'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Walking.cs#L12' title='double Walking.secondsPerFrame'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Walking.cs#L9' title='Texture2D Walking.texture'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Walking.cs#L14' title='double Walking.timer'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Walking.cs#L26' title='void Walking.Update(GameTime gameTime)'>26</a> | 73 | 2 :heavy_check_mark: | 0 | 2 | 10 / 4 |

<a href="#Walking-class-diagram">:link: to `Walking` class diagram</a>

<a href="#sprint-character">:top: back to Sprint.Character</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-collision">
    Sprint.Collision :exploding_head:
  </strong>
</summary>
<br>

The `Sprint.Collision` namespace contains 6 named types.

- 6 named types.
- 243 total lines of source code.
- Approximately 68 lines of executable code.
- The highest cyclomatic complexity is 15 :exploding_head:.

<details>
<summary>
  <strong id="activeitemenemycollision">
    ActiveItemEnemyCollision :exploding_head:
  </strong>
</summary>
<br>

- The `ActiveItemEnemyCollision` contains 7 members.
- 65 total lines of source code.
- Approximately 22 lines of executable code.
- The highest cyclomatic complexity is 15 :exploding_head:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/ActiveItemEnemyCollision.cs#L17' title='ActiveItemEnemyCollision.ActiveItemEnemyCollision(ItemManager itemManager, EnemyManager enemyManager)'>17</a> | 85 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/ActiveItemEnemyCollision.cs#L11' title='int ActiveItemEnemyCollision.BOMB_DAMAGE'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/ActiveItemEnemyCollision.cs#L12' title='int ActiveItemEnemyCollision.BOMB_RADIUS'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/ActiveItemEnemyCollision.cs#L15' title='EnemyManager ActiveItemEnemyCollision.enemyManager'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/ActiveItemEnemyCollision.cs#L23' title='void ActiveItemEnemyCollision.Handle()'>23</a> | 53 | 15 :exploding_head: | 0 | 12 | 49 / 18 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/ActiveItemEnemyCollision.cs#L14' title='ItemManager ActiveItemEnemyCollision.itemManager'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/ActiveItemEnemyCollision.cs#L10' title='int ActiveItemEnemyCollision.PROJECTILE_DAMAGE'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#ActiveItemEnemyCollision-class-diagram">:link: to `ActiveItemEnemyCollision` class diagram</a>

<a href="#sprint-collision">:top: back to Sprint.Collision</a>

</details>

<details>
<summary>
  <strong id="collisionmanager">
    CollisionManager :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CollisionManager` contains 3 members.
- 15 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/CollisionManager.cs#L10' title='void CollisionManager.Add(ICollisionHandler handler)'>10</a> | 97 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/CollisionManager.cs#L15' title='void CollisionManager.HandleAll()'>15</a> | 96 | 2 :heavy_check_mark: | 0 | 4 | 5 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/CollisionManager.cs#L8' title='List<ICollisionHandler> CollisionManager.handlers'>8</a> | 93 | 0 :heavy_check_mark: | 0 | 3 | 1 / 1 |

<a href="#CollisionManager-class-diagram">:link: to `CollisionManager` class diagram</a>

<a href="#sprint-collision">:top: back to Sprint.Collision</a>

</details>

<details>
<summary>
  <strong id="linkenemycollision">
    LinkEnemyCollision :heavy_check_mark:
  </strong>
</summary>
<br>

- The `LinkEnemyCollision` contains 4 members.
- 24 total lines of source code.
- Approximately 7 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyCollision.cs#L13' title='LinkEnemyCollision.LinkEnemyCollision(Link link, EnemyManager enemyManager)'>13</a> | 85 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyCollision.cs#L11' title='EnemyManager LinkEnemyCollision.enemyManager'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyCollision.cs#L19' title='void LinkEnemyCollision.Handle()'>19</a> | 72 | 4 :heavy_check_mark: | 0 | 7 | 12 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyCollision.cs#L10' title='Link LinkEnemyCollision.link'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#LinkEnemyCollision-class-diagram">:link: to `LinkEnemyCollision` class diagram</a>

<a href="#sprint-collision">:top: back to Sprint.Collision</a>

</details>

<details>
<summary>
  <strong id="linkenemyprojectilecollision">
    LinkEnemyProjectileCollision :radioactive:
  </strong>
</summary>
<br>

- The `LinkEnemyProjectileCollision` contains 5 members.
- 36 total lines of source code.
- Approximately 12 lines of executable code.
- The highest cyclomatic complexity is 10 :radioactive:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyProjectileCollision.cs#L16' title='LinkEnemyProjectileCollision.LinkEnemyProjectileCollision(Link link, EnemyManager enemyManager)'>16</a> | 85 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyProjectileCollision.cs#L14' title='EnemyManager LinkEnemyProjectileCollision.enemyManager'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyProjectileCollision.cs#L22' title='void LinkEnemyProjectileCollision.Handle()'>22</a> | 61 | 10 :radioactive: | 0 | 13 | 22 / 9 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyProjectileCollision.cs#L13' title='Link LinkEnemyProjectileCollision.link'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyProjectileCollision.cs#L11' title='int LinkEnemyProjectileCollision.PROJECTILE_DAMAGE'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#LinkEnemyProjectileCollision-class-diagram">:link: to `LinkEnemyProjectileCollision` class diagram</a>

<a href="#sprint-collision">:top: back to Sprint.Collision</a>

</details>

<details>
<summary>
  <strong id="linkitemcollision">
    LinkItemCollision :radioactive:
  </strong>
</summary>
<br>

- The `LinkItemCollision` contains 6 members.
- 58 total lines of source code.
- Approximately 15 lines of executable code.
- The highest cyclomatic complexity is 11 :radioactive:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkItemCollision.cs#L14' title='LinkItemCollision.LinkItemCollision(ILink link, Inventory inventory, List<AbstractItem> worldItems)'>14</a> | 79 | 1 :heavy_check_mark: | 0 | 4 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkItemCollision.cs#L21' title='void LinkItemCollision.Handle()'>21</a> | 68 | 3 :heavy_check_mark: | 0 | 5 | 15 / 6 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkItemCollision.cs#L37' title='void LinkItemCollision.HandlePickup(AbstractItem item)'>37</a> | 64 | 11 :radioactive: | 0 | 5 | 28 / 6 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkItemCollision.cs#L11' title='Inventory LinkItemCollision.inventory'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkItemCollision.cs#L10' title='ILink LinkItemCollision.link'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkItemCollision.cs#L12' title='List<AbstractItem> LinkItemCollision.worldItems'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |

<a href="#LinkItemCollision-class-diagram">:link: to `LinkItemCollision` class diagram</a>

<a href="#sprint-collision">:top: back to Sprint.Collision</a>

</details>

<details>
<summary>
  <strong id="swordenemycollision">
    SwordEnemyCollision :heavy_check_mark:
  </strong>
</summary>
<br>

- The `SwordEnemyCollision` contains 5 members.
- 29 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/SwordEnemyCollision.cs#L15' title='SwordEnemyCollision.SwordEnemyCollision(Link link, EnemyManager enemyManager)'>15</a> | 85 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/SwordEnemyCollision.cs#L13' title='EnemyManager SwordEnemyCollision.enemyManager'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/SwordEnemyCollision.cs#L21' title='void SwordEnemyCollision.Handle()'>21</a> | 70 | 5 :heavy_check_mark: | 0 | 7 | 15 / 6 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/SwordEnemyCollision.cs#L12' title='Link SwordEnemyCollision.link'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/SwordEnemyCollision.cs#L10' title='int SwordEnemyCollision.SWORD_DAMAGE'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#SwordEnemyCollision-class-diagram">:link: to `SwordEnemyCollision` class diagram</a>

<a href="#sprint-collision">:top: back to Sprint.Collision</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-collisions">
    Sprint.Collisions :x:
  </strong>
</summary>
<br>

The `Sprint.Collisions` namespace contains 5 named types.

- 5 named types.
- 271 total lines of source code.
- Approximately 93 lines of executable code.
- The highest cyclomatic complexity is 13 :x:.

<details>
<summary>
  <strong id="enemyblockcollisionhandler">
    EnemyBlockCollisionHandler :heavy_check_mark:
  </strong>
</summary>
<br>

- The `EnemyBlockCollisionHandler` contains 5 members.
- 42 total lines of source code.
- Approximately 13 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/EnemyBlockCollisionHandler.cs#L13' title='EnemyBlockCollisionHandler.EnemyBlockCollisionHandler(List<IEnemy> enemies, BlockManager blockManager)'>13</a> | 85 | 1 :heavy_check_mark: | 0 | 3 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/EnemyBlockCollisionHandler.cs#L11' title='BlockManager EnemyBlockCollisionHandler.blockManager'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/EnemyBlockCollisionHandler.cs#L10' title='List<IEnemy> EnemyBlockCollisionHandler.enemies'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/EnemyBlockCollisionHandler.cs#L19' title='void EnemyBlockCollisionHandler.Handle()'>19</a> | 74 | 6 :heavy_check_mark: | 0 | 6 | 13 / 5 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/EnemyBlockCollisionHandler.cs#L33' title='void EnemyBlockCollisionHandler.ResolveCollision(IEnemy enemy, Block block)'>33</a> | 67 | 4 :heavy_check_mark: | 0 | 5 | 16 / 6 |

<a href="#EnemyBlockCollisionHandler-class-diagram">:link: to `EnemyBlockCollisionHandler` class diagram</a>

<a href="#sprint-collisions">:top: back to Sprint.Collisions</a>

</details>

<details>
<summary>
  <strong id="enemywallcollisionhandler">
    EnemyWallCollisionHandler :heavy_check_mark:
  </strong>
</summary>
<br>

- The `EnemyWallCollisionHandler` contains 5 members.
- 44 total lines of source code.
- Approximately 16 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/EnemyWallCollisionHandler.cs#L17' title='EnemyWallCollisionHandler.EnemyWallCollisionHandler(List<IEnemy> enemies, DungeonWalls dungeonWalls)'>17</a> | 85 | 1 :heavy_check_mark: | 0 | 3 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/EnemyWallCollisionHandler.cs#L15' title='DungeonWalls EnemyWallCollisionHandler.dungeonWalls'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/EnemyWallCollisionHandler.cs#L14' title='List<IEnemy> EnemyWallCollisionHandler.enemies'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/EnemyWallCollisionHandler.cs#L23' title='void EnemyWallCollisionHandler.Handle()'>23</a> | 87 | 2 :heavy_check_mark: | 0 | 4 | 7 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/EnemyWallCollisionHandler.cs#L30' title='void EnemyWallCollisionHandler.ResolveCollision(IEnemy enemy, DungeonWalls dungeonWalls)'>30</a> | 57 | 5 :heavy_check_mark: | 0 | 5 | 24 / 12 |

<a href="#EnemyWallCollisionHandler-class-diagram">:link: to `EnemyWallCollisionHandler` class diagram</a>

<a href="#sprint-collisions">:top: back to Sprint.Collisions</a>

</details>

<details>
<summary>
  <strong id="linkblockcollisionhandler">
    LinkBlockCollisionHandler :heavy_check_mark:
  </strong>
</summary>
<br>

- The `LinkBlockCollisionHandler` contains 5 members.
- 40 total lines of source code.
- Approximately 12 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockCollisionHandler.cs#L13' title='LinkBlockCollisionHandler.LinkBlockCollisionHandler(ILink link, BlockManager blockManager)'>13</a> | 85 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockCollisionHandler.cs#L11' title='BlockManager LinkBlockCollisionHandler.blockManager'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockCollisionHandler.cs#L19' title='void LinkBlockCollisionHandler.Handle()'>19</a> | 76 | 5 :heavy_check_mark: | 0 | 7 | 10 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockCollisionHandler.cs#L10' title='ILink LinkBlockCollisionHandler.link'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockCollisionHandler.cs#L31' title='void LinkBlockCollisionHandler.ResolveCollision(ILink link, Block block)'>31</a> | 67 | 4 :heavy_check_mark: | 0 | 5 | 16 / 6 |

<a href="#LinkBlockCollisionHandler-class-diagram">:link: to `LinkBlockCollisionHandler` class diagram</a>

<a href="#sprint-collisions">:top: back to Sprint.Collisions</a>

</details>

<details>
<summary>
  <strong id="linkblockpushhandler">
    LinkBlockPushHandler :x:
  </strong>
</summary>
<br>

- The `LinkBlockPushHandler` contains 7 members.
- 89 total lines of source code.
- Approximately 37 lines of executable code.
- The highest cyclomatic complexity is 13 :x:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockPushHandler.cs#L16' title='LinkBlockPushHandler.LinkBlockPushHandler(ILink link, BlockManager blockManager)'>16</a> | 85 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockPushHandler.cs#L12' title='BlockManager LinkBlockPushHandler.blockManager'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockPushHandler.cs#L14' title='Rectangle LinkBlockPushHandler.FloorSource'>14</a> | 89 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockPushHandler.cs#L22' title='void LinkBlockPushHandler.Handle()'>22</a> | 72 | 5 :heavy_check_mark: | 0 | 7 | 13 / 6 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockPushHandler.cs#L11' title='ILink LinkBlockPushHandler.link'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockPushHandler.cs#L13' title='Rectangle LinkBlockPushHandler.PushableStatueSource'>13</a> | 88 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkBlockPushHandler.cs#L36' title='void LinkBlockPushHandler.ResolvePush(ILink link, Block block)'>36</a> | 47 | 13 :x: | 0 | 11 | 61 / 27 |

<a href="#LinkBlockPushHandler-class-diagram">:link: to `LinkBlockPushHandler` class diagram</a>

<a href="#sprint-collisions">:top: back to Sprint.Collisions</a>

</details>

<details>
<summary>
  <strong id="linkwallcollisionhandler">
    LinkWallCollisionHandler :heavy_check_mark:
  </strong>
</summary>
<br>

- The `LinkWallCollisionHandler` contains 5 members.
- 41 total lines of source code.
- Approximately 15 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkWallCollisionHandler.cs#L16' title='LinkWallCollisionHandler.LinkWallCollisionHandler(ILink link, DungeonWalls dungeonWalls)'>16</a> | 85 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkWallCollisionHandler.cs#L14' title='DungeonWalls LinkWallCollisionHandler.dungeonWalls'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkWallCollisionHandler.cs#L22' title='void LinkWallCollisionHandler.Handle()'>22</a> | 95 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkWallCollisionHandler.cs#L13' title='ILink LinkWallCollisionHandler.link'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkWallCollisionHandler.cs#L26' title='void LinkWallCollisionHandler.ResolveCollision(ILink link, DungeonWalls dungeonWalls)'>26</a> | 57 | 5 :heavy_check_mark: | 0 | 5 | 24 / 12 |

<a href="#LinkWallCollisionHandler-class-diagram">:link: to `LinkWallCollisionHandler` class diagram</a>

<a href="#sprint-collisions">:top: back to Sprint.Collisions</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-commands">
    Sprint.Commands :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Commands` namespace contains 5 named types.

- 5 named types.
- 94 total lines of source code.
- Approximately 14 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

<details>
<summary>
  <strong id="cycleenemycommand">
    CycleEnemyCommand :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CycleEnemyCommand` contains 4 members.
- 19 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleEnemyCommand.cs#L11' title='CycleEnemyCommand.CycleEnemyCommand(EnemyManager enemyManager, bool forward)'>11</a> | 85 | 1 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleEnemyCommand.cs#L8' title='EnemyManager CycleEnemyCommand.enemyManager'>8</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleEnemyCommand.cs#L17' title='void CycleEnemyCommand.Execute()'>17</a> | 92 | 4 :heavy_check_mark: | 0 | 2 | 7 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleEnemyCommand.cs#L9' title='bool CycleEnemyCommand.forward'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#CycleEnemyCommand-class-diagram">:link: to `CycleEnemyCommand` class diagram</a>

<a href="#sprint-commands">:top: back to Sprint.Commands</a>

</details>

<details>
<summary>
  <strong id="cycleitemcommand">
    CycleItemCommand :heavy_check_mark:
  </strong>
</summary>
<br>

- The `CycleItemCommand` contains 4 members.
- 19 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleItemCommand.cs#L11' title='CycleItemCommand.CycleItemCommand(Inventory inventory, bool forward)'>11</a> | 85 | 1 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleItemCommand.cs#L17' title='void CycleItemCommand.Execute()'>17</a> | 92 | 4 :heavy_check_mark: | 0 | 2 | 7 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleItemCommand.cs#L9' title='bool CycleItemCommand.forward'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleItemCommand.cs#L8' title='Inventory CycleItemCommand.inventory'>8</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#CycleItemCommand-class-diagram">:link: to `CycleItemCommand` class diagram</a>

<a href="#sprint-commands">:top: back to Sprint.Commands</a>

</details>

<details>
<summary>
  <strong id="quitcommand">
    QuitCommand :heavy_check_mark:
  </strong>
</summary>
<br>

- The `QuitCommand` contains 1 members.
- 7 total lines of source code.
- Approximately 1 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/QuitCommand.cs#L7' title='void QuitCommand.Execute()'>7</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |

<a href="#QuitCommand-class-diagram">:link: to `QuitCommand` class diagram</a>

<a href="#sprint-commands">:top: back to Sprint.Commands</a>

</details>

<details>
<summary>
  <strong id="setstatecommand">
    SetStateCommand :heavy_check_mark:
  </strong>
</summary>
<br>

- The `SetStateCommand` contains 3 members.
- 14 total lines of source code.
- Approximately 2 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/SetStateCommand.cs#L9' title='SetStateCommand.SetStateCommand(IGameState newState)'>9</a> | 96 | 1 :heavy_check_mark: | 0 | 1 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/SetStateCommand.cs#L14' title='void SetStateCommand.Execute()'>14</a> | 95 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/SetStateCommand.cs#L7' title='IGameState SetStateCommand.newState'>7</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#SetStateCommand-class-diagram">:link: to `SetStateCommand` class diagram</a>

<a href="#sprint-commands">:top: back to Sprint.Commands</a>

</details>

<details>
<summary>
  <strong id="useitemcommand">
    UseItemCommand :heavy_check_mark:
  </strong>
</summary>
<br>

- The `UseItemCommand` contains 6 members.
- 20 total lines of source code.
- Approximately 5 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/UseItemCommand.cs#L13' title='UseItemCommand.UseItemCommand(ItemManager itemManager, Inventory inventory, ILink link, int slot)'>13</a> | 75 | 1 :heavy_check_mark: | 0 | 3 | 7 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/UseItemCommand.cs#L21' title='void UseItemCommand.Execute()'>21</a> | 91 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/UseItemCommand.cs#L9' title='Inventory UseItemCommand.inventory'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/UseItemCommand.cs#L8' title='ItemManager UseItemCommand.itemManager'>8</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/UseItemCommand.cs#L10' title='ILink UseItemCommand.link'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/UseItemCommand.cs#L11' title='int UseItemCommand.slot'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#UseItemCommand-class-diagram">:link: to `UseItemCommand` class diagram</a>

<a href="#sprint-commands">:top: back to Sprint.Commands</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-enemies-concrete">
    Sprint.Enemies.Concrete :radioactive:
  </strong>
</summary>
<br>

The `Sprint.Enemies.Concrete` namespace contains 18 named types.

- 18 named types.
- 1,410 total lines of source code.
- Approximately 471 lines of executable code.
- The highest cyclomatic complexity is 10 :radioactive:.

<details>
<summary>
  <strong id="aquamentus">
    Aquamentus :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Aquamentus` contains 19 members.
- 98 total lines of source code.
- Approximately 38 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L33' title='Aquamentus.Aquamentus(Texture2D texture, Vector2 position)'>33</a> | 60 | 1 :heavy_check_mark: | 0 | 9 | 17 / 10 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L25' title='List<AquamentusFireball> Aquamentus.activeFireballs'>25</a> | 93 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L26' title='IReadOnlyList<AquamentusFireball> Aquamentus.ActiveFireballs'>26</a> | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L15' title='int Aquamentus.DAMAGE'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L20' title='float Aquamentus.DIRECTION_SWAP_MAX'>20</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L19' title='float Aquamentus.DIRECTION_SWAP_MIN'>19</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L18' title='float Aquamentus.directionChangeTimer'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L85' title='void Aquamentus.Draw(SpriteBatch spriteBatch, Vector2 location)'>85</a> | 85 | 2 :heavy_check_mark: | 0 | 7 | 6 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L28' title='float Aquamentus.FIREBALL_INTERVAL'>28</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L27' title='float Aquamentus.fireballTimer'>27</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L105' title='float Aquamentus.GetRandomFloat(float min, float max)'>105</a> | 90 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L14' title='int Aquamentus.HEALTH'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L17' title='float Aquamentus.MOVE_SPEED'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L21' title='float Aquamentus.moveDirectionTimer'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L22' title='bool Aquamentus.moveLeft'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L24' title='EnemyProjectileFactory Aquamentus.projectileFactory'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L92' title='void Aquamentus.SpawnFireballs()'>92</a> | 81 | 2 :heavy_check_mark: | 0 | 5 | 12 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L48' title='void Aquamentus.Update(GameTime gameTime)'>48</a> | 53 | 6 :heavy_check_mark: | 0 | 7 | 36 / 19 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L16' title='Vector2 Aquamentus.velocity'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#Aquamentus-class-diagram">:link: to `Aquamentus` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="aquamentusfireball">
    AquamentusFireball :heavy_check_mark:
  </strong>
</summary>
<br>

- The `AquamentusFireball` contains 14 members.
- 62 total lines of source code.
- Approximately 25 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L37' title='AquamentusFireball.AquamentusFireball(Texture2D texture, Vector2 startPosition, Vector2 direction)'>37</a> | 61 | 2 :heavy_check_mark: | 0 | 5 | 16 / 10 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L64' title='void AquamentusFireball.Draw(SpriteBatch spriteBatch, Vector2 location)'>64</a> | 85 | 2 :heavy_check_mark: | 0 | 4 | 5 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L20' title='bool AquamentusFireball.IsActive'>20</a> | 94 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L13' title='float AquamentusFireball.lifetime'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L14' title='float AquamentusFireball.MAX_LIFETIME'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L11' title='Vector2 AquamentusFireball.position'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L24' title='Vector2 AquamentusFireball.Position'>24</a> | 88 | 2 :heavy_check_mark: | 0 | 5 | 12 / 4 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L22' title='Rectangle AquamentusFireball.Rect'>22</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L18' title='int AquamentusFireball.SOURCE_HEIGHT'>18</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L17' title='int AquamentusFireball.SOURCE_WIDTH'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L15' title='float AquamentusFireball.SPEED'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L10' title='IPositionedSprite AquamentusFireball.sprite'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L54' title='void AquamentusFireball.Update(GameTime gameTime)'>54</a> | 71 | 2 :heavy_check_mark: | 0 | 4 | 9 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L12' title='Vector2 AquamentusFireball.velocity'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#AquamentusFireball-class-diagram">:link: to `AquamentusFireball` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="dodongo-direction">
    Dodongo.Direction :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Dodongo.Direction` contains 4 members.
- 1 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L22' title='Direction.Down'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L22' title='Direction.Left'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L22' title='Direction.Right'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L22' title='Direction.Up'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#Dodongo.Direction-class-diagram">:link: to `Dodongo.Direction` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="goriya-direction">
    Goriya.Direction :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Goriya.Direction` contains 4 members.
- 1 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L26' title='Direction.Down'>26</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L26' title='Direction.Left'>26</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L26' title='Direction.Right'>26</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L26' title='Direction.Up'>26</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#Goriya.Direction-class-diagram">:link: to `Goriya.Direction` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="dodongo">
    Dodongo :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Dodongo` contains 33 members.
- 216 total lines of source code.
- Approximately 61 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L44' title='Dodongo.Dodongo(Texture2D texture, Vector2 position, List<Block> solidBlocks)'>44</a> | 60 | 1 :heavy_check_mark: | 0 | 12 | 17 / 10 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L20' title='float Dodongo.BOMB_STUN_DURATION'>20</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L36' title='int[] Dodongo.bombedDownFrame'>36</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L37' title='int[] Dodongo.bombedSideFrame'>37</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L35' title='int[] Dodongo.bombedUpFrame'>35</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L28' title='float Dodongo.bombStunTimer'>28</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L133' title='void Dodongo.ChooseNextStep()'>133</a> | 68 | 2 :heavy_check_mark: | 0 | 4 | 12 / 6 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L24' title='Direction Dodongo.currentDirection'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L13' title='DodongoState Dodongo.currentState'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L15' title='int Dodongo.DAMAGE'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L33' title='int[] Dodongo.downFrames'>33</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L123' title='void Dodongo.EatBomb()'>123</a> | 72 | 3 :heavy_check_mark: | 0 | 2 | 9 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L19' title='float Dodongo.FLIP_INTERVAL'>19</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L39' title='bool Dodongo.FlipsOnVertical'>39</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L27' title='float Dodongo.flipTimer'>27</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L146' title='Direction Dodongo.GetDirectionTo(Vector2 target)'>146</a> | 80 | 4 :heavy_check_mark: | 0 | 3 | 8 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L14' title='int Dodongo.HEALTH'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L18' title='float Dodongo.MOVE_SPEED'>18</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L217' title='void Dodongo.Reset()'>217</a> | 72 | 1 :heavy_check_mark: | 0 | 3 | 8 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L34' title='int[] Dodongo.sideFrames'>34</a> | 91 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L38' title='List<Block> Dodongo.solidBlocks'>38</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L29' title='bool Dodongo.spriteHorizontalFlip'>29</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L17' title='float Dodongo.STEP_DELAY'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L16' title='float Dodongo.STEP_SIZE'>16</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L26' title='float Dodongo.stepTimer'>26</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L25' title='Vector2 Dodongo.targetPosition'>25</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L60' title='void Dodongo.Update(GameTime gameTime)'>60</a> | 74 | 4 :heavy_check_mark: | 0 | 4 | 19 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L112' title='void Dodongo.UpdateBombEaten(float deltaTime)'>112</a> | 76 | 2 :heavy_check_mark: | 0 | 2 | 10 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L173' title='void Dodongo.UpdateBombedSprite(DirectionalAnimatedSprite dirSprite, int sheetY, float frameTime)'>173</a> | 82 | 5 :heavy_check_mark: | 0 | 5 | 21 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L155' title='void Dodongo.UpdateSprite()'>155</a> | 73 | 3 :heavy_check_mark: | 0 | 3 | 17 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L80' title='void Dodongo.UpdateWalking(float deltaTime)'>80</a> | 56 | 6 :heavy_check_mark: | 0 | 3 | 31 / 15 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L195' title='void Dodongo.UpdateWalkingSprite(DirectionalAnimatedSprite dirSprite, int sheetY, float frameTime)'>195</a> | 82 | 5 :heavy_check_mark: | 0 | 5 | 21 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L32' title='int[] Dodongo.upFrames'>32</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |

<a href="#Dodongo-class-diagram">:link: to `Dodongo` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="dodongo-dodongostate">
    Dodongo.DodongoState :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Dodongo.DodongoState` contains 2 members.
- 1 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L12' title='DodongoState.BombEaten'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Dodongo.cs#L12' title='DodongoState.Walking'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#Dodongo.DodongoState-class-diagram">:link: to `Dodongo.DodongoState` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="gel">
    Gel :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Gel` contains 11 members.
- 66 total lines of source code.
- Approximately 23 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Gel.cs#L21' title='Gel.Gel(Texture2D texture, Vector2 position)'>21</a> | 62 | 1 :heavy_check_mark: | 0 | 8 | 15 / 9 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Gel.cs#L13' title='int Gel.DAMAGE'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Gel.cs#L64' title='Vector2 Gel.GetRandomTurnDirection()'>64</a> | 87 | 1 :heavy_check_mark: | 0 | 3 | 11 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Gel.cs#L12' title='int Gel.HEALTH'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Gel.cs#L19' title='float Gel.MOVE_SPEED'>19</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Gel.cs#L57' title='void Gel.Reset()'>57</a> | 81 | 1 :heavy_check_mark: | 0 | 3 | 6 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Gel.cs#L18' title='float Gel.TURN_INTERVAL'>18</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Gel.cs#L17' title='float Gel.TURN_SPEED'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Gel.cs#L16' title='float Gel.turnTimer'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Gel.cs#L38' title='void Gel.Update(GameTime gameTime)'>38</a> | 65 | 3 :heavy_check_mark: | 0 | 4 | 18 / 8 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Gel.cs#L15' title='Vector2 Gel.velocity'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#Gel-class-diagram">:link: to `Gel` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="goriya">
    Goriya :radioactive:
  </strong>
</summary>
<br>

- The `Goriya` contains 35 members.
- 246 total lines of source code.
- Approximately 86 lines of executable code.
- The highest cyclomatic complexity is 10 :radioactive:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L51' title='Goriya.Goriya(Texture2D texture, Vector2 position, ContentManager content, List<Block> solidBlocks)'>51</a> | 55 | 1 :heavy_check_mark: | 0 | 13 | 26 / 16 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L35' title='Boomerang Goriya.activeBoomerang'>35</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L36' title='Boomerang Goriya.ActiveBoomerang'>36</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L200' title='void Goriya.ChooseNextStep()'>200</a> | 69 | 2 :heavy_check_mark: | 0 | 4 | 12 / 6 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L37' title='ContentManager Goriya.contentManager'>37</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L28' title='Direction Goriya.currentDirection'>28</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L16' title='GoriyaState Goriya.currentState'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L18' title='int Goriya.DAMAGE'>18</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L41' title='int[] Goriya.downFrames'>41</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L106' title='void Goriya.Draw(SpriteBatch spriteBatch, Vector2 location)'>106</a> | 84 | 2 :heavy_check_mark: | 0 | 5 | 7 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L34' title='float Goriya.FLIP_INTERVAL'>34</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L44' title='bool Goriya.FlipsOnVertical'>44</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L33' title='float Goriya.flipTimer'>33</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L213' title='Direction Goriya.GetDirectionTo(Vector2 target)'>213</a> | 80 | 4 :heavy_check_mark: | 0 | 3 | 8 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L254' title='float Goriya.GetRandomThrowTime()'>254</a> | 89 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L17' title='int Goriya.HEALTH'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L191' title='bool Goriya.IsBoomerangActive()'>191</a> | 77 | 4 :heavy_check_mark: | 0 | 4 | 8 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L21' title='float Goriya.MOVE_SPEED'>21</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L42' title='int[] Goriya.sideFrames'>42</a> | 91 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L24' title='List<Block> Goriya.solidBlocks'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L32' title='bool Goriya.spriteHorizontalFlip'>32</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L20' title='float Goriya.STEP_DELAY'>20</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L19' title='float Goriya.STEP_SIZE'>19</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L30' title='float Goriya.stepTimer'>30</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L29' title='Vector2 Goriya.targetPosition'>29</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L23' title='float Goriya.THROW_COOLDOWN_MAX'>23</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L22' title='float Goriya.THROW_COOLDOWN_MIN'>22</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L166' title='void Goriya.ThrowBoomerang()'>166</a> | 65 | 2 :heavy_check_mark: | 0 | 8 | 24 / 7 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L43' title='int[] Goriya.throwFrame'>43</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L31' title='float Goriya.throwTimer'>31</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L74' title='void Goriya.Update(GameTime gameTime)'>74</a> | 62 | 7 :heavy_check_mark: | 0 | 5 | 31 / 10 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L222' title='void Goriya.UpdateSprite()'>222</a> | 58 | 10 :radioactive: | 0 | 5 | 32 / 11 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L149' title='void Goriya.UpdateThrowing(float deltaTime)'>149</a> | 67 | 3 :heavy_check_mark: | 0 | 5 | 16 / 7 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L114' title='void Goriya.UpdateWalking(float deltaTime)'>114</a> | 55 | 7 :heavy_check_mark: | 0 | 3 | 34 / 15 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L40' title='int[] Goriya.upFrames'>40</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |

<a href="#Goriya-class-diagram">:link: to `Goriya` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="goriya-goriyastate">
    Goriya.GoriyaState :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Goriya.GoriyaState` contains 2 members.
- 1 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L15' title='GoriyaState.Throwing'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L15' title='GoriyaState.Walking'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#Goriya.GoriyaState-class-diagram">:link: to `Goriya.GoriyaState` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="keese">
    Keese :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Keese` contains 17 members.
- 102 total lines of source code.
- Approximately 38 lines of executable code.
- The highest cyclomatic complexity is 7 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L30' title='Keese.Keese(Texture2D texture, Vector2 position)'>30</a> | 56 | 1 :heavy_check_mark: | 0 | 8 | 26 / 14 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L21' title='float Keese.actionDuration'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L20' title='float Keese.actionTimer'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L99' title='void Keese.ChooseRandomDirection()'>99</a> | 78 | 1 :heavy_check_mark: | 0 | 3 | 7 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L13' title='int Keese.DAMAGE'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L23' title='IPositionedSprite Keese.flyingSprite'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L107' title='float Keese.GetRandomFloat(float min, float max)'>107</a> | 90 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L12' title='int Keese.HEALTH'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L22' title='bool Keese.isResting'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L14' title='float Keese.MOVE_SPEED'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L18' title='float Keese.MOVE_TIME_MAX'>18</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L17' title='float Keese.MOVE_TIME_MIN'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L19' title='Vector2 Keese.moveDirection'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L16' title='float Keese.REST_TIME_MAX'>16</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L15' title='float Keese.REST_TIME_MIN'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L24' title='IPositionedSprite Keese.restingSprite'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Keese.cs#L53' title='void Keese.Update(GameTime gameTime)'>53</a> | 53 | 7 :heavy_check_mark: | 0 | 4 | 45 / 18 |

<a href="#Keese-class-diagram">:link: to `Keese` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="oldman">
    OldMan :heavy_check_mark:
  </strong>
</summary>
<br>

- The `OldMan` contains 5 members.
- 17 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/OldMan.cs#L13' title='OldMan.OldMan(Texture2D texture, Vector2 position)'>13</a> | 71 | 1 :heavy_check_mark: | 0 | 8 | 8 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/OldMan.cs#L11' title='int OldMan.DAMAGE'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/OldMan.cs#L23' title='void OldMan.Die()'>23</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/OldMan.cs#L10' title='int OldMan.HEALTH'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/OldMan.cs#L22' title='void OldMan.TakeDamage(int damageAmount)'>22</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#OldMan-class-diagram">:link: to `OldMan` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="rope">
    Rope :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Rope` contains 19 members.
- 105 total lines of source code.
- Approximately 37 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L28' title='Rope.Rope(Texture2D texture, Vector2 position)'>28</a> | 59 | 1 :heavy_check_mark: | 0 | 8 | 17 / 11 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L17' title='float Rope.CHARGE_DURATION'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L14' title='float Rope.CHARGE_SPEED'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L21' title='float Rope.chargeTimer'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L86' title='void Rope.ChooseRandomCardinalDirection()'>86</a> | 88 | 1 :heavy_check_mark: | 0 | 3 | 11 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L16' title='float Rope.DIRECTION_CHANGE_MAX'>16</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L15' title='float Rope.DIRECTION_CHANGE_MIN'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L23' title='float Rope.directionChangeDuration'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L22' title='float Rope.directionChangeTimer'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L24' title='bool Rope.facingLeft'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L26' title='int[] Rope.frameXPositions'>26</a> | 91 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L109' title='float Rope.GetRandomFloat(float min, float max)'>109</a> | 90 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L20' title='bool Rope.isCharging'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L19' title='Vector2 Rope.moveDirection'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L13' title='float Rope.PATROL_SPEED'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L12' title='int Rope.ROPE_DAMAGE'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L11' title='int Rope.ROPE_HEALTH'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L46' title='void Rope.Update(GameTime gameTime)'>46</a> | 54 | 6 :heavy_check_mark: | 0 | 4 | 39 / 17 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Rope.cs#L98' title='void Rope.UpdateSpriteFlip()'>98</a> | 71 | 3 :heavy_check_mark: | 0 | 4 | 10 / 5 |

<a href="#Rope-class-diagram">:link: to `Rope` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="stalfos">
    Stalfos :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Stalfos` contains 14 members.
- 103 total lines of source code.
- Approximately 30 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L22' title='Stalfos.Stalfos(Texture2D texture, Vector2 position)'>22</a> | 61 | 1 :heavy_check_mark: | 0 | 6 | 15 / 10 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L16' title='float Stalfos.DIRECTION_CHANGE_INTERVAL'>16</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L15' title='float Stalfos.directionChangeTimer'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L81' title='void Stalfos.Draw(SpriteBatch spriteBatch, Vector2 location)'>81</a> | 73 | 3 :heavy_check_mark: | 0 | 7 | 30 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L20' title='float Stalfos.FLIP_INTERVAL'>20</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L19' title='float Stalfos.flipTimer'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L38' title='Vector2 Stalfos.GetRandomCardinalDirection()'>38</a> | 80 | 1 :heavy_check_mark: | 0 | 3 | 14 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L18' title='bool Stalfos.isFlipped'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L13' title='float Stalfos.MOVE_SPEED'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L17' title='Rectangle Stalfos.sourceRect'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L11' title='int Stalfos.STALFOS_DAMAGE'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L10' title='int Stalfos.STALFOS_HEALTH'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L53' title='void Stalfos.Update(GameTime gameTime)'>53</a> | 60 | 4 :heavy_check_mark: | 0 | 4 | 25 / 12 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Stalfos.cs#L14' title='Vector2 Stalfos.velocity'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#Stalfos-class-diagram">:link: to `Stalfos` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="trap">
    Trap :warning:
  </strong>
</summary>
<br>

- The `Trap` contains 19 members.
- 131 total lines of source code.
- Approximately 42 lines of executable code.
- The highest cyclomatic complexity is 9 :warning:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L24' title='Trap.Trap(Texture2D texture, Vector2 position)'>24</a> | 62 | 1 :heavy_check_mark: | 0 | 9 | 14 / 9 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L12' title='float Trap.CHARGE_SPEED'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L19' title='Vector2 Trap.chargeDirection'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L20' title='Vector2 Trap.chargeTarget'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L17' title='TrapState Trap.currentState'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L130' title='void Trap.Die()'>130</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L18' title='Vector2 Trap.homePosition'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L132' title='void Trap.Reset()'>132</a> | 80 | 1 :heavy_check_mark: | 0 | 3 | 6 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L13' title='float Trap.RETRACT_SPEED'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L22' title='bool Trap.sameColumn'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L21' title='bool Trap.sameRow'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L101' title='void Trap.StartCharge()'>101</a> | 61 | 9 :warning: | 0 | 6 | 27 / 9 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L129' title='void Trap.TakeDamage(int damageAmount)'>129</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L11' title='int Trap.TRAP_DAMAGE'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L10' title='int Trap.TRAP_HEALTH'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L39' title='void Trap.Update(GameTime gameTime)'>39</a> | 70 | 6 :heavy_check_mark: | 0 | 6 | 20 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L68' title='void Trap.UpdateCharging(float deltaTime)'>68</a> | 68 | 2 :heavy_check_mark: | 0 | 3 | 15 / 6 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L60' title='void Trap.UpdateIdle()'>60</a> | 86 | 3 :heavy_check_mark: | 0 | 0 | 7 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L84' title='void Trap.UpdateRetracting(float deltaTime)'>84</a> | 66 | 2 :heavy_check_mark: | 0 | 3 | 16 / 7 |

<a href="#Trap-class-diagram">:link: to `Trap` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="trap-trapstate">
    Trap.TrapState :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Trap.TrapState` contains 3 members.
- 1 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L15' title='TrapState.Charging'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L15' title='TrapState.Idle'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Trap.cs#L15' title='TrapState.Retracting'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#Trap.TrapState-class-diagram">:link: to `Trap.TrapState` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="wallmaster">
    WallMaster :warning:
  </strong>
</summary>
<br>

- The `WallMaster` contains 20 members.
- 147 total lines of source code.
- Approximately 53 lines of executable code.
- The highest cyclomatic complexity is 8 :warning:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L27' title='WallMaster.WallMaster(Texture2D texture, Vector2 position)'>27</a> | 57 | 1 :heavy_check_mark: | 0 | 9 | 25 / 13 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L13' title='float WallMaster.CREEP_SPEED'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L20' title='WallMasterState WallMaster.currentState'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L14' title='float WallMaster.DETECTION_RANGE'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L53' title='Vector2 WallMaster.DetermineEntryDirection(Vector2 spawnPosition)'>53</a> | 64 | 4 :heavy_check_mark: | 0 | 3 | 15 / 9 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L143' title='void WallMaster.Draw(SpriteBatch spriteBatch, Vector2 location)'>143</a> | 84 | 3 :heavy_check_mark: | 0 | 4 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L16' title='float WallMaster.ENTER_SPEED'>16</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L22' title='Vector2 WallMaster.entryStart'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L23' title='Vector2 WallMaster.entryTarget'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L15' title='float WallMaster.GRAB_RANGE'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L21' title='Vector2 WallMaster.homePosition'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L25' title='bool WallMaster.IsEntering'>25</a> | 94 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L24' title='bool WallMaster.movingVertically'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L149' title='void WallMaster.Reset()'>149</a> | 80 | 1 :heavy_check_mark: | 0 | 3 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L69' title='void WallMaster.Update(GameTime gameTime)'>69</a> | 72 | 6 :heavy_check_mark: | 0 | 4 | 24 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L109' title='void WallMaster.UpdateCreeping(float deltaTime)'>109</a> | 58 | 8 :warning: | 0 | 7 | 27 / 11 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L94' title='void WallMaster.UpdateEntering(float deltaTime)'>94</a> | 68 | 2 :heavy_check_mark: | 0 | 3 | 14 / 6 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L137' title='void WallMaster.UpdateGrabbing()'>137</a> | 93 | 1 :heavy_check_mark: | 0 | 3 | 5 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L12' title='int WallMaster.WALLMASTER_DAMAGE'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L11' title='int WallMaster.WALLMASTER_HEALTH'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#WallMaster-class-diagram">:link: to `WallMaster` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="wallmaster-wallmasterstate">
    WallMaster.WallMasterState :heavy_check_mark:
  </strong>
</summary>
<br>

- The `WallMaster.WallMasterState` contains 3 members.
- 1 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L18' title='WallMasterState.Creeping'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L18' title='WallMasterState.Entering'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L18' title='WallMasterState.Grabbing'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#WallMaster.WallMasterState-class-diagram">:link: to `WallMaster.WallMasterState` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

<details>
<summary>
  <strong id="zol">
    Zol :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Zol` contains 12 members.
- 81 total lines of source code.
- Approximately 32 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L21' title='Zol.Zol(Texture2D texture, Vector2 position)'>21</a> | 61 | 1 :heavy_check_mark: | 0 | 8 | 16 / 10 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L15' title='float Zol.AIR_TIME'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L14' title='float Zol.BOUNCE_INTERVAL'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L13' title='float Zol.BOUNCE_SPEED'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L18' title='float Zol.bounceTimer'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L78' title='Vector2 Zol.GetRandomBounceDirection()'>78</a> | 87 | 1 :heavy_check_mark: | 0 | 3 | 11 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L19' title='bool Zol.isOnGround'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L70' title='void Zol.Reset()'>70</a> | 76 | 1 :heavy_check_mark: | 0 | 3 | 7 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L38' title='void Zol.Update(GameTime gameTime)'>38</a> | 57 | 5 :heavy_check_mark: | 0 | 4 | 31 / 15 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L17' title='Vector2 Zol.velocity'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L12' title='int Zol.ZOL_DAMAGE'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Zol.cs#L11' title='int Zol.ZOL_HEALTH'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#Zol-class-diagram">:link: to `Zol` class diagram</a>

<a href="#sprint-enemies-concrete">:top: back to Sprint.Enemies.Concrete</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-controllers">
    Sprint.Controllers :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Controllers` namespace contains 1 named types.

- 1 named types.
- 44 total lines of source code.
- Approximately 10 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="keyboardcontroller">
    KeyboardController :heavy_check_mark:
  </strong>
</summary>
<br>

- The `KeyboardController` contains 9 members.
- 41 total lines of source code.
- Approximately 10 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Controllers/KeyboardController.cs#L13' title='KeyboardController.KeyboardController()'>13</a> | 88 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Controllers/KeyboardController.cs#L11' title='KeyboardState KeyboardController.current'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Controllers/KeyboardController.cs#L30' title='bool KeyboardController.IsKeyDown(Keys key)'>30</a> | 96 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Controllers/KeyboardController.cs#L25' title='bool KeyboardController.IsKeyPressed(Keys key)'>25</a> | 91 | 2 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Controllers/KeyboardController.cs#L34' title='bool KeyboardController.IsKeyReleased(Keys key)'>34</a> | 91 | 2 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Controllers/KeyboardController.cs#L39' title='bool KeyboardController.IsKeyUp(Keys key)'>39</a> | 96 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Controllers/KeyboardController.cs#L10' title='KeyboardState KeyboardController.previous'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Controllers/KeyboardController.cs#L43' title='void KeyboardController.Reset()'>43</a> | 87 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Controllers/KeyboardController.cs#L19' title='void KeyboardController.Update()'>19</a> | 87 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |

<a href="#KeyboardController-class-diagram">:link: to `KeyboardController` class diagram</a>

<a href="#sprint-controllers">:top: back to Sprint.Controllers</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-enemies">
    Sprint.Enemies :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Enemies` namespace contains 6 named types.

- 6 named types.
- 304 total lines of source code.
- Approximately 93 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

<details>
<summary>
  <strong id="enemyeffectwrapper">
    EnemyEffectWrapper :heavy_check_mark:
  </strong>
</summary>
<br>

- The `EnemyEffectWrapper` contains 25 members.
- 105 total lines of source code.
- Approximately 46 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L21' title='EnemyEffectWrapper.EnemyEffectWrapper(IEnemy enemy, ISprite spawnSprite, ISprite deathSprite)'>21</a> | 76 | 1 :heavy_check_mark: | 0 | 2 | 7 / 4 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L49' title='int EnemyEffectWrapper.Damage'>49</a> | 96 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L11' title='ISprite EnemyEffectWrapper.deathSprite'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L54' title='void EnemyEffectWrapper.Die()'>54</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L93' title='void EnemyEffectWrapper.Draw(SpriteBatch spriteBatch, Vector2 location)'>93</a> | 72 | 5 :heavy_check_mark: | 0 | 5 | 18 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L18' title='float EnemyEffectWrapper.DYING_DURATION'>18</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L14' title='float EnemyEffectWrapper.dyingTimer'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L9' title='IEnemy EnemyEffectWrapper.enemy'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L41' title='int EnemyEffectWrapper.Health'>41</a> | 94 | 2 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L15' title='IEnemy EnemyEffectWrapper.InnerEnemy'>15</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L50' title='bool EnemyEffectWrapper.IsAlive'>50</a> | 96 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L51' title='bool EnemyEffectWrapper.IsDyingAnimation'>51</a> | 89 | 4 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L47' title='bool EnemyEffectWrapper.IsSpawning'>47</a> | 94 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L19' title='bool EnemyEffectWrapper.IsSpawningPublic'>19</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L48' title='int EnemyEffectWrapper.MaxHealth'>48</a> | 96 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L29' title='Vector2 EnemyEffectWrapper.Position'>29</a> | 94 | 2 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L35' title='Rectangle EnemyEffectWrapper.Rect'>35</a> | 94 | 2 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L62' title='void EnemyEffectWrapper.Reset()'>62</a> | 82 | 1 :heavy_check_mark: | 0 | 1 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L57' title='void EnemyEffectWrapper.ResetSpawnTimer()'>57</a> | 90 | 2 :heavy_check_mark: | 0 | 1 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L17' title='float EnemyEffectWrapper.SPAWN_DURATION'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L10' title='ISprite EnemyEffectWrapper.spawnSprite'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L13' title='float EnemyEffectWrapper.spawnTimer'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L53' title='void EnemyEffectWrapper.TakeDamage(int amount)'>53</a> | 96 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L55' title='string EnemyEffectWrapper.ToString()'>55</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L69' title='void EnemyEffectWrapper.Update(GameTime gameTime)'>69</a> | 66 | 5 :heavy_check_mark: | 0 | 4 | 23 / 8 |

<a href="#EnemyEffectWrapper-class-diagram">:link: to `EnemyEffectWrapper` class diagram</a>

<a href="#sprint-enemies">:top: back to Sprint.Enemies</a>

</details>

<details>
<summary>
  <strong id="enemyfactory">
    EnemyFactory :heavy_check_mark:
  </strong>
</summary>
<br>

- The `EnemyFactory` contains 10 members.
- 58 total lines of source code.
- Approximately 15 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L36' title='EnemyFactory.EnemyFactory(Texture2D enemySpriteSheet, Texture2D bossSpriteSheet, Texture2D linkSheet, Texture2D dustSheet, Texture2D NPCSheet)'>36</a> | 69 | 1 :heavy_check_mark: | 0 | 3 | 9 / 6 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L30' title='Texture2D EnemyFactory.bossSpriteSheet'>30</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L34' title='ContentManager EnemyFactory.contentManager'>34</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L50' title='IEnemy EnemyFactory.CreateEnemy(EnemyType type, Vector2 position, List<Block> solidBlocks = null)'>50</a> | 63 | 5 :heavy_check_mark: | 0 | 20 | 26 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L32' title='Texture2D EnemyFactory.dustSheet'>32</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L29' title='Texture2D EnemyFactory.enemySpriteSheet'>29</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L31' title='Texture2D EnemyFactory.linkSheet'>31</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L47' title='void EnemyFactory.LoadAllTextures(ContentManager content)'>47</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L33' title='Texture2D EnemyFactory.NPCSheet'>33</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L76' title='EnemyEffectWrapper EnemyFactory.WrapWithEffects(IEnemy enemy, Vector2 position, bool skipSpawnCloud = false)'>76</a> | 69 | 2 :heavy_check_mark: | 0 | 6 | 8 / 4 |

<a href="#EnemyFactory-class-diagram">:link: to `EnemyFactory` class diagram</a>

<a href="#sprint-enemies">:top: back to Sprint.Enemies</a>

</details>

<details>
<summary>
  <strong id="enemymanager">
    EnemyManager :heavy_check_mark:
  </strong>
</summary>
<br>

- The `EnemyManager` contains 16 members.
- 96 total lines of source code.
- Approximately 32 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L16' title='EnemyManager.EnemyManager()'>16</a> | 79 | 1 :heavy_check_mark: | 0 | 3 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L23' title='void EnemyManager.AddEnemy(IEnemy enemy)'>23</a> | 75 | 2 :heavy_check_mark: | 0 | 3 | 10 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L13' title='IEnemy EnemyManager.currentEnemy'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L12' title='int EnemyManager.currentEnemyIndex'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L34' title='void EnemyManager.CycleNext()'>34</a> | 76 | 2 :heavy_check_mark: | 0 | 3 | 8 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L43' title='void EnemyManager.CyclePrevious()'>43</a> | 76 | 2 :heavy_check_mark: | 0 | 3 | 8 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L58' title='void EnemyManager.Draw(SpriteBatch spriteBatch)'>58</a> | 76 | 5 :heavy_check_mark: | 0 | 6 | 9 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L76' title='void EnemyManager.DrawBehindBlocks(SpriteBatch spriteBatch)'>76</a> | 82 | 4 :heavy_check_mark: | 0 | 6 | 8 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L68' title='void EnemyManager.DrawOnTop(SpriteBatch spriteBatch)'>68</a> | 83 | 3 :heavy_check_mark: | 0 | 6 | 8 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L11' title='List<IEnemy> EnemyManager.enemies'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L14' title='List<IEnemy> EnemyManager.enemyList'>14</a> | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L99' title='IEnemy EnemyManager.GetCurrentEnemy()'>99</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L103' title='int EnemyManager.GetCurrentIndex()'>103</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L101' title='int EnemyManager.GetEnemyCount()'>101</a> | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L85' title='void EnemyManager.Reset()'>85</a> | 73 | 3 :heavy_check_mark: | 0 | 4 | 13 / 5 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L52' title='void EnemyManager.Update(GameTime gameTime)'>52</a> | 94 | 2 :heavy_check_mark: | 0 | 5 | 5 / 1 |

<a href="#EnemyManager-class-diagram">:link: to `EnemyManager` class diagram</a>

<a href="#sprint-enemies">:top: back to Sprint.Enemies</a>

</details>

<details>
<summary>
  <strong id="enemyprojectilefactory">
    EnemyProjectileFactory :question:
  </strong>
</summary>
<br>

- The `EnemyProjectileFactory` contains 0 members.
- 1 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :question:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |

<a href="#EnemyProjectileFactory-class-diagram">:link: to `EnemyProjectileFactory` class diagram</a>

<a href="#sprint-enemies">:top: back to Sprint.Enemies</a>

</details>

<details>
<summary>
  <strong id="enemytype">
    EnemyType :heavy_check_mark:
  </strong>
</summary>
<br>

- The `EnemyType` contains 11 members.
- 14 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L22' title='EnemyType.Aquamentus'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L23' title='EnemyType.Dodongo'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L16' title='EnemyType.Gel'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L18' title='EnemyType.Goriya'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L14' title='EnemyType.Keese'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L24' title='EnemyType.OldMan'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L21' title='EnemyType.Rope'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L15' title='EnemyType.Stalfos'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L20' title='EnemyType.Trap'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L19' title='EnemyType.WallMaster'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyFactory.cs#L17' title='EnemyType.Zol'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#EnemyType-class-diagram">:link: to `EnemyType` class diagram</a>

<a href="#sprint-enemies">:top: back to Sprint.Enemies</a>

</details>

<details>
<summary>
  <strong id="projectiletype">
    ProjectileType :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ProjectileType` contains 1 members.
- 4 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyProjectileFactory.cs#L11' title='ProjectileType.AquamentusFireball'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#ProjectileType-class-diagram">:link: to `ProjectileType` class diagram</a>

<a href="#sprint-enemies">:top: back to Sprint.Enemies</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-ui-hud">
    Sprint.UI.Hud :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.UI.Hud` namespace contains 1 named types.

- 1 named types.
- 64 total lines of source code.
- Approximately 21 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

<details>
<summary>
  <strong id="heartdisplay">
    HeartDisplay :heavy_check_mark:
  </strong>
</summary>
<br>

- The `HeartDisplay` contains 10 members.
- 62 total lines of source code.
- Approximately 21 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/HeartDisplay.cs#L19' title='HeartDisplay.HeartDisplay(Vector2 origin, int capacity)'>19</a> | 60 | 2 :heavy_check_mark: | 0 | 6 | 30 / 10 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/HeartDisplay.cs#L14' title='int HeartDisplay.capacity'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/HeartDisplay.cs#L50' title='void HeartDisplay.Draw(int hearts, bool halfHeart, int maxHearts, SpriteBatch sb)'>50</a> | 63 | 5 :heavy_check_mark: | 0 | 5 | 18 / 9 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/HeartDisplay.cs#L15' title='List<StillItem> HeartDisplay.emptyHearts'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/HeartDisplay.cs#L17' title='List<StillItem> HeartDisplay.fullHearts'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/HeartDisplay.cs#L10' title='float HeartDisplay.GAP'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/HeartDisplay.cs#L16' title='List<StillItem> HeartDisplay.halfHearts'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/HeartDisplay.cs#L9' title='float HeartDisplay.HEART_WIDTH'>9</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/HeartDisplay.cs#L13' title='Vector2 HeartDisplay.origin'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/HeartDisplay.cs#L11' title='float HeartDisplay.SCALE'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#HeartDisplay-class-diagram">:link: to `HeartDisplay` class diagram</a>

<a href="#sprint-ui-hud">:top: back to Sprint.UI.Hud</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-interfaces">
    Sprint.Interfaces :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Interfaces` namespace contains 11 named types.

- 11 named types.
- 97 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="icollisionhandler">
    ICollisionHandler :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ICollisionHandler` contains 1 members.
- 4 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ICollisionHandler.cs#L5' title='void ICollisionHandler.Handle()'>5</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#ICollisionHandler-class-diagram">:link: to `ICollisionHandler` class diagram</a>

<a href="#sprint-interfaces">:top: back to Sprint.Interfaces</a>

</details>

<details>
<summary>
  <strong id="icommand">
    ICommand :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ICommand` contains 1 members.
- 4 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ICommand.cs#L5' title='void ICommand.Execute()'>5</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#ICommand-class-diagram">:link: to `ICommand` class diagram</a>

<a href="#sprint-interfaces">:top: back to Sprint.Interfaces</a>

</details>

<details>
<summary>
  <strong id="icontroller">
    IController :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IController` contains 5 members.
- 8 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IController.cs#L9' title='bool IController.IsKeyDown(Keys key)'>9</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IController.cs#L10' title='bool IController.IsKeyPressed(Keys key)'>10</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IController.cs#L11' title='bool IController.IsKeyReleased(Keys key)'>11</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IController.cs#L8' title='void IController.Reset()'>8</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IController.cs#L7' title='void IController.Update()'>7</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#IController-class-diagram">:link: to `IController` class diagram</a>

<a href="#sprint-interfaces">:top: back to Sprint.Interfaces</a>

</details>

<details>
<summary>
  <strong id="ienemy">
    IEnemy :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IEnemy` contains 8 members.
- 11 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IEnemy.cs#L10' title='int IEnemy.Damage'>10</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IEnemy.cs#L13' title='void IEnemy.Die()'>13</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IEnemy.cs#L8' title='int IEnemy.Health'>8</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IEnemy.cs#L11' title='bool IEnemy.IsAlive'>11</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IEnemy.cs#L9' title='int IEnemy.MaxHealth'>9</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IEnemy.cs#L7' title='Rectangle IEnemy.Rect'>7</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IEnemy.cs#L14' title='void IEnemy.Reset()'>14</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IEnemy.cs#L12' title='void IEnemy.TakeDamage(int damageAmount)'>12</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#IEnemy-class-diagram">:link: to `IEnemy` class diagram</a>

<a href="#sprint-interfaces">:top: back to Sprint.Interfaces</a>

</details>

<details>
<summary>
  <strong id="igameactions">
    IGameActions :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IGameActions` contains 2 members.
- 5 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IGameActions.cs#L6' title='void IGameActions.ChangeState(IGameState newState)'>6</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IGameActions.cs#L5' title='void IGameActions.Quit()'>5</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#IGameActions-class-diagram">:link: to `IGameActions` class diagram</a>

<a href="#sprint-interfaces">:top: back to Sprint.Interfaces</a>

</details>

<details>
<summary>
  <strong id="igamestate">
    IGameState :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IGameState` contains 5 members.
- 8 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IGameState.cs#L12' title='void IGameState.Draw(SpriteBatch spriteBatch)'>12</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IGameState.cs#L8' title='void IGameState.Enter()'>8</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IGameState.cs#L9' title='void IGameState.Exit()'>9</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IGameState.cs#L10' title='void IGameState.LoadContent()'>10</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IGameState.cs#L11' title='void IGameState.Update(GameTime gameTime)'>11</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#IGameState-class-diagram">:link: to `IGameState` class diagram</a>

<a href="#sprint-interfaces">:top: back to Sprint.Interfaces</a>

</details>

<details>
<summary>
  <strong id="iitem">
    IItem :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IItem` contains 4 members.
- 7 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IItem.cs#L9' title='bool IItem.IsCollected'>9</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IItem.cs#L7' title='string IItem.Name'>7</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IItem.cs#L10' title='void IItem.OnCollect(ILink link)'>10</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IItem.cs#L8' title='Rectangle IItem.Rect'>8</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#IItem-class-diagram">:link: to `IItem` class diagram</a>

<a href="#sprint-interfaces">:top: back to Sprint.Interfaces</a>

</details>

<details>
<summary>
  <strong id="ilink">
    ILink :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ILink` contains 13 members.
- 16 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L10' title='Directions ILink.Facing'>10</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L19' title='void ILink.GetHealed(int amount)'>19</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L11' title='int ILink.Health'>11</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L20' title='void ILink.IncreaseRubies(int amount)'>20</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L12' title='int ILink.MaxHealth'>12</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L8' title='Vector2 ILink.Position'>8</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L9' title='Rectangle ILink.Rect'>9</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L14' title='void ILink.StartAttack()'>14</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L17' title='void ILink.StartPickUpTriforce()'>17</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L16' title='void ILink.StartPickUpWeapon(Rectangle itemRect)'>16</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L15' title='void ILink.StartUseItem()'>15</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L13' title='Rectangle ILink.SwordRect'>13</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L18' title='void ILink.TakeDamage(int amount)'>18</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#ILink-class-diagram">:link: to `ILink` class diagram</a>

<a href="#sprint-interfaces">:top: back to Sprint.Interfaces</a>

</details>

<details>
<summary>
  <strong id="ipositionedsprite">
    IPositionedSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IPositionedSprite` contains 1 members.
- 4 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ISprite.cs#L15' title='Vector2 IPositionedSprite.Position'>15</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#IPositionedSprite-class-diagram">:link: to `IPositionedSprite` class diagram</a>

<a href="#sprint-interfaces">:top: back to Sprint.Interfaces</a>

</details>

<details>
<summary>
  <strong id="isprite">
    ISprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ISprite` contains 2 members.
- 5 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ISprite.cs#L9' title='void ISprite.Draw(SpriteBatch spriteBatch, Vector2 location)'>9</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ISprite.cs#L10' title='void ISprite.Update(GameTime gameTime)'>10</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ISprite-class-diagram">:link: to `ISprite` class diagram</a>

<a href="#sprint-interfaces">:top: back to Sprint.Interfaces</a>

</details>

<details>
<summary>
  <strong id="iuielement">
    IUIElement :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IUIElement` contains 2 members.
- 5 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IUIElement.cs#L8' title='void IUIElement.Draw(SpriteBatch spriteBatch)'>8</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IUIElement.cs#L9' title='void IUIElement.Update(GameTime gameTime)'>9</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#IUIElement-class-diagram">:link: to `IUIElement` class diagram</a>

<a href="#sprint-interfaces">:top: back to Sprint.Interfaces</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-item">
    Sprint.Item :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Item` namespace contains 9 named types.

- 9 named types.
- 353 total lines of source code.
- Approximately 98 lines of executable code.
- The highest cyclomatic complexity is 7 :heavy_check_mark:.

<details>
<summary>
  <strong id="abstractitem">
    AbstractItem :heavy_check_mark:
  </strong>
</summary>
<br>

- The `AbstractItem` contains 13 members.
- 42 total lines of source code.
- Approximately 13 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L31' title='AbstractItem.AbstractItem(string name, Texture2D texture, Vector2 position)'>31</a> | 79 | 1 :heavy_check_mark: | 0 | 2 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L40' title='void AbstractItem.Draw(SpriteBatch sb, Vector2 location)'>40</a> | 92 | 2 :heavy_check_mark: | 0 | 4 | 4 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L26' title='bool AbstractItem.IsCollected'>26</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L27' title='bool AbstractItem.IsFinished'>27</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L23' title='string AbstractItem.Name'>23</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L38' title='void AbstractItem.OnCollect(ILink link)'>38</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L11' title='Vector2 AbstractItem.position'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L13' title='Vector2 AbstractItem.Position'>13</a> | 92 | 2 :heavy_check_mark: | 0 | 3 | 9 / 3 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L24' title='Rectangle AbstractItem.Rect'>24</a> | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L25' title='Rectangle AbstractItem.SourceRect'>25</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L29' title='ISprite AbstractItem.sprite'>29</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L10' title='Texture2D AbstractItem.texture'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L45' title='void AbstractItem.Update(GameTime time)'>45</a> | 95 | 2 :heavy_check_mark: | 0 | 3 | 4 / 1 |

<a href="#AbstractItem-class-diagram">:link: to `AbstractItem` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="arrow">
    Arrow :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Arrow` contains 7 members.
- 32 total lines of source code.
- Approximately 12 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Arrow.cs#L13' title='Arrow.Arrow(Rectangle sourceRect, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale)'>13</a> | 79 | 1 :heavy_check_mark: | 0 | 8 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Arrow.cs#L9' title='int Arrow.HITBOX_SIZE'>9</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Arrow.cs#L11' title='bool Arrow.hitEnemy'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Arrow.cs#L37' title='bool Arrow.IsFinished'>37</a> | 89 | 6 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Arrow.cs#L28' title='void Arrow.MarkHit()'>28</a> | 96 | 1 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Arrow.cs#L19' title='Arrow Arrow.StartMoving()'>19</a> | 84 | 2 :heavy_check_mark: | 0 | 2 | 8 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Arrow.cs#L30' title='void Arrow.Update(GameTime time)'>30</a> | 83 | 2 :heavy_check_mark: | 0 | 5 | 6 / 2 |

<a href="#Arrow-class-diagram">:link: to `Arrow` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="boomerang">
    Boomerang :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Boomerang` contains 6 members.
- 31 total lines of source code.
- Approximately 12 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Boomerang.cs#L12' title='Boomerang.Boomerang(Vector2 pos, Vector2 vel, float maxDistance)'>12</a> | 74 | 1 :heavy_check_mark: | 0 | 8 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Boomerang.cs#L37' title='ISprite Boomerang.GetSprite()'>37</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Boomerang.cs#L10' title='int Boomerang.HITBOX_SIZE'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Boomerang.cs#L35' title='bool Boomerang.IsFinished'>35</a> | 91 | 4 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Boomerang.cs#L19' title='Boomerang Boomerang.StartMoving()'>19</a> | 84 | 2 :heavy_check_mark: | 0 | 2 | 8 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/Boomerang.cs#L28' title='void Boomerang.Update(GameTime time)'>28</a> | 83 | 2 :heavy_check_mark: | 0 | 5 | 6 / 2 |

<a href="#Boomerang-class-diagram">:link: to `Boomerang` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="inventory">
    Inventory :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Inventory` contains 9 members.
- 32 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Inventory.cs#L11' title='int Inventory.ActiveSlot'>11</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Inventory.cs#L14' title='void Inventory.Add(IItem item)'>14</a> | 97 | 1 :heavy_check_mark: | 0 | 3 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Inventory.cs#L12' title='int Inventory.Count'>12</a> | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Inventory.cs#L18' title='void Inventory.CycleNext()'>18</a> | 90 | 2 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Inventory.cs#L23' title='void Inventory.CyclePrevious()'>23</a> | 92 | 2 :heavy_check_mark: | 0 | 1 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Inventory.cs#L34' title='void Inventory.Draw(SpriteBatch sb)'>34</a> | 90 | 2 :heavy_check_mark: | 0 | 4 | 5 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Inventory.cs#L16' title='IItem Inventory.Get(int slot)'>16</a> | 97 | 1 :heavy_check_mark: | 0 | 3 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Inventory.cs#L10' title='List<IItem> Inventory.items'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Inventory.cs#L28' title='void Inventory.Update(GameTime time)'>28</a> | 94 | 2 :heavy_check_mark: | 0 | 5 | 5 / 1 |

<a href="#Inventory-class-diagram">:link: to `Inventory` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="itemfactory">
    ItemFactory :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ItemFactory` contains 4 members.
- 75 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L34' title='Arrow ItemFactory.CreateArrow(Vector2 pos, Vector2 vel, float rotation, float scale = 1, float maxDistance = null)'>34</a> | 72 | 1 :heavy_check_mark: | 0 | 3 | 12 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L29' title='Boomerang ItemFactory.CreateBoomerang(Vector2 pos, Vector2 vel, float maxDistance)'>29</a> | 92 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L53' title='StillItem ItemFactory.CreateStillItem(StillType type, Vector2 pos, float scale = null)'>53</a> | 68 | 1 :heavy_check_mark: | 0 | 7 | 26 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L47' title='TimeBomb ItemFactory.CreateTimeBomb(double explodeDelayMillis, Vector2 pos, float scale)'>47</a> | 82 | 1 :heavy_check_mark: | 0 | 3 | 5 / 2 |

<a href="#ItemFactory-class-diagram">:link: to `ItemFactory` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="itemmanager">
    ItemManager :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ItemManager` contains 8 members.
- 75 total lines of source code.
- Approximately 31 lines of executable code.
- The highest cyclomatic complexity is 7 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L80' title='void ItemManager.Draw(SpriteBatch sb)'>80</a> | 94 | 2 :heavy_check_mark: | 0 | 4 | 5 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L17' title='IReadOnlyList<AbstractItem> ItemManager.JustFinished'>17</a> | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L14' title='List<AbstractItem> ItemManager.justFinishedItems'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L13' title='List<AbstractItem> ItemManager.spawnedItems'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L16' title='IReadOnlyList<AbstractItem> ItemManager.SpawnedItems'>16</a> | 100 | 2 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L70' title='void ItemManager.SpawnItem(AbstractItem item)'>70</a> | 97 | 1 :heavy_check_mark: | 0 | 3 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L72' title='void ItemManager.Update(GameTime time)'>72</a> | 74 | 2 :heavy_check_mark: | 0 | 4 | 7 / 5 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L19' title='void ItemManager.UseItem(ILink link, Inventory inventory, int slot)'>19</a> | 52 | 7 :heavy_check_mark: | 0 | 12 | 50 / 18 |

<a href="#ItemManager-class-diagram">:link: to `ItemManager` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="stillitem">
    StillItem :heavy_check_mark:
  </strong>
</summary>
<br>

- The `StillItem` contains 1 members.
- 14 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Pickup/StillItem.cs#L10' title='StillItem.StillItem(string name, Texture2D texture, Vector2 pos, Rectangle sourceRect, float scale)'>10</a> | 75 | 1 :heavy_check_mark: | 0 | 7 | 11 / 3 |

<a href="#StillItem-class-diagram">:link: to `StillItem` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="itemfactory-stilltype">
    ItemFactory.StillType :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ItemFactory.StillType` contains 18 members.
- 21 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L22' title='StillType.BlueCandle'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L10' title='StillType.BlueHeart'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L18' title='StillType.BluePotion'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L20' title='StillType.Bomb'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L21' title='StillType.Bow'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L15' title='StillType.Clock'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L24' title='StillType.Compass'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L14' title='StillType.Fairy'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L16' title='StillType.GoldRupee'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L25' title='StillType.GoldTriforce'>25</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L11' title='StillType.HalfHeart'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L9' title='StillType.Heart'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L13' title='StillType.HeartContainer'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L23' title='StillType.Key'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L19' title='StillType.Map'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L17' title='StillType.PurpleRupee'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L26' title='StillType.PurpleTriforce'>26</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L12' title='StillType.ZeroHeart'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#ItemFactory.StillType-class-diagram">:link: to `ItemFactory.StillType` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="timebomb">
    TimeBomb :heavy_check_mark:
  </strong>
</summary>
<br>

- The `TimeBomb` contains 5 members.
- 28 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/TimeBomb.cs#L13' title='TimeBomb.TimeBomb(double explodeDelayMillis, string name, Vector2 pos, Rectangle sourceRect, float scale)'>13</a> | 75 | 1 :heavy_check_mark: | 0 | 8 | 6 / 3 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/TimeBomb.cs#L11' title='bool TimeBomb.IsExploding'>11</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/TimeBomb.cs#L33' title='bool TimeBomb.IsFinished'>33</a> | 91 | 4 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/TimeBomb.cs#L9' title='double TimeBomb.millisUntilExplode'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Active/TimeBomb.cs#L20' title='void TimeBomb.Update(GameTime time)'>20</a> | 74 | 3 :heavy_check_mark: | 0 | 2 | 12 / 4 |

<a href="#TimeBomb-class-diagram">:link: to `TimeBomb` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-layers">
    Sprint.Layers :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Layers` namespace contains 1 named types.

- 1 named types.
- 11 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="layerdata">
    LayerData :heavy_check_mark:
  </strong>
</summary>
<br>

- The `LayerData` contains 5 members.
- 10 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LayerData.cs#L11' title='int[] LayerData.data'>11</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LayerData.cs#L9' title='int LayerData.height'>9</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LayerData.cs#L5' title='string LayerData.name'>5</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LayerData.cs#L6' title='string LayerData.type'>6</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LayerData.cs#L8' title='int LayerData.width'>8</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#LayerData-class-diagram">:link: to `LayerData` class diagram</a>

<a href="#sprint-layers">:top: back to Sprint.Layers</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-levels">
    Sprint.Levels :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Levels` namespace contains 1 named types.

- 1 named types.
- 9 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="leveldata">
    LevelData :heavy_check_mark:
  </strong>
</summary>
<br>

- The `LevelData` contains 3 members.
- 7 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelData.cs#L9' title='int LevelData.height'>9</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelData.cs#L11' title='List<LayerData> LevelData.layers'>11</a> | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelData.cs#L8' title='int LevelData.width'>8</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#LevelData-class-diagram">:link: to `LevelData` class diagram</a>

<a href="#sprint-levels">:top: back to Sprint.Levels</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint">
    Sprint :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint` namespace contains 1 named types.

- 1 named types.
- 88 total lines of source code.
- Approximately 27 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="game1">
    Game1 :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Game1` contains 11 members.
- 86 total lines of source code.
- Approximately 27 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L25' title='Game1.Game1()'>25</a> | 67 | 1 :heavy_check_mark: | 0 | 5 | 15 / 8 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L87' title='void Game1.ChangeState(IGameState newState)'>87</a> | 75 | 1 :heavy_check_mark: | 0 | 3 | 8 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L23' title='IGameState Game1.currentState'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L70' title='void Game1.Draw(GameTime gameTime)'>70</a> | 75 | 1 :heavy_check_mark: | 0 | 5 | 16 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L19' title='GraphicsDeviceManager Game1.graphics'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L41' title='void Game1.Initialize()'>41</a> | 84 | 1 :heavy_check_mark: | 0 | 5 | 10 / 3 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L17' title='Game1 Game1.Instance'>17</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L52' title='void Game1.LoadContent()'>52</a> | 88 | 1 :heavy_check_mark: | 0 | 3 | 7 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L96' title='void Game1.Quit()'>96</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L20' title='SpriteBatch Game1.spriteBatch'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L60' title='void Game1.Update(GameTime gameTime)'>60</a> | 82 | 1 :heavy_check_mark: | 0 | 6 | 9 / 3 |

<a href="#Game1-class-diagram">:link: to `Game1` class diagram</a>

<a href="#sprint">:top: back to Sprint</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-sprites">
    Sprint.Sprites :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Sprites` namespace contains 8 named types.

- 8 named types.
- 711 total lines of source code.
- Approximately 216 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

<details>
<summary>
  <strong id="animatedsprite">
    AnimatedSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `AnimatedSprite` contains 19 members.
- 94 total lines of source code.
- Approximately 26 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L36' title='AnimatedSprite.AnimatedSprite(Texture2D texture, Vector2 position, int[] sheetXPositions, int sheetYPos, int spriteWidth, int spriteHeight, float frameTime)'>36</a> | 61 | 1 :heavy_check_mark: | 0 | 3 | 15 / 11 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L14' title='int AnimatedSprite.curFrame'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L78' title='void AnimatedSprite.Draw(SpriteBatch spriteBatch, Vector2 location)'>78</a> | 80 | 1 :heavy_check_mark: | 0 | 6 | 23 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L17' title='float AnimatedSprite.elapsedTime'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L13' title='int AnimatedSprite.frameCount'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L19' title='int AnimatedSprite.frameHeight'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L16' title='float AnimatedSprite.frameTime'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L18' title='int AnimatedSprite.frameWidth'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L11' title='Vector2 AnimatedSprite.pos'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L22' title='Vector2 AnimatedSprite.Position'>22</a> | 94 | 2 :heavy_check_mark: | 0 | 1 | 9 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L12' title='Rectangle AnimatedSprite.rect'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L34' title='Rectangle AnimatedSprite.Rect'>34</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L62' title='void AnimatedSprite.SetFrame(int frame)'>62</a> | 92 | 1 :heavy_check_mark: | 0 | 1 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L15' title='int[] AnimatedSprite.sheetXPositions'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L20' title='int AnimatedSprite.sheetY'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L10' title='Texture2D AnimatedSprite.texture'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L32' title='Texture2D AnimatedSprite.Texture'>32</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L67' title='void AnimatedSprite.Update(GameTime gameTime)'>67</a> | 73 | 2 :heavy_check_mark: | 0 | 2 | 10 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L52' title='void AnimatedSprite.UpdateRect()'>52</a> | 88 | 1 :heavy_check_mark: | 0 | 4 | 9 / 1 |

<a href="#AnimatedSprite-class-diagram">:link: to `AnimatedSprite` class diagram</a>

<a href="#sprint-sprites">:top: back to Sprint.Sprites</a>

</details>

<details>
<summary>
  <strong id="boomerangsprite">
    BoomerangSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `BoomerangSprite` contains 16 members.
- 74 total lines of source code.
- Approximately 26 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L25' title='BoomerangSprite.BoomerangSprite(Texture2D texture, Vector2 initialPos, Vector2 velocity, float maxDistance, float scale)'>25</a> | 72 | 1 :heavy_check_mark: | 0 | 2 | 8 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L17' title='int BoomerangSprite.animationFrame'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L19' title='float BoomerangSprite.distanceTraveled'>19</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L39' title='void BoomerangSprite.Draw(SpriteBatch sb, Vector2 location)'>39</a> | 87 | 1 :heavy_check_mark: | 0 | 4 | 14 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L23' title='bool BoomerangSprite.IsActive'>23</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L18' title='int BoomerangSprite.lastAnimationFrame'>18</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L20' title='float BoomerangSprite.maxDistance'>20</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L12' title='Vector2 BoomerangSprite.pos'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L13' title='Vector2 BoomerangSprite.Position'>13</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L21' title='bool BoomerangSprite.returning'>21</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L16' title='float BoomerangSprite.scale'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L14' title='Texture2D BoomerangSprite.texture'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L34' title='void BoomerangSprite.Throw()'>34</a> | 96 | 1 :heavy_check_mark: | 0 | 0 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L22' title='bool BoomerangSprite.thrown'>22</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L54' title='void BoomerangSprite.Update(GameTime time)'>54</a> | 58 | 5 :heavy_check_mark: | 0 | 3 | 29 / 13 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/BoomerangSprite.cs#L15' title='Vector2 BoomerangSprite.velocity'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#BoomerangSprite-class-diagram">:link: to `BoomerangSprite` class diagram</a>

<a href="#sprint-sprites">:top: back to Sprint.Sprites</a>

</details>

<details>
<summary>
  <strong id="directionalanimatedsprite">
    DirectionalAnimatedSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `DirectionalAnimatedSprite` contains 20 members.
- 109 total lines of source code.
- Approximately 33 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L36' title='DirectionalAnimatedSprite.DirectionalAnimatedSprite(Texture2D texture, Vector2 position, int[] xPositions, int yPos, int spriteWidth, int spriteHeight, float frameTime, bool flipHorizontal = false)'>36</a> | 59 | 1 :heavy_check_mark: | 0 | 3 | 17 / 13 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L13' title='int DirectionalAnimatedSprite.curFrame'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L91' title='void DirectionalAnimatedSprite.Draw(SpriteBatch spriteBatch, Vector2 location)'>91</a> | 75 | 2 :heavy_check_mark: | 0 | 7 | 24 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L16' title='float DirectionalAnimatedSprite.elapsedTime'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L20' title='bool DirectionalAnimatedSprite.flipHorizontal'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L12' title='int DirectionalAnimatedSprite.frameCount'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L18' title='int DirectionalAnimatedSprite.frameHeight'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L15' title='float DirectionalAnimatedSprite.frameTime'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L17' title='int DirectionalAnimatedSprite.frameWidth'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L10' title='Vector2 DirectionalAnimatedSprite.pos'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L22' title='Vector2 DirectionalAnimatedSprite.Position'>22</a> | 94 | 2 :heavy_check_mark: | 0 | 1 | 9 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L11' title='Rectangle DirectionalAnimatedSprite.rect'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L34' title='Rectangle DirectionalAnimatedSprite.Rect'>34</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L14' title='int[] DirectionalAnimatedSprite.sheetXPositions'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L19' title='int DirectionalAnimatedSprite.sheetY'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L9' title='Texture2D DirectionalAnimatedSprite.texture'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L32' title='Texture2D DirectionalAnimatedSprite.Texture'>32</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L80' title='void DirectionalAnimatedSprite.Update(GameTime gameTime)'>80</a> | 73 | 2 :heavy_check_mark: | 0 | 2 | 10 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L54' title='void DirectionalAnimatedSprite.UpdateFrames(int[] xPositions, bool flipHorizontal)'>54</a> | 72 | 1 :heavy_check_mark: | 0 | 1 | 8 / 5 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/DirectionalAnimatedSprite.cs#L63' title='void DirectionalAnimatedSprite.UpdateRect()'>63</a> | 88 | 1 :heavy_check_mark: | 0 | 4 | 16 / 1 |

<a href="#DirectionalAnimatedSprite-class-diagram">:link: to `DirectionalAnimatedSprite` class diagram</a>

<a href="#sprint-sprites">:top: back to Sprint.Sprites</a>

</details>

<details>
<summary>
  <strong id="movinganimatedsprite">
    MovingAnimatedSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `MovingAnimatedSprite` contains 22 members.
- 129 total lines of source code.
- Approximately 44 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L41' title='MovingAnimatedSprite.MovingAnimatedSprite(Texture2D texture, Vector2 startPosition, int[] sheetXPositions, int frameY, int spriteWidth, int spriteHeight, float frameDuration, float moveSpeed = 150, float range = 300)'>41</a> | 54 | 1 :heavy_check_mark: | 0 | 3 | 28 / 17 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L15' title='int MovingAnimatedSprite.curFrame'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L113' title='void MovingAnimatedSprite.Draw(SpriteBatch spriteBatch, Vector2 location)'>113</a> | 71 | 2 :heavy_check_mark: | 0 | 7 | 24 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L18' title='float MovingAnimatedSprite.elapsedTime'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L14' title='int MovingAnimatedSprite.frameCount'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L20' title='int MovingAnimatedSprite.frameHeight'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L17' title='float MovingAnimatedSprite.frameTime'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L19' title='int MovingAnimatedSprite.frameWidth'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L21' title='int MovingAnimatedSprite.frameY'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L24' title='float MovingAnimatedSprite.maxX'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L23' title='float MovingAnimatedSprite.minX'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L25' title='bool MovingAnimatedSprite.movingRight'>25</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L12' title='Vector2 MovingAnimatedSprite.pos'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L27' title='Vector2 MovingAnimatedSprite.Position'>27</a> | 94 | 2 :heavy_check_mark: | 0 | 1 | 9 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L13' title='Rectangle MovingAnimatedSprite.rect'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L39' title='Rectangle MovingAnimatedSprite.Rect'>39</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L16' title='int[] MovingAnimatedSprite.sheetXPositions'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L22' title='float MovingAnimatedSprite.speed'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L11' title='Texture2D MovingAnimatedSprite.texture'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L37' title='Texture2D MovingAnimatedSprite.Texture'>37</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L80' title='void MovingAnimatedSprite.Update(GameTime gameTime)'>80</a> | 56 | 5 :heavy_check_mark: | 0 | 3 | 32 / 15 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingAnimatedSprite.cs#L70' title='void MovingAnimatedSprite.UpdateRect()'>70</a> | 87 | 1 :heavy_check_mark: | 0 | 3 | 9 / 1 |

<a href="#MovingAnimatedSprite-class-diagram">:link: to `MovingAnimatedSprite` class diagram</a>

<a href="#sprint-sprites">:top: back to Sprint.Sprites</a>

</details>

<details>
<summary>
  <strong id="movingsprite">
    MovingSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `MovingSprite` contains 23 members.
- 124 total lines of source code.
- Approximately 43 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L40' title='MovingSprite.MovingSprite(Texture2D tex, Vector2 start, int[] downXPositions, int[] upXPositions, int yPos, int spriteWidth, int spriteHeight, float frameDuration, float moveSpeed = 100, float range = 200)'>40</a> | 54 | 1 :heavy_check_mark: | 0 | 3 | 22 / 18 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L13' title='int MovingSprite.curFrame'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L14' title='int[] MovingSprite.downFrameXPositions'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L106' title='void MovingSprite.Draw(SpriteBatch spriteBatch, Vector2 location)'>106</a> | 71 | 2 :heavy_check_mark: | 0 | 6 | 24 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L17' title='float MovingSprite.elapsedTime'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L12' title='int MovingSprite.frameCount'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L19' title='int MovingSprite.frameHeight'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L16' title='float MovingSprite.frameTime'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L18' title='int MovingSprite.frameWidth'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L20' title='int MovingSprite.frameY'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L24' title='bool MovingSprite.goingDown'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L23' title='float MovingSprite.maxY'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L22' title='float MovingSprite.minY'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L10' title='Vector2 MovingSprite.pos'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L26' title='Vector2 MovingSprite.Position'>26</a> | 94 | 2 :heavy_check_mark: | 0 | 1 | 9 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L11' title='Rectangle MovingSprite.rect'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L38' title='Rectangle MovingSprite.Rect'>38</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L21' title='float MovingSprite.speed'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L9' title='Texture2D MovingSprite.texture'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L36' title='Texture2D MovingSprite.Texture'>36</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L73' title='void MovingSprite.Update(GameTime gameTime)'>73</a> | 56 | 5 :heavy_check_mark: | 0 | 3 | 32 / 15 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L63' title='void MovingSprite.UpdateRect()'>63</a> | 87 | 1 :heavy_check_mark: | 0 | 3 | 9 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/MovingSprite.cs#L15' title='int[] MovingSprite.upFrameXPositions'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#MovingSprite-class-diagram">:link: to `MovingSprite` class diagram</a>

<a href="#sprint-sprites">:top: back to Sprint.Sprites</a>

</details>

<details>
<summary>
  <strong id="projectilesprite">
    ProjectileSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ProjectileSprite` contains 15 members.
- 61 total lines of source code.
- Approximately 18 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L24' title='ProjectileSprite.ProjectileSprite(Texture2D texture, Rectangle sourceRect, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale)'>24</a> | 65 | 1 :heavy_check_mark: | 0 | 3 | 11 / 8 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L19' title='float ProjectileSprite.distanceTraveled'>19</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L54' title='void ProjectileSprite.Draw(SpriteBatch sb, Vector2 unused)'>54</a> | 88 | 1 :heavy_check_mark: | 0 | 5 | 14 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L20' title='bool ProjectileSprite.isMoving'>20</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L14' title='float ProjectileSprite.maxDistance'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L16' title='Vector2 ProjectileSprite.origin'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L10' title='Vector2 ProjectileSprite.Position'>10</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L22' title='bool ProjectileSprite.ReachedMaxDistance'>22</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L15' title='float ProjectileSprite.rotation'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L17' title='float ProjectileSprite.scale'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L12' title='Rectangle ProjectileSprite.sourceRect'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L36' title='void ProjectileSprite.StartMoving()'>36</a> | 96 | 1 :heavy_check_mark: | 0 | 0 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L11' title='Texture2D ProjectileSprite.texture'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L41' title='void ProjectileSprite.Update(GameTime time)'>41</a> | 69 | 3 :heavy_check_mark: | 0 | 3 | 12 / 6 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/ProjectileSprite.cs#L13' title='Vector2 ProjectileSprite.velocity'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ProjectileSprite-class-diagram">:link: to `ProjectileSprite` class diagram</a>

<a href="#sprint-sprites">:top: back to Sprint.Sprites</a>

</details>

<details>
<summary>
  <strong id="staticsprite">
    StaticSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `StaticSprite` contains 10 members.
- 51 total lines of source code.
- Approximately 14 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L22' title='StaticSprite.StaticSprite(Texture2D texture, Vector2 position, Rectangle source)'>22</a> | 79 | 1 :heavy_check_mark: | 0 | 3 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L29' title='StaticSprite.StaticSprite(Texture2D texture, Vector2 position, Rectangle source, float scale)'>29</a> | 75 | 1 :heavy_check_mark: | 0 | 4 | 7 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L12' title='float? StaticSprite.customScale'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L41' title='void StaticSprite.Draw(SpriteBatch spriteBatch, Vector2 location)'>41</a> | 75 | 2 :heavy_check_mark: | 0 | 7 | 16 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L10' title='Vector2 StaticSprite.pos'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L14' title='Vector2 StaticSprite.Position'>14</a> | 98 | 2 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L11' title='Rectangle StaticSprite.sourceRect'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L9' title='Texture2D StaticSprite.texture'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L20' title='Texture2D StaticSprite.Texture'>20</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L37' title='void StaticSprite.Update(GameTime gameTime)'>37</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 3 / 0 |

<a href="#StaticSprite-class-diagram">:link: to `StaticSprite` class diagram</a>

<a href="#sprint-sprites">:top: back to Sprint.Sprites</a>

</details>

<details>
<summary>
  <strong id="textsprite">
    TextSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `TextSprite` contains 9 members.
- 45 total lines of source code.
- Approximately 12 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/TextSprite.cs#L23' title='TextSprite.TextSprite(Texture2D texture, Vector2 position)'>23</a> | 73 | 2 :heavy_check_mark: | 0 | 4 | 16 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/TextSprite.cs#L44' title='void TextSprite.Draw(SpriteBatch spriteBatch, Vector2 location)'>44</a> | 84 | 2 :heavy_check_mark: | 0 | 4 | 7 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/TextSprite.cs#L10' title='Vector2 TextSprite.pos'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/TextSprite.cs#L13' title='Vector2 TextSprite.Position'>13</a> | 98 | 2 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/TextSprite.cs#L11' title='Rectangle TextSprite.rect'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/TextSprite.cs#L21' title='Rectangle TextSprite.Rect'>21</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/TextSprite.cs#L9' title='Texture2D TextSprite.texture'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/TextSprite.cs#L19' title='Texture2D TextSprite.Texture'>19</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/TextSprite.cs#L40' title='void TextSprite.Update(GameTime gameTime)'>40</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 3 / 0 |

<a href="#TextSprite-class-diagram">:link: to `TextSprite` class diagram</a>

<a href="#sprint-sprites">:top: back to Sprint.Sprites</a>

</details>

</details>

<details>
<summary>
  <strong id="sprint-ui">
    Sprint.UI :x:
  </strong>
</summary>
<br>

The `Sprint.UI` namespace contains 6 named types.

- 6 named types.
- 229 total lines of source code.
- Approximately 41 lines of executable code.
- The highest cyclomatic complexity is 13 :x:.

<details>
<summary>
  <strong id="dungeonwalls">
    DungeonWalls :heavy_check_mark:
  </strong>
</summary>
<br>

- The `DungeonWalls` contains 26 members.
- 85 total lines of source code.
- Approximately 17 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L38' title='DungeonWalls.DungeonWalls(Texture2D texture)'>38</a> | 85 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L21' title='int DungeonWalls.BOTTOM_DOOR_LEFT'>21</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L22' title='int DungeonWalls.BOTTOM_DOOR_RIGHT'>22</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L23' title='int DungeonWalls.BOTTOM_DOOR_TOP'>23</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L30' title='int DungeonWalls.CENTER_BOTTOM'>30</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L31' title='int DungeonWalls.CENTER_LEFT'>31</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L32' title='int DungeonWalls.CENTER_RIGHT'>32</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L29' title='int DungeonWalls.CENTER_TOP'>29</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L44' title='void DungeonWalls.Draw(SpriteBatch spriteBatch)'>44</a> | 62 | 1 :heavy_check_mark: | 0 | 2 | 30 / 8 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L83' title='void DungeonWalls.DrawSection(SpriteBatch spriteBatch, int srcX, int srcY, int srcW, int srcH)'>83</a> | 75 | 1 :heavy_check_mark: | 0 | 5 | 6 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L36' title='float DungeonWalls.hudHeight'>36</a> | 88 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L75' title='Rectangle DungeonWalls.InnerBounds'>75</a> | 85 | 2 :heavy_check_mark: | 0 | 2 | 7 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L18' title='int DungeonWalls.LEFT_DOOR_BOTTOM'>18</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L19' title='int DungeonWalls.LEFT_DOOR_RIGHT'>19</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L17' title='int DungeonWalls.LEFT_DOOR_TOP'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L27' title='int DungeonWalls.RIGHT_DOOR_BOTTOM'>27</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L25' title='int DungeonWalls.RIGHT_DOOR_LEFT'>25</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L26' title='int DungeonWalls.RIGHT_DOOR_TOP'>26</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L10' title='float DungeonWalls.scale'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L35' title='int DungeonWalls.SHEET_HEIGHT'>35</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L34' title='int DungeonWalls.SHEET_WIDTH'>34</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L9' title='Texture2D DungeonWalls.texture'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L15' title='int DungeonWalls.TOP_DOOR_BOTTOM'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L13' title='int DungeonWalls.TOP_DOOR_LEFT'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L14' title='int DungeonWalls.TOP_DOOR_RIGHT'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L90' title='void DungeonWalls.Update(GameTime gameTime)'>90</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#DungeonWalls-class-diagram">:link: to `DungeonWalls` class diagram</a>

<a href="#sprint-ui">:top: back to Sprint.UI</a>

</details>

<details>
<summary>
  <strong id="hudbar">
    HUDBar :heavy_check_mark:
  </strong>
</summary>
<br>

- The `HUDBar` contains 7 members.
- 32 total lines of source code.
- Approximately 7 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L23' title='HUDBar.HUDBar(Texture2D backgroundTexture)'>23</a> | 75 | 1 :heavy_check_mark: | 0 | 7 | 6 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L16' title='StaticSprite HUDBar.background'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L30' title='void HUDBar.Draw(SpriteBatch spriteBatch)'>30</a> | 76 | 1 :heavy_check_mark: | 0 | 7 | 7 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L19' title='HeartDisplay HUDBar.hearts'>19</a> | 86 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L21' title='NumberDisplay HUDBar.rupeeCount'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L17' title='Rectangle HUDBar.sourceRect'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L38' title='void HUDBar.Update(GameTime gameTime)'>38</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 3 / 0 |

<a href="#HUDBar-class-diagram">:link: to `HUDBar` class diagram</a>

<a href="#sprint-ui">:top: back to Sprint.UI</a>

</details>

<details>
<summary>
  <strong id="numberdisplay">
    NumberDisplay :x:
  </strong>
</summary>
<br>

- The `NumberDisplay` contains 7 members.
- 39 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 13 :x:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/NumberDisplay.cs#L19' title='NumberDisplay.NumberDisplay(Texture2D backgroundTexture, Vector2 pos, int id)'>19</a> | 66 | 13 :x: | 0 | 4 | 21 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/NumberDisplay.cs#L13' title='StaticSprite NumberDisplay.background'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/NumberDisplay.cs#L17' title='int NumberDisplay.baseX'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/NumberDisplay.cs#L41' title='void NumberDisplay.Draw(SpriteBatch spriteBatch)'>41</a> | 88 | 1 :heavy_check_mark: | 0 | 5 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/NumberDisplay.cs#L15' title='Vector2 NumberDisplay.pos'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/NumberDisplay.cs#L14' title='Rectangle NumberDisplay.sourceRect'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/Hud/NumberDisplay.cs#L46' title='void NumberDisplay.Update(GameTime gameTime)'>46</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 3 / 0 |

<a href="#NumberDisplay-class-diagram">:link: to `NumberDisplay` class diagram</a>

<a href="#sprint-ui">:top: back to Sprint.UI</a>

</details>

<details>
<summary>
  <strong id="hudbar-state">
    HUDBar.State :heavy_check_mark:
  </strong>
</summary>
<br>

- The `HUDBar.State` contains 1 members.
- 4 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L14' title='State.UNFOCUSED'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#HUDBar.State-class-diagram">:link: to `HUDBar.State` class diagram</a>

<a href="#sprint-ui">:top: back to Sprint.UI</a>

</details>

<details>
<summary>
  <strong id="titlescreen">
    TitleScreen :heavy_check_mark:
  </strong>
</summary>
<br>

- The `TitleScreen` contains 5 members.
- 20 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/TitleScreen.cs#L13' title='TitleScreen.TitleScreen(Texture2D backgroundTexture)'>13</a> | 82 | 1 :heavy_check_mark: | 0 | 4 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/TitleScreen.cs#L10' title='StaticSprite TitleScreen.background'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/TitleScreen.cs#L19' title='void TitleScreen.Draw(SpriteBatch spriteBatch)'>19</a> | 90 | 1 :heavy_check_mark: | 0 | 5 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/TitleScreen.cs#L11' title='Rectangle TitleScreen.sourceRect'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/TitleScreen.cs#L24' title='void TitleScreen.Update(GameTime gameTime)'>24</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 3 / 0 |

<a href="#TitleScreen-class-diagram">:link: to `TitleScreen` class diagram</a>

<a href="#sprint-ui">:top: back to Sprint.UI</a>

</details>

<details>
<summary>
  <strong id="uimanager">
    UIManager :heavy_check_mark:
  </strong>
</summary>
<br>

- The `UIManager` contains 8 members.
- 40 total lines of source code.
- Approximately 8 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L12' title='UIManager.UIManager()'>12</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L33' title='void UIManager.AddElement(IUIElement element)'>33</a> | 97 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L43' title='void UIManager.Clear()'>43</a> | 100 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L27' title='void UIManager.Draw(SpriteBatch spriteBatch)'>27</a> | 94 | 2 :heavy_check_mark: | 0 | 5 | 5 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L10' title='List<IUIElement> UIManager.elements'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L16' title='T UIManager.GetElement<T>()'>16</a> | 88 | 1 :heavy_check_mark: | 0 | 3 | 4 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L38' title='void UIManager.RemoveElement(IUIElement element)'>38</a> | 97 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L21' title='void UIManager.Update(GameTime gameTime)'>21</a> | 94 | 2 :heavy_check_mark: | 0 | 5 | 5 / 1 |

<a href="#UIManager-class-diagram">:link: to `UIManager` class diagram</a>

<a href="#sprint-ui">:top: back to Sprint.UI</a>

</details>

</details>

<a href="#sprint">:top: back to Sprint</a>

## Metric definitions

  - **Maintainability index**: Measures ease of code maintenance. Higher values are better.
  - **Cyclomatic complexity**: Measures the number of branches. Lower values are better.
  - **Depth of inheritance**: Measures length of object inheritance hierarchy. Lower values are better.
  - **Class coupling**: Measures the number of classes that are referenced. Lower values are better.
  - **Lines of source code**: Exact number of lines of source code. Lower values are better.
  - **Lines of executable code**: Approximates the lines of executable code. Lower values are better.

## Mermaid class diagrams

<div id="GameplayState-class-diagram"></div>

##### `GameplayState` class diagram

```mermaid
classDiagram
IGameState <|-- GameplayState : implements
class GameplayState{
    -Texture2D linkSheet
    -Texture2D enemiesSheet
    -Texture2D BossesSheet
    -Texture2D dustSheet
    -Texture2D NPCSheet
    -Texture2D tileSheet
    -Texture2D dungeonBackground
    -Texture2D hudElements
    -Link link
    -Dictionary<Keys, ICommand> pressedKeys
    -ItemManager items
    -Inventory inventory
    -EnemyManager enemyManager
    -EnemyFactory enemyFactory
    -LevelLoader levelLoader
    -Level currentLevel
    -UIManager uiManager
    -CollisionManager collisionManager
    -bool lmbReleased
    -bool rmbReleased
    -DungeonWalls dungeonWalls
    +.ctor() GameplayState
    +Exit() void
    +Enter() void
    +LoadContent() void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch) void
}

```

<div id="GameServices-class-diagram"></div>

##### `GameServices` class diagram

```mermaid
classDiagram
class GameServices{
    +ContentManager Content$
    +IController KeyInput$
    +IGameActions GameActions$
    +float ScaleFactor$
    +int GameWidth$
    +int GameHeight$
    +Texture2D TileSheet$
    +Texture2D ItemSheet$
    +Texture2D BoomerangSheet$
    +ILink Link$
}

```

<div id="Level-class-diagram"></div>

##### `Level` class diagram

```mermaid
classDiagram
class Level{
    +BlockManager Blocks
    +EnemyManager Enemies
    +List<AbstractItem> WorldItems
    +.ctor(BlockManager blockManager, EnemyManager enemyManager) Level
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch) void
    +DrawOnTop(SpriteBatch spriteBatch) void
}

```

<div id="LevelBuilder-class-diagram"></div>

##### `LevelBuilder` class diagram

```mermaid
classDiagram
class LevelBuilder{
    -int TILE_SIZE$
    +Build(LevelData data, EnemyFactory enemyFactory)$ Level
}

```

<div id="LevelLoader-class-diagram"></div>

##### `LevelLoader` class diagram

```mermaid
classDiagram
class LevelLoader{
    -List<string> levels
    -int currentLevel
    +CycleNext() LevelData
    +CyclePrevious() LevelData
    +GetCurrentLevel() LevelData
    +Load(string levelName) LevelData
}

```

<div id="StartScreenState-class-diagram"></div>

##### `StartScreenState` class diagram

```mermaid
classDiagram
IGameState <|-- StartScreenState : implements
class StartScreenState{
    -UIManager uiManager
    -Texture2D titleSheet
    -TitleScreen titleScreen
    -Dictionary<Keys, ICommand> pressedKeys
    +.ctor() StartScreenState
    +Exit() void
    +Enter() void
    +LoadContent() void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch) void
}

```

<div id="Enemy-class-diagram"></div>

##### `Enemy` class diagram

```mermaid
classDiagram
IEnemy <|-- Enemy : implements
class Enemy{
    -IPositionedSprite sprite
    -Vector2 position
    -Texture2D texture
    -int health
    -int maxHealth
    -int damage
    -bool isAlive
    -bool isInvincible
    -float dyingTimer
    -float DYING_DURATION$
    -Random random
    +bool FlipsOnVertical
    +Vector2 Position
    +int Health
    +Texture2D Texture
    +Rectangle Rect
    +int MaxHealth
    +int Damage
    +bool IsAlive
    +.ctor(Texture2D texture, Vector2 position, int health, int damage, bool isInvincible = false) Enemy
    +TakeDamage(int damageAmount) void
    +Die() void
    +Reset() void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
    +ChooseValidStep(List<Block> solidBlocks, float stepSize, int minSteps = 1, int maxSteps = 2, int maxAttempts = 4) Vector2
}

```

<div id="Block-class-diagram"></div>

##### `Block` class diagram

```mermaid
classDiagram
class Block{
    -int tileWidth
    -StaticSprite sprite
    -bool walkAble
    -Vector2 position
    -bool pushAble
    +Rectangle Rect
    +Vector2 Position
    +.ctor(Texture2D texture, Vector2 pos, Rectangle sourceRect, bool walkable, bool pushable) Block
    +Draw(SpriteBatch spriteBatch) void
    +Update(GameTime time) void
}

```

<div id="BlockFactory-class-diagram"></div>

##### `BlockFactory` class diagram

```mermaid
classDiagram
class BlockFactory{
    -int SHEET_COLUMNS$
    -int TILE_SIZE$
    -int TILE_SPACING$
    +Create(int tileId, Vector2 pos)$ Block
    +CreateBlock(BlockType type, Vector2 pos)$ Block
}

```

<div id="BlockManager-class-diagram"></div>

##### `BlockManager` class diagram

```mermaid
classDiagram
class BlockManager{
    -List<Block> blocks
    +List<Block> blocksList
    +Add(Block block) void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch) void
}

```

<div id="BlockFactory.BlockType-class-diagram"></div>

##### `BlockFactory.BlockType` class diagram

```mermaid
classDiagram
class BlockType{
    -Blank$
    -Square$
    -StatueRight$
    -StatueLeft$
    -Black$
    -Sand$
    -Water$
    -Stairs$
    -Bricks$
    -Ladder$
}

```

<div id="Attacking-class-diagram"></div>

##### `Attacking` class diagram

```mermaid
classDiagram
ISprite <|-- Attacking : implements
class Attacking{
    -Texture2D texture
    -SpriteEffects effect
    -Frame[] frames
    -double secondsPerFrame
    -double totalAttackSeconds
    -Action onFinished
    -int currentFrame
    -double timer
    -double totalTimer
    -bool finished
    +.ctor(Texture2D texture, SpriteEffects effect, Frame[] frames, double secondsPerFrame, double totalAttackSeconds, Action onFinished) Attacking
    +Reset() void
    +Update(GameTime gameTime) void
    +GetWeaponWorldRect(Vector2 position) Rectangle
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="Directions-class-diagram"></div>

##### `Directions` class diagram

```mermaid
classDiagram
class Directions{
    -Left$
    -Right$
    -Up$
    -Down$
}

```

<div id="DirectionsUtils-class-diagram"></div>

##### `DirectionsUtils` class diagram

```mermaid
classDiagram
class DirectionsUtils{
    +CreateVector(Directions direction, float magnitude)$ Vector2
}

```

<div id="Attacking.Frame-class-diagram"></div>

##### `Attacking.Frame` class diagram

```mermaid
classDiagram
class Frame{
    -Rectangle BodyRect
    -Rectangle WeaponRect
    -Vector2 WeaponOffset
    +bool HasWeapon
    +.ctor(Rectangle bodyRect) Frame
    +.ctor(Rectangle bodyRect, Rectangle weaponRect, Vector2 weaponOffset) Frame
}

```

<div id="PickUpItem.Frame-class-diagram"></div>

##### `PickUpItem.Frame` class diagram

```mermaid
classDiagram
class Frame{
    -Rectangle BodyRect
    -Rectangle? ItemRect
    -Vector2 ItemOffset
    +.ctor(Rectangle bodyRect) Frame
    +.ctor(Rectangle bodyRect, Rectangle itemRect, Vector2 itemOffset) Frame
}

```

<div id="UseItem.Frame-class-diagram"></div>

##### `UseItem.Frame` class diagram

```mermaid
classDiagram
class Frame{
    -Rectangle BodyRect
    +.ctor(Rectangle bodyRect) Frame
}

```

<div id="Idle-class-diagram"></div>

##### `Idle` class diagram

```mermaid
classDiagram
ISprite <|-- Idle : implements
class Idle{
    -Texture2D texture
    -Rectangle sourceRect
    -SpriteEffects effect
    +.ctor(Texture2D texture, Rectangle sourceRect, SpriteEffects effect) Idle
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="Link-class-diagram"></div>

##### `Link` class diagram

```mermaid
classDiagram
ILink <|-- Link : implements
class Link{
    -float SPEED$
    -int BODY_SIZE$
    -int HAND_X$
    -int HAND_Y$
    -double DAMAGED_DURATION$
    -double BLINK_INTERVAL$
    -int MAX_HEALTH$
    -ISprite IdleUp
    -ISprite IdleDown
    -ISprite IdleLeft
    -ISprite IdleRight
    -ISprite WalkUp
    -ISprite WalkDown
    -ISprite WalkLeft
    -ISprite WalkRight
    -Attacking AttackUp
    -Attacking AttackDown
    -Attacking AttackLeft
    -Attacking AttackRight
    -UseItem UseItemUp
    -UseItem UseItemDown
    -UseItem UseItemLeft
    -UseItem UseItemRight
    -PickUpItem PickUpWeapon
    -PickUpItem PickUpTriforce
    -ISprite sprite
    -Vector2 position
    -Vector2 move
    -Directions direction
    -double damagedTimer
    -int health
    -int rubies
    -bool isAttacking
    -bool isUsingItem
    -bool isDamaged
    -bool isVisible
    -bool attackHitLanded
    -Rectangle? pickUpItemRect
    +Directions Facing
    +int Health
    +int MaxHealth
    +Rectangle Rect
    +Rectangle SwordRect
    +Vector2 Position
    +int Rubies
    +RegisterSwordHit() void
    +.ctor(Texture2D texture, Vector2 position) Link
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch) void
    +StartUseItem() void
    +StartPickUpWeapon(Rectangle itemRect) void
    +StartPickUpTriforce() void
    +SetMove(Directions dir) void
    +StopMove() void
    +StartAttack() void
    +TakeDamage(int amount) void
    +StartDamaged() void
    +FinishAttack() void
    +FinishPickUpItem() void
    +FinishUseItem() void
    +GetHealed(int amount) void
    +IncreaseRubies(int amount) void
    +SetIdleSprite() void
}

```

<div id="LinkFactory-class-diagram"></div>

##### `LinkFactory` class diagram

```mermaid
classDiagram
class LinkFactory{
    +IdleDown(Texture2D texture)$ ISprite
    +IdleUp(Texture2D texture)$ ISprite
    +IdleLeft(Texture2D texture)$ ISprite
    +IdleRight(Texture2D texture)$ ISprite
    +WalkingDown(Texture2D texture)$ ISprite
    +WalkingUp(Texture2D texture)$ ISprite
    +WalkingLeft(Texture2D texture)$ ISprite
    +WalkingRight(Texture2D texture)$ ISprite
    +UseItemDown(Texture2D texture, Action onFinished)$ UseItem
    +UseItemUp(Texture2D texture, Action onFinished)$ UseItem
    +UseItemLeft(Texture2D texture, Action onFinished)$ UseItem
    +UseItemRight(Texture2D texture, Action onFinished)$ UseItem
    +PickUpWeapon(Texture2D texture, Action onFinished)$ PickUpItem
    +PickUpTriforce(Texture2D texture, Action onFinished)$ PickUpItem
    +AttackDown(Texture2D texture, Action onFinished)$ Attacking
    +AttackUp(Texture2D texture, Action onFinished)$ Attacking
    +AttackLeft(Texture2D texture, Action onFinished)$ Attacking
    +AttackRight(Texture2D texture, Action onFinished)$ Attacking
}

```

<div id="PickUpItem-class-diagram"></div>

##### `PickUpItem` class diagram

```mermaid
classDiagram
ISprite <|-- PickUpItem : implements
class PickUpItem{
    -Texture2D texture
    -SpriteEffects effect
    -Frame[] frames
    -double secondsPerFrame
    -double totalItemSeconds
    -Action onFinished
    -int currentFrame
    -double timer
    -double totalTimer
    -bool finished
    +.ctor(Texture2D texture, SpriteEffects effect, Frame[] frames, double secondsPerFrame, double totalItemSeconds, Action onFinished) PickUpItem
    +Reset() void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="UseItem-class-diagram"></div>

##### `UseItem` class diagram

```mermaid
classDiagram
ISprite <|-- UseItem : implements
class UseItem{
    -Texture2D texture
    -SpriteEffects effect
    -Frame[] frames
    -double secondsPerFrame
    -double totalItemSeconds
    -Action onFinished
    -int currentFrame
    -double timer
    -double totalTimer
    -bool finished
    +.ctor(Texture2D texture, SpriteEffects effect, Frame[] frames, double secondsPerFrame, double totalItemSeconds, Action onFinished) UseItem
    +Reset() void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="Walking-class-diagram"></div>

##### `Walking` class diagram

```mermaid
classDiagram
ISprite <|-- Walking : implements
class Walking{
    -Texture2D texture
    -SpriteEffects effect
    -Rectangle[] frames
    -double secondsPerFrame
    -int currentFrame
    -double timer
    +.ctor(Texture2D texture, SpriteEffects effect, Rectangle[] frames, double secondsPerFrame) Walking
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="ActiveItemEnemyCollision-class-diagram"></div>

##### `ActiveItemEnemyCollision` class diagram

```mermaid
classDiagram
ICollisionHandler <|-- ActiveItemEnemyCollision : implements
class ActiveItemEnemyCollision{
    -int PROJECTILE_DAMAGE$
    -int BOMB_DAMAGE$
    -int BOMB_RADIUS$
    -ItemManager itemManager
    -EnemyManager enemyManager
    +.ctor(ItemManager itemManager, EnemyManager enemyManager) ActiveItemEnemyCollision
    +Handle() void
}

```

<div id="CollisionManager-class-diagram"></div>

##### `CollisionManager` class diagram

```mermaid
classDiagram
class CollisionManager{
    -List<ICollisionHandler> handlers
    +Add(ICollisionHandler handler) void
    +HandleAll() void
}

```

<div id="LinkEnemyCollision-class-diagram"></div>

##### `LinkEnemyCollision` class diagram

```mermaid
classDiagram
ICollisionHandler <|-- LinkEnemyCollision : implements
class LinkEnemyCollision{
    -Link link
    -EnemyManager enemyManager
    +.ctor(Link link, EnemyManager enemyManager) LinkEnemyCollision
    +Handle() void
}

```

<div id="LinkEnemyProjectileCollision-class-diagram"></div>

##### `LinkEnemyProjectileCollision` class diagram

```mermaid
classDiagram
ICollisionHandler <|-- LinkEnemyProjectileCollision : implements
class LinkEnemyProjectileCollision{
    -int PROJECTILE_DAMAGE$
    -Link link
    -EnemyManager enemyManager
    +.ctor(Link link, EnemyManager enemyManager) LinkEnemyProjectileCollision
    +Handle() void
}

```

<div id="LinkItemCollision-class-diagram"></div>

##### `LinkItemCollision` class diagram

```mermaid
classDiagram
ICollisionHandler <|-- LinkItemCollision : implements
class LinkItemCollision{
    -ILink link
    -Inventory inventory
    -List<AbstractItem> worldItems
    +.ctor(ILink link, Inventory inventory, List<AbstractItem> worldItems) LinkItemCollision
    +Handle() void
    +HandlePickup(AbstractItem item) void
}

```

<div id="SwordEnemyCollision-class-diagram"></div>

##### `SwordEnemyCollision` class diagram

```mermaid
classDiagram
ICollisionHandler <|-- SwordEnemyCollision : implements
class SwordEnemyCollision{
    -int SWORD_DAMAGE$
    -Link link
    -EnemyManager enemyManager
    +.ctor(Link link, EnemyManager enemyManager) SwordEnemyCollision
    +Handle() void
}

```

<div id="EnemyBlockCollisionHandler-class-diagram"></div>

##### `EnemyBlockCollisionHandler` class diagram

```mermaid
classDiagram
ICollisionHandler <|-- EnemyBlockCollisionHandler : implements
class EnemyBlockCollisionHandler{
    -List<IEnemy> enemies
    -BlockManager blockManager
    +.ctor(List<IEnemy> enemies, BlockManager blockManager) EnemyBlockCollisionHandler
    +Handle() void
    +ResolveCollision(IEnemy enemy, Block block)$ void
}

```

<div id="EnemyWallCollisionHandler-class-diagram"></div>

##### `EnemyWallCollisionHandler` class diagram

```mermaid
classDiagram
ICollisionHandler <|-- EnemyWallCollisionHandler : implements
class EnemyWallCollisionHandler{
    -List<IEnemy> enemies
    -DungeonWalls dungeonWalls
    +.ctor(List<IEnemy> enemies, DungeonWalls dungeonWalls) EnemyWallCollisionHandler
    +Handle() void
    +ResolveCollision(IEnemy enemy, DungeonWalls dungeonWalls)$ void
}

```

<div id="LinkBlockCollisionHandler-class-diagram"></div>

##### `LinkBlockCollisionHandler` class diagram

```mermaid
classDiagram
ICollisionHandler <|-- LinkBlockCollisionHandler : implements
class LinkBlockCollisionHandler{
    -ILink link
    -BlockManager blockManager
    +.ctor(ILink link, BlockManager blockManager) LinkBlockCollisionHandler
    +Handle() void
    +ResolveCollision(ILink link, Block block)$ void
}

```

<div id="LinkBlockPushHandler-class-diagram"></div>

##### `LinkBlockPushHandler` class diagram

```mermaid
classDiagram
ICollisionHandler <|-- LinkBlockPushHandler : implements
class LinkBlockPushHandler{
    -ILink link
    -BlockManager blockManager
    -Rectangle PushableStatueSource$
    -Rectangle FloorSource$
    +.ctor(ILink link, BlockManager blockManager) LinkBlockPushHandler
    +Handle() void
    +ResolvePush(ILink link, Block block) void
}

```

<div id="LinkWallCollisionHandler-class-diagram"></div>

##### `LinkWallCollisionHandler` class diagram

```mermaid
classDiagram
ICollisionHandler <|-- LinkWallCollisionHandler : implements
class LinkWallCollisionHandler{
    -ILink link
    -DungeonWalls dungeonWalls
    +.ctor(ILink link, DungeonWalls dungeonWalls) LinkWallCollisionHandler
    +Handle() void
    +ResolveCollision(ILink link, DungeonWalls dungeonWalls)$ void
}

```

<div id="CycleEnemyCommand-class-diagram"></div>

##### `CycleEnemyCommand` class diagram

```mermaid
classDiagram
ICommand <|-- CycleEnemyCommand : implements
class CycleEnemyCommand{
    -EnemyManager enemyManager
    -bool forward
    +.ctor(EnemyManager enemyManager, bool forward) CycleEnemyCommand
    +Execute() void
}

```

<div id="CycleItemCommand-class-diagram"></div>

##### `CycleItemCommand` class diagram

```mermaid
classDiagram
ICommand <|-- CycleItemCommand : implements
class CycleItemCommand{
    -Inventory inventory
    -bool forward
    +.ctor(Inventory inventory, bool forward) CycleItemCommand
    +Execute() void
}

```

<div id="QuitCommand-class-diagram"></div>

##### `QuitCommand` class diagram

```mermaid
classDiagram
ICommand <|-- QuitCommand : implements
class QuitCommand{
    +Execute() void
}

```

<div id="SetStateCommand-class-diagram"></div>

##### `SetStateCommand` class diagram

```mermaid
classDiagram
ICommand <|-- SetStateCommand : implements
class SetStateCommand{
    -IGameState newState
    +.ctor(IGameState newState) SetStateCommand
    +Execute() void
}

```

<div id="UseItemCommand-class-diagram"></div>

##### `UseItemCommand` class diagram

```mermaid
classDiagram
ICommand <|-- UseItemCommand : implements
class UseItemCommand{
    -ItemManager itemManager
    -Inventory inventory
    -ILink link
    -int slot
    +.ctor(ItemManager itemManager, Inventory inventory, ILink link, int slot) UseItemCommand
    +Execute() void
}

```

<div id="Aquamentus-class-diagram"></div>

##### `Aquamentus` class diagram

```mermaid
classDiagram
class Aquamentus{
    -int HEALTH$
    -int DAMAGE$
    -Vector2 velocity
    -float MOVE_SPEED$
    -float directionChangeTimer
    -float DIRECTION_SWAP_MIN$
    -float DIRECTION_SWAP_MAX$
    -float moveDirectionTimer
    -bool moveLeft
    -EnemyProjectileFactory projectileFactory
    -List<AquamentusFireball> activeFireballs
    -float fireballTimer
    -float FIREBALL_INTERVAL$
    +IReadOnlyList<AquamentusFireball> ActiveFireballs
    +.ctor(Texture2D texture, Vector2 position) Aquamentus
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
    +SpawnFireballs() void
    +GetRandomFloat(float min, float max) float
}

```

<div id="AquamentusFireball-class-diagram"></div>

##### `AquamentusFireball` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- AquamentusFireball : implements
class AquamentusFireball{
    -IPositionedSprite sprite
    -Vector2 position
    -Vector2 velocity
    -float lifetime
    -float MAX_LIFETIME$
    -float SPEED$
    -int SOURCE_WIDTH$
    -int SOURCE_HEIGHT$
    +bool IsActive
    +Rectangle Rect
    +Vector2 Position
    +.ctor(Texture2D texture, Vector2 startPosition, Vector2 direction) AquamentusFireball
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="Dodongo.Direction-class-diagram"></div>

##### `Dodongo.Direction` class diagram

```mermaid
classDiagram
class Direction{
    -Up$
    -Down$
    -Left$
    -Right$
}

```

<div id="Goriya.Direction-class-diagram"></div>

##### `Goriya.Direction` class diagram

```mermaid
classDiagram
class Direction{
    -Up$
    -Down$
    -Left$
    -Right$
}

```

<div id="Dodongo-class-diagram"></div>

##### `Dodongo` class diagram

```mermaid
classDiagram
class Dodongo{
    -DodongoState currentState
    -int HEALTH$
    -int DAMAGE$
    -float STEP_SIZE$
    -float STEP_DELAY$
    -float MOVE_SPEED$
    -float FLIP_INTERVAL$
    -float BOMB_STUN_DURATION$
    -Direction currentDirection
    -Vector2 targetPosition
    -float stepTimer
    -float flipTimer
    -float bombStunTimer
    -bool spriteHorizontalFlip
    -int[] upFrames
    -int[] downFrames
    -int[] sideFrames
    -int[] bombedUpFrame
    -int[] bombedDownFrame
    -int[] bombedSideFrame
    -List<Block> solidBlocks
    +bool FlipsOnVertical
    +.ctor(Texture2D texture, Vector2 position, List<Block> solidBlocks) Dodongo
    +Update(GameTime gameTime) void
    +UpdateWalking(float deltaTime) void
    +UpdateBombEaten(float deltaTime) void
    +EatBomb() void
    +ChooseNextStep() void
    +GetDirectionTo(Vector2 target) Direction
    +UpdateSprite() void
    +UpdateBombedSprite(DirectionalAnimatedSprite dirSprite, int sheetY, float frameTime) void
    +UpdateWalkingSprite(DirectionalAnimatedSprite dirSprite, int sheetY, float frameTime) void
    +Reset() void
}

```

<div id="Dodongo.DodongoState-class-diagram"></div>

##### `Dodongo.DodongoState` class diagram

```mermaid
classDiagram
class DodongoState{
    -Walking$
    -BombEaten$
}

```

<div id="Gel-class-diagram"></div>

##### `Gel` class diagram

```mermaid
classDiagram
class Gel{
    -int HEALTH$
    -int DAMAGE$
    -Vector2 velocity
    -float turnTimer
    -float TURN_SPEED$
    -float TURN_INTERVAL$
    -float MOVE_SPEED$
    +.ctor(Texture2D texture, Vector2 position) Gel
    +Update(GameTime gameTime) void
    +Reset() void
    +GetRandomTurnDirection() Vector2
}

```

<div id="Goriya-class-diagram"></div>

##### `Goriya` class diagram

```mermaid
classDiagram
class Goriya{
    -GoriyaState currentState
    -int HEALTH$
    -int DAMAGE$
    -float STEP_SIZE$
    -float STEP_DELAY$
    -float MOVE_SPEED$
    -float THROW_COOLDOWN_MIN$
    -float THROW_COOLDOWN_MAX$
    -List<Block> solidBlocks
    -Direction currentDirection
    -Vector2 targetPosition
    -float stepTimer
    -float throwTimer
    -bool spriteHorizontalFlip
    -float flipTimer
    -float FLIP_INTERVAL$
    -Boomerang activeBoomerang
    -ContentManager contentManager
    -int[] upFrames
    -int[] downFrames
    -int[] sideFrames
    -int[] throwFrame
    +Boomerang ActiveBoomerang
    +bool FlipsOnVertical
    +.ctor(Texture2D texture, Vector2 position, ContentManager content, List<Block> solidBlocks) Goriya
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
    +UpdateWalking(float deltaTime) void
    +UpdateThrowing(float deltaTime) void
    +ThrowBoomerang() void
    +IsBoomerangActive() bool
    +ChooseNextStep() void
    +GetDirectionTo(Vector2 target) Direction
    +UpdateSprite() void
    +GetRandomThrowTime() float
}

```

<div id="Goriya.GoriyaState-class-diagram"></div>

##### `Goriya.GoriyaState` class diagram

```mermaid
classDiagram
class GoriyaState{
    -Walking$
    -Throwing$
}

```

<div id="Keese-class-diagram"></div>

##### `Keese` class diagram

```mermaid
classDiagram
class Keese{
    -int HEALTH$
    -int DAMAGE$
    -float MOVE_SPEED$
    -float REST_TIME_MIN$
    -float REST_TIME_MAX$
    -float MOVE_TIME_MIN$
    -float MOVE_TIME_MAX$
    -Vector2 moveDirection
    -float actionTimer
    -float actionDuration
    -bool isResting
    -IPositionedSprite flyingSprite
    -IPositionedSprite restingSprite
    +.ctor(Texture2D texture, Vector2 position) Keese
    +Update(GameTime gameTime) void
    +ChooseRandomDirection() void
    +GetRandomFloat(float min, float max) float
}

```

<div id="OldMan-class-diagram"></div>

##### `OldMan` class diagram

```mermaid
classDiagram
class OldMan{
    -int HEALTH$
    -int DAMAGE$
    +.ctor(Texture2D texture, Vector2 position) OldMan
    +TakeDamage(int damageAmount) void
    +Die() void
}

```

<div id="Rope-class-diagram"></div>

##### `Rope` class diagram

```mermaid
classDiagram
class Rope{
    -int ROPE_HEALTH$
    -int ROPE_DAMAGE$
    -float PATROL_SPEED$
    -float CHARGE_SPEED$
    -float DIRECTION_CHANGE_MIN$
    -float DIRECTION_CHANGE_MAX$
    -float CHARGE_DURATION$
    -Vector2 moveDirection
    -bool isCharging
    -float chargeTimer
    -float directionChangeTimer
    -float directionChangeDuration
    -bool facingLeft
    -int[] frameXPositions
    +.ctor(Texture2D texture, Vector2 position) Rope
    +Update(GameTime gameTime) void
    +ChooseRandomCardinalDirection() void
    +UpdateSpriteFlip() void
    +GetRandomFloat(float min, float max) float
}

```

<div id="Stalfos-class-diagram"></div>

##### `Stalfos` class diagram

```mermaid
classDiagram
class Stalfos{
    -int STALFOS_HEALTH$
    -int STALFOS_DAMAGE$
    -float MOVE_SPEED$
    -Vector2 velocity
    -float directionChangeTimer
    -float DIRECTION_CHANGE_INTERVAL$
    -Rectangle sourceRect
    -bool isFlipped
    -float flipTimer
    -float FLIP_INTERVAL$
    +.ctor(Texture2D texture, Vector2 position) Stalfos
    +GetRandomCardinalDirection() Vector2
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="Trap-class-diagram"></div>

##### `Trap` class diagram

```mermaid
classDiagram
class Trap{
    -int TRAP_HEALTH$
    -int TRAP_DAMAGE$
    -float CHARGE_SPEED$
    -float RETRACT_SPEED$
    -TrapState currentState
    -Vector2 homePosition
    -Vector2 chargeDirection
    -Vector2 chargeTarget
    -bool sameRow
    -bool sameColumn
    +.ctor(Texture2D texture, Vector2 position) Trap
    +Update(GameTime gameTime) void
    +UpdateIdle() void
    +UpdateCharging(float deltaTime) void
    +UpdateRetracting(float deltaTime) void
    +StartCharge() void
    +TakeDamage(int damageAmount) void
    +Die() void
    +Reset() void
}

```

<div id="Trap.TrapState-class-diagram"></div>

##### `Trap.TrapState` class diagram

```mermaid
classDiagram
class TrapState{
    -Idle$
    -Charging$
    -Retracting$
}

```

<div id="WallMaster-class-diagram"></div>

##### `WallMaster` class diagram

```mermaid
classDiagram
class WallMaster{
    -int WALLMASTER_HEALTH$
    -int WALLMASTER_DAMAGE$
    -float CREEP_SPEED$
    -float DETECTION_RANGE$
    -float GRAB_RANGE$
    -float ENTER_SPEED$
    -WallMasterState currentState
    -Vector2 homePosition
    -Vector2 entryStart
    -Vector2 entryTarget
    -bool movingVertically
    +bool IsEntering
    +.ctor(Texture2D texture, Vector2 position) WallMaster
    +DetermineEntryDirection(Vector2 spawnPosition) Vector2
    +Update(GameTime gameTime) void
    +UpdateEntering(float deltaTime) void
    +UpdateCreeping(float deltaTime) void
    +UpdateGrabbing() void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
    +Reset() void
}

```

<div id="WallMaster.WallMasterState-class-diagram"></div>

##### `WallMaster.WallMasterState` class diagram

```mermaid
classDiagram
class WallMasterState{
    -Entering$
    -Creeping$
    -Grabbing$
}

```

<div id="Zol-class-diagram"></div>

##### `Zol` class diagram

```mermaid
classDiagram
class Zol{
    -int ZOL_HEALTH$
    -int ZOL_DAMAGE$
    -float BOUNCE_SPEED$
    -float BOUNCE_INTERVAL$
    -float AIR_TIME$
    -Vector2 velocity
    -float bounceTimer
    -bool isOnGround
    +.ctor(Texture2D texture, Vector2 position) Zol
    +Update(GameTime gameTime) void
    +Reset() void
    +GetRandomBounceDirection() Vector2
}

```

<div id="KeyboardController-class-diagram"></div>

##### `KeyboardController` class diagram

```mermaid
classDiagram
IController <|-- KeyboardController : implements
class KeyboardController{
    -KeyboardState previous
    -KeyboardState current
    +.ctor() KeyboardController
    +Update() void
    +IsKeyPressed(Keys key) bool
    +IsKeyDown(Keys key) bool
    +IsKeyReleased(Keys key) bool
    +IsKeyUp(Keys key) bool
    +Reset() void
}

```

<div id="EnemyEffectWrapper-class-diagram"></div>

##### `EnemyEffectWrapper` class diagram

```mermaid
classDiagram
IEnemy <|-- EnemyEffectWrapper : implements
class EnemyEffectWrapper{
    -IEnemy enemy
    -ISprite spawnSprite
    -ISprite deathSprite
    -float spawnTimer
    -float dyingTimer
    -float SPAWN_DURATION$
    -float DYING_DURATION$
    +IEnemy InnerEnemy
    +bool IsSpawningPublic
    +Vector2 Position
    +Rectangle Rect
    +int Health
    +bool IsSpawning
    +int MaxHealth
    +int Damage
    +bool IsAlive
    +bool IsDyingAnimation
    +.ctor(IEnemy enemy, ISprite spawnSprite, ISprite deathSprite) EnemyEffectWrapper
    +TakeDamage(int amount) void
    +Die() void
    +ToString() string
    +ResetSpawnTimer() void
    +Reset() void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="EnemyFactory-class-diagram"></div>

##### `EnemyFactory` class diagram

```mermaid
classDiagram
class EnemyFactory{
    -Texture2D enemySpriteSheet
    -Texture2D bossSpriteSheet
    -Texture2D linkSheet
    -Texture2D dustSheet
    -Texture2D NPCSheet
    -ContentManager contentManager
    +.ctor(Texture2D enemySpriteSheet, Texture2D bossSpriteSheet, Texture2D linkSheet, Texture2D dustSheet, Texture2D NPCSheet) EnemyFactory
    +LoadAllTextures(ContentManager content) void
    +CreateEnemy(EnemyType type, Vector2 position, List<Block> solidBlocks = null) IEnemy
    +WrapWithEffects(IEnemy enemy, Vector2 position, bool skipSpawnCloud = false) EnemyEffectWrapper
}

```

<div id="EnemyManager-class-diagram"></div>

##### `EnemyManager` class diagram

```mermaid
classDiagram
class EnemyManager{
    -List<IEnemy> enemies
    -int currentEnemyIndex
    -IEnemy currentEnemy
    +List<IEnemy> enemyList
    +.ctor() EnemyManager
    +AddEnemy(IEnemy enemy) void
    +CycleNext() void
    +CyclePrevious() void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch) void
    +DrawOnTop(SpriteBatch spriteBatch) void
    +DrawBehindBlocks(SpriteBatch spriteBatch) void
    +Reset() void
    +GetCurrentEnemy() IEnemy
    +GetEnemyCount() int
    +GetCurrentIndex() int
}

```

<div id="EnemyProjectileFactory-class-diagram"></div>

##### `EnemyProjectileFactory` class diagram

```mermaid
classDiagram
class EnemyProjectileFactory{
}

```

<div id="EnemyType-class-diagram"></div>

##### `EnemyType` class diagram

```mermaid
classDiagram
class EnemyType{
    -Keese$
    -Stalfos$
    -Gel$
    -Zol$
    -Goriya$
    -WallMaster$
    -Trap$
    -Rope$
    -Aquamentus$
    -Dodongo$
    -OldMan$
}

```

<div id="ProjectileType-class-diagram"></div>

##### `ProjectileType` class diagram

```mermaid
classDiagram
class ProjectileType{
    -AquamentusFireball$
}

```

<div id="HeartDisplay-class-diagram"></div>

##### `HeartDisplay` class diagram

```mermaid
classDiagram
class HeartDisplay{
    -float HEART_WIDTH$
    -float GAP$
    -float SCALE$
    -Vector2 origin
    -int capacity
    -List<StillItem> emptyHearts
    -List<StillItem> halfHearts
    -List<StillItem> fullHearts
    +.ctor(Vector2 origin, int capacity) HeartDisplay
    +Draw(int hearts, bool halfHeart, int maxHearts, SpriteBatch sb) void
}

```

<div id="ICollisionHandler-class-diagram"></div>

##### `ICollisionHandler` class diagram

```mermaid
classDiagram
class ICollisionHandler{
    +Handle()* void
}

```

<div id="ICommand-class-diagram"></div>

##### `ICommand` class diagram

```mermaid
classDiagram
class ICommand{
    +Execute()* void
}

```

<div id="IController-class-diagram"></div>

##### `IController` class diagram

```mermaid
classDiagram
class IController{
    +Update()* void
    +Reset()* void
    +IsKeyDown(Keys key)* bool
    +IsKeyPressed(Keys key)* bool
    +IsKeyReleased(Keys key)* bool
}

```

<div id="IEnemy-class-diagram"></div>

##### `IEnemy` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- IEnemy : implements
class IEnemy{
    +Rectangle Rect*
    +int Health*
    +int MaxHealth*
    +int Damage*
    +bool IsAlive*
    +TakeDamage(int damageAmount)* void
    +Die()* void
    +Reset()* void
}

```

<div id="IGameActions-class-diagram"></div>

##### `IGameActions` class diagram

```mermaid
classDiagram
class IGameActions{
    +Quit()* void
    +ChangeState(IGameState newState)* void
}

```

<div id="IGameState-class-diagram"></div>

##### `IGameState` class diagram

```mermaid
classDiagram
class IGameState{
    +Enter()* void
    +Exit()* void
    +LoadContent()* void
    +Update(GameTime gameTime)* void
    +Draw(SpriteBatch spriteBatch)* void
}

```

<div id="IItem-class-diagram"></div>

##### `IItem` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- IItem : implements
class IItem{
    +string Name*
    +Rectangle Rect*
    +bool IsCollected*
    +OnCollect(ILink link)* void
}

```

<div id="ILink-class-diagram"></div>

##### `ILink` class diagram

```mermaid
classDiagram
class ILink{
    +Vector2 Position*
    +Rectangle Rect*
    +Directions Facing*
    +int Health*
    +int MaxHealth*
    +Rectangle SwordRect*
    +StartAttack()* void
    +StartUseItem()* void
    +StartPickUpWeapon(Rectangle itemRect)* void
    +StartPickUpTriforce()* void
    +TakeDamage(int amount)* void
    +GetHealed(int amount)* void
    +IncreaseRubies(int amount)* void
}

```

<div id="IPositionedSprite-class-diagram"></div>

##### `IPositionedSprite` class diagram

```mermaid
classDiagram
ISprite <|-- IPositionedSprite : implements
class IPositionedSprite{
    +Vector2 Position*
}

```

<div id="ISprite-class-diagram"></div>

##### `ISprite` class diagram

```mermaid
classDiagram
class ISprite{
    +Draw(SpriteBatch spriteBatch, Vector2 location)* void
    +Update(GameTime gameTime)* void
}

```

<div id="IUIElement-class-diagram"></div>

##### `IUIElement` class diagram

```mermaid
classDiagram
class IUIElement{
    +Draw(SpriteBatch spriteBatch)* void
    +Update(GameTime gameTime)* void
}

```

<div id="AbstractItem-class-diagram"></div>

##### `AbstractItem` class diagram

```mermaid
classDiagram
IItem <|-- AbstractItem : implements
class AbstractItem{
    -Texture2D texture
    -Vector2 position
    -ISprite sprite
    +Vector2 Position
    +string Name
    +Rectangle Rect
    +Rectangle SourceRect
    +bool IsCollected
    +bool IsFinished
    +.ctor(string name, Texture2D texture, Vector2 position) AbstractItem
    +OnCollect(ILink link) void
    +Draw(SpriteBatch sb, Vector2 location) void
    +Update(GameTime time) void
}

```

<div id="Arrow-class-diagram"></div>

##### `Arrow` class diagram

```mermaid
classDiagram
class Arrow{
    -int HITBOX_SIZE$
    -bool hitEnemy
    +bool IsFinished
    +.ctor(Rectangle sourceRect, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale) Arrow
    +StartMoving() Arrow
    +MarkHit() void
    +Update(GameTime time) void
}

```

<div id="Boomerang-class-diagram"></div>

##### `Boomerang` class diagram

```mermaid
classDiagram
class Boomerang{
    -int HITBOX_SIZE$
    +bool IsFinished
    +.ctor(Vector2 pos, Vector2 vel, float maxDistance) Boomerang
    +StartMoving() Boomerang
    +Update(GameTime time) void
    +GetSprite() ISprite
}

```

<div id="Inventory-class-diagram"></div>

##### `Inventory` class diagram

```mermaid
classDiagram
class Inventory{
    -List<IItem> items
    +int ActiveSlot
    +int Count
    +Add(IItem item) void
    +Get(int slot) IItem
    +CycleNext() void
    +CyclePrevious() void
    +Update(GameTime time) void
    +Draw(SpriteBatch sb) void
}

```

<div id="ItemFactory-class-diagram"></div>

##### `ItemFactory` class diagram

```mermaid
classDiagram
class ItemFactory{
    +CreateBoomerang(Vector2 pos, Vector2 vel, float maxDistance)$ Boomerang
    +CreateArrow(Vector2 pos, Vector2 vel, float rotation, float scale = 1, float maxDistance = null)$ Arrow
    +CreateTimeBomb(double explodeDelayMillis, Vector2 pos, float scale)$ TimeBomb
    +CreateStillItem(StillType type, Vector2 pos, float scale = null)$ StillItem
}

```

<div id="ItemManager-class-diagram"></div>

##### `ItemManager` class diagram

```mermaid
classDiagram
class ItemManager{
    -List<AbstractItem> spawnedItems
    -List<AbstractItem> justFinishedItems
    +IReadOnlyList<AbstractItem> SpawnedItems
    +IReadOnlyList<AbstractItem> JustFinished
    +UseItem(ILink link, Inventory inventory, int slot) void
    +SpawnItem(AbstractItem item) void
    +Update(GameTime time) void
    +Draw(SpriteBatch sb) void
}

```

<div id="StillItem-class-diagram"></div>

##### `StillItem` class diagram

```mermaid
classDiagram
class StillItem{
    +.ctor(string name, Texture2D texture, Vector2 pos, Rectangle sourceRect, float scale) StillItem
}

```

<div id="ItemFactory.StillType-class-diagram"></div>

##### `ItemFactory.StillType` class diagram

```mermaid
classDiagram
class StillType{
    -Heart$
    -BlueHeart$
    -HalfHeart$
    -ZeroHeart$
    -HeartContainer$
    -Fairy$
    -Clock$
    -GoldRupee$
    -PurpleRupee$
    -BluePotion$
    -Map$
    -Bomb$
    -Bow$
    -BlueCandle$
    -Key$
    -Compass$
    -GoldTriforce$
    -PurpleTriforce$
}

```

<div id="TimeBomb-class-diagram"></div>

##### `TimeBomb` class diagram

```mermaid
classDiagram
class TimeBomb{
    -double millisUntilExplode
    +bool IsExploding
    +bool IsFinished
    +.ctor(double explodeDelayMillis, string name, Vector2 pos, Rectangle sourceRect, float scale) TimeBomb
    +Update(GameTime time) void
}

```

<div id="LayerData-class-diagram"></div>

##### `LayerData` class diagram

```mermaid
classDiagram
class LayerData{
    +string name
    +string type
    +int width
    +int height
    +int[] data
}

```

<div id="LevelData-class-diagram"></div>

##### `LevelData` class diagram

```mermaid
classDiagram
class LevelData{
    +int width
    +int height
    +List<LayerData> layers
}

```

<div id="Game1-class-diagram"></div>

##### `Game1` class diagram

```mermaid
classDiagram
IGameActions <|-- Game1 : implements
class Game1{
    -GraphicsDeviceManager graphics
    -SpriteBatch spriteBatch
    -IGameState currentState
    +Game1 Instance$
    +.ctor() Game1
    +Initialize() void
    +LoadContent() void
    +Update(GameTime gameTime) void
    +Draw(GameTime gameTime) void
    +ChangeState(IGameState newState) void
    +Quit() void
}

```

<div id="AnimatedSprite-class-diagram"></div>

##### `AnimatedSprite` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- AnimatedSprite : implements
class AnimatedSprite{
    -Texture2D texture
    -Vector2 pos
    -Rectangle rect
    -int frameCount
    -int curFrame
    -int[] sheetXPositions
    -float frameTime
    -float elapsedTime
    -int frameWidth
    -int frameHeight
    -int sheetY
    +Vector2 Position
    +Texture2D Texture
    +Rectangle Rect
    +.ctor(Texture2D texture, Vector2 position, int[] sheetXPositions, int sheetYPos, int spriteWidth, int spriteHeight, float frameTime) AnimatedSprite
    +UpdateRect() void
    +SetFrame(int frame) void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="BoomerangSprite-class-diagram"></div>

##### `BoomerangSprite` class diagram

```mermaid
classDiagram
ISprite <|-- BoomerangSprite : implements
class BoomerangSprite{
    -Vector2 pos
    -Texture2D texture
    -Vector2 velocity
    -float scale
    -int animationFrame
    -int lastAnimationFrame
    -float distanceTraveled
    -float maxDistance
    -bool returning
    -bool thrown
    +Vector2 Position
    +bool IsActive
    +.ctor(Texture2D texture, Vector2 initialPos, Vector2 velocity, float maxDistance, float scale) BoomerangSprite
    +Throw() void
    +Draw(SpriteBatch sb, Vector2 location) void
    +Update(GameTime time) void
}

```

<div id="DirectionalAnimatedSprite-class-diagram"></div>

##### `DirectionalAnimatedSprite` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- DirectionalAnimatedSprite : implements
class DirectionalAnimatedSprite{
    -Texture2D texture
    -Vector2 pos
    -Rectangle rect
    -int frameCount
    -int curFrame
    -int[] sheetXPositions
    -float frameTime
    -float elapsedTime
    -int frameWidth
    -int frameHeight
    -int sheetY
    -bool flipHorizontal
    +Vector2 Position
    +Texture2D Texture
    +Rectangle Rect
    +.ctor(Texture2D texture, Vector2 position, int[] xPositions, int yPos, int spriteWidth, int spriteHeight, float frameTime, bool flipHorizontal = false) DirectionalAnimatedSprite
    +UpdateFrames(int[] xPositions, bool flipHorizontal) void
    +UpdateRect() void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="MovingAnimatedSprite-class-diagram"></div>

##### `MovingAnimatedSprite` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- MovingAnimatedSprite : implements
class MovingAnimatedSprite{
    -Texture2D texture
    -Vector2 pos
    -Rectangle rect
    -int frameCount
    -int curFrame
    -int[] sheetXPositions
    -float frameTime
    -float elapsedTime
    -int frameWidth
    -int frameHeight
    -int frameY
    -float speed
    -float minX
    -float maxX
    -bool movingRight
    +Vector2 Position
    +Texture2D Texture
    +Rectangle Rect
    +.ctor(Texture2D texture, Vector2 startPosition, int[] sheetXPositions, int frameY, int spriteWidth, int spriteHeight, float frameDuration, float moveSpeed = 150, float range = 300) MovingAnimatedSprite
    +UpdateRect() void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="MovingSprite-class-diagram"></div>

##### `MovingSprite` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- MovingSprite : implements
class MovingSprite{
    -Texture2D texture
    -Vector2 pos
    -Rectangle rect
    -int frameCount
    -int curFrame
    -int[] downFrameXPositions
    -int[] upFrameXPositions
    -float frameTime
    -float elapsedTime
    -int frameWidth
    -int frameHeight
    -int frameY
    -float speed
    -float minY
    -float maxY
    -bool goingDown
    +Vector2 Position
    +Texture2D Texture
    +Rectangle Rect
    +.ctor(Texture2D tex, Vector2 start, int[] downXPositions, int[] upXPositions, int yPos, int spriteWidth, int spriteHeight, float frameDuration, float moveSpeed = 100, float range = 200) MovingSprite
    +UpdateRect() void
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="ProjectileSprite-class-diagram"></div>

##### `ProjectileSprite` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- ProjectileSprite : implements
class ProjectileSprite{
    -Texture2D texture
    -Rectangle sourceRect
    -Vector2 velocity
    -float maxDistance
    -float rotation
    -Vector2 origin
    -float scale
    -float distanceTraveled
    -bool isMoving
    -bool ReachedMaxDistance
    +Vector2 Position
    +.ctor(Texture2D texture, Rectangle sourceRect, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale) ProjectileSprite
    +StartMoving() void
    +Update(GameTime time) void
    +Draw(SpriteBatch sb, Vector2 unused) void
}

```

<div id="StaticSprite-class-diagram"></div>

##### `StaticSprite` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- StaticSprite : implements
class StaticSprite{
    -Texture2D texture
    -Vector2 pos
    -Rectangle sourceRect
    -float? customScale
    +Vector2 Position
    +Texture2D Texture
    +.ctor(Texture2D texture, Vector2 position, Rectangle source) StaticSprite
    +.ctor(Texture2D texture, Vector2 position, Rectangle source, float scale) StaticSprite
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="TextSprite-class-diagram"></div>

##### `TextSprite` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- TextSprite : implements
class TextSprite{
    -Texture2D texture
    -Vector2 pos
    -Rectangle rect
    +Vector2 Position
    +Texture2D Texture
    +Rectangle Rect
    +.ctor(Texture2D texture, Vector2 position) TextSprite
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch, Vector2 location) void
}

```

<div id="DungeonWalls-class-diagram"></div>

##### `DungeonWalls` class diagram

```mermaid
classDiagram
IUIElement <|-- DungeonWalls : implements
class DungeonWalls{
    -Texture2D texture
    -float scale
    -int TOP_DOOR_LEFT$
    -int TOP_DOOR_RIGHT$
    -int TOP_DOOR_BOTTOM$
    -int LEFT_DOOR_TOP$
    -int LEFT_DOOR_BOTTOM$
    -int LEFT_DOOR_RIGHT$
    -int BOTTOM_DOOR_LEFT$
    -int BOTTOM_DOOR_RIGHT$
    -int BOTTOM_DOOR_TOP$
    -int RIGHT_DOOR_LEFT$
    -int RIGHT_DOOR_TOP$
    -int RIGHT_DOOR_BOTTOM$
    -int CENTER_TOP$
    -int CENTER_BOTTOM$
    -int CENTER_LEFT$
    -int CENTER_RIGHT$
    -int SHEET_WIDTH$
    -int SHEET_HEIGHT$
    -float hudHeight
    +Rectangle InnerBounds
    +.ctor(Texture2D texture) DungeonWalls
    +Draw(SpriteBatch spriteBatch) void
    +DrawSection(SpriteBatch spriteBatch, int srcX, int srcY, int srcW, int srcH) void
    +Update(GameTime gameTime) void
}

```

<div id="HUDBar-class-diagram"></div>

##### `HUDBar` class diagram

```mermaid
classDiagram
IUIElement <|-- HUDBar : implements
class HUDBar{
    -StaticSprite background
    -Rectangle sourceRect
    -HeartDisplay hearts
    -NumberDisplay rupeeCount
    +.ctor(Texture2D backgroundTexture) HUDBar
    +Draw(SpriteBatch spriteBatch) void
    +Update(GameTime gameTime) void
}

```

<div id="NumberDisplay-class-diagram"></div>

##### `NumberDisplay` class diagram

```mermaid
classDiagram
IUIElement <|-- NumberDisplay : implements
class NumberDisplay{
    -StaticSprite background
    -Rectangle sourceRect
    -Vector2 pos
    -int baseX
    +.ctor(Texture2D backgroundTexture, Vector2 pos, int id) NumberDisplay
    +Draw(SpriteBatch spriteBatch) void
    +Update(GameTime gameTime) void
}

```

<div id="HUDBar.State-class-diagram"></div>

##### `HUDBar.State` class diagram

```mermaid
classDiagram
class State{
    -UNFOCUSED$
}

```

<div id="TitleScreen-class-diagram"></div>

##### `TitleScreen` class diagram

```mermaid
classDiagram
IUIElement <|-- TitleScreen : implements
class TitleScreen{
    -StaticSprite background
    -Rectangle sourceRect
    +.ctor(Texture2D backgroundTexture) TitleScreen
    +Draw(SpriteBatch spriteBatch) void
    +Update(GameTime gameTime) void
}

```

<div id="UIManager-class-diagram"></div>

##### `UIManager` class diagram

```mermaid
classDiagram
class UIManager{
    -List<IUIElement> elements
    +.ctor() UIManager
    +GetElement<T>() T
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch) void
    +AddElement(IUIElement element) void
    +RemoveElement(IUIElement element) void
    +Clear() void
}

```

*This file is maintained by a bot.*

<!-- markdownlint-restore -->
