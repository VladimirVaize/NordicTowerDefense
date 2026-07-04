---
Sprint: Sprint 05
Title: Tower System

Status: Planned
Priority: Critical

Roadmap Phase: Phase 2 — Core Gameplay
Milestone: 2.3 Combat System

Estimated Duration: 3–4 Weeks
Actual Duration: TBD

Start Date: TBD
End Date: TBD

Dependencies: Sprint 04
Next Sprint: Sprint 06 — Enemy System
---

# Sprint 05 — Tower System

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

Sprint 05 introduces the Tower System.

Towers are the primary defensive structures used to eliminate enemies before they reach the player's settlement.

The system should support multiple tower types, upgrades, targeting strategies and combat statistics while remaining fully data-driven and extensible.

Enemy interaction will be integrated during Sprint 06.

---

# 2. Sprint Objective

Implement a complete Tower System.

At the end of this sprint the project should support:

- Tower placement
- Tower definitions
- Target acquisition
- Attack logic
- Projectile framework
- Tower upgrades
- Range visualization
- Targeting modes

The system should integrate with the Building System and be prepared for Enemy System integration.

---

# 3. Deliverables

The sprint is considered complete when the following systems are implemented.

## Tower Definitions

- ScriptableObject-based tower data
- Categories
- Statistics
- Upgrade information
- Visual prefabs

---

## Tower Placement

Support for:

- Construction using Building System
- Grid placement
- Placement validation
- Placement preview

---

## Target Acquisition

Support for:

- Enemy detection
- Attack range
- Target selection
- Target switching

Enemy implementation will be completed in Sprint 06.

---

## Attack System

Support for:

- Attack cooldown
- Fire rate
- Damage calculation
- Attack timing

---

## Projectile Framework

Support for:

- Projectile spawning
- Projectile movement
- Hit detection
- Future damage effects

---

## Tower Upgrades

Support for:

- Upgrade levels
- Upgrade costs
- Improved statistics
- Upgrade progression

---

## Targeting Modes

Support for configurable targeting strategies:

- First
- Last
- Closest
- Strongest
- Weakest

Additional targeting modes may be introduced in future updates.

---

## Range Visualization

Support for:

- Attack radius display
- Placement preview
- Debug visualization

---

# 4. Features

## TowerManager

Responsibilities:

- Register towers
- Update active towers
- Coordinate tower systems
- Notify dependent systems

---

## TowerController

Responsibilities:

- Attack logic
- Cooldown management
- Target acquisition
- Upgrade handling

---

## Targeting System

Responsibilities:

- Detect valid targets
- Apply targeting rules
- Switch targets when necessary

---

## Projectile System

Responsibilities:

- Spawn projectiles
- Move projectiles
- Detect impacts
- Notify combat events

---

## Upgrade System

Responsibilities:

- Validate upgrades
- Apply stat improvements
- Handle progression

---

# 5. Technical Tasks

Complete the following work:

- Implement TowerManager
- Create TowerData ScriptableObjects
- Implement TowerController
- Implement targeting framework
- Implement attack system
- Implement projectile framework
- Implement upgrade system
- Implement range visualization
- Connect towers to Building System
- Prepare interfaces for Enemy System
- Create combat events

---

# 6. Documentation

Update documentation if implementation affects:

Gameplay:

- Towers.md
- Buildings.md
- Enemies.md

Architecture:

- Systems.md
- Managers.md

Coding Standards:

- ScriptableObjects.md
- ArchitecturePatterns.md

---

# 7. Testing

Verify that:

- Towers can be placed successfully.
- Placement validation works correctly.
- Target acquisition functions correctly.
- Cooldowns are respected.
- Projectiles spawn correctly.
- Projectile movement is stable.
- Upgrade progression works correctly.
- Range visualization is accurate.
- Combat events are generated correctly.

Enemy interaction will be fully tested in Sprint 06.

---

# 8. Definition of Done

Sprint 05 is complete when:

- Tower placement is operational.
- Attack logic functions correctly.
- Projectile framework is complete.
- Upgrade system is operational.
- Targeting strategies work correctly.
- Documentation is updated.

---

# 9. Dependencies

Required:

- Sprint 04 completed.

Future dependent sprints:

- Sprint 06 — Enemy System
- Sprint 07 — Wave System
- Sprint 09 — UI Framework
- Sprint 11 — Save & Configuration

The Tower System becomes the foundation of the game's combat mechanics.

---

# 10. Risks

Potential risks include:

- Tight coupling with Enemy System
- Hardcoded tower behaviors
- Poor targeting performance
- Projectile synchronization issues
- Upgrade balancing difficulties
- Duplicate combat logic

The Tower System should remain modular, event-driven and fully data-driven.

---

# 11. Exit Criteria

Sprint 05 is complete when:

- Towers can be constructed.
- Attack logic is stable.
- Targeting strategies are operational.
- Projectile framework is reusable.
- Upgrade system functions correctly.
- The project is ready for Enemy System integration.

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

- ../Gameplay/Towers.md
- ../Gameplay/Buildings.md
- ../Gameplay/Enemies.md

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
