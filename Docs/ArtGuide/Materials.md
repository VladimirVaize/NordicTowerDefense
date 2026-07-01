# Materials Guide

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Material Philosophy
3. Material Library
4. Shader Standards
5. Material Rules
6. Texture Usage
7. Color Palette
8. Transparency
9. Emission
10. Terrain Materials
11. Reusable Materials
12. Performance Guidelines
13. Common Mistakes
14. Related Documentation

---

# 1. Overview

This document defines the material standards used throughout the project.

The primary goals are:

- Consistent visual style
- Easy maintenance
- High performance
- Reusable assets
- Clean production pipeline

All materials must follow these guidelines.

---

# 2. Material Philosophy

Materials describe **surfaces**, not objects.

Correct:

- MAT_Wood
- MAT_Stone
- MAT_Metal
- MAT_Grass

Incorrect:

- MAT_Barracks
- MAT_Tower01
- MAT_CastleMaterial

Whenever possible, assets should reuse existing materials instead of creating new ones.

---

# 3. Material Library

Project materials are organized by surface type.

Example structure:

Materials/

- Wood
- Stone
- Metal
- Grass
- Dirt
- Snow
- Roof
- Fabric
- Water
- Fire

Every new material should belong to one of these categories.

---

# 4. Shader Standards

The project uses **Universal Render Pipeline (URP)**.

Approved shaders:

- URP Lit (default)
- URP Simple Lit (when appropriate)
- Custom shaders (only with approval)

Avoid mixing different shader families unnecessarily.

---

# 5. Material Rules

General rules:

- Prefer one material per model.
- Reuse existing materials whenever possible.
- Keep material count low.
- Material names must follow Naming.md.
- Do not duplicate identical materials.
- Apply transforms before export.
- Materials should be assigned in Blender whenever practical.

---

# 6. Texture Usage

Textures should remain simple and stylized.

Recommended maps:

- Base Color
- Normal (optional)
- Mask (optional)
- Ambient Occlusion (optional)
- Emission (only when needed)

Avoid excessive texture complexity.

For small props, a shared texture atlas is preferred.

---

# 7. Color Palette

The project follows a stylized Scandinavian-inspired palette.

General principles:

- Natural colors
- Slight saturation
- Soft contrast
- Readable from a top-down camera
- Consistent hue relationships

Avoid:

- Neon colors
- Pure black
- Pure white
- Oversaturated materials

The complete visual language is defined in StyleGuide.md.

---

# 8. Transparency

Transparent materials should be used sparingly.

Recommended uses:

- Water
- Windows
- Magic effects
- UI elements

Avoid transparency for foliage unless required.

Opaque rendering is preferred for performance.

---

# 9. Emission

Emission should only be used for objects that emit light.

Examples:

- Campfires
- Torches
- Magic crystals
- Lava
- Windows at night

Emission intensity should remain subtle.

---

# 10. Terrain Materials

Terrain materials should blend naturally.

Recommended surfaces:

- Grass
- Dirt
- Stone
- Sand
- Snow

Transitions should avoid abrupt visual changes.

---

# 11. Reusable Materials

Materials should be reused across the project.

Examples:

MAT_Wood

used by:

- Towers
- Barracks
- Storage
- Fences

MAT_Stone

used by:

- Castle
- Walls
- Roads
- Rocks

Material reuse improves consistency and performance.

---

# 12. Performance Guidelines

To maintain good performance:

- Minimize material count.
- Reuse shared materials.
- Prefer texture atlases.
- Avoid unnecessary transparency.
- Keep shader complexity low.
- Avoid expensive custom shaders.

Performance should always be considered during asset creation.

---

# 13. Common Mistakes

Avoid:

- Duplicate materials
- Object-specific materials
- Excessive texture resolution
- Overly shiny surfaces
- High-emission materials
- Unused textures
- Mixed visual styles

---

# 14. Related Documentation

Art Guide

- Scale.md
- Naming.md
- StyleGuide.md
- LOD.md
- Export.md

Architecture

- ../Architecture/ARCHITECTURE.md

Coding Standards

- ../CodingStandard/
