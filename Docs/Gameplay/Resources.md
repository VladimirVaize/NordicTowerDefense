# Resources

**Project:** Hrafnar Tower Defense

**Document Version:** 2.0

---

# Table of Contents

1. Overview
2. Design Goals
3. Core Economy Principles
4. Gameplay Loop
5. Resource Categories
6. Resource Nodes
7. Resource Density
8. Resource Depletion
9. Resource Buildings
10. Production Efficiency
11. Resource Storage
12. Resource Consumption
13. Economy Balance
14. Gameplay Integration
15. ScriptableObjects
16. Future Expansion
17. Related Documentation

---

# 1. Overview

The resource system is the foundation of the game's economy.

Unlike traditional Tower Defense games, resources are **not generated automatically** and are **not awarded solely after each wave**.

Players must actively:

- Explore the world
- Discover resource deposits
- Expand their territory
- Build production infrastructure
- Protect economic buildings
- Manage limited natural resources

The economy is designed to create meaningful strategic decisions throughout the entire game.

---

# 2. Design Goals

The economy should encourage:

- Exploration
- Expansion
- Strategic planning
- Risk versus reward
- Long-term development
- Continuous decision making

Players should constantly decide between investing in:

- Economy
- Defense
- Upgrades
- Expansion

There should never be a single optimal strategy.

---

# 3. Core Economy Principles

The economy is built upon four fundamental principles.

## Exploration

New resources can only be obtained by revealing unexplored areas of the map.

Fog of War limits access to valuable resource deposits.

---

## Expansion

Players must continuously expand their territory to secure additional resources.

Expanding increases income but also creates new areas that require protection.

---

## Production

Resources are generated only by dedicated production buildings.

Natural resource nodes do not provide resources by themselves.

---

## Depletion

Every natural resource deposit contains a finite amount of resources.

Eventually every deposit becomes exhausted.

Players must continuously search for new deposits to maintain economic growth.

This prevents infinite passive income and encourages constant expansion.

---

# 4. Gameplay Loop

The intended economic loop is:

```text
Reveal New Territory
          │
          ▼
Discover Resource Deposits
          │
          ▼
Build Production Buildings
          │
          ▼
Generate Resources
          │
          ▼
Expand Base
          │
          ▼
Improve Defenses
          │
          ▼
Survive Enemy Waves
          │
          ▼
Resource Deposits Become Depleted
          │
          ▼
Explore New Territory
          │
          └─────────────┐
                        ▼
                    Repeat
```

This gameplay loop remains active throughout the entire match.

---

# 5. Resource Categories

Resources are divided into three categories.

## Primary Resources

Basic construction materials used throughout the game.

Examples:

- Wood
- Stone
- Iron

Characteristics:

- Common
- Easy to gather
- Required for most buildings

---

## Strategic Resources

Advanced materials required for powerful structures.

Examples:

- Coal
- Steel
- Crystal

Characteristics:

- Less common
- More difficult to obtain
- Used for advanced technologies and towers

---

## Special Resources

Rare resources used for unique content.

Examples:

- Ancient Core
- Rune Stone
- Artifact
- Magic Essence

Characteristics:

- Extremely limited
- Often guarded by powerful enemies
- Used only for end-game buildings or unique upgrades

---

# 6. Resource Nodes

Natural resources appear as physical objects on the map.

Examples:

- Forest
- Stone Deposit
- Iron Vein
- Crystal Deposit

Nodes are generated randomly during map creation.

Each node has:

- Resource Type
- Resource Capacity
- Extraction Radius
- Extraction Speed
- Density Level

---

# 7. Resource Density

Not all resource nodes are equally valuable.

Example forest sizes:

| Density | Approximate Capacity |
|----------|---------------------:|
| Sparse Forest | 1,000 Wood |
| Normal Forest | 2,500 Wood |
| Dense Forest | 4,500 Wood |

Example iron deposits:

| Density | Approximate Capacity |
|----------|---------------------:|
| Small Vein | 900 Iron |
| Medium Vein | 1,800 Iron |
| Rich Vein | 3,500 Iron |

This encourages exploration in search of better resource deposits.

---

# 8. Resource Depletion

Every resource node has a limited reserve.

Examples:

- Forests are gradually harvested.
- Stone deposits are mined.
- Iron veins become exhausted.
- Crystal deposits eventually disappear.

When a resource node reaches zero capacity:

- Production immediately stops.
- The production building becomes inactive.
- The player must locate a new deposit.

Resource depletion is a core gameplay mechanic.

It ensures that economic expansion remains important throughout the game.

---

# 9. Resource Buildings

Resources are extracted only by specialized production buildings.

Examples:

| Building | Produces |
|----------|----------|
| Lumber Camp | Wood |
| Quarry | Stone |
| Mine | Iron |
| Crystal Extractor | Crystal |

Production buildings must be placed within extraction range of the appropriate resource node.

---

# 10. Production Efficiency

Production depends on the surrounding environment.

Example:

A Lumber Camp produces wood based on the number of trees within its harvesting radius.

Example:

| Trees Nearby | Efficiency |
|-------------:|-----------:|
| 10 | 100% |
| 8 | 80% |
| 5 | 50% |
| 2 | 20% |

As nearby resources are depleted, production efficiency gradually decreases.

Players may decide to:

- Continue harvesting at reduced efficiency.
- Relocate production.
- Expand into new territory.

This creates meaningful strategic decisions.

---

# 11. Resource Storage

Resources are stored globally.

Collected resources are immediately available throughout the player's territory.

Future mechanics may introduce:

- Warehouses
- Storage limits
- Logistics
- Transportation
- Supply chains

---

# 12. Resource Consumption

Resources are required for:

- Building construction
- Repairs
- Upgrades
- Tower construction
- Advanced technologies
- Special abilities

Every economic decision should involve opportunity cost.

Investing heavily in expansion delays defensive growth.

Investing only in defense limits future development.

---

# 13. Economy Balance

The economy is designed around meaningful choices.

Players should constantly balance:

- Expansion
- Defense
- Production
- Technology

There should always be multiple viable strategies.

Economic snowballing should be minimized through:

- Resource depletion
- Limited deposits
- Increasing construction costs
- Stronger enemy waves

---

# 14. Gameplay Integration

The resource system interacts with nearly every gameplay mechanic.

| System | Interaction |
|---------|-------------|
| Grid | Building placement |
| Buildings | Resource production |
| Towers | Protection of production sites |
| Waves | Enemy rewards and pressure |
| Fog of War | Unlocks new deposits |
| Construction | Resource costs |
| Repairs | Resource costs |
| Upgrades | Resource costs |
| Save System | Stores economy state |
| UI | Displays resource information |

---

# 15. ScriptableObjects

## Gameplay Data

- ResourceData
- ResourceNodeData
- ProductionBuildingData

## System Configuration

- EconomyConfig
- ResourceGenerationConfig

Possible runtime classes:

- ResourceManager
- ResourceSystem
- ResourceNode
- ProductionBuilding

---

# 16. Future Expansion

Possible future mechanics:

- Warehouses
- Worker units
- Resource transportation
- Logistics
- Trading
- Dynamic economy
- Seasonal production
- Resource processing
- Resource quality
- Merchant caravans
- Ancient ruins
- Random world events

---

# 17. Related Documentation

Gameplay

- Buildings.md
- Towers.md
- Waves.md
- FogOfWar.md

Architecture

- ../Architecture/

Coding Standards

- ScriptableObjects.md
- ArchitecturePatterns.md
