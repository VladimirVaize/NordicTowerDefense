---
Sprint: Sprint 07
Title: Wave System

Status: Planned
Priority: Critical

Roadmap Phase: Phase 2 — Core Gameplay
Milestone: 2.4 Wave System

Estimated Duration: 2–3 Weeks
Actual Duration: TBD

Start Date: TBD
End Date: TBD

Dependencies: Sprint 06
Next Sprint: Sprint 08 — Fog of War
---

# Sprint 07 — Wave System

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

Sprint 07 introduces the Wave System.

The Wave System is responsible for orchestrating enemy attacks by controlling when waves begin, which enemies are spawned and how wave progression is managed throughout the game.

The implementation is intentionally separated into several focused components to ensure scalability, maintainability and flexibility.

Enemy creation remains the responsibility of the Enemy System.

---

# 2. Sprint Objective

Implement a complete and scalable Wave System.

At the end of this sprint the project should support:

- Wave progression
- Wave scheduling
- Spawn groups
- Spawn timing
- Enemy factories
- Multiple spawn points
- Boss waves
- Difficulty scaling
- Victory conditions
- Defeat conditions

The Wave System should coordinate enemy attacks without directly managing enemy behavior.

---

# 3. Deliverables

The sprint is considered complete when the following systems are implemented.

## Wave Management

Support for:

- Wave sequence
- Wave start
- Wave completion
- Wave countdown
- Wave state management

---

## Spawn Management

Support for:

- Multiple spawn points
- Spawn queues
- Spawn groups
- Spawn delays
- Spawn timing

---

## Enemy Factory

Support for:

- Enemy creation
- EnemyData instantiation
- Spawn initialization
- Runtime registration

Enemy lifecycle remains managed by the Enemy System.

---

## Difficulty Scaling

Support for:

- Increasing enemy count
- Health scaling
- Speed scaling
- Damage scaling
- Reward scaling

Scaling values should be configurable through data assets.

---

## Boss Waves

Support for:

- Boss wave identification
- Boss introductions
- Custom wave composition
- Boss completion detection

---

## Win/Loss Conditions

Support for:

Victory:

- All waves completed
- All objectives protected

Defeat:

- Base destroyed
- Objective lost
- Mission failed

---

# 4. Features

## WaveManager

Responsibilities:

- Control wave progression
- Track current wave
- Handle wave transitions
- Notify gameplay systems

---

## WaveSpawner

Responsibilities:

- Schedule enemy spawning
- Manage spawn queues
- Handle spawn timing
- Coordinate spawn points

---

## EnemyFactory

Responsibilities:

- Instantiate enemies
- Initialize enemy instances
- Register enemies with EnemyManager

---

## Difficulty System

Responsibilities:

- Calculate wave scaling
- Apply gameplay modifiers
- Support future difficulty settings

---

## Victory System

Responsibilities:

- Detect mission completion
- Detect mission failure
- Trigger end-of-game events

---

# 5. Technical Tasks

Complete the following work:

- Implement WaveManager
- Implement WaveSpawner
- Implement EnemyFactory
- Create WaveData ScriptableObjects
- Create SpawnGroup definitions
- Implement wave timers
- Implement spawn queues
- Support multiple spawn points
- Implement boss wave logic
- Implement difficulty scaling
- Implement victory conditions
- Implement defeat conditions
- Connect to EnemyManager
- Generate gameplay events

---

# 6. Documentation

Update documentation if implementation affects:

Gameplay:

- Waves.md
- Enemies.md
- Towers.md

Architecture:

- Systems.md
- Managers.md

Coding Standards:

- ScriptableObjects.md
- ArchitecturePatterns.md

---

# 7. Testing

Verify that:

- Waves begin correctly.
- Countdown timers function correctly.
- Enemies spawn according to WaveData.
- Multiple spawn points operate correctly.
- Spawn timing is accurate.
- EnemyFactory creates valid enemies.
- Boss waves trigger correctly.
- Difficulty scaling applies correctly.
- Victory conditions are detected.
- Defeat conditions are detected.
- Gameplay events are generated correctly.

---

# 8. Definition of Done

Sprint 07 is complete when:

- Wave progression is stable.
- Enemy spawning functions correctly.
- Difficulty scaling is operational.
- Boss waves are supported.
- Win and loss conditions work correctly.
- Documentation is updated.

---

# 9. Dependencies

Required:

- Sprint 06 completed.

Future dependent sprints:

- Sprint 08 — Fog of War
- Sprint 09 — UI Framework
- Sprint 10 — Audio System
- Sprint 11 — Save & Configuration
- Sprint 12 — Visual Polish

The Wave System completes the project's core gameplay loop.

---

# 10. Risks

Potential risks include:

- Spawn synchronization issues
- Poor wave balancing
- Excessive enemy counts
- Performance degradation
- Boss scripting complexity
- Tight coupling between Wave and Enemy systems

The Wave System should remain data-driven and independent from enemy behavior.

---

# 11. Exit Criteria

Sprint 07 is complete when:

- Complete gameplay sessions can be played.
- Waves progress correctly.
- Enemy spawning is reliable.
- Victory and defeat conditions are fully operational.
- Boss waves function correctly.
- The project contains a complete playable gameplay loop.

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

- ../Gameplay/Waves.md
- ../Gameplay/Enemies.md
- ../Gameplay/Towers.md

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
