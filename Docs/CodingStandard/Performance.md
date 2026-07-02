# Performance Guide

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Performance Philosophy
3. Profiling
4. CPU Performance
5. Memory Management
6. Garbage Collection
7. Update Methods
8. Object Pooling
9. Component Access
10. Physics
11. Rendering
12. UI Performance
13. ScriptableObjects
14. Events
15. Coroutines
16. Collections
17. Gameplay Systems
18. Tower Defense Specific Optimizations
19. Code Review Checklist
20. Related Documentation

---

# 1. Overview

This document defines the performance guidelines used throughout the project.

Performance is considered from the beginning of development but should never come at the expense of readability or maintainability.

The primary goal is to build scalable systems that remain performant as the project grows.

---

# 2. Performance Philosophy

Follow these principles:

- Measure before optimizing.
- Prioritize readable code.
- Optimize real bottlenecks.
- Avoid premature optimization.
- Keep systems scalable.

Performance improvements should be based on profiler data rather than assumptions.

---

# 3. Profiling

Always verify performance using Unity Profiler before implementing optimizations.

Recommended tools:

- Unity Profiler
- Frame Debugger
- Memory Profiler
- Rendering Statistics
- Profile Analyzer

Do not optimize code without evidence that it is causing a performance issue.

---

# 4. CPU Performance

Avoid unnecessary work.

General recommendations:

- Cache expensive operations.
- Reduce nested loops.
- Minimize per-frame calculations.
- Prefer events over polling.
- Spread heavy work across multiple frames when appropriate.

---

# 5. Memory Management

Reduce memory allocations during gameplay.

Avoid:

- Creating temporary objects unnecessarily.
- Allocating strings every frame.
- Frequent list recreation.

Prefer reusing existing objects and collections.

---

# 6. Garbage Collection

Garbage Collection spikes can cause frame drops.

Recommendations:

- Avoid allocations inside Update().
- Reuse collections.
- Use object pooling.
- Minimize boxing.
- Avoid unnecessary string concatenation.

Aim for stable frame times rather than occasional high FPS.

---

# 7. Update Methods

Use Unity update methods appropriately.

### Update()

Only for logic that must execute every frame.

### FixedUpdate()

Physics only.

### LateUpdate()

Camera updates and execution order adjustments.

If a script does not require Update(), do not implement it.

---

# 8. Object Pooling

Frequently spawned objects should use pools.

Examples:

- Enemies
- Projectiles
- Floating damage numbers
- Visual effects

Avoid repeated Instantiate()/Destroy() calls during gameplay.

---

# 9. Component Access

Cache frequently used component references.

Avoid repeated calls to:

- GetComponent()
- Camera.main
- FindObjectOfType()
- GameObject.Find()

during gameplay.

---

# 10. Physics

Use physics only when required.

Recommendations:

- Prefer triggers when collisions are unnecessary.
- Limit Rigidbody usage.
- Keep collision layers organized.
- Avoid unnecessary raycasts.

---

# 11. Rendering

Rendering performance should be considered when importing assets.

Recommendations:

- Use LOD Groups where appropriate.
- Enable GPU Instancing when possible.
- Reduce overdraw.
- Limit dynamic lights.
- Keep materials shared whenever practical.

Refer to ArtGuide/LOD.md for additional guidance.

---

# 12. UI Performance

Avoid updating UI every frame.

Update UI only when values change.

Examples:

- Resources
- Health
- Wave counter

Prefer event-driven UI updates.

---

# 13. ScriptableObjects

Use ScriptableObjects for static configuration data.

Avoid storing runtime state.

Shared configuration reduces duplication and memory usage.

---

# 14. Events

Prefer events over polling.

Examples:

Good:

- ResourceChanged
- WaveStarted
- BuildingPlaced

Avoid systems constantly checking for state changes each frame.

---

# 15. Coroutines

Use Coroutines for timed gameplay sequences.

Examples:

- Wave spawning
- Construction timers
- Cooldowns

Avoid excessive nesting or long-lived Coroutines that are difficult to manage.

---

# 16. Collections

Reuse collections whenever possible.

Recommendations:

- Clear lists instead of recreating them.
- Reuse dictionaries.
- Avoid unnecessary LINQ in frequently executed code.

Choose data structures appropriate to the use case.

---

# 17. Gameplay Systems

Gameplay systems should:

- Process only active objects.
- Avoid global searches.
- Cache references.
- Communicate through events where appropriate.

Independent systems are easier to optimize and profile.

---

# 18. Tower Defense Specific Optimizations

The following systems require special attention:

### Grid System

- Cache grid cells.
- Avoid rebuilding the grid unnecessarily.

### Wave System

- Spawn enemies over time.
- Avoid creating large numbers of objects simultaneously.

### Tower System

- Search for targets at configurable intervals rather than every frame.
- Cache target references when possible.

### Enemy AI

- Recalculate paths only when necessary.
- Avoid expensive pathfinding every frame.

### Fog of War

- Update only affected regions.
- Avoid recalculating the entire map.

### Resource System

- Update UI through events.
- Avoid continuous polling.

### Building System

- Reuse building preview objects.
- Avoid repeated allocations while placing buildings.

---

# 19. Code Review Checklist

Before merging code:

- No unnecessary Update()
- No runtime allocations in hot paths
- Uses object pooling where appropriate
- Uses cached references
- Event-driven where practical
- No unnecessary searches
- Profiled if optimization was performed
- Readability preserved

---

# 20. Related Documentation

Coding Standards

- BestPractices.md
- StyleGuide.md
- ScriptableObjects.md
- ArchitecturePatterns.md

Art Guide

- ../ArtGuide/LOD.md

Architecture

- ../Architecture/

Gameplay

- ../Gameplay/
