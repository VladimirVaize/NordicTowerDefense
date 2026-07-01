# Project Architecture

**Project:** Hrafnar Tower Defense

**Engine:** Unity 6.5 (6000.5.1f1)

**Render Pipeline:** Universal Render Pipeline (URP)

**Architecture Version:** 1.0

---

# Table of Contents

1. Overview
2. Architecture Goals
3. Core Principles
4. High-Level Architecture
5. Project Layers
6. Core Modules
7. Data Flow
8. Dependency Rules
9. Update Order
10. Folder Responsibilities
11. Extensibility
12. Performance Guidelines
13. Future Architecture
14. Related Documentation

---

# 1. Overview

The project follows a modular architecture designed specifically for long-term game development.

The primary goals are:

- Maintainability
- Scalability
- Readability
- Separation of responsibilities
- Easy onboarding for new developers
- Minimal coupling between systems

Every gameplay feature should be implemented as an independent module whenever possible.

No system should become a "God Object" responsible for unrelated functionality.

---

# 2. Architecture Goals

The architecture is designed to satisfy the following requirements.

## Scalability

The project should allow adding:

- new towers
- new enemies
- new maps
- new resources
- new buildings
- new gameplay mechanics

without major refactoring.

---

## Modularity

Every gameplay system should exist independently.

Example:

- Grid System
- Building System
- Enemy System
- Wave System
- Resource System

should be implemented as separate modules.

---

## Readability

The project should remain understandable after several years of development.

Code should prioritize clarity over cleverness.

---

## Testability

Gameplay systems should be isolated enough to allow testing independently inside the Sandbox scene.

---

## Reusability

Systems should expose public interfaces instead of relying on direct references whenever possible.

---

# 3. Core Principles

The project follows several architectural principles.

## Single Responsibility Principle

Every class should have one clear responsibility.

Good:

GridManager
→ manages only the grid.

Bad:

GameManager
→ grid
→ enemies
→ resources
→ UI
→ saving
→ audio
→ camera

---

## Composition over Inheritance

Gameplay behaviour should be composed from components instead of deep inheritance trees.

Preferred:

```
Building
    ├── Health
    ├── Upgrade
    ├── Repair
    ├── Production
```

Avoid:

```
Building
    ↓
DefensiveBuilding
    ↓
FireTower
    ↓
AdvancedFireTower
```

---

## Loose Coupling

Systems should communicate through clearly defined APIs.

Avoid direct dependencies whenever possible.

---

## Data-Driven Design

Gameplay values should be stored in ScriptableObjects whenever possible.

Examples:

- Tower stats
- Enemy stats
- Resources
- Waves
- Buildings

Logic belongs in code.

Data belongs in assets.

---

## Separation of Data and Behaviour

Gameplay logic should never contain hardcoded balancing values.

Bad:

damage = 25;

Good:

damage = TowerData.Damage;

---

# 4. High-Level Architecture

The project is divided into several independent layers.

```
Application
│
├── Bootstrap
│
├── Core
│
├── Managers
│
├── Gameplay
│
├── UI
│
├── Audio
│
├── Saving
│
└── Rendering
```

Each layer has a specific responsibility.

---

# 5. Project Layers

## Bootstrap

Responsible for:

- application startup
- service initialization
- manager creation
- scene loading

---

## Core

Contains:

- base classes
- interfaces
- utilities
- common helpers
- constants

Core should never depend on Gameplay.

---

## Managers

Contains all high-level managers.

Examples:

- GameManager
- UIManager
- AudioManager
- SaveManager
- ResourceManager

Managers coordinate systems.

They should not contain gameplay logic.

---

## Gameplay

Contains all gameplay mechanics.

Examples:

- Grid
- Buildings
- Towers
- Enemies
- Waves
- Fog of War
- Resources

Gameplay systems should remain independent.

---

## UI

Contains:

- HUD
- Menus
- Windows
- Notifications

UI should never control gameplay directly.

Instead it should communicate through managers.

---

## Audio

Responsible for:

- music
- sound effects
- ambient sounds

---

## Saving

Responsible for:

- serialization
- loading
- autosave
- save validation

---

## Rendering

Responsible for:

- Fog of War
- VFX
- camera effects
- rendering utilities

---

# 6. Core Modules

The project is divided into multiple independent modules.

Core modules include:

- Grid System
- Building System
- Resource System
- Enemy System
- Wave System
- Projectile System
- Fog of War System
- Camera System
- UI System
- Save System
- Audio System

Each module should expose only its public API.

Internal implementation should remain hidden.

---

# 7. Data Flow

The general flow of information inside the project is:

```
Input
    ↓
Game Manager
    ↓
Gameplay Systems
    ↓
Events
    ↓
UI
```

Gameplay systems should not update UI directly.

Instead they notify interested systems through events or manager APIs.

---

# 8. Dependency Rules

Allowed dependencies:

```
Gameplay
    ↓
Core
```

```
Managers
    ↓
Gameplay
```

```
UI
    ↓
Managers
```

Forbidden dependencies:

Gameplay → UI

Core → Gameplay

Core → UI

Saving → UI

Grid → Camera

Enemy → UI

Building → UI

These rules help keep the architecture clean and reduce tight coupling.

---

# 9. Update Order

The general update sequence is:

1. Input
2. Managers
3. Gameplay Systems
4. AI
5. Physics
6. Projectiles
7. UI
8. Audio

The exact initialization process is described in **Initialization.md**.

---

# 10. Folder Responsibilities

Each folder has a single responsibility.

Example:

Core/
Contains reusable framework code.

Gameplay/
Contains all gameplay mechanics.

Managers/
Contains high-level coordinators.

UI/
Contains all interface elements.

Art/
Contains imported art assets.

Prefabs/
Contains reusable prefabs.

ScriptableObjects/
Contains game configuration data.

Documentation about folder structure is available in:

**CodingStandard/FolderStructure.md**

---

# 11. Extensibility

The architecture is designed to support future expansion.

Examples:

- Multiplayer
- New enemy factions
- New resource types
- New tower categories
- New maps
- New game modes
- Steam Workshop support

No existing module should require significant redesign when these systems are added.

---

# 12. Performance Guidelines

The project follows several performance principles.

- Avoid unnecessary Update() methods.
- Prefer event-driven communication.
- Cache frequently used references.
- Minimize memory allocations.
- Use object pooling for frequently spawned objects.
- Avoid expensive scene searches.
- Keep systems independent.

Optimization should never sacrifice readability without measurable benefit.

---

# 13. Future Architecture

The project may later introduce:

- Dependency Injection
- Addressables
- Async Scene Loading
- ECS for selected systems
- Automated Testing
- Build Pipeline Automation

These features should integrate without requiring major architectural changes.

---

# 14. Related Documentation

Additional architectural documentation is available in:

- Managers.md
- Systems.md
- Initialization.md
- SceneFlow.md

Additional coding standards:

- CodingStandard/StyleGuide.md
- CodingStandard/FolderStructure.md
- CodingStandard/BestPractices.md

Gameplay documentation:

- Gameplay/Buildings.md
- Gameplay/Enemies.md
- Gameplay/Resources.md
- Gameplay/Waves.md
- Gameplay/FogOfWar.md

Git workflow:

- Git/Workflow.md
- Git/Branches.md
