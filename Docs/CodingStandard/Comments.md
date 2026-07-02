# Comments Guide

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Philosophy
3. When to Write Comments
4. When NOT to Write Comments
5. XML Documentation
6. TODO Comments
7. FIXME Comments
8. HACK Comments
9. NOTE Comments
10. Comment Style
11. Examples
12. Code Review Checklist
13. Related Documentation

---

# 1. Overview

This document defines the commenting standards used throughout the project.

The goal is to keep the codebase clean, readable, and maintainable while ensuring that comments provide meaningful information.

Comments should explain intent, reasoning, or non-obvious behavior—not repeat what the code already says.

---

# 2. Philosophy

Code should be written to be self-documenting whenever possible.

Prefer:

- Clear class names
- Descriptive method names
- Meaningful variable names
- Small focused methods

Instead of relying on comments.

A good comment explains **why**, not **what**.

---

# 3. When to Write Comments

Write comments when they explain information that cannot be easily understood from the code itself.

Examples include:

- Design decisions
- Complex algorithms
- Performance optimizations
- Workarounds
- Engine limitations
- Business rules
- Non-obvious calculations
- Temporary compromises

---

# 4. When NOT to Write Comments

Do not comment code that is already obvious.

Avoid comments such as:

```csharp
// Increase health
_health++;
```

or

```csharp
// Get the player
Player player = GetPlayer();
```

These comments add noise without increasing understanding.

---

# 5. XML Documentation

Public APIs should include XML documentation when they are intended for use by other systems or developers.

Example:

```csharp
/// <summary>
/// Starts the next enemy wave.
/// </summary>
public void StartNextWave()
{
}
```

XML documentation is recommended for:

- Public classes
- Public methods
- Public properties
- Interfaces

It is optional for private members.

---

# 6. TODO Comments

Use `TODO` for planned improvements that are intentionally postponed.

Example:

```csharp
// TODO: Replace linear search with spatial partitioning.
```

Rules:

- Keep TODOs short.
- Describe the intended improvement.
- Remove TODOs once completed.

---

# 7. FIXME Comments

Use `FIXME` to indicate known issues that require correction.

Example:

```csharp
// FIXME: This calculation fails when the grid size is zero.
```

FIXME comments should be treated as high priority.

---

# 8. HACK Comments

Use `HACK` only when a temporary workaround is unavoidable.

Example:

```csharp
// HACK: Temporary workaround for Unity serialization issue.
```

Every HACK should eventually be removed.

---

# 9. NOTE Comments

Use `NOTE` to provide useful context that future developers should know.

Example:

```csharp
// NOTE: Waves are intentionally spawned sequentially to simplify balancing.
```

---

# 10. Comment Style

Rules:

- Write complete sentences.
- Keep comments concise.
- Use proper punctuation.
- Avoid unnecessary capitalization.
- Keep comments close to the code they describe.

Comments should remain accurate when the code changes.

---

# 11. Examples

## Good

```csharp
// Cache the component to avoid repeated GetComponent calls every frame.
_camera = GetComponent<Camera>();
```

```csharp
// Delay the wave start to give the player time to finish building.
yield return new WaitForSeconds(_preWaveDelay);
```

```csharp
// Unity calls Awake before Start on all active objects.
```

## Bad

```csharp
// Set camera
_camera = GetComponent<Camera>();
```

```csharp
// Wait
yield return new WaitForSeconds(5f);
```

```csharp
// Increase index
_index++;
```

---

# 12. Code Review Checklist

Before merging code, verify that:

- Comments explain intent rather than implementation.
- Obvious comments have been removed.
- XML documentation is present where appropriate.
- TODO comments are still relevant.
- FIXME comments are justified.
- HACK comments are temporary.
- Comments remain accurate after code changes.

---

# 13. Related Documentation

Coding Standards

- StyleGuide.md
- Naming.md
- BestPractices.md
- Performance.md
- ScriptableObjects.md
- ArchitecturePatterns.md
- FolderStructure.md

Architecture

- ../Architecture/

Gameplay

- ../Gameplay/
