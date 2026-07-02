# Architecture Patterns

**Project:** Hrafnar Tower Defense

**Document Version:** 2.0

---

# Table of Contents

1. Overview
2. Architectural Goals
3. High-Level Architecture
4. Feature Modules
5. Layer Responsibilities
6. Design Patterns
7. Composition over Inheritance
8. Event-Driven Communication
9. Dependency Management
10. Data-Driven Design
11. State Machines
12. Object Pooling
13. Separation of Concerns
14. Anti-Patterns
15. Adding New Features
16. Code Review Checklist
17. Related Documentation

---

# 1. Overview

This document defines the architectural patterns used throughout the project.

The project follows a modular architecture based on Feature Modules, where each gameplay mechanic is implemented as an independent module.

The primary goals are:

- Scalability
- Maintainability
- Readability
- Low coupling
- High cohesion
- Easy testing
- Reusability

Every new gameplay mechanic should integrate into the existing architecture without affecting unrelated systems.

---

# 2. Architectural Goals

The architecture should be:

- Modular
- Feature-oriented
- Data-driven
- Event-driven
- Performance-conscious
- Easy to maintain
- Easy to extend

New gameplay mechanics should require adding new modules rather than modifying existing ones.

---

# 3. High-Level Architecture

The project is divided into several major layers.

```text
Game
│
├── Core
│
├── Managers
│
├── Feature Modules
│   ├── Buildings
│   ├── Camera
│   ├── Castle
│   ├── Enemies
│   ├── FogOfWar
│   ├── Grid
│   ├── Projectiles
│   ├── Resources
│   ├── Towers
│   ├── Waves
│   └── ...
│
├── UI
│
└── ScriptableObjects
```

Each layer has a clearly defined responsibility.

---

# 4. Feature Modules

A Feature Module is a self-contained gameplay feature.

Each module owns everything related to its functionality.

Typical module structure:

```text
Feature/
│
├── Components/
├── Controllers/
├── Events/
├── Factories/
├── Interfaces/
├── Runtime/
├── States/
├── Systems/
├── Utilities/
└── Views/
```

Some modules may additionally contain:

```text
Config/
Data/
Editor/
```

depending on their requirements.

Examples of Feature Modules:

- Grid
- Buildings
- Towers
- Enemies
- Waves
- Resources
- FogOfWar
- Camera
- Castle

Each module should remain as independent as possible.

---

# 5. Layer Responsibilities

## Core

Contains shared infrastructure.

Examples:

- Bootstrap
- Event Bus
- State Machine Framework
- Utility Services

---

## Managers

Coordinate global systems.

Examples:

- GameManager
- SceneManager
- AudioManager
- SaveManager
- UIManager

Managers should never contain gameplay logic.

---

## Feature Modules

Contain gameplay implementation.

Each module owns:

- Runtime logic
- Components
- Events
- Systems
- Internal utilities

Modules communicate using events whenever practical.

---

## UI

Contains only user interface logic.

Gameplay logic should not exist inside UI.

---

## ScriptableObjects

Contain configuration data only.

Gameplay behavior belongs in code.

---

# 6. Design Patterns

The project uses the following patterns where appropriate:

- Feature Module
- State Machine
- Factory
- Strategy
- Object Pool
- Observer (Events)
- Singleton (limited use)
- Command (future expansion)

Patterns should simplify the architecture rather than complicate it.

---

# 7. Composition over Inheritance

Prefer composition over deep inheritance hierarchies.

Instead of:

```text
Tower
 └── ArrowTower
      └── FireArrowTower
```

Prefer:

```text
Tower
├── TargetingComponent
├── AttackComponent
├── UpgradeComponent
└── BuffComponent
```

This improves flexibility and reduces coupling.

---

# 8. Event-Driven Communication

Feature Modules should communicate through events.

Examples:

- WaveStarted
- WaveEnded
- EnemyKilled
- BuildingPlaced
- ResourceChanged
- FogRevealed

Avoid direct references between unrelated modules.

---

# 9. Dependency Management

Dependencies should be explicit.

Prefer:

- Initialization methods
- Constructor injection (for non-MonoBehaviour classes)
- Interfaces

Avoid:

- Circular dependencies
- Hidden references
- Global searches
- Tight coupling

---

# 10. Data-Driven Design

Gameplay configuration belongs in ScriptableObjects.

The project defines two categories:

## Gameplay Data

Describes individual gameplay objects.

Examples:

- TowerData
- EnemyData
- BuildingData
- WaveData

## System Configuration

Defines global settings for gameplay systems.

Examples:

- GridConfig
- CameraConfig
- EconomyConfig
- FogOfWarConfig
- GameConfig

Behavior must never be implemented inside ScriptableObjects.

---

# 11. State Machines

Complex behaviors should be implemented using state machines.

Recommended for:

- Enemies
- Camera
- Towers
- Building Placement
- Game Flow

Each state should have a single responsibility.

---

# 12. Object Pooling

Objects created frequently should use object pooling.

Examples:

- Enemies
- Projectiles
- Effects
- Floating Damage Numbers

Avoid frequent Instantiate() and Destroy() operations during gameplay.

---

# 13. Separation of Concerns

Each class should have one clear responsibility.

Examples:

GridSystem

- Grid logic

ConstructionSystem

- Building placement

WaveSystem

- Wave progression

ResourceSystem

- Economy

Avoid classes responsible for multiple unrelated systems.

---

# 14. Anti-Patterns

Avoid the following:

- God Object
- Massive Manager
- Circular Dependencies
- Singleton Everywhere
- Hardcoded Gameplay Values
- Deep Inheritance
- Excessive Update()
- Cross-Module Logic

Each module should remain self-contained.

---

# 15. Adding New Features

When adding a new gameplay mechanic:

1. Create a new Feature Module.
2. Add Gameplay Data assets if required.
3. Add System Configuration assets if required.
4. Implement the module's systems.
5. Implement runtime components.
6. Connect the module using events.
7. Test the module independently.
8. Integrate with Managers only if necessary.

Adding a new feature should not require modifying existing modules whenever possible.

---

# 16. Code Review Checklist

Before merging a new module:

- Fits the modular architecture.
- One responsibility per class.
- One responsibility per module.
- Uses composition.
- Uses events where appropriate.
- Uses ScriptableObjects correctly.
- No circular dependencies.
- No unnecessary Singletons.
- No gameplay logic inside Managers.
- No runtime state inside ScriptableObjects.
- Module can be understood independently.

---

# 17. Related Documentation

Architecture

- ../Architecture/

Coding Standards

- StyleGuide.md
- Naming.md
- BestPractices.md
- ScriptableObjects.md
- Performance.md
- FolderStructure.md

Gameplay

- ../Gameplay/

Art Guide

- ../ArtGuide/
