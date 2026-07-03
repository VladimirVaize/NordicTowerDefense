# Buildings

**Project:** Hrafnar Tower Defense

**Document Version:** 2.0

---

# Table of Contents

1. Overview
2. Design Goals
3. Building Philosophy
4. Core Design Principles
5. Gameplay Loop
6. Building Categories
7. Building Lifecycle
8. Grid-Based Construction
9. Influence Radius
10. Zone Synergy
11. Construction Rules
12. Building States
13. Building Health
14. Repair System
15. Upgrade System
16. Relocation System
17. Selling Buildings
18. Building Destruction
19. Gameplay Integration
20. Gameplay Events
21. ScriptableObjects
22. Runtime Architecture
23. Design Guidelines
24. Future Expansion
25. Related Documentation

---

# 1. Overview

Buildings are the foundation of the player's kingdom.

Every structure constructed by the player belongs to the Building System and contributes to the overall development of the settlement.

Unlike traditional Tower Defense games where towers are the only interactive structures, Hrafnar treats every player-built object as a building with a specific gameplay purpose.

Buildings are responsible for:

- Defending the Castle
- Producing resources
- Expanding the player's territory
- Revealing the map
- Supporting nearby structures
- Strengthening the economy
- Creating strategic opportunities

A well-designed settlement is the key to surviving increasingly difficult enemy waves.

The Building System is designed to reward thoughtful planning rather than rapid construction.

---

# 2. Design Goals

The Building System is designed around several core objectives.

## Strategic Planning

Every building should represent a meaningful decision.

Players should constantly evaluate:

- Which building to construct.
- Where to place it.
- When to upgrade it.
- Whether to relocate it.
- Whether it is worth repairing.

There should never be one universally optimal solution.

---

## Long-Term Base Development

The player's settlement should evolve continuously throughout the match.

The base should gradually become:

- Larger
- Stronger
- More specialized
- More interconnected

---

## Meaningful Placement

Building placement is one of the primary strategic decisions in the game.

A good location should provide long-term benefits.

Poor placement should create future problems that the player must solve.

---

## Risk versus Reward

The strongest economic opportunities should exist farther away from the Castle.

Expanding into dangerous territory provides access to valuable resources but requires additional protection.

---

## Adaptability

The Building System should allow players to reorganize their settlement between waves.

As the battlefield changes, the settlement should evolve with it.

---

# 3. Building Philosophy

Every building must solve a specific gameplay problem.

Buildings should introduce new tactical or strategic choices instead of simply increasing numerical values.

Each building must have a clearly defined role.

Examples:

| Building | Primary Purpose |
|----------|-----------------|
| Arrow Tower | Defeat lightly armored enemies |
| Ballista | Eliminate heavily armored enemies |
| Cannon Tower | Deal area damage |
| Lumber Camp | Produce Wood |
| Quarry | Produce Stone |
| Mine | Produce Iron |
| Campfire Tower | Reveal Fog of War |
| Repair Station | Restore nearby buildings |
| Beacon | Improve nearby structures |
| Warehouse | Support future logistics |

If two buildings perform the same function, they should provide different strategic advantages rather than being simple upgrades of one another.

Buildings should encourage experimentation and different playstyles.

---

# 4. Core Design Principles

The Building System is built around four fundamental principles.

---

## Grid-Based Construction

Every building occupies one or more cells of the construction grid.

The grid ensures:

- Clear placement rules.
- Readable settlement layouts.
- Predictable building interactions.
- Efficient pathfinding.

Grid placement should always be intuitive.

---

## Zone-Based Gameplay

Buildings influence the surrounding area.

Instead of acting as isolated objects, buildings create functional zones that shape the settlement.

Examples include:

- Attack Radius
- Harvest Radius
- Vision Radius
- Repair Radius
- Support Radius

Planning these zones is just as important as choosing the building itself.

---

## Building Synergy

Buildings should work together.

A well-planned settlement is more effective than a collection of individually strong structures.

Examples:

- Campfire Towers reveal areas for new production buildings.
- Defensive Towers protect production buildings.
- Repair Stations support frontline defenses.
- Beacons improve nearby structures.

Players should naturally create networks of complementary buildings.

---

## Continuous Expansion

The settlement should never be considered "finished."

As nearby resources become depleted and new areas are revealed, the player is encouraged to expand, rebuild and redesign the base.

Construction is a continuous process throughout the match.

---

# 5. Gameplay Loop

The Building System follows a repeating gameplay loop.

```text
Collect Resources
        │
        ▼
Choose Building
        │
        ▼
Select Construction Location
        │
        ▼
Place Building
        │
        ▼
Building Becomes Active
        │
        ▼
Supports Other Buildings
        │
        ▼
Expand Settlement
        │
        ▼
Upgrade / Repair / Relocate
        │
        ▼
Prepare for Next Wave
        │
        ▼
Repeat
```

This loop forms the core of the player's long-term progression.

Each iteration presents new strategic decisions as the settlement grows.

---

# 6. Building Categories

Buildings are divided into several gameplay categories.

Each category fulfills a different role within the settlement.

---

## Defense Buildings

Protect the Castle and nearby structures.

Primary responsibilities:

- Attack enemies.
- Block enemy advances (future feature).
- Provide area denial.
- Apply status effects.

Examples:

- Arrow Tower
- Ballista
- Cannon Tower
- Magic Tower

---

## Production Buildings

Generate resources required for expansion.

Primary responsibilities:

- Harvest natural resources.
- Sustain the economy.
- Encourage territorial expansion.

Examples:

- Lumber Camp
- Quarry
- Mine
- Crystal Extractor

---

## Utility Buildings

Provide indirect support.

Rather than dealing damage, these buildings improve the efficiency of the settlement.

Examples:

- Campfire Tower
- Repair Station
- Beacon
- Warehouse

---

## Special Buildings

Unique structures that define gameplay objectives.

These buildings usually follow unique rules and cannot be freely constructed.

Examples:

- Castle
- Ancient Shrine
- Portal
- World Objective

Special Buildings often trigger unique events or introduce new gameplay mechanics.

---

# 7. Building Lifecycle

Every building progresses through a defined lifecycle.

The lifecycle describes how a building changes from placement to destruction.

```text
Blueprint
      │
      ▼
Under Construction
      │
      ▼
Operational
      │
 ┌────┼─────────────┐
 ▼    ▼             ▼
Damaged Upgrading Disabled
 │      │           │
 └──────┴───────────┘
          │
          ▼
Operational
          │
          ▼
Destroyed
```

Each state has its own gameplay rules, visuals and interactions.

The lifecycle allows buildings to react dynamically to changing gameplay situations.

---

## Blueprint

The player is previewing the building before construction.

Characteristics:

- Does not occupy the grid permanently.
- Does not consume resources.
- Can be freely moved.
- Displays placement validation.

---

## Under Construction

Construction has started.

Characteristics:

- Resources have been consumed.
- Grid cells are reserved.
- Building is inactive.
- Cannot perform its intended function.

Future versions may include construction time.

---

## Operational

The building is fully functional.

Examples:

- Towers attack enemies.
- Production buildings gather resources.
- Utility buildings provide support.
- Special buildings activate their effects.

---

## Damaged

The building has taken damage.

Characteristics:

- Continues operating.
- Reduced health.
- Can be repaired between waves.

---

## Upgrading

The building is currently being improved.

Characteristics:

- Upgrade cost is paid.
- New statistics are applied after completion.
- Upgrade occurs only between waves.

---

## Disabled

The building exists but is temporarily inactive.

Possible reasons:

- Resource deposit depleted.
- No valid target within range.
- Disabled by future enemy abilities.
- Awaiting relocation.

Disabled buildings remain on the map but provide no benefits.

---

## Destroyed

The building has been destroyed.

Characteristics:

- Stops functioning immediately.
- Loses all active effects.
- May be rebuilt or removed.

Destroyed buildings represent permanent consequences during a wave.

---

# 8. Grid-Based Construction

All buildings are placed on a predefined construction grid.

The grid provides:

- Predictable placement
- Clear visual feedback
- Efficient pathfinding
- Consistent gameplay

Players cannot place buildings outside valid grid cells.

---

## Building Footprint

Each building occupies one or more grid cells.

Examples:

| Building | Footprint |
|----------|----------:|
| Arrow Tower | 1×1 |
| Campfire Tower | 1×1 |
| Lumber Camp | 2×2 |
| Quarry | 2×2 |
| Castle | 4×4 |

Larger buildings require more planning and available space.

---

## Placement Validation

A building can only be placed if:

- All required cells are free.
- Terrain is valid.
- The location is visible (not covered by Fog of War).
- Required resources are available.
- The building follows placement restrictions.

Invalid placements should be clearly highlighted in the placement preview.

---

## Placement Preview

Before confirming construction, the player enters placement mode.

The preview should display:

- Building footprint.
- Grid alignment.
- Occupied cells.
- Influence Radius.
- Resource harvesting area (if applicable).
- Valid / Invalid placement feedback.

The player should always understand why a placement is invalid.

---

# 9. Influence Radius

Most buildings affect the surrounding area.

This area is called the Influence Radius.

The Influence Radius defines where a building provides its gameplay effects.

Examples:

| Building | Influence Radius |
|----------|-----------------:|
| Arrow Tower | Attack Range |
| Campfire Tower | Vision Range |
| Lumber Camp | Harvest Radius |
| Quarry | Mining Radius |
| Repair Station | Repair Radius |
| Beacon | Support Radius |

Influence Radius is one of the core gameplay mechanics.

Players should consider both the building's position and the area it affects.

---

## Influence Visualization

Whenever a building is selected, its Influence Radius should be displayed.

Visualization improves:

- Readability
- Planning
- Building placement
- Base optimization

Each building type may use a different visual indicator.

---

# 10. Zone Synergy

Buildings should support one another through overlapping areas of influence.

The goal is to encourage thoughtful settlement planning.

Examples:

- Campfire Tower reveals land for new production buildings.
- Repair Station supports nearby defensive towers.
- Beacon increases the effectiveness of nearby buildings.
- Defensive Towers protect production buildings.

The player is rewarded for creating connected infrastructure rather than isolated structures.

---

## Strategic Placement

Players should think beyond individual buildings.

Questions to consider include:

- Which buildings should be grouped together?
- Which structures should protect valuable production?
- Where should support buildings be placed?
- How can influence areas overlap efficiently?

Good planning results in a stronger and more resilient settlement.

---

## Future Expansion

Zone Synergy can be expanded with additional mechanics.

Examples:

- Production bonuses.
- Faster repairs.
- Increased harvesting efficiency.
- Shared defensive bonuses.
- Building chains.
- Area-based upgrades.

These mechanics should remain optional enhancements rather than mandatory combinations.

---

# 11. Construction Rules

Construction is only available during the preparation phase between enemy waves.

During this phase the player may:

- Construct buildings.
- Upgrade buildings.
- Repair buildings.
- Relocate buildings.
- Sell buildings.

Construction becomes unavailable immediately when a wave begins.

This creates a clear distinction between:

Preparation Phase

and

Combat Phase.

The player must carefully plan before each wave begins.

Construction Rules should remain simple, predictable and easy to understand.

---

# 12. Building Management

Once constructed, buildings become part of the player's settlement and can be managed between enemy waves.

Building Management allows the player to adapt the settlement as the game evolves.

Available management actions include:

- Inspect
- Repair
- Upgrade
- Relocate
- Sell

Not every building supports every action.

For example, the Castle cannot be sold or relocated.

---

## Building Actions

When a building is selected, the player should always have access to a consistent set of actions.

Standard actions:

| Action | Description |
|---------|-------------|
| Inspect | View building information |
| Repair | Restore lost durability |
| Upgrade | Improve the building |
| Relocate | Move to another valid location |
| Sell | Remove the building and receive a partial refund |

Unavailable actions should remain visible but disabled, making it clear that the action exists but is not applicable.

This creates a predictable and intuitive user experience.

---

# 13. Building Health

Every building has a Health value.

Health represents the structural integrity of the building.

If Health reaches zero, the building is destroyed.

---

## Damage Sources

Buildings may receive damage from:

- Enemy attacks
- Boss abilities
- Special enemy units
- Future environmental hazards

Different enemy types may prioritize different building categories.

---

## Durability

Buildings become more durable as they are upgraded.

Higher tiers generally provide:

- Increased Maximum Health
- Greater resistance to destruction
- Improved survivability during large enemy waves

---

# 14. Repair System

Damaged buildings can be repaired between waves.

Repairs restore lost Health without rebuilding the structure.

---

## Repair Cost

Repair cost depends on:

- Missing Health
- Building Tier
- Resource Type
- Global balance configuration

Repairing a heavily damaged structure should usually cost less than constructing a new one.

---

## Repair Rules

Repairing a building:

- Does not reset upgrades.
- Does not change placement.
- Restores operational status if applicable.
- Cannot be performed during enemy waves.

---

## Strategic Decisions

The player must decide whether to:

- Repair an existing building.
- Replace it with a stronger one.
- Sell it and redesign the settlement.

Repairing should always be a meaningful economic decision.

---

# 15. Upgrade System

Most buildings support multiple upgrade levels.

Upgrades improve a building instead of replacing it.

---

## Upgrade Benefits

Possible improvements include:

- Increased Health
- Increased Damage
- Increased Range
- Faster Production
- Larger Influence Radius
- Improved Special Abilities
- Increased Efficiency

Not every building gains the same bonuses.

---

## Upgrade Cost

Every upgrade requires resources.

Higher upgrade levels become progressively more expensive.

This encourages players to balance expansion with improvement.

---

## Upgrade Restrictions

Upgrades:

- Can only occur between waves.
- Require sufficient resources.
- Preserve building placement.
- Preserve building identity.

---

## Upgrade Philosophy

Upgrades should unlock new strategic possibilities, not simply increase statistics.

Examples:

- Tower gains a new attack type.
- Production building unlocks improved extraction.
- Support building gains a larger area of influence.

---

# 16. Relocation System

Buildings may be moved to another valid location between waves.

Relocation allows players to redesign their settlement without rebuilding everything.

---

## Relocation Rules

Relocation:

- Costs resources.
- Requires a valid destination.
- Preserves upgrade level.
- Preserves Health.
- Cannot occur during combat.

---

## Strategic Purpose

Relocation allows players to:

- Adapt to depleted resource deposits.
- Strengthen vulnerable defenses.
- Improve building synergies.
- Expand toward newly explored areas.

---

# 17. Selling Buildings

Players may remove unwanted buildings.

Selling permanently removes the building from the settlement.

---

## Refund

Selling returns a percentage of the original construction cost.

Refund values are defined in configuration assets.

Possible examples:

| Building State | Refund |
|---------------|-------:|
| Full Health | 75% |
| Damaged | 60% |
| Destroyed (future rebuild) | 0% |

Exact values are subject to balancing.

---

## Selling Restrictions

Buildings cannot be sold:

- During enemy waves.
- While upgrading.
- While under construction.

Certain unique buildings cannot be sold at all.

Examples:

- Castle
- Story-related structures

---

# 18. Building Destruction

Buildings are destroyed when their Health reaches zero.

Destroyed buildings immediately stop providing all gameplay effects.

Examples:

- Towers stop attacking.
- Production buildings stop generating resources.
- Support buildings lose their influence.
- Fog-revealing buildings stop revealing terrain.

---

## Consequences

Destroyed buildings may significantly affect the player's settlement.

Examples:

- Loss of resource income.
- Reduced defensive coverage.
- Loss of support bonuses.
- Reduced explored territory.

The player must adapt before the next wave.

---

## Rebuilding

Destroyed buildings may be rebuilt during the preparation phase.

Rebuilding requires:

- Available resources.
- A valid building location.

Future versions may allow rebuilding directly on destroyed foundations.

---

## Design Philosophy

Building destruction should be impactful but not overly punishing.

Losing an important structure should create a meaningful setback while still allowing the player to recover through good planning and efficient resource management.

---

# 19. Gameplay Integration

The Building System is one of the central gameplay systems and interacts with nearly every major feature in the game.

Buildings do not operate in isolation.

Instead, they form the foundation of the player's settlement and continuously exchange information with other systems.

---

## System Interactions

| Gameplay System | Interaction |
|-----------------|-------------|
| Grid System | Building placement and occupied cells |
| Resource System | Construction costs, production and repairs |
| Tower System | Defensive buildings belong to the Building System |
| Fog of War | Campfire Towers reveal new territory |
| Wave System | Enemy attacks and combat restrictions |
| Enemy System | Buildings receive damage and may become targets |
| Save System | Stores building state and progression |
| UI System | Displays information and management actions |

The Building System should remain modular and communicate through events whenever possible.

---

# 20. Gameplay Events

The Building System generates gameplay events that may be used by other systems.

Examples include:

- BuildingPlaced
- BuildingConstructed
- BuildingActivated
- BuildingDamaged
- BuildingRepaired
- BuildingUpgraded
- BuildingRelocated
- BuildingSold
- BuildingDisabled
- BuildingDestroyed

Other gameplay systems should subscribe to these events rather than directly depending on building implementations.

This supports a modular, event-driven architecture.

---

# 21. ScriptableObjects

The Building System follows a Data-Driven Design approach.

---

## Gameplay Data

Stores static building definitions.

Examples:

- BuildingData
- BuildingTierData
- ConstructionCostData

Gameplay Data should define:

- Name
- Description
- Category
- Construction Cost
- Upgrade Costs
- Health
- Influence Radius
- Footprint Size
- Icons
- Visual Prefabs

---

## Configuration Assets

Stores global configuration shared across the entire Building System.

Examples:

- BuildingConfig
- ConstructionConfig
- UpgradeConfig
- RepairConfig

Configuration assets define:

- Refund percentage
- Repair multiplier
- Upgrade balance
- Placement rules
- Global construction settings

---

# 22. Runtime Architecture

At runtime, the Building System is composed of multiple independent systems.

```text
Building Manager
        │
        ├── Building Placement System
        ├── Construction System
        ├── Building Registry
        ├── Building Selection System
        ├── Upgrade System
        ├── Repair System
        ├── Relocation System
        ├── Selling System
        └── Building Event Dispatcher
```

Each runtime system has a single responsibility.

Systems communicate through events rather than direct references whenever practical.

This architecture improves:

- Scalability
- Testability
- Maintainability
- Modularity

---

# 23. Design Guidelines

Every new building introduced into the game should follow the project's design philosophy.

A new building should:

- Solve a unique gameplay problem.
- Introduce meaningful strategic decisions.
- Support the overall settlement.
- Interact with existing systems.
- Have a clearly defined area of influence.
- Fit naturally into one of the existing building categories.

Whenever possible, new buildings should expand gameplay rather than duplicate existing functionality.

Design complexity should grow through new mechanics instead of larger numerical values.

---

# 24. Future Expansion

The Building System has been designed with long-term scalability in mind.

Potential future additions include:

- Worker units
- Logistics and transportation
- Building adjacency bonuses
- Advanced zone synergies
- Seasonal modifiers
- Weather effects
- Building maintenance
- Power distribution
- Building specialization
- Defensive walls and gates
- Multi-stage construction
- World Wonders
- Temporary structures
- Research-dependent buildings

These features should integrate with the existing architecture without requiring major redesign.

---

# 25. Related Documentation

Gameplay

- Resources.md
- Towers.md
- FogOfWar.md
- Enemies.md
- Waves.md

Architecture

- ../Architecture/

Coding Standards

- ArchitecturePatterns.md
- ScriptableObjects.md
- FolderStructure.md
