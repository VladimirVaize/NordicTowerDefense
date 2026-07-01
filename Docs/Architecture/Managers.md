# Managers

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Design Principles
3. Manager Responsibilities
4. Manager Lifecycle
5. Core Managers
6. Manager Communication
7. Dependency Rules
8. Initialization Order
9. Best Practices
10. Anti-Patterns
11. Future Expansion
12. Related Documentation

---

# 1. Overview

Managers are high-level services responsible for coordinating major parts of the application.

A Manager should never implement gameplay mechanics directly.

Instead, Managers coordinate gameplay systems, provide global services, or control application flow.

Examples:

- Scene loading
- Saving
- Audio
- UI
- Global game state

Gameplay logic belongs to gameplay systems, not Managers.

---

# 2. Design Principles

Every Manager follows these principles.

## Single Responsibility

Every Manager has one clearly defined responsibility.

A Manager should solve one problem only.

---

## Global Availability

Managers are globally accessible through the application's architecture.

Gameplay systems should not create Managers.

Managers are initialized during application startup.

---

## Coordination

Managers coordinate systems.

Managers do not replace gameplay systems.

For example:

GameManager

coordinates

- Wave System
- Resource System
- Building System

but does not implement them.

---

## No Gameplay Logic

Managers should never contain gameplay rules.

Wrong:

GameManager calculates tower damage.

Correct:

Tower System calculates tower damage.

---

# 3. Manager Responsibilities

Managers are responsible for:

- initialization
- shutdown
- communication
- application state
- global services

Managers are NOT responsible for:

- enemy AI
- tower attacks
- resource harvesting
- fog calculations
- pathfinding

Those belong to gameplay systems.

---

# 4. Manager Lifecycle

Every Manager follows the same lifecycle.

```
Application Starts
        │
        ▼
Manager Created
        │
        ▼
Initialize()
        │
        ▼
Running
        │
        ▼
Shutdown()
```

Managers are expected to exist during the entire application lifetime unless stated otherwise.

---

# 5. Core Managers

The project currently defines the following Managers.

---

## GameManager

### Purpose

Coordinates the overall game state.

### Responsibilities

- current game state
- pause
- game over
- victory
- gameplay flow
- communication between systems

### Does NOT

- control enemies
- control towers
- calculate damage

---

## SceneLoader

### Purpose

Responsible for scene loading.

### Responsibilities

- load scenes
- unload scenes
- loading screen
- asynchronous loading
- additive scenes

### Does NOT

- initialize gameplay

---

## SaveManager

### Purpose

Handles save and load operations.

### Responsibilities

- save game
- load game
- autosave
- save validation
- version compatibility

---

## UIManager

### Purpose

Controls user interface.

### Responsibilities

- HUD
- menus
- windows
- notifications
- tooltips

UIManager never contains gameplay rules.

---

## AudioManager

### Purpose

Controls all audio.

### Responsibilities

- music
- sound effects
- ambient sounds
- volume settings

---

## InputManager

### Purpose

Provides centralized access to the Unity Input System.

### Responsibilities

- input initialization
- input action maps
- input enabling/disabling
- gameplay/UI switching

Does not execute gameplay actions.

---

## LocalizationManager

### Purpose

Provides localization services.

### Responsibilities

- language switching
- localized strings
- localization tables

---

## ResourceManager

### Purpose

Tracks global player resources.

### Responsibilities

- current resources
- add resources
- spend resources
- resource events

Does not generate resources.

Generation belongs to gameplay systems.

---

## SettingsManager

### Purpose

Stores player settings.

### Responsibilities

- graphics
- audio
- controls
- gameplay settings

---

# 6. Manager Communication

Managers communicate through clearly defined APIs.

Preferred communication:

```
UI

↓

GameManager

↓

Gameplay System
```

Avoid direct communication between unrelated Managers whenever possible.

---

Managers should never create cyclic dependencies.

Wrong:

```
AudioManager

↓

UIManager

↓

AudioManager
```

---

# 7. Dependency Rules

Allowed

```
UI

↓

UIManager
```

```
Gameplay

↓

GameManager
```

```
SaveManager

↓

GameManager
```

Forbidden

```
Tower System

↓

UIManager
```

```
Enemy System

↓

AudioManager
```

```
Resource System

↓

SceneLoader
```

Managers should remain independent.

---

# 8. Initialization Order

Managers are initialized in a predefined order.

1. GameManager

2. SceneLoader

3. SaveManager

4. SettingsManager

5. LocalizationManager

6. AudioManager

7. InputManager

8. UIManager

Gameplay systems are initialized after Managers.

The complete startup sequence is documented in:

Initialization.md

---

# 9. Best Practices

Managers should:

- expose clean APIs
- avoid unnecessary Update()
- avoid FindObjectOfType()
- avoid GameObject.Find()
- cache references
- use events when appropriate
- remain focused

---

Managers should NOT:

- contain balancing values
- contain enemy logic
- contain tower logic
- manipulate scene objects directly
- become "God Objects"

---

# 10. Anti-Patterns

Avoid creating Managers for every gameplay feature.

Bad examples:

- EnemyManager
- TowerManager
- ProjectileManager
- FogManager
- GridManager

These are gameplay systems.

They belong inside the Gameplay layer.

---

Avoid Managers calling each other recursively.

Avoid Managers depending on scene hierarchy.

Avoid static utility classes replacing Managers.

---

# 11. Future Expansion

Additional Managers may be introduced when required.

Possible future additions:

- AnalyticsManager
- AchievementManager
- SteamManager
- CloudSaveManager
- ModManager

A new Manager should only be added when it provides a true global service.

---

# 12. Related Documentation

Architecture Overview

- ARCHITECTURE.md

Gameplay Systems

- Systems.md

Initialization

- Initialization.md

Scene Flow

- SceneFlow.md

Gameplay Documentation

- Gameplay/

Coding Standards

- CodingStandard/

Git Workflow

- Git/
