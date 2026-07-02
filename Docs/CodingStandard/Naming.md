# C# Naming Convention

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. General Principles
3. Namespaces
4. Files
5. Classes
6. Interfaces
7. Abstract Classes
8. Static Classes
9. Structs
10. Enums
11. Enum Values
12. Methods
13. Parameters
14. Local Variables
15. Fields
16. Constants
17. Readonly Fields
18. Properties
19. Events
20. Delegates
21. Generic Types
22. MonoBehaviour Classes
23. ScriptableObject Classes
24. Manager Classes
25. System Classes
26. Factory Classes
27. State Classes
28. UI Classes
29. Test Classes
30. Asset Menu Names
31. Common Abbreviations
32. Forbidden Naming
33. Naming Examples
34. Related Documentation

---

# 1. Overview

This document defines the naming conventions for all C# code used in the project.

Following these rules ensures:

- Readable code
- Consistent naming
- Easier navigation
- Better maintainability
- Faster onboarding for new developers

All new code must follow these conventions.

---

# 2. General Principles

Use:

- English only
- Full words whenever practical
- PascalCase
- camelCase
- Descriptive names

Avoid:

- Abbreviations
- Temporary names
- Numbers without meaning
- Single-letter identifiers (except loop counters)

Names should describe intent rather than implementation.

---

# 3. Namespaces

Namespaces use **PascalCase**.

Examples:

```text
Hrafnar.Core

Hrafnar.Managers

Hrafnar.Systems

Hrafnar.Gameplay

Hrafnar.UI
```

Namespace names should match the folder hierarchy.

---

# 4. Files

One public type per file.

The filename must match the class name.

Correct:

```text
WaveManager.cs

GridSystem.cs

EnemyData.cs
```

Incorrect:

```text
Script1.cs

Manager.cs

NewBehaviour.cs
```

---

# 5. Classes

Classes use **PascalCase**.

Correct:

```csharp
GameManager

WaveManager

EnemySpawner

Castle
```

Incorrect:

```csharp
gameManager

game_manager

Manager1
```

---

# 6. Interfaces

Interfaces begin with **I**.

Examples:

```csharp
IDamageable

ISelectable

ISaveable

IBuilding
```

---

# 7. Abstract Classes

Abstract classes use PascalCase.

Avoid prefixes like:

```text
Base
Abstract
```

unless they genuinely improve readability.

Prefer:

```csharp
Building

Tower
```

instead of:

```csharp
BaseBuilding

AbstractTower
```

---

# 8. Static Classes

Static classes use PascalCase.

Examples:

```csharp
MathUtility

GridUtility

SceneUtility
```

---

# 9. Structs

Struct names use PascalCase.

Examples:

```csharp
GridPosition

DamageInfo

SpawnPoint
```

---

# 10. Enums

Enum names use singular PascalCase.

Correct:

```csharp
BuildingType

EnemyType

ResourceType
```

Incorrect:

```csharp
BuildingTypes
```

---

# 11. Enum Values

Enum values also use PascalCase.

Example:

```csharp
public enum EnemyType
{
    Goblin,
    Orc,
    Troll
}
```

---

# 12. Methods

Methods use PascalCase and should begin with a verb.

Examples:

```csharp
StartWave()

SpawnEnemy()

CalculateDamage()

MoveCamera()
```

Avoid vague names like:

```csharp
Run()

Process()

Handle()
```

unless the context is obvious.

---

# 13. Parameters

Method parameters use **camelCase**.

Example:

```csharp
SpawnEnemy(EnemyData enemyData)
```

---

# 14. Local Variables

Local variables use **camelCase**.

Example:

```csharp
enemyCount

currentWave

selectedTower
```

---

# 15. Fields

Private fields use **camelCase** with a leading underscore.

Example:

```csharp
[SerializeField]
private int _health;

private Camera _mainCamera;

private GridSystem _gridSystem;
```

Public fields are discouraged.

---

# 16. Constants

Constants use PascalCase.

Example:

```csharp
private const float MaxBuildDistance = 5f;
```

---

# 17. Readonly Fields

Readonly fields use the same convention as private fields.

Example:

```csharp
private readonly List<Enemy> _activeEnemies;
```

---

# 18. Properties

Properties use PascalCase.

Example:

```csharp
public int Health { get; private set; }

public bool IsAlive { get; private set; }
```

Boolean properties should begin with:

- Is
- Has
- Can
- Should

---

# 19. Events

Events use PascalCase and describe what happened.

Examples:

```csharp
WaveStarted

WaveEnded

EnemyKilled

BuildingPlaced
```

Avoid prefixes such as:

```text
OnWaveStarted
```

`On...` should be reserved for methods that invoke or respond to events.

---

# 20. Delegates

Delegates use PascalCase.

Examples:

```csharp
DamageHandler

BuildingSelectedHandler
```

---

# 21. Generic Types

Use descriptive generic names where possible.

Example:

```csharp
Repository<TItem>

Pool<TObject>
```

Prefer meaningful names over single letters when clarity improves.

---

# 22. MonoBehaviour Classes

MonoBehaviour classes use PascalCase and describe their responsibility.

Examples:

```csharp
CameraController

EnemySpawner

BuildingPreview

HealthBar
```

Avoid generic names like:

```text
Manager

Controller

Script
```

---

# 23. ScriptableObject Classes

Configuration assets should end with **Data** or **Config**.

Examples:

```csharp
TowerData

EnemyData

WaveData

ResourceConfig
```

---

# 24. Manager Classes

Global managers end with **Manager**.

Examples:

```csharp
GameManager

AudioManager

SceneManager

UIManager
```

Managers should coordinate systems rather than contain gameplay logic.

---

# 25. System Classes

Gameplay systems end with **System**.

Examples:

```csharp
GridSystem

WaveSystem

ConstructionSystem

FogOfWarSystem
```

Systems implement gameplay mechanics.

---

# 26. Factory Classes

Factories end with **Factory**.

Examples:

```csharp
EnemyFactory

ProjectileFactory
```

---

# 27. State Classes

State machine states end with **State**.

Examples:

```csharp
IdleState

AttackState

MoveState

BuildState
```

---

# 28. UI Classes

UI classes should describe the screen or widget.

Examples:

```csharp
MainMenuView

PauseMenuView

HealthBarView

ResourcePanel
```

Prefer suffixes such as:

- View
- Panel
- Window
- Popup

---

# 29. Test Classes

Tests mirror the production class name.

Examples:

```text
GridSystemTests

WaveManagerTests

EnemyFactoryTests
```

---

# 30. Asset Menu Names

ScriptableObject asset menus should follow a consistent hierarchy.

Example:

```text
Hrafnar/

    Buildings/

    Enemies/

    Waves/

    Resources/
```

---

# 31. Common Abbreviations

Allowed:

```text
UI

ID

URL

FPS

LOD

VFX

SFX

XP
```

Avoid inventing project-specific abbreviations.

---

# 32. Forbidden Naming

Do not use:

```text
tmp

test

new

object

manager1

script

data2

copy

final
```

Names should always describe the purpose of the object.

---

# 33. Naming Examples

| Type | Example |
|------|---------|
| Namespace | Hrafnar.Systems |
| Class | WaveManager |
| Interface | IDamageable |
| Enum | BuildingType |
| Method | SpawnEnemy |
| Property | Health |
| Field | _health |
| Constant | MaxHealth |
| Event | WaveStarted |
| ScriptableObject | TowerData |
| System | GridSystem |
| Manager | AudioManager |
| Factory | EnemyFactory |
| State | BuildState |

---

# 34. Related Documentation

Coding Standards

- StyleGuide.md
- BestPractices.md
- Comments.md
- Performance.md
- ScriptableObjects.md
- ArchitecturePatterns.md
- FolderStructure.md

Architecture

- ../Architecture/

Gameplay

- ../Gameplay/
