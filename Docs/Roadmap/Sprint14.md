---
Sprint: Sprint 14
Title: Optimization

Status: Planned
Priority: High

Roadmap Phase: Phase 4 — Visual Polish & Optimization
Milestone: 5.4 Performance Stabilization

Estimated Duration: 3–5 Weeks
Actual Duration: TBD

Start Date: TBD
End Date: TBD

Dependencies: Sprint 13
Next Sprint: Sprint 15 — Vertical Slice

---

# Sprint 14 — Optimization

---

# Table of Contents

1. Overview
2. Sprint Objective
3. Deliverables
4. Optimization Areas
5. Technical Tasks
6. Performance Strategy
7. Testing
8. Definition of Done
9. Dependencies
10. Risks
11. Exit Criteria
12. Sprint Summary
13. Related Documentation

---

# 1. Overview

Sprint 14 focuses on Optimization.

This sprint is dedicated to improving performance, reducing unnecessary computations, and ensuring the game can scale to large numbers of entities without degradation.

The goal is not to add features, but to make existing systems efficient, stable, and production-ready.

---

# 2. Sprint Objective

Optimize the entire game architecture for performance and scalability.

At the end of this sprint the project should support:

- Stable FPS during large waves
- Efficient enemy management
- Optimized pathfinding
- Reduced GC allocations
- Efficient UI updates
- Optimized VFX and audio systems
- Scalable grid operations

---

# 3. Deliverables

The sprint is considered complete when the following optimizations are implemented.

## Enemy System Optimization

Support for:

- Reduced update frequency where possible
- Object pooling for enemies
- Efficient state machine execution
- Batch processing where applicable

---

## Tower System Optimization

Support for:

- Efficient target acquisition
- Reduced per-frame scanning
- Cached enemy lists
- Optimized projectile handling

---

## Grid System Optimization

Support for:

- Efficient cell queries
- Reduced recalculation of pathfinding data
- Cached grid data structures
- Optimized fog updates dependency

---

## Wave System Optimization

Support for:

- Efficient spawn handling
- Reduced overhead in wave updates
- Event-driven wave progression

---

## UI System Optimization

Support for:

- Reduced UI refresh frequency
- Event-driven updates instead of polling
- Efficient HUD binding
- Minimized layout recalculations

---

## VFX & Audio Optimization

Support for:

- Object pooling for effects
- Limited simultaneous audio sources
- Reuse of particle systems
- Reduced overdraw and update cost

---

# 4. Optimization Areas

## CPU Optimization

- Reduce per-frame Update() usage
- Replace polling with events
- Batch expensive operations

---

## Memory Optimization

- Reduce allocations during gameplay
- Avoid runtime garbage spikes
- Reuse objects via pooling systems

---

## Pathfinding Optimization

- Cache paths where possible
- Avoid recomputation unless needed
- Limit recalculations per frame

---

## Rendering Optimization

- Reduce overdraw from VFX
- Optimize fog rendering
- Reduce unnecessary UI redraws

---

## Event System Optimization

- Prevent excessive event firing
- Avoid redundant subscriptions
- Clean up unused listeners

---

# 5. Technical Tasks

Complete the following work:

- Implement object pooling system (enemies, projectiles, VFX)
- Optimize Enemy update loops
- Optimize Tower targeting system
- Optimize Grid operations
- Optimize pathfinding recalculations
- Optimize UI event updates
- Optimize Wave spawning system
- Reduce GC allocations
- Profile performance bottlenecks
- Fix memory leaks (if any)
- Improve batching of repeated operations

---

# 6. Performance Strategy

Optimization must follow this approach:

## Step 1 — Profiling

- Identify real bottlenecks using profiler
- Avoid premature optimization

## Step 2 — Targeting Hotspots

- Focus on highest cost systems first
- Enemy + Tower systems are priority

## Step 3 — Structural Optimization

- Improve architecture where needed
- Reduce unnecessary dependencies

## Step 4 — Micro Optimization

- Reduce allocations
- Optimize loops
- Cache repeated calculations

## Step 5 — Validation

- Measure performance improvements
- Ensure no gameplay regression

---

# 7. Testing

Verify that:

- Large waves maintain stable FPS.
- No memory leaks occur over time.
- UI remains responsive under load.
- Pathfinding does not cause spikes.
- VFX does not overload GPU/CPU.
- Game runs consistently over long sessions.
- No gameplay behavior is broken by optimizations.

---

# 8. Definition of Done

Sprint 14 is complete when:

- Game runs smoothly with large enemy counts.
- No major performance bottlenecks remain.
- Object pooling is implemented where needed.
- UI and gameplay updates are efficient.
- Profiling shows stable performance.
- Game is ready for Vertical Slice.

---

# 9. Dependencies

Required:

- Sprint 13 completed.

Future dependent sprints:

- Sprint 15 — Vertical Slice
- Sprint 16 — Beta Preparation
- Sprint 17 — Release Candidate

Optimization is required before final gameplay assembly.

---

# 10. Risks

Potential risks include:

- Over-optimization of non-critical systems
- Introducing bugs during refactoring
- Breaking gameplay logic while optimizing
- Inconsistent performance across platforms
- Increased complexity from pooling systems

Optimization must not change gameplay behavior.

---

# 11. Exit Criteria

Sprint 14 is complete when:

- Performance is stable under heavy load.
- No major GC spikes occur during gameplay.
- Systems are optimized without breaking functionality.
- Game is ready for Vertical Slice integration.
- Profiling confirms acceptable performance baseline.

---

# 12. Sprint Summary

Status: Planned

Completed:

- TBD

Lessons Learned:

- TBD

Carry Over:

- TBD

---

# 13. Related Documentation

## Architecture

- ../Architecture/

## Coding Standards

- ../CodingStandard/

## Gameplay

- ../Gameplay/

## Roadmap

- Vision.md
- Roadmap.md
- Milestones.md
