# Initialization

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Initialization Goals
3. Startup Sequence
4. Bootstrap
5. Framework Initialization
6. Manager Initialization
7. Gameplay Initialization
8. Scene Initialization
9. Shutdown Sequence
10. Initialization Rules
11. Error Handling
12. Future Expansion
13. Related Documentation

---

# 1. Overview

Initialization defines how the application starts, creates its core services, initializes gameplay systems, and becomes ready for player interaction.

The initialization process must be:

- deterministic
- predictable
- easy to debug
- independent from Unity's Script Execution Order whenever possible

The project uses a centralized Bootstrap process as the single entry point for application startup.

---

# 2. Initialization Goals

The initialization system is designed to achieve the following goals.

## Predictable Startup

Every system is initialized in a predefined order.

No system should rely on undefined execution order.

---

## Single Entry Point

The application starts from one Bootstrap process.

Bootstrap is responsible for creating and initializing all global services.

---

## Dependency Safety

A system should never initialize before all required dependencies are available.

Example:

Resource System cannot initialize before ResourceManager exists.

---

## Easy Debugging

The initialization sequence should be easy to inspect and verify during development.

Every initialization step should produce clear debug logs in Development Builds.

---

# 3. Startup Sequence

The complete startup process is:

```
Application Launch
        │
        ▼
Bootstrap
        │
        ▼
Framework Layer
        │
        ▼
Managers
        │
        ▼
Gameplay Systems
        │
        ▼
Scene Initialization
        │
        ▼
Game Ready
```

Each stage must complete successfully before the next one begins.

---

# 4. Bootstrap

Bootstrap is the only component responsible for starting the application.

Responsibilities:

- initialize framework services
- register global services
- create managers
- initialize gameplay systems
- prepare the active scene
- signal when initialization is complete

Bootstrap should not contain gameplay logic.

Bootstrap exists only during application startup.

---

# 5. Framework Initialization

Framework services are initialized first.

Initialization order:

1. Event System
2. Time System
3. Object Pooling System
4. Save System
5. Localization System

These services provide the foundation for the rest of the application.

Framework services should remain independent from gameplay systems.

---

# 6. Manager Initialization

Managers are initialized after the framework layer.

Recommended order:

1. GameManager
2. SceneLoader
3. SettingsManager
4. SaveManager
5. LocalizationManager
6. AudioManager
7. InputManager
8. UIManager

Managers should register themselves during initialization.

Managers should never initialize gameplay systems directly.

---

# 7. Gameplay Initialization

Gameplay systems are initialized after all managers are available.

Recommended order:

1. Grid System
2. Resource System
3. Building System
4. Construction System
5. Upgrade System
6. Repair System
7. Fog Of War System
8. Vision System
9. Camera System
10. Wave System
11. Spawn System
12. Enemy System
13. Pathfinding System
14. Combat System
15. Projectile System
16. Interaction System
17. Selection System

Every gameplay system should expose an Initialize() method.

Gameplay systems should not initialize themselves inside Awake() whenever possible.

---

# 8. Scene Initialization

Once all systems are initialized, the active gameplay scene is prepared.

Scene initialization includes:

- creating the world grid
- generating the map
- placing environmental objects
- placing the castle
- generating resource nodes
- generating decorative objects
- initializing Fog of War
- preparing enemy paths
- preparing buildable cells
- preparing UI
- starting the pre-wave countdown

The player gains control only after scene initialization is complete.

---

# 9. Shutdown Sequence

The application should shut down in the reverse order.

Recommended sequence:

1. Gameplay Systems
2. Managers
3. Framework Services
4. Save Progress
5. Shutdown

Systems should release resources before destruction.

---

# 10. Initialization Rules

Every initialization step must satisfy the following rules.

## Rule 1

Initialize only once.

---

## Rule 2

Initialization should never depend on Unity scene hierarchy.

---

## Rule 3

Avoid FindObjectOfType() during initialization.

---

## Rule 4

Avoid GameObject.Find() during startup.

---

## Rule 5

Never rely on Script Execution Order as the primary initialization mechanism.

---

## Rule 6

Every initialization step should validate its required dependencies.

---

## Rule 7

Initialization should fail fast if critical services are missing.

---

# 11. Error Handling

Initialization failures should provide meaningful error messages.

Examples:

Missing GameManager

Missing Grid System

Localization database not found

Save file corrupted

Required ScriptableObject missing

Errors should stop initialization when the application cannot continue safely.

---

# 12. Future Expansion

The initialization pipeline is designed to support future features.

Possible additions:

- Addressables
- Async Initialization
- Dependency Injection
- Cloud Save
- Steam Services
- Analytics
- Multiplayer Services
- Mod Loading

These features should integrate without changing the overall initialization flow.

---

# 13. Related Documentation

Architecture Overview

- ARCHITECTURE.md

Managers

- Managers.md

Gameplay Systems

- Systems.md

Scene Flow

- SceneFlow.md

Coding Standards

- CodingStandard/BestPractices.md

Gameplay Documentation

- Gameplay/

Git Workflow

- Git/
