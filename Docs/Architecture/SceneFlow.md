# Scene Flow

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Scene Architecture
3. Scene Responsibilities
4. Scene Flow
5. Scene Loading
6. Persistent Objects
7. Gameplay Scene Initialization
8. Scene Transition Rules
9. Future Expansion
10. Related Documentation

---

# 1. Overview

The project uses a scene architecture where global services remain persistent while gameplay scenes can be loaded and unloaded independently.

The primary goals are:

- fast loading
- modular scenes
- reusable UI
- reusable managers
- predictable transitions
- easy expansion

---

# 2. Scene Architecture

The project is divided into several scene categories.

```
Bootstrap
        │
        ▼
Persistent
        │
        ├── Managers
        ├── Audio
        ├── UI
        └── Global Services
        │
        ▼
Gameplay Scene
```

The Bootstrap scene is loaded only once.

The Persistent scene remains loaded during the entire application lifetime.

Gameplay scenes are loaded and unloaded as needed.

---

# 3. Scene Responsibilities

## Bootstrap Scene

Responsible for:

- application startup
- framework initialization
- loading the Persistent scene
- validating project configuration

This scene contains only startup logic.

---

## Persistent Scene

Responsible for global objects.

Contains:

- Managers
- Audio Listener
- Audio Manager
- UI Root
- Event System
- Save System
- Input System
- Localization
- Global Cameras (if required)

This scene is never unloaded during normal gameplay.

---

## Gameplay Scene

Contains:

- terrain
- environment
- castle
- roads
- towers
- enemies
- resources
- fog of war
- visual effects
- gameplay objects

Gameplay scenes should contain no global managers.

---

## UI

The main UI is hosted in the Persistent scene.

Gameplay windows are enabled or disabled depending on the current game state.

---

# 4. Scene Flow

The normal application flow is:

```
Application Launch
        │
        ▼
Bootstrap
        │
        ▼
Persistent
        │
        ▼
Main Menu
        │
        ▼
Loading Screen
        │
        ▼
Gameplay
        │
        ▼
Victory
        │
        ├─────────────┐
        ▼             │
Main Menu             │
                      │
Game Over ────────────┘
```

Future game modes should integrate into this flow without modifying existing transitions.

---

# 5. Scene Loading

All scene loading should be handled exclusively by the SceneLoader.

Gameplay systems must never load scenes directly.

Preferred loading process:

```
Request Load

↓

SceneLoader

↓

Loading Screen

↓

Async Scene Loading

↓

Scene Initialization

↓

Gameplay Starts
```

Scene loading should be asynchronous whenever possible.

---

# 6. Persistent Objects

The following objects remain active throughout the application lifetime:

- GameManager
- SceneLoader
- SaveManager
- SettingsManager
- LocalizationManager
- AudioManager
- InputManager
- UIManager
- Event System

These objects should not be duplicated.

Bootstrap is responsible for creating them.

---

# 7. Gameplay Scene Initialization

When a gameplay scene is loaded, the following sequence occurs:

1. Load terrain
2. Generate world grid
3. Generate environment objects
4. Spawn the castle
5. Generate resource nodes
6. Generate decorative props
7. Initialize Fog of War
8. Prepare enemy path
9. Initialize gameplay systems
10. Initialize gameplay UI
11. Start pre-wave countdown
12. Player gains control

Gameplay should begin only after initialization is complete.

---

# 8. Scene Transition Rules

The following rules apply:

- Gameplay scenes never create managers.
- Gameplay scenes never destroy managers.
- Only SceneLoader loads or unloads scenes.
- Global services exist only in the Persistent scene.
- Scene transitions should preserve player settings.
- Loading screens should hide asynchronous loading.

These rules ensure predictable application behavior.

---

# 9. Future Expansion

The architecture supports future additions such as:

- multiple gameplay maps
- campaign mode
- endless mode
- challenge maps
- cooperative multiplayer
- downloadable content (DLC)
- Addressables
- streamed world loading

No redesign of the scene flow should be required.

---

# 10. Related Documentation

Architecture Overview

- ARCHITECTURE.md

Initialization

- Initialization.md

Managers

- Managers.md

Gameplay Systems

- Systems.md

Gameplay Documentation

- Gameplay/

Coding Standards

- CodingStandard/

Git Workflow

- Git/
