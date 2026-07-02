# C# Style Guide

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. General Principles
3. File Structure
4. Namespace Rules
5. Using Directives
6. Class Layout
7. Member Order
8. Formatting Rules
9. Braces
10. Indentation
11. Blank Lines
12. Access Modifiers
13. Fields
14. Properties
15. Constants
16. Methods
17. Constructors
18. Regions
19. Comments
20. XML Documentation
21. MonoBehaviour Rules
22. ScriptableObject Rules
23. Events
24. Coroutines
25. Async Code
26. Error Handling
27. Logging
28. Inspector Usage
29. Serialization
30. Unity Attributes
31. Code Review Checklist
32. Related Documentation

---

# 1. Overview

This document defines the official C# coding style used throughout the project.

The goal is to ensure that every source file has a consistent appearance regardless of who wrote it.

Consistency improves readability, maintainability, and long-term scalability.

---

# 2. General Principles

All code should follow these principles:

- Readability over cleverness
- Simplicity over complexity
- Explicit over implicit
- Consistency over personal preference
- Self-documenting code whenever possible

Code is written for humans first and computers second.

---

# 3. File Structure

Each `.cs` file should contain a single top-level type.

Recommended order:

1. File Header (optional)
2. Using Directives
3. Namespace
4. Class Declaration
5. Class Members

One file should contain only one public class.

---

# 4. Namespace Rules

Namespaces should reflect the project structure.

Example:

```text
Hrafnar.Core
Hrafnar.Managers
Hrafnar.Systems
Hrafnar.UI
Hrafnar.Gameplay
```

Avoid deeply nested namespaces.

---

# 5. Using Directives

Rules:

- System namespaces first
- Unity namespaces second
- Project namespaces last
- Remove unused usings
- Do not use wildcard imports

Example:

```csharp
using System;
using System.Collections.Generic;

using UnityEngine;

using Hrafnar.Systems;
```

---

# 6. Class Layout

Recommended layout:

```text
Class Declaration

↓

Constants

↓

Static Fields

↓

Serialized Fields

↓

Private Fields

↓

Properties

↓

Events

↓

Constructors

↓

Unity Messages

↓

Public Methods

↓

Protected Methods

↓

Private Methods
```

Maintain the same structure across all classes.

---

# 7. Member Order

Members should always appear in the order defined above.

Do not mix fields and methods.

Group similar members together.

---

# 8. Formatting Rules

- UTF-8 encoding
- Unix or Windows line endings (consistent across the project)
- One statement per line
- Maximum line length: 120 characters (recommended)
- One declaration per line

---

# 9. Braces

Always use braces, even for single-line statements.

Correct:

```csharp
if (isAlive)
{
    Attack();
}
```

Incorrect:

```csharp
if (isAlive)
    Attack();
```

---

# 10. Indentation

Use:

- 4 spaces
- No tabs

Nested blocks increase indentation by one level.

---

# 11. Blank Lines

Use blank lines to separate logical sections.

Avoid multiple consecutive empty lines.

---

# 12. Access Modifiers

Always specify an access modifier.

Preferred order:

- public
- protected
- internal
- private

Do not rely on default accessibility.

---

# 13. Fields

Rules:

- Prefer private fields.
- Use `[SerializeField]` for Inspector exposure.
- Avoid public fields.
- Initialize fields where appropriate.

---

# 14. Properties

Expose data through properties when external access is required.

Prefer:

```csharp
public int Health { get; private set; }
```

Instead of:

```csharp
public int health;
```

---

# 15. Constants

Use `const` for compile-time constants.

Use `readonly` for runtime constants.

Avoid magic numbers.

---

# 16. Methods

Methods should:

- Perform one task.
- Have descriptive names.
- Be short and focused.
- Avoid excessive nesting.

Break large methods into smaller private methods.

---

# 17. Constructors

Use constructors for dependency initialization when appropriate.

Avoid complex logic inside constructors.

For `MonoBehaviour`, prefer Unity lifecycle methods.

---

# 18. Regions

The project does **not** use `#region`.

If a class requires regions to remain readable, it should be refactored into smaller classes.

Exception:

- Editor scripts may use regions for organization.

---

# 19. Comments

Write comments only when they add value.

Avoid comments that simply restate the code.

Prefer self-documenting code.

Detailed commenting rules are defined in `Comments.md`.

---

# 20. XML Documentation

Public APIs should include XML documentation where appropriate.

Example:

```csharp
/// <summary>
/// Starts the next enemy wave.
/// </summary>
public void StartWave()
{
}
```

---

# 21. MonoBehaviour Rules

- Keep MonoBehaviours lightweight.
- Avoid business logic when possible.
- Delegate gameplay logic to systems or services.
- Cache component references.
- Minimize `Update()` usage.

---

# 22. ScriptableObject Rules

Use `ScriptableObject` for configuration data.

Avoid storing runtime state inside assets.

Detailed guidelines are defined in `ScriptableObjects.md`.

---

# 23. Events

Prefer C# events or delegated event systems for communication between systems.

Avoid unnecessary direct references between unrelated classes.

---

# 24. Coroutines

Use Coroutines for timed sequences and asynchronous gameplay flow.

Avoid deeply nested Coroutines.

---

# 25. Async Code

Use `async` / `await` only when it provides a clear benefit.

Do not mix Coroutines and async patterns without a clear reason.

---

# 26. Error Handling

Validate input where appropriate.

Handle expected errors gracefully.

Avoid empty `catch` blocks.

---

# 27. Logging

Use `Debug.Log()` sparingly.

Remove temporary debug logs before merging.

Use `Debug.LogWarning()` and `Debug.LogError()` appropriately.

---

# 28. Inspector Usage

Only expose fields that require designer configuration.

Avoid exposing implementation details.

Use attributes such as:

- `[Header]`
- `[Tooltip]`
- `[Range]`

to improve Inspector usability.

---

# 29. Serialization

Prefer `[SerializeField] private`.

Avoid serializing unnecessary runtime data.

Keep serialized fields organized and documented.

---

# 30. Unity Attributes

Use Unity attributes consistently to improve readability and Inspector organization.

Examples:

- `[SerializeField]`
- `[Header]`
- `[Tooltip]`
- `[Range]`
- `[Min]`
- `[Space]`

---

# 31. Code Review Checklist

Before submitting code:

- Follows naming conventions
- Correct formatting
- No public fields unless justified
- No magic numbers
- No unused code
- No commented-out code
- No unnecessary allocations
- No temporary debug logs
- Passes compilation
- Reviewed locally

---

# 32. Related Documentation

Coding Standards

- Naming.md
- BestPractices.md
- Comments.md
- Performance.md
- ScriptableObjects.md
- ArchitecturePatterns.md
- FolderStructure.md

Architecture

- ../Architecture/

Gameplay

- ../Gameplay/
