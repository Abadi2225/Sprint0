<!-- markdownlint-capture -->
<!-- markdownlint-disable -->

# Code Metrics

This file is dynamically maintained by a bot, *please do not* edit this by hand. It represents various [code metrics](https://aka.ms/dotnet/code-metrics), such as cyclomatic complexity, maintainability index, and so on.

<div id='sprint'></div>

## Sprint :exploding_head:

The *Sprint.csproj* project file contains:

- 18 namespaces.
- 93 named types.
- 4,675 total lines of source code.
- Approximately 1,343 lines of executable code.
- The highest cyclomatic complexity is 21 :exploding_head:.

<details>
<summary>
  <strong id="global+namespace">
    &lt;global namespace&gt; :exploding_head:
  </strong>
</summary>
<br>

The `<global namespace>` namespace contains 7 named types.

- 7 named types.
- 365 total lines of source code.
- Approximately 132 lines of executable code.
- The highest cyclomatic complexity is 21 :exploding_head:.

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

- The `GameplayState` contains 25 members.
- 176 total lines of source code.
- Approximately 72 lines of executable code.
- The highest cyclomatic complexity is 21 :exploding_head:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L40' title='GameplayState.GameplayState()'>40</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 3 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L20' title='Texture2D GameplayState.BossesSheet'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L35' title='CollisionManager GameplayState.collisionManager'>35</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L33' title='Level GameplayState.currentLevel'>33</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L184' title='void GameplayState.Draw(SpriteBatch spriteBatch)'>184</a> | 76 | 1 :heavy_check_mark: | 0 | 5 | 7 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L24' title='Texture2D GameplayState.dungeonBackground'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L21' title='Texture2D GameplayState.dustSheet'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L19' title='Texture2D GameplayState.enemiesSheet'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L31' title='EnemyFactory GameplayState.enemyFactory'>31</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L30' title='EnemyManager GameplayState.enemyManager'>30</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L46' title='void GameplayState.Enter()'>46</a> | 84 | 1 :heavy_check_mark: | 0 | 15 | 16 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L44' title='void GameplayState.Exit()'>44</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L25' title='Texture2D GameplayState.hudElements'>25</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L29' title='ItemManager GameplayState.items'>29</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L32' title='LevelLoader GameplayState.levelLoader'>32</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L27' title='Link GameplayState.link'>27</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L18' title='Texture2D GameplayState.linkSheet'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L37' title='bool GameplayState.lmbReleased'>37</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L63' title='void GameplayState.LoadContent()'>63</a> | 45 | 2 :heavy_check_mark: | 0 | 31 | 66 / 31 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L22' title='Texture2D GameplayState.NPCSheet'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L28' title='Dictionary<Keys, ICommand> GameplayState.pressedKeys'>28</a> | 100 | 0 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L38' title='bool GameplayState.rmbReleased'>38</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L23' title='Texture2D GameplayState.tileSheet'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L34' title='UIManager GameplayState.uiManager'>34</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game States/GameplayState.cs#L130' title='void GameplayState.Update(GameTime gameTime)'>130</a> | 42 | 21 :exploding_head: | 0 | 27 | 53 / 34 |

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

- The `GameServices` contains 8 members.
- 19 total lines of source code.
- Approximately 4 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L12' title='ContentManager GameServices.Content'>12</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L15' title='IGameActions GameServices.GameActions'>15</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L19' title='int GameServices.GameHeight'>19</a> | 93 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L18' title='int GameServices.GameWidth'>18</a> | 93 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L13' title='IController GameServices.KeyInput'>13</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../GameServices.cs#L23' title='ILink GameServices.Link'>23</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
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

- The `Level` contains 5 members.
- 23 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L12' title='Level.Level(BlockManager blockManager, EnemyManager enemyManager)'>12</a> | 85 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L9' title='BlockManager Level.Blocks'>9</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L24' title='void Level.Draw(SpriteBatch spriteBatch)'>24</a> | 86 | 1 :heavy_check_mark: | 0 | 3 | 5 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L10' title='EnemyManager Level.Enemies'>10</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/Level.cs#L18' title='void Level.Update(GameTime gameTime)'>18</a> | 86 | 1 :heavy_check_mark: | 0 | 3 | 5 / 2 |

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
- 46 total lines of source code.
- Approximately 23 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Levels/LevelBuilder.cs#L12' title='Level LevelBuilder.Build(LevelData data, EnemyFactory enemyFactory)'>12</a> | 50 | 6 :heavy_check_mark: | 0 | 13 | 41 / 22 |
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
- 112 total lines of source code.
- Approximately 19 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="block">
    Block :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Block` contains 8 members.
- 28 total lines of source code.
- Approximately 7 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L16' title='Block.Block(Texture2D texture, Vector2 pos, Rectangle sourceRect, bool walkable)'>16</a> | 73 | 1 :heavy_check_mark: | 0 | 5 | 7 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L24' title='void Block.Draw(SpriteBatch spriteBatch)'>24</a> | 93 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L14' title='Vector2 Block.position'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L15' title='Rectangle Block.Rect'>15</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L12' title='StaticSprite Block.sprite'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L11' title='int Block.tileWidth'>11</a> | 87 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/Block.cs#L29' title='void Block.Update(GameTime time)'>29</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 7 / 1 |
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
- 56 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L28' title='Block BlockFactory.Create(int tileId, Vector2 pos)'>28</a> | 84 | 1 :heavy_check_mark: | 0 | 3 | 17 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Block/BlockFactory.cs#L46' title='Block BlockFactory.CreateBlock(BlockType type, Vector2 pos)'>46</a> | 73 | 1 :heavy_check_mark: | 0 | 7 | 18 / 3 |
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

The `Sprint.Character` namespace contains 10 named types.

- 10 named types.
- 653 total lines of source code.
- Approximately 190 lines of executable code.
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

- The `Link` contains 51 members.
- 241 total lines of source code.
- Approximately 76 lines of executable code.
- The highest cyclomatic complexity is 7 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L84' title='Link.Link(Texture2D texture, Vector2 position)'>84</a> | 53 | 1 :heavy_check_mark: | 0 | 6 | 26 / 19 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L26' title='Attacking Link.AttackDown'>26</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L45' title='bool Link.attackHitLanded'>45</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L27' title='Attacking Link.AttackLeft'>27</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L28' title='Attacking Link.AttackRight'>28</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L25' title='Attacking Link.AttackUp'>25</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L12' title='double Link.BLINK_INTERVAL'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L10' title='int Link.BODY_SIZE'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L11' title='double Link.DAMAGED_DURATION'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L39' title='double Link.damagedTimer'>39</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L38' title='Directions Link.direction'>38</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L143' title='void Link.Draw(SpriteBatch spriteBatch)'>143</a> | 83 | 3 :heavy_check_mark: | 0 | 4 | 7 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L47' title='Directions Link.Facing'>47</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L224' title='void Link.FinishAttack()'>224</a> | 88 | 1 :heavy_check_mark: | 0 | 0 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L230' title='void Link.FinishUseItem()'>230</a> | 88 | 1 :heavy_check_mark: | 0 | 0 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L40' title='int Link.health'>40</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L48' title='int Link.Health'>48</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L16' title='ISprite Link.IdleDown'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L17' title='ISprite Link.IdleLeft'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L18' title='ISprite Link.IdleRight'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L15' title='ISprite Link.IdleUp'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L41' title='bool Link.isAttacking'>41</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L43' title='bool Link.isDamaged'>43</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L42' title='bool Link.isUsingItem'>42</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L44' title='bool Link.isVisible'>44</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L13' title='int Link.MAX_HEALTH'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L49' title='int Link.MaxHealth'>49</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L37' title='Vector2 Link.move'>37</a> | 93 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L36' title='Vector2 Link.position'>36</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L74' title='Vector2 Link.Position'>74</a> | 91 | 2 :heavy_check_mark: | 0 | 3 | 9 / 3 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L51' title='Rectangle Link.Rect'>51</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L72' title='void Link.RegisterSwordHit()'>72</a> | 96 | 1 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L236' title='void Link.SetIdleSprite()'>236</a> | 87 | 1 :heavy_check_mark: | 0 | 2 | 11 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L167' title='void Link.SetMove(Directions dir)'>167</a> | 69 | 7 :heavy_check_mark: | 0 | 5 | 15 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L9' title='float Link.SPEED'>9</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L35' title='ISprite Link.sprite'>35</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L188' title='void Link.StartAttack()'>188</a> | 68 | 6 :heavy_check_mark: | 0 | 5 | 16 / 5 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L213' title='void Link.StartDamaged()'>213</a> | 68 | 1 :heavy_check_mark: | 0 | 2 | 10 / 7 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L151' title='void Link.StartUseItem()'>151</a> | 70 | 6 :heavy_check_mark: | 0 | 5 | 15 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L183' title='void Link.StopMove()'>183</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L53' title='Rectangle Link.SwordRect'>53</a> | 75 | 3 :heavy_check_mark: | 0 | 5 | 18 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L205' title='void Link.TakeDamage(int amount)'>205</a> | 79 | 2 :heavy_check_mark: | 0 | 1 | 7 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L111' title='void Link.Update(GameTime gameTime)'>111</a> | 59 | 7 :heavy_check_mark: | 0 | 4 | 31 / 11 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L31' title='UseItem Link.UseItemDown'>31</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L32' title='UseItem Link.UseItemLeft'>32</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L33' title='UseItem Link.UseItemRight'>33</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L30' title='UseItem Link.UseItemUp'>30</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L21' title='ISprite Link.WalkDown'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L22' title='ISprite Link.WalkLeft'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L23' title='ISprite Link.WalkRight'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/Link.cs#L20' title='ISprite Link.WalkUp'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

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

- The `LinkFactory` contains 16 members.
- 103 total lines of source code.
- Approximately 28 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L63' title='Attacking LinkFactory.AttackDown(Texture2D texture, Action onFinished)'>63</a> | 77 | 1 :heavy_check_mark: | 0 | 8 | 11 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L87' title='Attacking LinkFactory.AttackLeft(Texture2D texture, Action onFinished)'>87</a> | 77 | 1 :heavy_check_mark: | 0 | 8 | 11 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L99' title='Attacking LinkFactory.AttackRight(Texture2D texture, Action onFinished)'>99</a> | 77 | 1 :heavy_check_mark: | 0 | 8 | 11 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L75' title='Attacking LinkFactory.AttackUp(Texture2D texture, Action onFinished)'>75</a> | 77 | 1 :heavy_check_mark: | 0 | 8 | 11 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L10' title='ISprite LinkFactory.IdleDown(Texture2D texture)'>10</a> | 93 | 1 :heavy_check_mark: | 0 | 5 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L12' title='ISprite LinkFactory.IdleLeft(Texture2D texture)'>12</a> | 93 | 1 :heavy_check_mark: | 0 | 5 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L13' title='ISprite LinkFactory.IdleRight(Texture2D texture)'>13</a> | 93 | 1 :heavy_check_mark: | 0 | 5 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Character/LinkFactory.cs#L11' title='ISprite LinkFactory.IdleUp(Texture2D texture)'>11</a> | 93 | 1 :heavy_check_mark: | 0 | 5 | 1 / 1 |
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
    Sprint.Collision :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Collision` namespace contains 3 named types.

- 3 named types.
- 73 total lines of source code.
- Approximately 17 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

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
- 21 total lines of source code.
- Approximately 5 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyCollision.cs#L12' title='LinkEnemyCollision.LinkEnemyCollision(Link link, EnemyManager enemyManager)'>12</a> | 85 | 1 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyCollision.cs#L10' title='EnemyManager LinkEnemyCollision.enemyManager'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyCollision.cs#L18' title='void LinkEnemyCollision.Handle()'>18</a> | 78 | 4 :heavy_check_mark: | 0 | 7 | 9 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Collisions/LinkEnemyCollision.cs#L9' title='Link LinkEnemyCollision.link'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#LinkEnemyCollision-class-diagram">:link: to `LinkEnemyCollision` class diagram</a>

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
    Sprint.Collisions :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.Collisions` namespace contains 1 named types.

- 1 named types.
- 45 total lines of source code.
- Approximately 13 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

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
- 92 total lines of source code.
- Approximately 13 lines of executable code.
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
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleItemCommand.cs#L11' title='CycleItemCommand.CycleItemCommand(ItemManager itemManager, bool forward)'>11</a> | 85 | 1 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleItemCommand.cs#L17' title='void CycleItemCommand.Execute()'>17</a> | 92 | 4 :heavy_check_mark: | 0 | 2 | 7 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleItemCommand.cs#L9' title='bool CycleItemCommand.forward'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/CycleItemCommand.cs#L8' title='ItemManager CycleItemCommand.itemManager'>8</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

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

- The `UseItemCommand` contains 5 members.
- 18 total lines of source code.
- Approximately 4 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/UseItemCommand.cs#L17' title='UseItemCommand.UseItemCommand(ItemManager itemManager, ILink link, int slot)'>17</a> | 79 | 1 :heavy_check_mark: | 0 | 2 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/UseItemCommand.cs#L24' title='void UseItemCommand.Execute()'>24</a> | 93 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/UseItemCommand.cs#L13' title='ItemManager UseItemCommand.itemManager'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/UseItemCommand.cs#L14' title='ILink UseItemCommand.link'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Commands/UseItemCommand.cs#L15' title='int UseItemCommand.slot'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

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
- 1,363 total lines of source code.
- Approximately 448 lines of executable code.
- The highest cyclomatic complexity is 10 :radioactive:.

<details>
<summary>
  <strong id="aquamentus">
    Aquamentus :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Aquamentus` contains 18 members.
- 97 total lines of source code.
- Approximately 36 lines of executable code.
- The highest cyclomatic complexity is 6 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L32' title='Aquamentus.Aquamentus(Texture2D texture, Vector2 position)'>32</a> | 60 | 1 :heavy_check_mark: | 0 | 9 | 17 / 10 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L25' title='List<AquamentusFireball> Aquamentus.activeFireballs'>25</a> | 93 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L15' title='int Aquamentus.DAMAGE'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L20' title='float Aquamentus.DIRECTION_SWAP_MAX'>20</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L19' title='float Aquamentus.DIRECTION_SWAP_MIN'>19</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L18' title='float Aquamentus.directionChangeTimer'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L84' title='void Aquamentus.Draw(SpriteBatch spriteBatch, Vector2 location)'>84</a> | 85 | 2 :heavy_check_mark: | 0 | 7 | 6 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L27' title='float Aquamentus.FIREBALL_INTERVAL'>27</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L26' title='float Aquamentus.fireballTimer'>26</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L104' title='float Aquamentus.GetRandomFloat(float min, float max)'>104</a> | 90 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L14' title='int Aquamentus.HEALTH'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L17' title='float Aquamentus.MOVE_SPEED'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L21' title='float Aquamentus.moveDirectionTimer'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L22' title='bool Aquamentus.moveLeft'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L24' title='EnemyProjectileFactory Aquamentus.projectileFactory'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L91' title='void Aquamentus.SpawnFireballs()'>91</a> | 81 | 2 :heavy_check_mark: | 0 | 5 | 12 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Aquamentus.cs#L47' title='void Aquamentus.Update(GameTime gameTime)'>47</a> | 53 | 6 :heavy_check_mark: | 0 | 7 | 36 / 19 |
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

- The `AquamentusFireball` contains 11 members.
- 54 total lines of source code.
- Approximately 24 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L29' title='AquamentusFireball.AquamentusFireball(Texture2D texture, Vector2 startPosition, Vector2 direction)'>29</a> | 61 | 2 :heavy_check_mark: | 0 | 5 | 16 / 10 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L56' title='void AquamentusFireball.Draw(SpriteBatch spriteBatch, Vector2 location)'>56</a> | 85 | 2 :heavy_check_mark: | 0 | 4 | 5 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L17' title='bool AquamentusFireball.IsActive'>17</a> | 94 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L13' title='float AquamentusFireball.lifetime'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L14' title='float AquamentusFireball.MAX_LIFETIME'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L11' title='Vector2 AquamentusFireball.position'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L19' title='Vector2 AquamentusFireball.Position'>19</a> | 92 | 2 :heavy_check_mark: | 0 | 2 | 9 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L15' title='float AquamentusFireball.SPEED'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L10' title='IPositionedSprite AquamentusFireball.sprite'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/AquamentusFireball.cs#L46' title='void AquamentusFireball.Update(GameTime gameTime)'>46</a> | 71 | 2 :heavy_check_mark: | 0 | 4 | 9 / 5 |
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

- The `Goriya` contains 34 members.
- 245 total lines of source code.
- Approximately 84 lines of executable code.
- The highest cyclomatic complexity is 10 :radioactive:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L50' title='Goriya.Goriya(Texture2D texture, Vector2 position, ContentManager content, List<Block> solidBlocks)'>50</a> | 55 | 1 :heavy_check_mark: | 0 | 13 | 26 / 16 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L35' title='Boomerang Goriya.activeBoomerang'>35</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L199' title='void Goriya.ChooseNextStep()'>199</a> | 69 | 2 :heavy_check_mark: | 0 | 4 | 12 / 6 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L36' title='ContentManager Goriya.contentManager'>36</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L28' title='Direction Goriya.currentDirection'>28</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L16' title='GoriyaState Goriya.currentState'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L18' title='int Goriya.DAMAGE'>18</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L40' title='int[] Goriya.downFrames'>40</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L105' title='void Goriya.Draw(SpriteBatch spriteBatch, Vector2 location)'>105</a> | 84 | 2 :heavy_check_mark: | 0 | 5 | 7 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L34' title='float Goriya.FLIP_INTERVAL'>34</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L43' title='bool Goriya.FlipsOnVertical'>43</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L31' title='float Goriya.flipTimer'>31</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L212' title='Direction Goriya.GetDirectionTo(Vector2 target)'>212</a> | 80 | 4 :heavy_check_mark: | 0 | 3 | 8 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L253' title='float Goriya.GetRandomThrowTime()'>253</a> | 89 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L17' title='int Goriya.HEALTH'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L190' title='bool Goriya.IsBoomerangActive()'>190</a> | 77 | 4 :heavy_check_mark: | 0 | 4 | 8 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L21' title='float Goriya.MOVE_SPEED'>21</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L41' title='int[] Goriya.sideFrames'>41</a> | 91 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L24' title='List<Block> Goriya.solidBlocks'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L33' title='bool Goriya.spriteHorizontalFlip'>33</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L20' title='float Goriya.STEP_DELAY'>20</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L19' title='float Goriya.STEP_SIZE'>19</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L30' title='float Goriya.stepTimer'>30</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L29' title='Vector2 Goriya.targetPosition'>29</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L23' title='float Goriya.THROW_COOLDOWN_MAX'>23</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L22' title='float Goriya.THROW_COOLDOWN_MIN'>22</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L165' title='void Goriya.ThrowBoomerang()'>165</a> | 65 | 2 :heavy_check_mark: | 0 | 8 | 24 / 7 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L42' title='int[] Goriya.throwFrame'>42</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L32' title='float Goriya.throwTimer'>32</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L73' title='void Goriya.Update(GameTime gameTime)'>73</a> | 62 | 7 :heavy_check_mark: | 0 | 5 | 31 / 10 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L221' title='void Goriya.UpdateSprite()'>221</a> | 58 | 10 :radioactive: | 0 | 5 | 32 / 11 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L148' title='void Goriya.UpdateThrowing(float deltaTime)'>148</a> | 67 | 3 :heavy_check_mark: | 0 | 5 | 16 / 7 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L113' title='void Goriya.UpdateWalking(float deltaTime)'>113</a> | 55 | 7 :heavy_check_mark: | 0 | 3 | 34 / 15 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/Goriya.cs#L39' title='int[] Goriya.upFrames'>39</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |

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
    WallMaster :heavy_check_mark:
  </strong>
</summary>
<br>

- The `WallMaster` contains 15 members.
- 110 total lines of source code.
- Approximately 35 lines of executable code.
- The highest cyclomatic complexity is 7 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L23' title='WallMaster.WallMaster(Texture2D texture, Vector2 position)'>23</a> | 62 | 1 :heavy_check_mark: | 0 | 9 | 15 / 9 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L13' title='float WallMaster.CREEP_SPEED'>13</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L19' title='WallMasterState WallMaster.currentState'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L14' title='float WallMaster.DETECTION_RANGE'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L104' title='void WallMaster.Draw(SpriteBatch spriteBatch, Vector2 location)'>104</a> | 81 | 4 :heavy_check_mark: | 0 | 5 | 7 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L15' title='float WallMaster.GRAB_RANGE'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L20' title='Vector2 WallMaster.homePosition'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L21' title='bool WallMaster.movingVertically'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L112' title='void WallMaster.Reset()'>112</a> | 80 | 1 :heavy_check_mark: | 0 | 3 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L39' title='void WallMaster.Update(GameTime gameTime)'>39</a> | 73 | 6 :heavy_check_mark: | 0 | 4 | 24 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L75' title='void WallMaster.UpdateCreeping(float deltaTime)'>75</a> | 61 | 7 :heavy_check_mark: | 0 | 7 | 22 / 9 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L98' title='void WallMaster.UpdateGrabbing()'>98</a> | 93 | 1 :heavy_check_mark: | 0 | 3 | 5 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L64' title='void WallMaster.UpdateHidden()'>64</a> | 70 | 2 :heavy_check_mark: | 0 | 5 | 10 / 5 |
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
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L17' title='WallMasterState.Creeping'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L17' title='WallMasterState.Grabbing'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/Concrete/WallMaster.cs#L17' title='WallMasterState.Hidden'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

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
- 39 total lines of source code.
- Approximately 8 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="keyboardcontroller">
    KeyboardController :heavy_check_mark:
  </strong>
</summary>
<br>

- The `KeyboardController` contains 8 members.
- 36 total lines of source code.
- Approximately 8 lines of executable code.
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
- 280 total lines of source code.
- Approximately 81 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

<details>
<summary>
  <strong id="enemyeffectwrapper">
    EnemyEffectWrapper :heavy_check_mark:
  </strong>
</summary>
<br>

- The `EnemyEffectWrapper` contains 22 members.
- 102 total lines of source code.
- Approximately 41 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L19' title='EnemyEffectWrapper.EnemyEffectWrapper(IEnemy enemy, ISprite spawnSprite, ISprite deathSprite)'>19</a> | 76 | 1 :heavy_check_mark: | 0 | 2 | 7 / 4 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L47' title='int EnemyEffectWrapper.Damage'>47</a> | 96 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L11' title='ISprite EnemyEffectWrapper.deathSprite'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L52' title='void EnemyEffectWrapper.Die()'>52</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L90' title='void EnemyEffectWrapper.Draw(SpriteBatch spriteBatch, Vector2 location)'>90</a> | 72 | 5 :heavy_check_mark: | 0 | 5 | 18 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L17' title='float EnemyEffectWrapper.DYING_DURATION'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L14' title='float EnemyEffectWrapper.dyingTimer'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L9' title='IEnemy EnemyEffectWrapper.enemy'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L39' title='int EnemyEffectWrapper.Health'>39</a> | 94 | 2 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L48' title='bool EnemyEffectWrapper.IsAlive'>48</a> | 96 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L49' title='bool EnemyEffectWrapper.IsDyingAnimation'>49</a> | 89 | 4 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L45' title='bool EnemyEffectWrapper.IsSpawning'>45</a> | 94 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L46' title='int EnemyEffectWrapper.MaxHealth'>46</a> | 96 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L27' title='Vector2 EnemyEffectWrapper.Position'>27</a> | 94 | 2 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L33' title='Rectangle EnemyEffectWrapper.Rect'>33</a> | 94 | 2 :heavy_check_mark: | 0 | 2 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L59' title='void EnemyEffectWrapper.Reset()'>59</a> | 82 | 1 :heavy_check_mark: | 0 | 1 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L54' title='void EnemyEffectWrapper.ResetSpawnTimer()'>54</a> | 90 | 2 :heavy_check_mark: | 0 | 1 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L16' title='float EnemyEffectWrapper.SPAWN_DURATION'>16</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L10' title='ISprite EnemyEffectWrapper.spawnSprite'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L13' title='float EnemyEffectWrapper.spawnTimer'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L51' title='void EnemyEffectWrapper.TakeDamage(int amount)'>51</a> | 96 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyEffectWrapper.cs#L66' title='void EnemyEffectWrapper.Update(GameTime gameTime)'>66</a> | 66 | 5 :heavy_check_mark: | 0 | 4 | 23 / 8 |

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

- The `EnemyManager` contains 14 members.
- 75 total lines of source code.
- Approximately 25 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L15' title='EnemyManager.EnemyManager()'>15</a> | 79 | 1 :heavy_check_mark: | 0 | 3 | 6 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L22' title='void EnemyManager.AddEnemy(IEnemy enemy)'>22</a> | 75 | 2 :heavy_check_mark: | 0 | 3 | 10 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L12' title='IEnemy EnemyManager.currentEnemy'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L11' title='int EnemyManager.currentEnemyIndex'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L33' title='void EnemyManager.CycleNext()'>33</a> | 76 | 2 :heavy_check_mark: | 0 | 3 | 8 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L42' title='void EnemyManager.CyclePrevious()'>42</a> | 76 | 2 :heavy_check_mark: | 0 | 3 | 8 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L57' title='void EnemyManager.Draw(SpriteBatch spriteBatch)'>57</a> | 93 | 2 :heavy_check_mark: | 0 | 5 | 5 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L10' title='List<IEnemy> EnemyManager.enemies'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L13' title='List<IEnemy> EnemyManager.enemyList'>13</a> | 100 | 2 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L77' title='IEnemy EnemyManager.GetCurrentEnemy()'>77</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L81' title='int EnemyManager.GetCurrentIndex()'>81</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L79' title='int EnemyManager.GetEnemyCount()'>79</a> | 100 | 1 :heavy_check_mark: | 0 | 3 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L63' title='void EnemyManager.Reset()'>63</a> | 73 | 3 :heavy_check_mark: | 0 | 4 | 13 / 5 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Enemies/EnemyManager.cs#L51' title='void EnemyManager.Update(GameTime gameTime)'>51</a> | 94 | 2 :heavy_check_mark: | 0 | 5 | 5 / 1 |

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

The `Sprint.Interfaces` namespace contains 10 named types.

- 10 named types.
- 82 total lines of source code.
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

- The `IController` contains 4 members.
- 7 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IController.cs#L8' title='bool IController.IsKeyDown(Keys key)'>8</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IController.cs#L9' title='bool IController.IsKeyPressed(Keys key)'>9</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/IController.cs#L10' title='bool IController.IsKeyReleased(Keys key)'>10</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
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
  <strong id="ilink">
    ILink :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ILink` contains 9 members.
- 12 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L10' title='Directions ILink.Facing'>10</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L11' title='int ILink.Health'>11</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L12' title='int ILink.MaxHealth'>12</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L8' title='Vector2 ILink.Position'>8</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L9' title='Rectangle ILink.Rect'>9</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L14' title='void ILink.StartAttack()'>14</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L15' title='void ILink.StartUseItem()'>15</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L13' title='Rectangle ILink.SwordRect'>13</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Interfaces/ILink.cs#L16' title='void ILink.TakeDamage(int amount)'>16</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |

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
    Sprint.Item :exploding_head:
  </strong>
</summary>
<br>

The `Sprint.Item` namespace contains 12 named types.

- 12 named types.
- 582 total lines of source code.
- Approximately 133 lines of executable code.
- The highest cyclomatic complexity is 19 :exploding_head:.

<details>
<summary>
  <strong id="abstractitem">
    AbstractItem :heavy_check_mark:
  </strong>
</summary>
<br>

- The `AbstractItem` contains 10 members.
- 33 total lines of source code.
- Approximately 8 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L20' title='AbstractItem.AbstractItem(string name)'>20</a> | 85 | 1 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L26' title='AbstractItem.AbstractItem(string name, ContentManager contentManager, string resourceName, Vector2 drawPos)'>26</a> | 83 | 1 :heavy_check_mark: | 0 | 4 | 5 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L14' title='string AbstractItem.DisplayName'>14</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L32' title='void AbstractItem.Draw(SpriteBatch sb, Vector2 pos)'>32</a> | 96 | 2 :heavy_check_mark: | 0 | 4 | 4 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L12' title='Vector2 AbstractItem.DrawPos'>12</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L18' title='bool AbstractItem.IsFinished'>18</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L13' title='string AbstractItem.Name'>13</a> | 100 | 1 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L16' title='ISprite AbstractItem.sprite'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L11' title='Texture2D AbstractItem.texture'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/AbstractItem.cs#L37' title='void AbstractItem.Update(GameTime time)'>37</a> | 95 | 2 :heavy_check_mark: | 0 | 3 | 4 / 1 |

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

- The `Arrow` contains 4 members.
- 28 total lines of source code.
- Approximately 7 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Arrow.cs#L13' title='Arrow.Arrow(Rectangle texMask, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale, ContentManager cm)'>13</a> | 87 | 1 :heavy_check_mark: | 0 | 7 | 13 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Arrow.cs#L35' title='bool Arrow.IsFinished'>35</a> | 92 | 4 :heavy_check_mark: | 0 | 2 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Arrow.cs#L11' title='string Arrow.ResourceName'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Arrow.cs#L26' title='Arrow Arrow.StartMoving()'>26</a> | 84 | 2 :heavy_check_mark: | 0 | 2 | 8 / 3 |

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

- The `Boomerang` contains 5 members.
- 27 total lines of source code.
- Approximately 8 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Boomerang.cs#L14' title='Boomerang.Boomerang(Vector2 pos, Vector2 vel, float maxDistance, ContentManager contentManager)'>14</a> | 87 | 1 :heavy_check_mark: | 0 | 6 | 10 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Boomerang.cs#L35' title='ISprite Boomerang.GetSprite()'>35</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Boomerang.cs#L33' title='bool Boomerang.IsFinished'>33</a> | 91 | 4 :heavy_check_mark: | 0 | 3 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Boomerang.cs#L12' title='string Boomerang.ResourceName'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Boomerang.cs#L25' title='Boomerang Boomerang.StartMoving()'>25</a> | 84 | 2 :heavy_check_mark: | 0 | 2 | 8 / 3 |

<a href="#Boomerang-class-diagram">:link: to `Boomerang` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="boomerangsprite">
    BoomerangSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `BoomerangSprite` contains 15 members.
- 73 total lines of source code.
- Approximately 24 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L25' title='BoomerangSprite.BoomerangSprite(Texture2D texture, Vector2 initialPos, Vector2 velocity, float maxDistance, float scale)'>25</a> | 72 | 1 :heavy_check_mark: | 0 | 2 | 8 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L17' title='int BoomerangSprite.animationFrame'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L19' title='float BoomerangSprite.distanceTraveled'>19</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L39' title='void BoomerangSprite.Draw(SpriteBatch sb, Vector2 location)'>39</a> | 87 | 1 :heavy_check_mark: | 0 | 4 | 14 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L23' title='bool BoomerangSprite.IsActive'>23</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L18' title='int BoomerangSprite.lastAnimationFrame'>18</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L20' title='float BoomerangSprite.maxDistance'>20</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L13' title='Vector2 BoomerangSprite.Pos'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L21' title='bool BoomerangSprite.returning'>21</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L16' title='float BoomerangSprite.scale'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L14' title='Texture2D BoomerangSprite.texture'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L34' title='void BoomerangSprite.Throw()'>34</a> | 96 | 1 :heavy_check_mark: | 0 | 0 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L22' title='bool BoomerangSprite.thrown'>22</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L54' title='void BoomerangSprite.Update(GameTime time)'>54</a> | 58 | 5 :heavy_check_mark: | 0 | 3 | 29 / 13 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/BoomerangSprite.cs#L15' title='Vector2 BoomerangSprite.velocity'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#BoomerangSprite-class-diagram">:link: to `BoomerangSprite` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="bow">
    Bow :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Bow` contains 2 members.
- 15 total lines of source code.
- Approximately 2 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Bow.cs#L14' title='Bow.Bow(string name, ContentManager contentManager, Vector2 drawPos, Rectangle mask, float rotation, float scale)'>14</a> | 87 | 1 :heavy_check_mark: | 0 | 7 | 10 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/Bow.cs#L12' title='string Bow.ResourceName'>12</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#Bow-class-diagram">:link: to `Bow` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="itemfactory">
    ItemFactory :exploding_head:
  </strong>
</summary>
<br>

- The `ItemFactory` contains 5 members.
- 121 total lines of source code.
- Approximately 13 lines of executable code.
- The highest cyclomatic complexity is 19 :exploding_head:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L30' title='ContentManager ItemFactory.contentManager'>30</a> | 93 | 0 :heavy_check_mark: | 0 | 3 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L36' title='Arrow ItemFactory.CreateArrow(Vector2 pos, Vector2 vel, float rotation, float scale = 1, float maxDistance = null)'>36</a> | 72 | 1 :heavy_check_mark: | 0 | 4 | 13 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L31' title='Boomerang ItemFactory.CreateBoomerang(Vector2 pos, Vector2 vel, float maxDistance)'>31</a> | 91 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L64' title='StillItem ItemFactory.CreateStillItem(StillType type, Vector2 pos, float rotation = null, float scale = null)'>64</a> | 59 | 19 :exploding_head: | 0 | 6 | 63 / 5 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L50' title='TimeBomb ItemFactory.CreateTimeBomb(double explodeDelayMillis, Vector2 pos, float scale, float rotation = null)'>50</a> | 74 | 1 :heavy_check_mark: | 0 | 4 | 13 / 3 |

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

- The `ItemManager` contains 12 members.
- 116 total lines of source code.
- Approximately 36 lines of executable code.
- The highest cyclomatic complexity is 7 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L17' title='ItemManager.ItemManager()'>17</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L14' title='int ItemManager.ActiveItem'>14</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L75' title='void ItemManager.Add(AbstractItem item)'>75</a> | 97 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L112' title='void ItemManager.CycleNext()'>112</a> | 83 | 2 :heavy_check_mark: | 0 | 3 | 7 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L119' title='void ItemManager.CyclePrevious()'>119</a> | 86 | 2 :heavy_check_mark: | 0 | 1 | 7 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L85' title='void ItemManager.Draw(SpriteBatch sb)'>85</a> | 80 | 2 :heavy_check_mark: | 0 | 4 | 8 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L107' title='AbstractItem ItemManager.GetActiveItem()'>107</a> | 95 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L13' title='List<AbstractItem> ItemManager.Inventory'>13</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L15' title='List<AbstractItem> ItemManager.SpawnedItems'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L80' title='void ItemManager.SpawnItem(AbstractItem item)'>80</a> | 97 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L94' title='void ItemManager.Update(GameTime time)'>94</a> | 72 | 3 :heavy_check_mark: | 0 | 4 | 12 / 6 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemManager.cs#L22' title='void ItemManager.UseItem(ILink link, int slot)'>22</a> | 52 | 7 :heavy_check_mark: | 0 | 11 | 52 / 18 |

<a href="#ItemManager-class-diagram">:link: to `ItemManager` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="projectilesprite">
    ProjectileSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ProjectileSprite` contains 15 members.
- 63 total lines of source code.
- Approximately 19 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L25' title='ProjectileSprite.ProjectileSprite(Texture2D texture, Rectangle texMask, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale)'>25</a> | 65 | 1 :heavy_check_mark: | 0 | 3 | 11 / 8 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L20' title='float ProjectileSprite.distanceTraveled'>20</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L55' title='void ProjectileSprite.Draw(SpriteBatch sb, Vector2 unused)'>55</a> | 81 | 2 :heavy_check_mark: | 0 | 5 | 16 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L21' title='bool ProjectileSprite.isMoving'>21</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L15' title='float ProjectileSprite.maxDistance'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L17' title='Vector2 ProjectileSprite.origin'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L11' title='Vector2 ProjectileSprite.Position'>11</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L23' title='bool ProjectileSprite.ReachedMaxDistance'>23</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L16' title='float ProjectileSprite.rotation'>16</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L18' title='float ProjectileSprite.scale'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L37' title='void ProjectileSprite.StartMoving()'>37</a> | 96 | 1 :heavy_check_mark: | 0 | 0 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L13' title='Rectangle ProjectileSprite.texMask'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L12' title='Texture2D ProjectileSprite.texture'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L42' title='void ProjectileSprite.Update(GameTime time)'>42</a> | 69 | 3 :heavy_check_mark: | 0 | 3 | 12 / 6 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ProjectileSprite.cs#L14' title='Vector2 ProjectileSprite.velocity'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#ProjectileSprite-class-diagram">:link: to `ProjectileSprite` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="stillitem">
    StillItem :heavy_check_mark:
  </strong>
</summary>
<br>

- The `StillItem` contains 2 members.
- 14 total lines of source code.
- Approximately 2 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/StillItem.cs#L12' title='StillItem.StillItem(string name, ContentManager contentManager, Vector2 drawPos, Rectangle mask, float rotation, float scale)'>12</a> | 87 | 1 :heavy_check_mark: | 0 | 7 | 10 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/StillItem.cs#L11' title='string StillItem.ResourceName'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#StillItem-class-diagram">:link: to `StillItem` class diagram</a>

<a href="#sprint-item">:top: back to Sprint.Item</a>

</details>

<details>
<summary>
  <strong id="stillitemsprite">
    StillItemSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `StillItemSprite` contains 8 members.
- 35 total lines of source code.
- Approximately 8 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/StillItemSprite.cs#L17' title='StillItemSprite.StillItemSprite(Vector2 position, Texture2D texture, Rectangle mask, float rotation, float scale)'>17</a> | 72 | 1 :heavy_check_mark: | 0 | 3 | 8 / 5 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/StillItemSprite.cs#L26' title='void StillItemSprite.Draw(SpriteBatch sb, Vector2 unused)'>26</a> | 88 | 1 :heavy_check_mark: | 0 | 5 | 14 / 1 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/StillItemSprite.cs#L11' title='Vector2 StillItemSprite.Position'>11</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/StillItemSprite.cs#L14' title='float StillItemSprite.rotation'>14</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/StillItemSprite.cs#L15' title='float StillItemSprite.scale'>15</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/StillItemSprite.cs#L12' title='Texture2D StillItemSprite.texture'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/StillItemSprite.cs#L13' title='Rectangle StillItemSprite.textureMask'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/StillItemSprite.cs#L40' title='void StillItemSprite.Update(GameTime time)'>40</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 3 / 0 |

<a href="#StillItemSprite-class-diagram">:link: to `StillItemSprite` class diagram</a>

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
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L24' title='StillType.BlueCandle'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L12' title='StillType.BlueHeart'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L20' title='StillType.BluePotion'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L22' title='StillType.Bomb'>22</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L23' title='StillType.Bow'>23</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L17' title='StillType.Clock'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L26' title='StillType.Compass'>26</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L16' title='StillType.Fairy'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L18' title='StillType.GoldRupee'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L27' title='StillType.GoldTriforce'>27</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L13' title='StillType.HalfHeart'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L11' title='StillType.Heart'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L15' title='StillType.HeartContainer'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L25' title='StillType.Key'>25</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L21' title='StillType.Map'>21</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L19' title='StillType.PurpleRupee'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L28' title='StillType.PurpleTriforce'>28</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/ItemFactory.cs#L14' title='StillType.ZeroHeart'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |

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
- 24 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/TimeBomb.cs#L14' title='TimeBomb.TimeBomb(double explodeDelayMillis, string name, ContentManager contentManager, Vector2 drawPos, Rectangle mask, float rotation, float scale)'>14</a> | 80 | 1 :heavy_check_mark: | 0 | 7 | 11 / 2 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/TimeBomb.cs#L31' title='bool TimeBomb.IsFinished'>31</a> | 94 | 2 :heavy_check_mark: | 0 | 0 | 1 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/TimeBomb.cs#L12' title='double TimeBomb.millisUntilExplode'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/TimeBomb.cs#L11' title='string TimeBomb.ResourceName'>11</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Item/TimeBomb.cs#L26' title='void TimeBomb.Update(GameTime time)'>26</a> | 94 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |

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
- 87 total lines of source code.
- Approximately 26 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="game1">
    Game1 :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Game1` contains 11 members.
- 85 total lines of source code.
- Approximately 26 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L26' title='Game1.Game1()'>26</a> | 67 | 1 :heavy_check_mark: | 0 | 5 | 15 / 8 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L87' title='void Game1.ChangeState(IGameState newState)'>87</a> | 79 | 1 :heavy_check_mark: | 0 | 1 | 7 / 4 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L24' title='IGameState Game1.currentState'>24</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L70' title='void Game1.Draw(GameTime gameTime)'>70</a> | 75 | 1 :heavy_check_mark: | 0 | 5 | 16 / 5 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L19' title='GraphicsDeviceManager Game1.graphics'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L42' title='void Game1.Initialize()'>42</a> | 84 | 1 :heavy_check_mark: | 0 | 5 | 10 / 3 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L17' title='Game1 Game1.Instance'>17</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L53' title='void Game1.LoadContent()'>53</a> | 88 | 1 :heavy_check_mark: | 0 | 3 | 6 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Game1.cs#L95' title='void Game1.Quit()'>95</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 1 |
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

The `Sprint.Sprites` namespace contains 6 named types.

- 6 named types.
- 568 total lines of source code.
- Approximately 167 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

<details>
<summary>
  <strong id="animatedsprite">
    AnimatedSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `AnimatedSprite` contains 19 members.
- 101 total lines of source code.
- Approximately 26 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L36' title='AnimatedSprite.AnimatedSprite(Texture2D texture, Vector2 position, int[] sheetXPositions, int sheetYPos, int spriteWidth, int spriteHeight, float frameTime)'>36</a> | 61 | 1 :heavy_check_mark: | 0 | 3 | 15 / 11 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L14' title='int AnimatedSprite.curFrame'>14</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L84' title='void AnimatedSprite.Draw(SpriteBatch spriteBatch, Vector2 location)'>84</a> | 80 | 1 :heavy_check_mark: | 0 | 6 | 24 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L17' title='float AnimatedSprite.elapsedTime'>17</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L13' title='int AnimatedSprite.frameCount'>13</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L19' title='int AnimatedSprite.frameHeight'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L16' title='float AnimatedSprite.frameTime'>16</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L18' title='int AnimatedSprite.frameWidth'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L11' title='Vector2 AnimatedSprite.pos'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L22' title='Vector2 AnimatedSprite.Position'>22</a> | 94 | 2 :heavy_check_mark: | 0 | 1 | 9 / 3 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L12' title='Rectangle AnimatedSprite.rect'>12</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L34' title='Rectangle AnimatedSprite.Rect'>34</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L68' title='void AnimatedSprite.SetFrame(int frame)'>68</a> | 92 | 1 :heavy_check_mark: | 0 | 1 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L15' title='int[] AnimatedSprite.sheetXPositions'>15</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L20' title='int AnimatedSprite.sheetY'>20</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L10' title='Texture2D AnimatedSprite.texture'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L32' title='Texture2D AnimatedSprite.Texture'>32</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L73' title='void AnimatedSprite.Update(GameTime gameTime)'>73</a> | 73 | 2 :heavy_check_mark: | 0 | 2 | 10 / 4 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/AnimatedSprite.cs#L52' title='void AnimatedSprite.UpdateRect()'>52</a> | 88 | 1 :heavy_check_mark: | 0 | 4 | 15 / 1 |

<a href="#AnimatedSprite-class-diagram">:link: to `AnimatedSprite` class diagram</a>

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
  <strong id="staticsprite">
    StaticSprite :heavy_check_mark:
  </strong>
</summary>
<br>

- The `StaticSprite` contains 8 members.
- 42 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L21' title='StaticSprite.StaticSprite(Texture2D texture, Vector2 position, Rectangle source)'>21</a> | 79 | 1 :heavy_check_mark: | 0 | 3 | 7 / 3 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L33' title='void StaticSprite.Draw(SpriteBatch spriteBatch, Vector2 location)'>33</a> | 80 | 1 :heavy_check_mark: | 0 | 6 | 15 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L10' title='Vector2 StaticSprite.pos'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L13' title='Vector2 StaticSprite.Position'>13</a> | 98 | 2 :heavy_check_mark: | 0 | 1 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L11' title='Rectangle StaticSprite.sourceRect'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L9' title='Texture2D StaticSprite.texture'>9</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L19' title='Texture2D StaticSprite.Texture'>19</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 2 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../Sprites/StaticSprite.cs#L29' title='void StaticSprite.Update(GameTime gameTime)'>29</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 3 / 0 |

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
    Sprint.UI :heavy_check_mark:
  </strong>
</summary>
<br>

The `Sprint.UI` namespace contains 5 named types.

- 5 named types.
- 116 total lines of source code.
- Approximately 18 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="dungeonwalls">
    DungeonWalls :heavy_check_mark:
  </strong>
</summary>
<br>

- The `DungeonWalls` contains 5 members.
- 20 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L13' title='DungeonWalls.DungeonWalls(Texture2D backgroundTexture)'>13</a> | 80 | 1 :heavy_check_mark: | 0 | 6 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L10' title='StaticSprite DungeonWalls.background'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L19' title='void DungeonWalls.Draw(SpriteBatch spriteBatch)'>19</a> | 87 | 1 :heavy_check_mark: | 0 | 6 | 4 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L11' title='Rectangle DungeonWalls.sourceRect'>11</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/DungeonWalls.cs#L24' title='void DungeonWalls.Update(GameTime gameTime)'>24</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 3 / 0 |

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
- 30 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L23' title='HUDBar.HUDBar(Texture2D backgroundTexture)'>23</a> | 81 | 1 :heavy_check_mark: | 0 | 4 | 5 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L18' title='StaticSprite HUDBar.background'>18</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L29' title='void HUDBar.Draw(SpriteBatch spriteBatch)'>29</a> | 81 | 1 :heavy_check_mark: | 0 | 6 | 6 / 2 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L21' title='HeartDisplay HUDBar.hearts'>21</a> | 86 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L19' title='Rectangle HUDBar.sourceRect'>19</a> | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L17' title='State HUDBar.state'>17</a> | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/HUDBar.cs#L36' title='void HUDBar.Update(GameTime gameTime)'>36</a> | 100 | 1 :heavy_check_mark: | 0 | 1 | 3 / 0 |

<a href="#HUDBar-class-diagram">:link: to `HUDBar` class diagram</a>

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

- The `UIManager` contains 7 members.
- 36 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L12' title='UIManager.UIManager()'>12</a> | 100 | 1 :heavy_check_mark: | 0 | 2 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L29' title='void UIManager.AddElement(IUIElement element)'>29</a> | 97 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L39' title='void UIManager.Clear()'>39</a> | 100 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L23' title='void UIManager.Draw(SpriteBatch spriteBatch)'>23</a> | 94 | 2 :heavy_check_mark: | 0 | 5 | 5 / 1 |
| Field | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L10' title='List<IUIElement> UIManager.elements'>10</a> | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L34' title='void UIManager.RemoveElement(IUIElement element)'>34</a> | 97 | 1 :heavy_check_mark: | 0 | 3 | 4 / 1 |
| Method | <a href='https://github.com/Abadi2225/The_Legend_of_Zilda/blob/main/../UI/UIManager.cs#L17' title='void UIManager.Update(GameTime gameTime)'>17</a> | 94 | 2 :heavy_check_mark: | 0 | 5 | 5 / 1 |

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
    -EnemyManager enemyManager
    -EnemyFactory enemyFactory
    -LevelLoader levelLoader
    -Level currentLevel
    -UIManager uiManager
    -CollisionManager collisionManager
    -bool lmbReleased
    -bool rmbReleased
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
    +.ctor(BlockManager blockManager, EnemyManager enemyManager) Level
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch) void
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
    +Rectangle Rect
    +.ctor(Texture2D texture, Vector2 pos, Rectangle sourceRect, bool walkable) Block
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
    -ISprite sprite
    -Vector2 position
    -Vector2 move
    -Directions direction
    -double damagedTimer
    -int health
    -bool isAttacking
    -bool isUsingItem
    -bool isDamaged
    -bool isVisible
    -bool attackHitLanded
    +Directions Facing
    +int Health
    +int MaxHealth
    +Rectangle Rect
    +Rectangle SwordRect
    +Vector2 Position
    +RegisterSwordHit() void
    +.ctor(Texture2D texture, Vector2 position) Link
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch) void
    +StartUseItem() void
    +SetMove(Directions dir) void
    +StopMove() void
    +StartAttack() void
    +TakeDamage(int amount) void
    +StartDamaged() void
    +FinishAttack() void
    +FinishUseItem() void
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
    +AttackDown(Texture2D texture, Action onFinished)$ Attacking
    +AttackUp(Texture2D texture, Action onFinished)$ Attacking
    +AttackLeft(Texture2D texture, Action onFinished)$ Attacking
    +AttackRight(Texture2D texture, Action onFinished)$ Attacking
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
    -ItemManager itemManager
    -bool forward
    +.ctor(ItemManager itemManager, bool forward) CycleItemCommand
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
    -ILink link
    -int slot
    +.ctor(ItemManager itemManager, ILink link, int slot) UseItemCommand
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
    +bool IsActive
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
    -float flipTimer
    -float throwTimer
    -bool spriteHorizontalFlip
    -float FLIP_INTERVAL$
    -Boomerang activeBoomerang
    -ContentManager contentManager
    -int[] upFrames
    -int[] downFrames
    -int[] sideFrames
    -int[] throwFrame
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
    -WallMasterState currentState
    -Vector2 homePosition
    -bool movingVertically
    +.ctor(Texture2D texture, Vector2 position) WallMaster
    +Update(GameTime gameTime) void
    +UpdateHidden() void
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
    -Hidden$
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
    +TakeDamage(int amount)* void
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
ISprite <|-- AbstractItem : implements
class AbstractItem{
    -Texture2D texture
    -ISprite sprite
    +Vector2 DrawPos
    +string Name
    +string DisplayName
    +bool IsFinished
    +.ctor(string name) AbstractItem
    +.ctor(string name, ContentManager contentManager, string resourceName, Vector2 drawPos) AbstractItem
    +Draw(SpriteBatch sb, Vector2 pos) void
    +Update(GameTime time) void
}

```

<div id="Arrow-class-diagram"></div>

##### `Arrow` class diagram

```mermaid
classDiagram
class Arrow{
    -string ResourceName$
    +bool IsFinished
    +.ctor(Rectangle texMask, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale, ContentManager cm) Arrow
    +StartMoving() Arrow
}

```

<div id="Boomerang-class-diagram"></div>

##### `Boomerang` class diagram

```mermaid
classDiagram
class Boomerang{
    -string ResourceName$
    +bool IsFinished
    +.ctor(Vector2 pos, Vector2 vel, float maxDistance, ContentManager contentManager) Boomerang
    +StartMoving() Boomerang
    +GetSprite() ISprite
}

```

<div id="BoomerangSprite-class-diagram"></div>

##### `BoomerangSprite` class diagram

```mermaid
classDiagram
ISprite <|-- BoomerangSprite : implements
class BoomerangSprite{
    -Vector2 Pos
    -Texture2D texture
    -Vector2 velocity
    -float scale
    -int animationFrame
    -int lastAnimationFrame
    -float distanceTraveled
    -float maxDistance
    -bool returning
    -bool thrown
    +bool IsActive
    +.ctor(Texture2D texture, Vector2 initialPos, Vector2 velocity, float maxDistance, float scale) BoomerangSprite
    +Throw() void
    +Draw(SpriteBatch sb, Vector2 location) void
    +Update(GameTime time) void
}

```

<div id="Bow-class-diagram"></div>

##### `Bow` class diagram

```mermaid
classDiagram
class Bow{
    -string ResourceName$
    +.ctor(string name, ContentManager contentManager, Vector2 drawPos, Rectangle mask, float rotation, float scale) Bow
}

```

<div id="ItemFactory-class-diagram"></div>

##### `ItemFactory` class diagram

```mermaid
classDiagram
class ItemFactory{
    -ContentManager contentManager$
    +CreateBoomerang(Vector2 pos, Vector2 vel, float maxDistance)$ Boomerang
    +CreateArrow(Vector2 pos, Vector2 vel, float rotation, float scale = 1, float maxDistance = null)$ Arrow
    +CreateTimeBomb(double explodeDelayMillis, Vector2 pos, float scale, float rotation = null)$ TimeBomb
    +CreateStillItem(StillType type, Vector2 pos, float rotation = null, float scale = null)$ StillItem
}

```

<div id="ItemManager-class-diagram"></div>

##### `ItemManager` class diagram

```mermaid
classDiagram
class ItemManager{
    -List<AbstractItem> SpawnedItems
    +List<AbstractItem> Inventory
    +int ActiveItem
    +.ctor() ItemManager
    +UseItem(ILink link, int slot) void
    +Add(AbstractItem item) void
    +SpawnItem(AbstractItem item) void
    +Draw(SpriteBatch sb) void
    +Update(GameTime time) void
    +GetActiveItem() AbstractItem
    +CycleNext() void
    +CyclePrevious() void
}

```

<div id="ProjectileSprite-class-diagram"></div>

##### `ProjectileSprite` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- ProjectileSprite : implements
class ProjectileSprite{
    -Texture2D texture
    -Rectangle texMask
    -Vector2 velocity
    -float maxDistance
    -float rotation
    -Vector2 origin
    -float scale
    -float distanceTraveled
    -bool isMoving
    -bool ReachedMaxDistance
    +Vector2 Position
    +.ctor(Texture2D texture, Rectangle texMask, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale) ProjectileSprite
    +StartMoving() void
    +Update(GameTime time) void
    +Draw(SpriteBatch sb, Vector2 unused) void
}

```

<div id="StillItem-class-diagram"></div>

##### `StillItem` class diagram

```mermaid
classDiagram
class StillItem{
    -string ResourceName$
    +.ctor(string name, ContentManager contentManager, Vector2 drawPos, Rectangle mask, float rotation, float scale) StillItem
}

```

<div id="StillItemSprite-class-diagram"></div>

##### `StillItemSprite` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- StillItemSprite : implements
class StillItemSprite{
    -Texture2D texture
    -Rectangle textureMask
    -float rotation
    -float scale
    +Vector2 Position
    +.ctor(Vector2 position, Texture2D texture, Rectangle mask, float rotation, float scale) StillItemSprite
    +Draw(SpriteBatch sb, Vector2 unused) void
    +Update(GameTime time) void
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
    -string ResourceName$
    -double millisUntilExplode
    +bool IsFinished
    +.ctor(double explodeDelayMillis, string name, ContentManager contentManager, Vector2 drawPos, Rectangle mask, float rotation, float scale) TimeBomb
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

<div id="StaticSprite-class-diagram"></div>

##### `StaticSprite` class diagram

```mermaid
classDiagram
IPositionedSprite <|-- StaticSprite : implements
class StaticSprite{
    -Texture2D texture
    -Vector2 pos
    -Rectangle sourceRect
    +Vector2 Position
    +Texture2D Texture
    +.ctor(Texture2D texture, Vector2 position, Rectangle source) StaticSprite
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
    -StaticSprite background
    -Rectangle sourceRect
    +.ctor(Texture2D backgroundTexture) DungeonWalls
    +Draw(SpriteBatch spriteBatch) void
    +Update(GameTime gameTime) void
}

```

<div id="HUDBar-class-diagram"></div>

##### `HUDBar` class diagram

```mermaid
classDiagram
IUIElement <|-- HUDBar : implements
class HUDBar{
    -State state
    -StaticSprite background
    -Rectangle sourceRect
    -HeartDisplay hearts
    +.ctor(Texture2D backgroundTexture) HUDBar
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
    +Update(GameTime gameTime) void
    +Draw(SpriteBatch spriteBatch) void
    +AddElement(IUIElement element) void
    +RemoveElement(IUIElement element) void
    +Clear() void
}

```

*This file is maintained by a bot.*

<!-- markdownlint-restore -->
