# Folder Structure

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Repository Structure
3. Unity Project Structure
4. Scripts Structure
5. ScriptableObjects Structure
6. Art Structure
7. Audio Structure
8. Prefabs Structure
9. Scenes Structure
10. UI Structure
11. Resources Folder
12. StreamingAssets Folder
13. Editor Folder
14. Tests Structure
15. Rules
16. Common Mistakes
17. Related Documentation

---

# 1. Overview

This document defines the official folder structure for the project.

The goals are:

- Predictable organization
- Easy navigation
- Scalability
- Clear ownership
- Consistency across the team

Every new asset and script should be placed in its appropriate location.

---

# 2. Repository Structure

```text
Repository/
│
├── Docs/
├── AssetsSource/
├── UnityProject/
├── LICENSE
├── README.md
└── .gitignore
```

### Description

| Folder | Purpose |
|---------|---------|
| Docs | Project documentation |
| AssetsSource | Source files (Blender, concepts, PSD, references) |
| UnityProject | Unity project |
| README.md | Project overview |
| LICENSE | Project license |

---

# 3. Unity Project Structure

```text
UnityProject/
│
├── Assets/
├── Packages/
├── ProjectSettings/
└── UserSettings/
```

Inside **Assets/**

```text
Assets/
│
├── Art/
├── Audio/
├── Materials/
├── Prefabs/
├── Scenes/
├── Scripts/
├── ScriptableObjects/
├── Settings/
├── UI/
├── VFX/
├── Fonts/
├── Localization/
├── Gizmos/
├── Editor/
├── Tests/
└── Resources/
```

---

# 4. Scripts Structure

```text
Scripts/
│
├── Core/
│
├── Managers/
│
├── Systems/
│
├── Gameplay/
│   ├── Buildings/
│   ├── Enemies/
│   ├── Projectiles/
│   ├── Resources/
│   ├── Waves/
│   ├── Grid/
│   ├── FogOfWar/
│   └── Castle/
│
├── UI/
│
├── Utilities/
│
├── Extensions/
│
└── Editor/
```

### Folder Descriptions

**Core**

Core framework classes.

Examples:

- Bootstrap
- Service Locator (if used)
- Event Bus
- State Machine

---

**Managers**

Global managers.

Examples:

- GameManager
- SceneManager
- AudioManager
- SaveManager

---

**Systems**

Gameplay systems.

Examples:

- GridSystem
- ConstructionSystem
- WaveSystem
- ResourceSystem

---

**Gameplay**

Feature-specific behaviours and gameplay components.

---

**UI**

UI logic only.

---

**Utilities**

Reusable helper classes.

---

**Extensions**

Extension methods.

---

# 5. ScriptableObjects Structure

```text
ScriptableObjects/
│
├── Buildings/
├── Enemies/
├── Towers/
├── Resources/
├── Waves/
├── Audio/
├── VFX/
└── Settings/
```

Configuration assets should never be mixed with runtime scripts.

---

# 6. Art Structure

```text
Art/
│
├── Buildings/
├── Environment/
├── Props/
├── Characters/
├── Terrain/
├── Icons/
└── Sprites/
```

Only imported Unity assets belong here.

Source files remain in `AssetsSource/`.

---

# 7. Audio Structure

```text
Audio/
│
├── Music/
├── SFX/
├── Ambient/
├── UI/
└── Voices/
```

---

# 8. Prefabs Structure

```text
Prefabs/
│
├── Buildings/
├── Towers/
├── Enemies/
├── Environment/
├── UI/
├── Projectiles/
└── Effects/
```

Every reusable GameObject should exist as a Prefab.

---

# 9. Scenes Structure

```text
Scenes/
│
├── Bootstrap/
├── Persistent/
├── MainMenu/
├── Gameplay/
└── Testing/
```

Testing scenes should never be included in release builds.

---

# 10. UI Structure

```text
UI/
│
├── HUD/
├── Menus/
├── Popups/
├── Windows/
├── Icons/
└── Themes/
```

Separate visual assets from UI scripts.

---

# 11. Resources Folder

The `Resources` folder should only be used when runtime loading through `Resources.Load()` is explicitly required.

Avoid storing general assets inside `Resources`.

---

# 12. StreamingAssets Folder

Use `StreamingAssets` only for files that must remain unchanged after the build.

Examples:

- External configuration
- Import/export templates
- Third-party data

---

# 13. Editor Folder

Editor-only scripts belong inside:

```text
Editor/
```

These scripts must never be included in runtime assemblies.

---

# 14. Tests Structure

```text
Tests/
│
├── EditMode/
└── PlayMode/
```

Tests should mirror the production folder structure whenever practical.

---

# 15. Rules

- One responsibility per folder.
- Do not create miscellaneous folders such as `New`, `Temp`, or `Misc`.
- Keep folder depth reasonable.
- Use PascalCase.
- Group related assets together.
- Do not duplicate assets.
- Remove unused folders when appropriate.

---

# 16. Common Mistakes

Avoid:

- Mixing source files with Unity assets.
- Placing scripts inside Art folders.
- Using Resources unnecessarily.
- Creating deeply nested folders.
- Storing test assets in production folders.
- Using inconsistent folder names.

---

# 17. Related Documentation

Coding Standards

- StyleGuide.md
- Naming.md
- BestPractices.md
- ScriptableObjects.md
- Performance.md
- ArchitecturePatterns.md
- Comments.md

Architecture

- ../Architecture/

Art Guide

- ../ArtGuide/

Gameplay

- ../Gameplay/
