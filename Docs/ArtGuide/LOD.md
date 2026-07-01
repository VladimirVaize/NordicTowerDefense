# Level of Detail (LOD) Guide

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Purpose
3. LOD Philosophy
4. Objects That Require LOD
5. Objects That Do Not Require LOD
6. LOD Levels
7. Triangle Reduction Guidelines
8. Visual Consistency
9. Unity LOD Group
10. Asset Workflow
11. Validation Checklist
12. Common Mistakes
13. Future Improvements
14. Related Documentation

---

# 1. Overview

This document defines the Level of Detail (LOD) standards used throughout the project.

The goals are:

- Improve rendering performance
- Reduce GPU workload
- Maintain visual consistency
- Simplify asset production
- Ensure predictable optimization

LOD should improve performance without noticeably affecting visual quality.

---

# 2. Purpose

The game is viewed from a top-down camera at approximately 45 degrees.

Most objects become significantly smaller as the camera zooms out.

Reducing geometric complexity for distant objects improves performance while preserving gameplay readability.

---

# 3. LOD Philosophy

The project follows these principles:

- Keep LOD transitions visually smooth.
- Reduce geometry, not artistic quality.
- Preserve silhouettes whenever possible.
- Do not create unnecessary LOD levels.
- Readability is more important than realism.

---

# 4. Objects That Require LOD

LOD should be created for:

- Castle
- Large buildings
- Towers
- Large trees
- Cliffs
- Rock formations
- Large decorative structures

These assets remain visible for long periods and benefit from optimization.

---

# 5. Objects That Do Not Require LOD

LOD is generally unnecessary for:

- Small rocks
- Bushes
- Grass
- Crates
- Barrels
- Small props
- Resource boxes
- Ground decals

These objects have low polygon counts or are too small for LOD to provide meaningful benefits.

---

# 6. LOD Levels

The recommended setup is:

## LOD0

Highest quality.

Used when the object is close to the camera.

---

## LOD1

Medium quality.

Approximately 50–70% of the original triangle count.

Small decorative details may be removed.

---

## LOD2

Low quality.

Approximately 20–40% of the original triangle count.

Only the primary silhouette should remain.

---

## Culled

The object is no longer rendered when it occupies only a tiny portion of the screen.

---

# 7. Triangle Reduction Guidelines

Recommended triangle budgets:

| LOD | Triangle Count |
|------|---------------:|
| LOD0 | 100% |
| LOD1 | 50–70% |
| LOD2 | 20–40% |

Triangle reduction should prioritize removing hidden or insignificant geometry before altering the overall shape.

---

# 8. Visual Consistency

Every LOD version should:

- Maintain the same silhouette.
- Use the same materials.
- Use the same textures.
- Preserve the object's identity.
- Avoid noticeable visual "popping".

LOD transitions should be as seamless as possible.

---

# 9. Unity LOD Group

All LOD-enabled assets should use Unity's built-in **LOD Group** component.

General recommendations:

- Configure transition percentages based on object size.
- Enable cross-fading if appropriate for the asset.
- Test transitions using the gameplay camera.

Do not create custom LOD systems unless there is a demonstrated need.

---

# 10. Asset Workflow

Recommended production pipeline:

```text
Create Model
        │
        ▼
LOD0
        │
        ▼
Create LOD1
        │
        ▼
Create LOD2
        │
        ▼
Export FBX
        │
        ▼
Import to Unity
        │
        ▼
Assign LOD Group
        │
        ▼
Test in Gameplay Camera
```

---

# 11. Validation Checklist

Before committing an asset with LOD:

- LOD Group configured
- Correct LOD order
- Triangle counts verified
- Materials consistent
- Naming correct
- No missing meshes
- No broken references
- Smooth transitions
- Tested in gameplay camera

Only validated assets should be committed.

---

# 12. Common Mistakes

Avoid:

- Too many LOD levels
- Excessive triangle reduction
- Different materials between LODs
- Incorrect pivots
- Broken silhouettes
- Noticeable popping
- Missing LOD meshes

Optimization should never reduce gameplay readability.

---

# 13. Future Improvements

The current LOD system is designed to support future enhancements, including:

- Billboard LODs
- Impostor rendering
- GPU instancing
- Automatic LOD generation (with manual validation)
- Addressables integration
- Streaming large environments

These features can be introduced without changing the overall LOD workflow.

---

# 14. Related Documentation

Art Guide

- Scale.md
- Naming.md
- StyleGuide.md
- Materials.md
- Export.md

Architecture

- ../Architecture/ARCHITECTURE.md

Coding Standards

- ../CodingStandard/
