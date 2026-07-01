# Gameplay Systems

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Design Principles
3. System Categories
4. Core Gameplay Systems
5. Support Systems
6. System Communication
7. Dependencies
8. Update Order
9. Events
10. Future Expansion
11. Related Documentation

---

# 1. Overview

Gameplay Systems are independent modules responsible for implementing game mechanics.

Each system owns a single gameplay feature and exposes a clear public API.

Systems should remain independent whenever possible.

Managers coordinate systems.

Systems implement gameplay.

---

# 2. Design Principles

Every gameplay system follows the same architectural rules.

## Single Responsibility

One system = one gameplay feature.

Examples:

- Grid System
- Wave System
- Enemy System

Never combine unrelated mechanics into one system.

---

## Independence

Systems should not know internal implementation details of other systems.

Communication should happen through public APIs or events.

---

## Data Driven

Configuration data should be stored in ScriptableObjects.

Examples:

- Enemy stats
- Building stats
- Tower stats
- Resources
- Waves

---

## Event Driven

Whenever possible, systems should communicate through events instead of direct references.

---

## Extensible

Adding a new gameplay feature should require adding a new system instead of modifying existing ones.

---

# 3. System Categories

Gameplay systems are divided into several categories.

## Core Systems

Fundamental gameplay mechanics.

## World Systems

World simulation.

## Combat Systems

Everything related to combat.

## Economy Systems

Resource management.

## UI Support Systems

Gameplay systems supporting the UI.

## Technical Systems

Infrastructure used by gameplay.

---

# 4. Core Gameplay Systems

## Grid System

Responsible for:

- world grid
- occupied cells
- build validation
- build coordinates
- cell queries

---

## Building System

Responsible for:

- placing buildings
- removing buildings
- moving buildings
- building ownership

---

## Construction System

Responsible for:

- construction rules
- placement validation
- placement preview
- collision checks

---

## Upgrade System

Responsible for:

- building upgrades
- upgrade validation
- upgrade costs

---

## Repair System

Responsible for:

- repairing buildings
- repair costs
- repair timers

---

## Resource System

Responsible for:

- resource generation
- resource spending
- storage capacity
- production rates

Player resources themselves are tracked by ResourceManager.

---

## Wave System

Responsible for:

- wave timing
- wave generation
- countdown
- difficulty scaling

---

## Spawn System

Responsible for:

- enemy spawning
- spawn queues
- spawn locations

---

## Enemy System

Responsible for:

- enemy lifecycle
- enemy behaviour
- enemy movement
- enemy death

---

## Pathfinding System

Responsible for:

- road navigation
- path calculation
- path updates

---

## Combat System

Responsible for:

- attacks
- damage
- armor
- combat calculations

---

## Projectile System

Responsible for:

- projectiles
- trajectories
- collisions
- impact

---

## Fog Of War System

Responsible for:

- hidden areas
- revealed areas
- visibility calculations

---

## Vision System

Responsible for:

- visibility radius
- revealed cells
- exploration state

---

## Camera System

Responsible for:

- movement
- zoom
- rotation
- edge scrolling

---

## Selection System

Responsible for:

- selecting buildings
- deselection
- multi-selection (future)

---

## Interaction System

Responsible for:

- mouse interaction
- hover detection
- clicks
- object interaction

---

## Time System

Responsible for:

- game time
- pause state
- time scaling

---

# 5. Support Systems

These systems provide infrastructure for gameplay.

## Save System

Game serialization.

---

## Audio System

Gameplay sound playback.

---

## Localization System

Localized gameplay text.

---

## Object Pooling System

Reusable objects.

Examples:

- projectiles
- particles
- enemies

---

## Event System

Centralized gameplay events.

---

## Random Generation System

Responsible for:

- random trees
- random rocks
- random resource crates
- procedural object placement

---

# 6. System Communication

Preferred communication:

```
System A

↓

Event

↓

System B
```

or

```
System A

↓

Public API

↓

System B
```

Avoid:

```
System A

↓

System B

↓

System C

↓

System D
```

Long dependency chains increase coupling.

---

# 7. Dependencies

Allowed

```
Construction

↓

Grid
```

```
Wave

↓

Spawn
```

```
Enemy

↓

Combat
```

```
Projectile

↓

Combat
```

Forbidden

```
Grid

↓

UI
```

```
Enemy

↓

Audio
```

```
Fog

↓

Camera
```

```
Resource

↓

Wave
```

---

# 8. Update Order

Gameplay systems update in a predictable order.

1. Input
2. Interaction
3. Selection
4. Construction
5. Grid
6. Resource
7. Waves
8. Spawn
9. Enemy
10. Pathfinding
11. Combat
12. Projectiles
13. Fog Of War
14. Camera
15. UI

The exact initialization order is described in Initialization.md.

---

# 9. Events

Gameplay systems should expose events instead of directly calling unrelated systems.

Examples:

BuildingPlaced

BuildingDestroyed

WaveStarted

WaveEnded

EnemySpawned

EnemyKilled

ResourceCollected

ResourceSpent

TowerUpgraded

FogUpdated

Using events reduces coupling between systems.

---

# 10. Future Expansion

Possible future gameplay systems.

- Quest System
- Achievement System
- Weather System
- Diplomacy System
- Buff System
- Skill System
- Technology System
- Analytics System
- Mod Support System

The architecture should allow adding these systems without modifying existing gameplay systems.

---

# 11. Related Documentation

Architecture Overview

- ARCHITECTURE.md

Managers

- Managers.md

Initialization

- Initialization.md

Scene Flow

- SceneFlow.md

Gameplay Documentation

- Gameplay/Buildings.md
- Gameplay/Enemies.md
- Gameplay/Resources.md
- Gameplay/Waves.md
- Gameplay/FogOfWar.md

Coding Standards

- CodingStandard/FolderStructure.md
- CodingStandard/BestPractices.md
