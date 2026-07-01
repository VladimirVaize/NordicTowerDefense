# Scale Guide

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. General Rules
3. Unity Units
4. Grid Scale
5. Building Dimensions
6. Environment Dimensions
7. Character Dimensions
8. Pivot Rules
9. Rotation Rules
10. Transform Rules
11. Collision Guidelines
12. Best Practices
13. Common Mistakes
14. Related Documentation

---

# 1. Overview

This document defines the scale standards used throughout the project.

Following a consistent scale is essential for:

- Gameplay readability
- Correct grid placement
- Collision accuracy
- Camera composition
- Animation consistency
- Modular asset creation

Every asset in the project must follow these standards.

---

# 2. General Rules

The project uses real-world metric units.

| Unit | Value |
|------|------:|
| 1 Unity Unit | 1 Meter |
| 1 Meter | 100 Centimeters |

All assets must be modeled using real-world dimensions whenever possible.

Import Scale in Unity must always remain:

```
1
```

---

# 3. Unity Units

The following conventions are mandatory.

- 1 Unity Unit = 1 Meter
- Scale = 1
- Rotation = (0,0,0)
- Apply all transforms before export
- Do not compensate incorrect size by changing Import Scale

---

# 4. Grid Scale

The game world is built on a square grid.

Grid Cell Size:

```
2 m × 2 m
```

Every buildable object occupies one or more complete cells.

Examples:

| Object | Grid Size |
|---------|----------:|
| Small Decoration | 1×1 |
| Tree | 1×1 |
| Rock | 1×1 |
| Arrow Tower | 2×2 |
| Ballista Tower | 2×2 |
| Barracks | 3×3 |
| Storage | 3×3 |
| Workshop | 4×4 |
| Castle | 12×12 |

Assets should never overlap neighboring cells unintentionally.

---

# 5. Building Dimensions

Buildings should visually fit inside their assigned grid cells.

Approximate recommendations:

| Building | Width | Length | Height |
|----------|-------:|--------:|--------:|
| Arrow Tower | 4 m | 4 m | 8 m |
| Cannon Tower | 4 m | 4 m | 7 m |
| Barracks | 6 m | 6 m | 5 m |
| Warehouse | 8 m | 8 m | 6 m |
| Castle | 24 m | 24 m | 18–25 m |

Small decorative elements may extend beyond the footprint if they do not affect gameplay readability.

---

# 6. Environment Dimensions

Recommended sizes.

| Object | Height |
|---------|-------:|
| Pine Tree | 7–12 m |
| Young Tree | 3–5 m |
| Bush | 0.5–1.5 m |
| Grass Patch | 0.2–0.5 m |
| Small Rock | 0.5 m |
| Medium Rock | 1.5 m |
| Large Boulder | 3–5 m |

Environment assets should maintain visual consistency across the map.

---

# 7. Character Dimensions

Approximate dimensions.

| Character | Height |
|-----------|--------:|
| Human | 1.8 m |
| Heavy Enemy | 2.5–3 m |
| Boss | 6–10 m |

Characters should remain clearly visible from the gameplay camera.

---

# 8. Pivot Rules

Correct pivot placement is required.

Buildings:

- Bottom Center

Environment:

- Bottom Center

Trees:

- Bottom Center

Rocks:

- Bottom Center

Resource Nodes:

- Bottom Center

Projectiles:

- Geometric Center

Proper pivot placement simplifies placement, rotation, and animation.

---

# 9. Rotation Rules

Before export:

Rotation must be:

```
X = 0
Y = 0
Z = 0
```

Forward Direction:

```
+Z
```

Up Direction:

```
+Y
```

---

# 10. Transform Rules

Before exporting every asset:

- Apply Location
- Apply Rotation
- Apply Scale

In Blender:

```
Ctrl + A

↓

All Transforms
```

Objects with unapplied transforms must not be committed to the repository.

---

# 11. Collision Guidelines

Collision meshes should closely match gameplay needs rather than visual complexity.

General rules:

- Keep colliders simple.
- Avoid unnecessary mesh colliders.
- Use primitive colliders whenever possible.
- Decorative overhangs should not unnecessarily expand collision bounds.

Gameplay always has priority over visual accuracy.

---

# 12. Best Practices

- Maintain consistent proportions.
- Design assets for top-down readability.
- Leave visual breathing space between objects.
- Prioritize clean silhouettes.
- Test assets in Unity before committing.

---

# 13. Common Mistakes

Avoid:

- Incorrect Import Scale
- Negative Scale
- Offset Pivot
- Unapplied Transforms
- Incorrect Rotation
- Oversized Decorations
- Tiny Details invisible from gameplay camera

Following these rules greatly reduces production issues.

---

# 14. Related Documentation

- Naming.md
- Materials.md
- StyleGuide.md
- LOD.md
- Export.md

Architecture:

- ../Architecture/ARCHITECTURE.md

Coding Standards:

- ../CodingStandard/FolderStructure.md
