---
Sprint: Sprint 06
Title: Enemy System

Status: Planned
Priority: Critical

Roadmap Phase: Phase 2 — Core Gameplay
Milestone: 2.3 Combat System

Estimated Duration: 3–4 Weeks
Actual Duration: TBD

Start Date: TBD
End Date: TBD

Dependencies: Sprint 05
Next Sprint: Sprint 07 — Wave System
---

# Sprint 06 — Enemy System

---

# Table of Contents

1. Overview
2. Sprint Objective
3. Deliverables
4. Features
5. Technical Tasks
6. Documentation
7. Testing
8. Definition of Done
9. Dependencies
10. Risks
11. Exit Criteria
12. Sprint Summary
13. Related Documentation

---

# 1. Overview

Sprint 06 introduces the Enemy System.

Enemies are autonomous gameplay entities that navigate the map, interact with towers, receive damage and threaten the player's settlement.

The implementation is divided into two feature modules:

- **Enemies** — enemy definitions, statistics, health, states and combat interactions.
- **Navigation** — pathfinding, movement and grid-based navigation.

This separation keeps combat logic independent from movement logic and improves long-term maintainability.

---

# 2. Sprint Objective

Implement a modular Enemy System.

At the end of this sprint the project should support:

- Enemy definitions
- Enemy spawning hooks
- Health and damage
- Status effects framework
- Enemy states
- Grid navigation
- Pathfinding
- Movement
- Death handling
- Combat integration with towers

Wave orchestration will be implemented in Sprint 07.

---

# 3. Deliverables

The sprint is considered complete when the following systems are implemented.

## Enemy Definitions

- ScriptableObject-based enemy data
- Enemy categories
- Statistics
- Movement speed
- Health
- Damage values
- Visual prefabs

---

## Enemy Lifecycle

Support for:

- Spawn initialization
- Runtime updates
- Death
- Cleanup

---

## Health System

Support for:

- Current health
- Maximum health
- Damage reception
- Healing hooks
- Death events

---

## Enemy States

Support for:

- Idle
- Moving
- Attacking
- Stunned
- Dead

Additional states may be introduced in future updates.

---

## Status Effects Framework

Support for future effects such as:

- Slow
- Burn
- Poison
- Freeze
- Stun

Only the framework is required during this sprint.

---

## Navigation

Support for:

- Grid navigation
- Path calculation
- Path following
- Destination updates
- Obstacle handling

---

## Combat Integration

Support for:

- Receiving tower damage
- Projectile hit detection
- Combat events
- Death notifications

---

# 4. Features

## EnemyManager

Responsibilities:

- Register enemies
- Update active enemies
- Track enemy lifecycle
- Notify dependent systems

---

## EnemyController

Responsibilities:

- Enemy behavior
- State transitions
- Health management
- Combat interaction

---

## Navigation System

Responsibilities:

- Calculate paths
- Follow paths
- Update movement
- Handle dynamic path recalculation

---

## Health System

Responsibilities:

- Receive damage
- Handle death
- Trigger events
- Maintain health state

---

## Status Effect System

Responsibilities:

- Register active effects
- Apply modifiers
- Manage durations
- Notify gameplay systems

---

# 5. Technical Tasks

Complete the following work:

- Implement EnemyManager
- Create EnemyData ScriptableObjects
- Implement EnemyController
- Implement health system
- Implement enemy state machine
- Implement Navigation module
- Implement pathfinding
- Implement movement system
- Integrate tower damage
- Implement death handling
- Create combat events
- Prepare Wave System integration

---

# 6. Documentation

Update documentation if implementation affects:

Gameplay:

- Enemies.md
- Towers.md
- Waves.md

Architecture:

- Systems.md
- Managers.md

Coding Standards:

- ArchitecturePatterns.md
- ScriptableObjects.md

---

# 7. Testing

Verify that:

- Enemies initialize correctly.
- Enemy statistics load from ScriptableObjects.
- Navigation follows valid paths.
- Dynamic path recalculation works correctly.
- Towers can damage enemies.
- Health decreases correctly.
- Death events are triggered.
- Status effect framework functions correctly.
- Combat events are generated correctly.

---

# 8. Definition of Done

Sprint 06 is complete when:

- Enemy lifecycle is operational.
- Navigation is reliable.
- Health system functions correctly.
- Enemy states transition correctly.
- Towers can damage enemies.
- Death handling is stable.
- Documentation is updated.

---

# 9. Dependencies

Required:

- Sprint 05 completed.

Future dependent sprints:

- Sprint 07 — Wave System
- Sprint 08 — Fog of War
- Sprint 09 — UI Framework
- Sprint 11 — Save & Configuration

The Enemy System provides the core runtime entities used throughout gameplay.

---

# 10. Risks

Potential risks include:

- Expensive pathfinding calculations
- Tight coupling between movement and combat
- Frequent path recalculations
- State transition bugs
- Poor scalability with large enemy counts
- Complex status effect interactions

The system should remain modular, event-driven and optimized for large numbers of active enemies.

---

# 11. Exit Criteria

Sprint 06 is complete when:

- Enemies move correctly across the grid.
- Navigation is stable.
- Combat interactions with towers function correctly.
- Enemy health and death handling work reliably.
- The Status Effects framework is ready for future expansion.
- The project is ready for implementation of the Wave System.

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

## Gameplay

- ../Gameplay/Enemies.md
- ../Gameplay/Towers.md
- ../Gameplay/Waves.md

---

## Architecture

- ../Architecture/

---

## Coding Standards

- ../CodingStandard/

---

## Roadmap

- Vision.md
- Roadmap.md
- Milestones.md
