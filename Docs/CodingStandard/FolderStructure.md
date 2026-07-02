# Folder Structure Guide

**Project:** Hrafnar Tower Defense

**Document Version:** 2.0

---

# Table of Contents

1. Overview
2. Design Philosophy
3. Root Project Structure
4. Unity Project Structure
5. Scripts Architecture
6. Feature Modules
7. Core
8. Managers
9. UI
10. ScriptableObjects
11. Resources
12. Editor
13. Tests
14. Creating New Features
15. Folder Creation Rules
16. File Organization Rules
17. Growth Strategy
18. Examples
19. Code Review Checklist
20. Related Documentation

---

# 1. Overview

This document defines the official folder structure used throughout the project.

The project follows a **Feature-Based Architecture**, where every gameplay mechanic is implemented as an independent module.

The folder structure is designed to be:

- Scalable
- Easy to navigate
- Easy to maintain
- Consistent
- Suitable for long-term development

---

# 2. Design Philosophy

The project is organized around **features**, not file types.

Instead of grouping files by their technical role (all systems together, all components together), each gameplay mechanic owns everything related to itself.

This keeps code highly cohesive and minimizes dependencies between different gameplay systems.

---

# 3. Root Project Structure

Repository structure:

```text
Repository
│
├── UnityProject/
├── AssetsSource/
├── Docs/
├── .github/
├── .gitignore
├── README.md
└── LICENSE
```

## UnityProject/

Contains the Unity project.

## AssetsSource/

Contains original source assets.

Examples:

- Blender
- PSD
- Krita
- References
- Logos

## Docs/

Contains all project documentation.

---

# 4. Unity Project Structure

```text
Assets/
│
├── Art/
├── Audio/
├── Materials/
├── Models/
├── Prefabs/
├── Resources/
├── Scenes/
├── ScriptableObjects/
├── Scripts/
├── Settings/
├── Shaders/
├── Textures/
├── UI/
└── VFX/
```

Each top-level folder has a single responsibility.

Avoid creating unnecessary top-level folders.

---

# 5. Scripts Architecture

```text
Scripts/
│
├── Core/
├── Managers/
├── Features/
├── UI/
├── Editor/
├── Extensions/
└── Utilities/
```

Every folder has a clearly defined responsibility.

---

# 6. Feature Modules

Gameplay mechanics are implemented as Feature Modules.

Examples:

```text
Features/
│
├── Buildings/
├── Camera/
├── Castle/
├── Enemies/
├── FogOfWar/
├── Grid/
├── Projectiles/
├──Resources/
├── Towers/
└── Waves/
```

Each module owns everything related to its functionality.

Typical structure:

```text
Feature/
│
├── Components/
├── Controllers/
├── Events/
├── Factories/
├── Interfaces/
├── States/
├── Systems/
└── Views/
```

Additional folders may be added when required.

Examples:

```text
Editor/
Utilities/
Debug/
```

Only create folders that are actually needed.

---

# 7. Core

The Core folder contains shared infrastructure.

Examples:

```text
Core/
│
├── Bootstrap/
├── Events/
├── Interfaces/
├── Services/
├── StateMachine/
└── Utilities/
```

Core should never contain gameplay mechanics.

Everything inside Core should be reusable across multiple systems.

---

# 8. Managers

Managers coordinate global game services.

Examples:

```text
Managers/
│
├── AudioManager
├── GameManager
├── SaveManager
├── SceneManager
└── UIManager
```

Managers:

- coordinate
- initialize
- manage lifecycle

Managers should **not** contain gameplay logic.

---

# 9. UI

Contains all user interface code.

Examples:

```text
UI/
│
├── HUD/
├── MainMenu/
├── PauseMenu/
├── Settings/
├── Windows/
└── Shared/
```

Gameplay logic must never exist inside UI.

---

# 10. ScriptableObjects

ScriptableObjects are divided into two categories.

```text
ScriptableObjects/
│
├── Data/
└── Config/
```

## Data

Contains gameplay object definitions.

Examples:

```text
Data/
│
├── Buildings/
├── Enemies/
├── Projectiles/
├── Resources/
├── Towers/
├── Upgrades/
└── Waves/
```

## Config

Contains global system configuration.

Examples:

```text
Config/
│
├── Audio/
├── Camera/
├── Economy/
├── FogOfWar/
├── Game/
├── Grid/
├── Input/
└── Save/
```

---

# 11. Resources

Use the Resources folder only when runtime loading through Unity's Resources API is required.

Avoid storing general assets inside Resources.

Addressables should be preferred for future scalability.

---

# 12. Editor

Contains Unity Editor tools.

Examples:

```text
Editor/
│
├── CustomInspectors/
├── Editors/
├── PropertyDrawers/
└── Windows/
```

Editor scripts must never be included in runtime builds.

---

# 13. Tests

Testing structure:

```text
Tests/
│
├── EditMode/
└── PlayMode/
```

Keep runtime tests separated from editor tests.

---

# 14. Creating New Features

When implementing a new gameplay mechanic:

1. Create a new Feature Module.
2. Create Gameplay Data assets if needed.
3. Create Config assets if needed.
4. Implement systems.
5. Add runtime components.
6. Connect through events.
7. Create UI only if required.
8. Add documentation.

Each feature should remain independent.

---

# 15. Folder Creation Rules

Create folders only when needed.

Avoid empty folders.

Avoid speculative folders for future functionality.

Prefer:

```text
Grid/
└── Systems/
```

instead of:

```text
Grid/
├── Components/
├── Controllers/
├──Factories/
├──Interfaces/
├──Views/
└──Utilities/
```

when those folders are empty.

The structure should evolve naturally as the project grows.

---

# 16. File Organization Rules

General principles:

- One responsibility per class.
- One responsibility per folder.
- One gameplay mechanic per Feature Module.
- Keep related files together.
- Minimize dependencies between modules.

Move code instead of duplicating it.

---

# 17. Growth Strategy

As the project grows:

- Add new Feature Modules instead of expanding existing ones.
- Keep modules independent.
- Avoid large "miscellaneous" folders.
- Refactor when folders become difficult to navigate.
- Keep folder depth reasonable.

The structure should support years of development without major reorganization.

---

# 18. Examples

Small Feature Module:

```text
Grid/
└── Systems/
    └── GridSystem.cs
```

Medium Feature Module:

```text
Resources/
│
├── Events/
├── Systems/
└── Views/
```

Large Feature Module:

```text
Buildings/
│
├── Components/
├── Controllers/
├── Events/
├── Factories/
├── Interfaces/
├── States/
├── Systems/
└── Views/
```

Modules should grow only as complexity increases.

---

# 19. Code Review Checklist

Before merging changes:

- Correct folder placement.
- No unnecessary folders.
- No duplicated functionality.
- Feature remains self-contained.
- Shared code moved to Core.
- Gameplay logic not placed in Managers.
- Data stored in ScriptableObjects.
- Folder names follow naming conventions.

---

# 20. Related Documentation

Architecture

- ../Architecture/

Coding Standards

- StyleGuide.md
- Naming.md
- BestPractices.md
- ArchitecturePatterns.md
- ScriptableObjects.md

Git

- ../Git/

Gameplay

- ../Gameplay/
