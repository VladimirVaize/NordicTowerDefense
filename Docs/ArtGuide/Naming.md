# Asset Naming Convention

**Project:** Hrafnar Tower Defense

**Document Version:** 2.0

---

# Table of Contents

1. Overview
2. General Rules
3. Naming Style
4. Asset Prefixes
5. Texture Suffixes
6. Static Mesh Naming
7. Prefab Naming
8. Material Naming
9. Texture Naming
10. Animation Naming
11. Audio Naming
12. VFX Naming
13. UI Asset Naming
14. Scene Naming
15. Folder Naming
16. Examples
17. Common Mistakes
18. Related Documentation

---

# 1. Overview

This document defines the naming conventions for all art assets used in the project.

Its purpose is to ensure consistency across:

- 3D Models
- Prefabs
- Materials
- Textures
- Animations
- Audio Assets
- Visual Effects
- UI Assets
- Scenes

Programming-related naming conventions are documented separately in:

**CodingStandard/Naming.md**

---

# 2. General Rules

Every asset must follow these principles.

- English language only
- PascalCase
- No spaces
- No special characters
- No temporary names
- No version numbers
- Clear and descriptive names

Correct

```text
ArrowTower

PineTree

CastleWall
```

Incorrect

```text
arrowTower

Arrow Tower

Tree_Final

Tree_Copy

Rock_New
```

Git already stores file history.

Never use filenames to indicate versions.

---

# 3. Naming Style

The project uses **PascalCase**.

Correct

```text
ArrowTower

WoodFence

StoneWall
```

Incorrect

```text
arrowTower

arrow_tower

arrow-tower

Arrow Tower
```

---

# 4. Asset Prefixes

The following prefixes are mandatory.

| Prefix | Asset Type | Example |
|---------|------------|---------|
| SM_ | Static Mesh | SM_PineTree |
| PF_ | Prefab | PF_ArrowTower |
| MAT_ | Material | MAT_Wood |
| T_ | Texture | T_Stone_D |
| A_ | Animation Clip | A_Attack |
| AC_ | Animator Controller | AC_Goblin |
| AU_ | Audio Clip | AU_BowShot |
| VFX_ | Visual Effect | VFX_Explosion |
| SH_ | Shader | SH_FogOfWar |
| UI_ | UI Prefab | UI_HUD |
| ICO_ | Icon | ICO_Wood |
| FONT_ | Font | FONT_Main |

---

# 5. Texture Suffixes

Textures use standardized suffixes.

| Suffix | Meaning |
|---------|---------|
| _D | Base Color / Diffuse |
| _N | Normal |
| _M | Mask |
| _R | Roughness |
| _AO | Ambient Occlusion |
| _E | Emission |
| _H | Height |

Examples

```text
T_Wood_D

T_Wood_N

T_Wood_AO
```

---

# 6. Static Mesh Naming

Environment

```text
SM_PineTree_01

SM_PineTree_02

SM_Rock_01

SM_Rock_02
```

Buildings

```text
SM_Castle

SM_ArrowTower

SM_Barracks

SM_Workshop
```

Props

```text
SM_Barrel

SM_Crate

SM_Fence
```

Variants use numeric suffixes.

```text
SM_PineTree_01

SM_PineTree_02

SM_PineTree_03
```

---

# 7. Prefab Naming

Every reusable GameObject should use the PF_ prefix.

Examples

```text
PF_ArrowTower

PF_Castle

PF_Goblin

PF_PineTree
```

Prefab names should match the corresponding mesh whenever possible.

---

# 8. Material Naming

Materials use the MAT_ prefix.

Examples

```text
MAT_Wood

MAT_Stone

MAT_Metal

MAT_Snow

MAT_Grass
```

Material names should describe the surface, not the object.

Correct

```text
MAT_Wood
```

Incorrect

```text
MAT_Barracks
```

---

# 9. Texture Naming

Textures use the T_ prefix.

Examples

```text
T_Wood_D

T_Wood_N

T_Wood_AO

T_Stone_D

T_Stone_N
```

---

# 10. Animation Naming

Animation Clips

```text
A_Idle

A_Run

A_Attack

A_Death
```

Animator Controllers

```text
AC_Goblin

AC_ArrowTower
```

---

# 11. Audio Naming

Examples

```text
AU_MenuClick

AU_BowShot

AU_Explosion

AU_WindLoop

AU_BackgroundMusic
```

---

# 12. VFX Naming

Examples

```text
VFX_Fire

VFX_Explosion

VFX_Smoke

VFX_FogReveal
```

---

# 13. UI Asset Naming

UI Prefabs

```text
UI_HUD

UI_MainMenu

UI_PauseMenu

UI_BuildMenu
```

Icons

```text
ICO_Wood

ICO_Stone

ICO_Gold
```

Fonts

```text
FONT_Main

FONT_Title
```

---

# 14. Scene Naming

Scenes use the S_ prefix.

Examples

```text
S_Bootstrap

S_Persistent

S_MainMenu

S_Loading

S_Gameplay
```

---

# 15. Folder Naming

Folders use PascalCase.

Correct

```text
Buildings

Environment

Textures

Materials

Prefabs

Animations
```

Incorrect

```text
my assets

environment_models

New Folder

Buildings Copy
```

---

# 16. Examples

Correct

```text
SM_PineTree_03

PF_ArrowTower

MAT_Wood

T_Stone_D

VFX_Fire

UI_HUD
```

Incorrect

```text
tree

Tree_Final

Tower Copy

material01

newTexture

Test
```

---

# 17. Common Mistakes

Avoid:

- Spaces
- Temporary filenames
- Version numbers
- Copy/New/Final
- Mixed naming styles
- Local language names
- Undefined abbreviations

Consistent naming significantly improves asset management and collaboration.

---

# 18. Related Documentation

Art Pipeline

- Scale.md
- StyleGuide.md
- Materials.md
- LOD.md
- Export.md

Coding Standards

- ../CodingStandard/Naming.md

Architecture

- ../Architecture/ARCHITECTURE.md
