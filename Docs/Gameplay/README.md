# Gameplay Systems

**Project:** Hrafnar Tower Defense  
**Document Version:** 2.0  

---

# Overview

This folder contains all core gameplay design documentation for the project.

It defines how the game behaves from a player perspective, including:

- Core mechanics
- Enemy behavior
- Building systems
- Economy and resources
- Combat rules
- Map systems

All documents here describe **gameplay logic, not technical implementation**.

---

# Core Gameplay Structure

The gameplay is built around four main layers:

```text
Resources → Economy Layer  
Buildings → World Interaction Layer  
Towers → Combat Defense Layer  
Enemies → Threat Layer  
Waves → Control & Progression Layer  
Fog of War → Information & Exploration Layer
```

These systems interact to form the core gameplay loop.

---

# System Responsibilities

## Resources System
Defines:
- Economy rules
- Resource generation
- Costs for buildings and upgrades

File: `Resources.md`

---

## Buildings System
Defines:
- Player structures
- Construction rules
- Upgrade paths
- Utility buildings (vision, economy, defense)

File: `Buildings.md`

---

## Towers System
Defines:
- Combat defense units
- Attack behavior
- Targeting logic
- Upgrade mechanics

File: `Towers.md`

---

## Enemies System
Defines:
- Enemy types
- AI behavior
- Movement rules
- Combat interactions
- Death mechanics

File: `Enemies.md`

---

## Waves System
Defines:
- Enemy spawn logic
- Difficulty progression
- Threat budget system
- Spawn patterns
- Game pacing

File: `Waves.md`

---

## Fog of War System
Defines:
- Map visibility rules
- Exploration mechanics
- Strategic information control

File: `FogOfWar.md`

---

# Gameplay Design Philosophy

The gameplay is designed as a **system-driven strategy simulation**.

Key principles:

- Systems interact, not scripts
- Difficulty comes from combinations, not raw numbers
- Player decisions affect multiple layers
- Information (Fog of War) is a core strategic resource

---

# System Interaction Model

Gameplay systems are not isolated.

They interact like this:

```text
Waves → spawn Enemies  
Enemies → pressure Buildings & Towers  
Towers → control Enemies  
Buildings → support economy & vision  
Resources → enable expansion  
Fog of War → limits information  
```

---

# Design Goals

- Create readable but deep strategy gameplay
- Ensure every system has counterplay
- Encourage adaptive decision-making
- Support long-term scalability
- Avoid single dominant strategy

---

# Related Documentation

## Architecture
- ../Architecture/

## Coding Standards
- ../CodingStandard/

## Art & Asset Guidelines
- ../ArtGuide/
