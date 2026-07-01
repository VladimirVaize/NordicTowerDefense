# Art Guide

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Overview

The **ArtGuide** documentation defines the visual, technical, and production standards for all art assets used in the project.

Its purpose is to ensure that every asset follows the same artistic direction, technical requirements, and production pipeline.

This documentation should be used by:

- 3D Artists
- Technical Artists
- Environment Artists
- UI Artists
- VFX Artists
- Animators

Programmers generally do not need these documents unless they are creating or importing visual assets.

---

# Documents

## Scale.md

Defines the scale standards used throughout the project.

Includes:

- Unity measurement system
- Blender units
- Building dimensions
- Character scale
- Grid cell size
- Pivot placement
- Camera readability
- Asset proportions

Read this document before creating any new 3D model.

---

## Naming.md

Defines the naming conventions for all art assets.

Includes:

- Asset naming rules
- Prefixes
- Texture suffixes
- Folder naming
- Material naming
- Animation naming
- Audio naming
- VFX naming
- UI asset naming

Following these rules ensures a clean and searchable project structure.

---

## Materials.md

Defines the material pipeline and rendering standards.

Includes:

- Material philosophy
- Material library
- URP shader usage
- Texture usage
- Transparency
- Emission
- Terrain materials
- Performance recommendations

This document ensures visual consistency across all assets.

---

## StyleGuide.md

Defines the artistic direction of the project.

Includes:

- Visual style
- Shape language
- Color palette
- Building design
- Environment design
- Character readability
- Lighting
- Gameplay readability

This is the primary reference for the game's visual identity.

---

## Export.md

Defines the complete asset export pipeline.

Includes:

- Blender workflow
- FBX export settings
- Unity import settings
- Prefab creation
- Validation checklist
- Version control recommendations

Every asset must follow this workflow before being committed to the repository.

---

## LOD.md

Defines the Level of Detail (LOD) standards.

Includes:

- LOD philosophy
- Supported object types
- Triangle reduction
- Unity LOD Group
- Asset validation
- Performance recommendations

LOD should improve performance while maintaining visual consistency.

---

# Recommended Reading Order

For new artists, the recommended reading order is:

1. StyleGuide.md
2. Scale.md
3. Naming.md
4. Materials.md
5. Export.md
6. LOD.md

Following this order provides a complete understanding of the project's visual standards and production workflow.

---

# Art Pipeline Overview

The standard workflow for creating a new asset is:

```text
Read StyleGuide
        │
        ▼
Create Model
        │
        ▼
Validate Scale
        │
        ▼
Name Assets
        │
        ▼
Assign Materials
        │
        ▼
Export FBX
        │
        ▼
Import into Unity
        │
        ▼
Create Prefab
        │
        ▼
Configure LOD (if required)
        │
        ▼
Commit to Git
```

Every new asset should follow this pipeline.

---

# Related Documentation

Architecture

- ../Architecture/

Coding Standards

- ../CodingStandard/

Gameplay

- ../Gameplay/

Git

- ../Git/

Setup

- ../Setup/
