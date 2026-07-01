# Visual Style Guide

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Visual Direction
3. Artistic Principles
4. Shape Language
5. Silhouette Readability
6. Color Palette
7. Level of Detail
8. Environment Design
9. Buildings
10. Towers
11. Resources
12. Characters
13. Visual Effects
14. Lighting
15. Camera Considerations
16. Things to Avoid
17. Quality Checklist
18. Related Documentation

---

# 1. Overview

This document defines the artistic direction of the project.

Its purpose is to ensure that every asset follows the same visual language and fits naturally into the game world.

All artists should use this guide as the primary visual reference.

---

# 2. Visual Direction

The project follows a:

**Stylized Low-Poly Scandinavian**

visual style.

The atmosphere should feel:

- Calm
- Natural
- Nordic
- Clean
- Readable
- Cozy between waves
- Tense during battles

Gameplay readability always takes priority over realism.

---

# 3. Artistic Principles

Every asset should follow these principles.

## Simplicity

Use clean geometric shapes.

Avoid unnecessary complexity.

---

## Readability

Assets must remain recognizable from the gameplay camera.

---

## Consistency

All assets should appear as if created by the same artist.

---

## Function First

Visual design should support gameplay.

Decoration should never reduce readability.

---

## Stylization

Prefer stylized proportions over realistic ones when it improves gameplay clarity.

---

# 4. Shape Language

Different object categories should have distinct shapes.

Buildings:

- Stable
- Wide
- Heavy
- Rectangular

Towers:

- Vertical
- Recognizable
- Visible from a distance

Trees:

- Organic
- Rounded or triangular

Rocks:

- Large simple volumes
- Irregular but clean

Resources:

- Distinctive
- Easy to identify

---

# 5. Silhouette Readability

Silhouette is one of the most important design elements.

Every asset should remain recognizable:

- without textures
- without materials
- at long distance
- from the gameplay camera

Large forms are more important than small details.

---

# 6. Color Palette

Preferred colors:

- Natural greens
- Warm wood tones
- Cold gray stone
- Soft snow whites
- Earth browns
- Muted blues

Avoid:

- Neon colors
- Extremely saturated colors
- Pure black
- Pure white

Contrast should guide the player's attention.

---

# 7. Level of Detail

Models should contain only the amount of detail visible during gameplay.

Guidelines:

- Large readable shapes
- Medium supporting details
- Minimal tiny details

If a detail is invisible from the gameplay camera, it should be removed.

Detailed LOD rules are defined in LOD.md.

---

# 8. Environment Design

The world should feel handcrafted.

Environment assets include:

- Pine trees
- Spruce trees
- Bushes
- Grass
- Rocks
- Cliffs
- Stumps
- Fallen logs

Objects should appear naturally distributed rather than perfectly aligned.

---

# 9. Buildings

Buildings should communicate their purpose visually.

Examples:

Barracks

- Defensive
- Wooden
- Reinforced

Storage

- Large
- Practical
- Organized

Workshop

- Functional
- Industrial
- Durable

The player should understand a building's role before opening its UI.

---

# 10. Towers

Towers are key gameplay elements.

Requirements:

- Highly visible
- Strong silhouette
- Clearly distinguishable from other buildings
- Easy to identify by function

Each tower type should have its own visual identity.

---

# 11. Resources

Resource nodes should be instantly recognizable.

Examples:

Wood

- Trees
- Logs

Stone

- Rock formations

Supply Crates

- Bright enough to attract attention
- Clearly different from decorative props

Players should never confuse decorative objects with collectible resources.

---

# 12. Characters

Characters should remain readable despite the distant camera.

Requirements:

- Slightly exaggerated proportions
- Clear animations
- Distinct team colors
- Recognizable silhouettes

Important enemies should be visually larger than standard units.

---

# 13. Visual Effects

Effects should support gameplay.

Examples:

- Fire
- Smoke
- Snow
- Magic
- Explosions

Effects must never hide gameplay information.

Avoid excessive particle density.

---

# 14. Lighting

Lighting should reinforce the Nordic atmosphere.

Preferred characteristics:

- Soft daylight
- Cold ambient light
- Warm firelight
- Clear shadows

Lighting should improve readability rather than create dramatic realism.

---

# 15. Camera Considerations

The primary gameplay camera is:

- Top-down
- Approximately 45° angle

Assets should be designed to look good from this perspective.

Top surfaces are more important than undersides.

---

# 16. Things to Avoid

Avoid:

- Photorealism
- Hyper-detailed models
- Excessive ornamentation
- Tiny unreadable details
- Visual noise
- Inconsistent proportions
- Mixed artistic styles

Every asset should support the overall visual identity.

---

# 17. Quality Checklist

Before submitting an asset, verify:

- Correct scale
- Correct naming
- Correct pivot
- Clean silhouette
- Appropriate level of detail
- Consistent materials
- Fits the art style
- Readable from gameplay camera

Only assets passing this checklist should be committed to the repository.

---

# 18. Related Documentation

Art Guide

- Scale.md
- Naming.md
- Materials.md
- LOD.md
- Export.md

Architecture

- ../Architecture/ARCHITECTURE.md

Coding Standards

- ../CodingStandard/
