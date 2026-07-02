# ScriptableObject Guide

**Project:** Hrafnar Tower Defense

**Document Version:** 2.0

---

# Table of Contents

1. Overview
2. Philosophy
3. ScriptableObject Categories
4. Gameplay Data
5. System Configuration
6. Runtime Data
7. Asset Organization
8. Naming Conventions
9. Asset Creation
10. Data Relationships
11. Validation
12. Versioning
13. Best Practices
14. Common Mistakes
15. Tower Defense Data Model
16. Code Review Checklist
17. Related Documentation

---

# 1. Overview

This document defines how ScriptableObjects are used throughout the project.

The project follows a **Data-Driven Design** approach, where gameplay behavior is implemented in code, while configurable values are stored in ScriptableObjects.

ScriptableObjects are divided into two categories:

- Gameplay Data (`*Data`)
- System Configuration (`*Config`)

Each category has a clearly defined responsibility.

---

# 2. Philosophy

The project follows a strict separation between **behavior** and **configuration**.

- Code defines **how** something works.
- ScriptableObjects define **what values** are used.

ScriptableObjects should be treated as immutable assets during gameplay.

They should never store runtime state.

---

# 3. ScriptableObject Categories

There are only two official categories of ScriptableObjects.

## Gameplay Data (`*Data`)

Represents the configuration of a specific gameplay object.

Examples:

- TowerData
- EnemyData
- BuildingData
- ProjectileData
- ResourceData
- WaveData
- UpgradeData

Gameplay Data answers the question:

> "What are the properties of this game object?"

---

## System Configuration (`*Config`)

Stores settings for an entire gameplay system.

Examples:

- GridConfig
- CameraConfig
- FogOfWarConfig
- EconomyConfig
- AudioConfig
- InputConfig
- SaveConfig
- GameConfig

Configuration answers the question:

> "How should this system behave?"

---

# 4. Gameplay Data

Gameplay Data assets describe individual gameplay objects.

Typical values include:

- Damage
- Health
- Cost
- Speed
- Range
- Attack Speed
- Build Time
- Armor
- Rewards
- Icons
- Prefabs
- Audio
- VFX
- Upgrade values

Each asset represents one gameplay object.

Examples:

```text
TowerData

EnemyData

BuildingData
```

Gameplay Data should never contain runtime values.

---

# 5. System Configuration

Configuration assets define the behavior of complete systems.

Typical values include:

GridConfig

- Cell Size
- Grid Width
- Grid Height

CameraConfig

- Zoom Speed
- Min Zoom
- Max Zoom
- Rotation Speed

FogOfWarConfig

- Reveal Radius
- Update Interval

EconomyConfig

- Starting Resources
- Resource Limits
- Sell Multiplier

GameConfig

- Max Waves
- Autosave Interval
- Difficulty Multipliers

Configuration assets are shared across the entire game.

---

# 6. Runtime Data

Runtime data belongs inside runtime objects.

Example:

EnemyData

Stores:

- Max Health
- Speed
- Reward

Enemy

Stores:

- Current Health
- Current Target
- Current State
- Current Position

Only runtime objects should change during gameplay.

---

# 7. Asset Organization

```text
Assets/
└── ScriptableObjects/
    ├── Data/
    │   ├── Buildings/
    │   ├── Enemies/
    │   ├── Projectiles/
    │   ├── Resources/
    │   ├── Towers/
    │   ├── Upgrades/
    │   └── Waves/
    │
    └── Config/
        ├── Audio/
        ├── Camera/
        ├── Economy/
        ├── FogOfWar/
        ├── Game/
        ├── Grid/
        ├── Input/
        └── Save/
```

Gameplay Data and Configuration assets must always remain separated.

---

# 8. Naming Conventions

Gameplay Data

```text
EnemyData

TowerData

BuildingData

WaveData
```

Configuration

```text
GridConfig

GameConfig

CameraConfig

EconomyConfig

FogOfWarConfig
```

Never mix the suffixes.

A Data asset should never end with Config.

A Config asset should never end with Data.

Refer to CodingStandard/Naming.md for additional naming rules.

---

# 9. Asset Creation

Every ScriptableObject should expose a Create Asset menu.

Examples:

Gameplay Data

```csharp
[CreateAssetMenu(
    menuName = "Hrafnar/Data/Towers/Tower Data",
    fileName = "TowerData"
)]
```

Configuration

```csharp
[CreateAssetMenu(
    menuName = "Hrafnar/Config/Grid/Grid Config",
    fileName = "GridConfig"
)]
```

Maintain a consistent menu hierarchy.

---

# 10. Data Relationships

Always prefer references over duplicated values.

Example:

WaveData

contains:

- EnemyData reference
- Spawn Count
- Spawn Delay

instead of copying enemy statistics.

This ensures that balancing an enemy automatically affects every wave using that enemy.

---

# 11. Validation

All ScriptableObjects should validate their own data.

Examples:

TowerData

- Damage ≥ 0
- Range > 0
- Prefab assigned

EnemyData

- Health > 0
- Reward ≥ 0

GridConfig

- Cell Size > 0
- Width > 0
- Height > 0

CameraConfig

- Min Zoom < Max Zoom

Use `OnValidate()` for editor-time validation whenever appropriate.

---

# 12. Versioning

Avoid deleting serialized fields unnecessarily.

When changing asset structures:

- Preserve existing data.
- Migrate assets carefully.
- Verify old assets after serialization changes.

---

# 13. Best Practices

- Keep each asset focused.
- One responsibility per asset.
- Prefer references.
- Avoid duplicated values.
- Separate runtime state from configuration.
- Validate assets.
- Make balancing designer-friendly.

---

# 14. Common Mistakes

Avoid:

- Runtime state inside assets.
- Giant GameData assets.
- Duplicate values.
- Circular references.
- Hardcoded gameplay values.
- Mixing Data and Config responsibilities.

---

# 15. Tower Defense Data Model

Gameplay Data

```text
TowerData
EnemyData
BuildingData
ProjectileData
WaveData
UpgradeData
ResourceData
```

Configuration

```text
GameConfig
GridConfig
CameraConfig
FogOfWarConfig
EconomyConfig
AudioConfig
InputConfig
SaveConfig
```

This separation keeps gameplay objects independent from system-wide settings.

---

# 16. Code Review Checklist

Before creating or modifying a ScriptableObject:

- Correct category (Data or Config)
- No runtime state stored
- One responsibility only
- Proper validation
- Naming follows conventions
- Uses references where appropriate
- Stored in the correct folder
- CreateAssetMenu configured
- Inspector organized

---

# 17. Related Documentation

Coding Standards

- StyleGuide.md
- Naming.md
- BestPractices.md
- Performance.md
- ArchitecturePatterns.md
- FolderStructure.md

Architecture

- ../Architecture/

Gameplay

- ../Gameplay/
