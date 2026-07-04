---
Sprint: Sprint 03
Title: Resource System

Status: Planned
Priority: Critical

Roadmap Phase: Phase 2 — Core Gameplay
Milestone: 2.1 Economy

Estimated Duration: 2–3 Weeks
Actual Duration: TBD

Start Date: TBD
End Date: TBD

Dependencies: Sprint 02
Next Sprint: Sprint 04 — Building System
---

# Sprint 03 — Resource System

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

Sprint 03 introduces the Resource System, which forms the economic foundation of the game.

The system manages resource generation, storage, collection and consumption. It also defines how resources are distributed across the map and how players interact with them.

The implementation should be fully data-driven and designed to support future resource types without significant architectural changes.

---

# 2. Sprint Objective

Implement a flexible and scalable Resource System.

At the end of this sprint the project should support:

- Resource definitions
- Resource nodes
- Resource generation
- Resource collection
- Resource storage
- Resource spending
- Resource depletion

The system should integrate seamlessly with the existing Grid System while remaining independent of buildings and combat mechanics.

---

# 3. Deliverables

The sprint is considered complete when the following systems are implemented.

## Resource Definitions

- ScriptableObject-based resource types
- Resource icons
- Display names
- Descriptions
- Default values

---

## Resource Nodes

- Grid-based placement
- Configurable resource amount
- Configurable depletion behavior
- Visual representation

---

## Resource Collection

- Resource extraction
- Collection rate
- Collection state
- Resource transfer

---

## Resource Storage

Support for:

- Global resource inventory
- Resource limits
- Resource addition
- Resource removal
- Resource validation

---

## Resource Depletion

Support for:

- Finite resource nodes
- Remaining resource tracking
- Empty node state
- Optional regeneration hooks for future content

---

# 4. Features

## ResourceManager

Responsibilities:

- Track all available resources
- Handle resource transactions
- Validate costs
- Broadcast resource events

---

## ResourceNode

Responsibilities:

- Store resource data
- Handle extraction
- Track remaining amount
- Report depletion state

---

## Resource Inventory

Responsibilities:

- Store collected resources
- Handle additions and removals
- Validate available amounts
- Notify dependent systems

---

## Resource Events

Responsibilities:

- Notify UI
- Notify Buildings
- Notify future gameplay systems
- Maintain loose coupling

---

# 5. Technical Tasks

Complete the following work:

- Implement ResourceManager
- Create ResourceData ScriptableObjects
- Implement ResourceNode
- Implement inventory system
- Implement resource transactions
- Implement depletion logic
- Connect nodes to the Grid System
- Create resource event system
- Prepare UI integration hooks
- Test scalability with multiple resource types

---

# 6. Documentation

Update documentation if implementation affects:

Gameplay:

- Resources.md
- Buildings.md

Architecture:

- Systems.md

Coding Standards:

- ScriptableObjects.md
- ArchitecturePatterns.md

---

# 7. Testing

Verify that:

- Resource nodes initialize correctly.
- Resources can be collected.
- Resource inventory updates correctly.
- Spending resources works correctly.
- Resource costs are validated.
- Depleted nodes stop producing resources.
- Multiple resource types are supported.
- Event notifications are triggered correctly.

---

# 8. Definition of Done

Sprint 03 is complete when:

- Resource definitions are data-driven.
- Resource nodes function correctly.
- Inventory management is stable.
- Resource transactions are validated.
- Resource depletion works as expected.
- Documentation is updated.

---

# 9. Dependencies

Required:

- Sprint 02 completed.

Future dependent sprints:

- Sprint 04 — Building System
- Sprint 05 — Tower System
- Sprint 07 — Wave System
- Sprint 09 — UI Framework
- Sprint 11 — Save & Configuration

The Resource System is the foundation of the game's economy.

---

# 10. Risks

Potential risks include:

- Hardcoded resource types
- Tight coupling with buildings
- Poor scalability
- Invalid resource synchronization
- Inconsistent inventory state

The Resource System should remain generic, modular and data-driven.

---

# 11. Exit Criteria

Sprint 03 is complete when:

- Resource nodes function correctly.
- Resources can be collected and spent.
- Inventory management is stable.
- Resource depletion is operational.
- Event notifications are functioning.
- The project is ready for implementation of the Building System.

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

- ../Gameplay/Resources.md
- ../Gameplay/Buildings.md

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
