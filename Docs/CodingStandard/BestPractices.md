# Best Practices

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Core Principles
3. SOLID
4. Clean Code
5. Data-Driven Design
6. Composition over Inheritance
7. Managers
8. Systems
9. MonoBehaviour
10. ScriptableObject
11. Events
12. Dependency Management
13. Update Usage
14. Object Pooling
15. Coroutines
16. Error Handling
17. Performance Mindset
18. Testing
19. Code Review Checklist
20. Related Documentation

---

# 1. Overview

This document describes the recommended programming practices for the project.

Its purpose is to encourage:

- Maintainable code
- Scalable architecture
- High performance
- Clear responsibilities
- Consistent implementation

All gameplay code should follow these practices.

---

# 2. Core Principles

Every new feature should prioritize:

- Readability
- Simplicity
- Reusability
- Modularity
- Testability
- Performance
- Scalability

If a solution is difficult to explain, it is probably too complex.

---

# 3. SOLID

The project follows the SOLID principles.

### Single Responsibility Principle

Each class should have one reason to change.

### Open/Closed Principle

Extend behavior without modifying existing code whenever possible.

### Liskov Substitution Principle

Derived classes should be interchangeable with their base classes.

### Interface Segregation Principle

Prefer several focused interfaces over one large interface.

### Dependency Inversion Principle

Depend on abstractions rather than concrete implementations.

---

# 4. Clean Code

Write code that is:

- Easy to read
- Easy to modify
- Easy to debug
- Easy to remove

Avoid:

- Long methods
- Deep nesting
- Duplicate code
- Hidden side effects

---

# 5. Data-Driven Design

Gameplay values should be stored in ScriptableObjects whenever appropriate.

Examples:

- Towers
- Enemies
- Waves
- Resources
- Buildings

Avoid hardcoded gameplay values.

---

# 6. Composition over Inheritance

Prefer composition whenever possible.

Example:

Instead of creating:

```text
FireTower : ArrowTower : Tower
```

Prefer reusable components:

- Targeting
- Shooting
- Damage
- Upgrades

Composition improves flexibility and reduces hierarchy complexity.

---

# 7. Managers

Managers coordinate high-level functionality.

Managers should:

- Manage lifecycle
- Coordinate systems
- Avoid gameplay logic
- Remain lightweight

Examples:

- GameManager
- SceneManager
- AudioManager

---

# 8. Systems

Systems implement gameplay mechanics.

Examples:

- GridSystem
- WaveSystem
- ConstructionSystem
- FogOfWarSystem

Systems should remain independent whenever possible.

---

# 9. MonoBehaviour

MonoBehaviours should:

- Be lightweight
- Delegate logic
- Cache references
- Minimize Update()

Business logic belongs in systems or services.

---

# 10. ScriptableObject

Use ScriptableObjects for:

- Configuration
- Static data
- Shared settings

Avoid storing runtime state inside assets.

Detailed guidelines are defined in ScriptableObjects.md.

---

# 11. Events

Prefer event-driven communication.

Benefits:

- Lower coupling
- Better scalability
- Easier testing

Avoid direct dependencies between unrelated systems.

---

# 12. Dependency Management

Avoid:

- Global lookups
- Circular dependencies
- Tight coupling

Prefer explicit dependencies and clear ownership.

---

# 13. Update Usage

Avoid unnecessary `Update()` methods.

Preferred alternatives:

- Events
- Coroutines
- Timers
- Scheduled actions

Use `FixedUpdate()` only for physics.

Use `LateUpdate()` only when frame ordering requires it.

---

# 14. Object Pooling

Frequently spawned objects should use object pooling.

Examples:

- Projectiles
- Enemies
- Damage numbers
- Visual effects

Avoid frequent Instantiate/Destroy during gameplay.

---

# 15. Coroutines

Use Coroutines for:

- Timed sequences
- Delays
- Wave spawning
- UI animations

Avoid deeply nested Coroutines.

---

# 16. Error Handling

Validate:

- Input parameters
- References
- External data

Fail early and provide meaningful error messages.

Avoid silent failures.

---

# 17. Performance Mindset

Performance should be considered from the beginning.

General recommendations:

- Cache references
- Avoid allocations in Update()
- Reuse objects
- Profile before optimizing
- Optimize bottlenecks, not assumptions

Premature optimization should be avoided, but obvious inefficiencies should not be ignored.

---

# 18. Testing

Every gameplay system should be tested independently.

Verify:

- Expected behavior
- Edge cases
- Invalid input
- Performance impact

Systems should remain deterministic whenever possible.

---

# 19. Code Review Checklist

Before submitting code:

- Follows StyleGuide.md
- Follows Naming.md
- No duplicated logic
- No magic numbers
- Clear responsibilities
- No unnecessary Update()
- No global searches
- Uses events appropriately
- Uses ScriptableObjects correctly
- Passes local testing

---

# 20. Related Documentation

Coding Standards

- StyleGuide.md
- Naming.md
- Comments.md
- ScriptableObjects.md
- Performance.md
- ArchitecturePatterns.md
- FolderStructure.md

Architecture

- ../Architecture/

Gameplay

- ../Gameplay/
