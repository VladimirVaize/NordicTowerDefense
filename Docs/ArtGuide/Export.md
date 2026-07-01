# Export Guide

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Export Pipeline
3. Source Files
4. Blender Preparation
5. FBX Export Settings
6. Unity Import Settings
7. Prefab Creation
8. Asset Validation
9. Version Control
10. Common Mistakes
11. Export Checklist
12. Related Documentation

---

# 1. Overview

This document defines the official asset export pipeline for the project.

The goals are:

- Consistent asset import
- Reliable scaling
- Correct pivots
- Clean Git history
- Predictable Unity integration

Every 3D asset must follow this pipeline.

---

# 2. Export Pipeline

The standard workflow is:

```text
Create Model in Blender
        │
        ▼
Apply Transforms
        │
        ▼
Validate Scale
        │
        ▼
Validate Pivot
        │
        ▼
Export FBX
        │
        ▼
Commit to Git
        │
        ▼
Import into Unity
        │
        ▼
Configure Import Settings
        │
        ▼
Create Prefab
        │
        ▼
Ready for Gameplay
```

No steps should be skipped.

---

# 3. Source Files

Blender files (`.blend`) are the master source files.

Rules:

- Always edit the `.blend` file.
- Never edit geometry inside Unity.
- Never use an exported `.fbx` as the master file.
- Store `.blend` files in the `AssetsSource/Blender/` directory.
- Exported `.fbx` files are placed inside the Unity project.

---

# 4. Blender Preparation

Before exporting:

- Apply Location
- Apply Rotation
- Apply Scale
- Remove unused objects
- Remove unused materials
- Check pivot position
- Verify forward direction (+Z)
- Verify up direction (+Y)

Use:

```text
Ctrl + A

↓

All Transforms
```

The model should have:

- Scale = (1,1,1)
- Rotation = (0,0,0)

---

# 5. FBX Export Settings

Recommended export settings:

## Include

- Selected Objects
- Apply Transform
- Meshes
- Armatures (if applicable)
- Animations (if applicable)

## Transform

Forward:

```text
-Z Forward
```

Up:

```text
Y Up
```

Scale:

```text
1.00
```

Apply Unit:

Enabled

Apply Scalings:

```text
FBX Units Scale
```

Only export the objects intended for Unity.

---

# 6. Unity Import Settings

After importing into Unity, verify:

- Scale Factor = 1
- Generate Lightmap UVs (if required)
- Import Materials = Disabled (unless explicitly needed)
- Normals = Import
- Tangents = Calculate Mikktspace (or Import if authored)
- Mesh Compression = Off (default, enable only if tested)

For animated assets:

- Configure Rig
- Configure Avatar
- Configure Animation Clips

---

# 7. Prefab Creation

Every reusable object should have a Prefab.

Workflow:

```text
FBX
        │
        ▼
Configure Components
        │
        ▼
Assign Materials
        │
        ▼
Add Colliders
        │
        ▼
Add Scripts (if required)
        │
        ▼
Create Prefab
```

The Prefab is the asset used in gameplay.

Do not place raw FBX models directly into scenes.

---

# 8. Asset Validation

Before committing, verify:

- Correct scale
- Correct rotation
- Correct pivot
- Correct materials
- Correct naming
- No missing textures
- No missing references
- Clean mesh
- No duplicate geometry
- No unnecessary objects

The asset should be tested in Unity before submission.

---

# 9. Version Control

Commit the following files:

- `.blend`
- `.fbx`
- `.meta`
- Prefab
- Materials (if created)
- Textures (if new)

Do not commit:

- Temporary Blender backups
- Autosave files
- Cache files
- Export test files

All asset changes should be committed through GitHub Desktop following the Git workflow.

---

# 10. Common Mistakes

Avoid:

- Unapplied transforms
- Wrong pivot
- Incorrect forward axis
- Wrong scale
- Missing textures
- Duplicate materials
- Broken Prefabs
- Editing FBX manually
- Using multiple export settings across the project

Consistency is more important than individual preference.

---

# 11. Export Checklist

Before committing an asset:

- Model follows the style guide
- Scale is correct
- Pivot is correct
- Naming follows Naming.md
- Materials follow Materials.md
- Transforms applied
- FBX exports without errors
- Unity import settings verified
- Prefab created
- Asset tested in the Gameplay scene

Only after completing this checklist should the asset be committed.

---

# 12. Related Documentation

Art Guide

- Scale.md
- Naming.md
- Materials.md
- StyleGuide.md
- LOD.md

Architecture

- ../Architecture/ARCHITECTURE.md

Coding Standards

- ../CodingStandard/

Git Workflow

- ../Git/
