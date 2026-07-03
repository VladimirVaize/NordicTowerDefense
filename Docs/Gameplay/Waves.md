# Waves

**Project:** Hrafnar Tower Defense  
**Document Version:** 5.0  

---

# Table of Contents

1. Overview  
2. Wave Philosophy  
3. Design Goals  
4. Gameplay Loop  
5. Wave Structure  
6. High-Level System Model  
7. Threat Budget System  
8. Enemy Composition System  
9. Wave Templates  
10. Scaling System  
11. Spawn Pattern System  
12. Wave Modifiers  
13. Adaptive Difficulty System  
14. Special Wave Events  
15. Boss Waves  
16. Wave State Machine  
17. Runtime Architecture  
18. Event System  
19. ScriptableObjects Architecture  
20. Integration with Other Systems  
21. Wave State Machine (Runtime Phases)  
22. Runtime Systems Breakdown  
23. Event System (Runtime Details)  
24. ScriptableObjects (Wave Data Model)  
25. Integration with Enemies System  
26. Integration with Towers System  
27. Integration with Resources System  
28. Integration with Fog of War System  
29. Design Guidelines  
30. Edge Cases  
31. Performance Considerations  
32. Debugging & Development Tools  
33. Final System Architecture Summary  
34. Integration Summary  
35. System Philosophy Final Statement  
36. Related Documentation  

---

# 1. Overview

The Wave System is the core pacing and orchestration layer of the game.

It controls when enemies appear, how they are composed, and how difficulty evolves over time.

Unlike traditional Tower Defense systems that rely on static predefined enemy lists, this game uses a **dynamic threat orchestration model**.

Waves are not scripts of enemies.

Waves are **rule-based systems that generate encounters**.

They define:

- When combat starts
- What enemies appear
- How encounters are structured
- How difficulty evolves

---

# 2. Wave Philosophy

The Wave System is designed as a **combat director system**.

It does not spawn enemies directly in fixed sequences.

Instead, it defines:

- Constraints
- Rules
- Budgets
- Modifiers

and lets the system generate encounters dynamically.

---

## Static vs Dynamic Design

❌ Static Approach:

```text
Wave 1: 10 Runners  
Wave 2: 15 Runners  
Wave 3: 10 Runners + 2 Tanks  
```

✔ Dynamic Approach:

```text
Wave 3:
- Threat Budget: 100
- Rules: Include at least 1 Tank
- Pattern: Mixed Pressure
```

This approach allows:

- Replayability
- Easier balancing
- Emergent gameplay
- Scalable content creation

---

## Player Experience Philosophy

Waves should feel:

> Predictable in structure, but variable in execution.

The player should understand how the system works, but still be forced to adapt each wave.

---

# 3. Design Goals

The Wave System follows these core goals:

---

## Controlled Progression

Difficulty increases in a structured curve:

- Early game: learning mechanics
- Mid game: combining systems
- Late game: mastery and pressure

---

## Tactical Adaptation

Waves must force players to adapt:

- Change tower composition
- Adjust defensive positioning
- React to enemy combinations

---

## Systemic Variety

No two waves should feel identical.

Variety is achieved through:

- Enemy composition changes
- Threat budget variation
- Spawn patterns
- Wave modifiers

---

## Fair Challenge

Difficulty must come from:

- System interaction
- Not randomness

Players should always understand why a wave is difficult.

---

# 4. Gameplay Loop

The Wave System follows a repeating cycle:

```text
Preparation Phase
      │
      ▼
Wave Countdown
      │
      ▼
Wave Start
      │
      ▼
Enemy Spawning (based on rules)
      │
      ▼
Combat Phase
      │
      ▼
Wave Completion
      │
      ▼
Reward Phase
```

---

## Preparation Phase

Player actions:

- Build towers
- Upgrade buildings
- Place defenses
- Optimize economy

---

## Combat Phase

System actions:

- Spawn enemies
- Apply modifiers
- Track wave progress

Player actions:

- Prioritize targets
- React to threats
- Manage defenses

---

## Reward Phase

Player receives:

- Resources
- Progression rewards
- Strategic advantage for next wave

---

# 5. Wave Structure

Each wave is defined as a **set of rules rather than fixed enemy lists**.

---

## Core Components

A wave consists of:

- Threat Budget
- Enemy Composition Rules
- Spawn Pattern Definition
- Wave Modifiers
- Optional Events

---

## Example Structure

```text
Wave 10

Threat Budget: 250

Rules:
- At least 20% Support Units
- At least 1 Elite Unit

Modifiers:
- Increased Armor enemies
- Slightly increased movement speed

Pattern:
- Mixed Pressure Formation
```

---

## Key Principle

Waves define **systems of encounter generation**, not fixed compositions.

---

# 6. High-Level System Model

The Wave System is the top-level controller of combat flow.

```text
Wave Manager
        │
        ├── Threat Budget System
        ├── Enemy Composition System
        ├── Spawn Pattern System
        ├── Wave Modifier System
        └── Event Dispatcher
```

---

## Responsibility Separation

- Threat Budget → defines total power of wave  
- Composition → defines enemy roles  
- Spawn System → defines delivery of enemies  
- Modifiers → alter rules dynamically  
- Events → synchronize gameplay systems  

---

# 7. Threat Budget System

The Threat Budget System replaces fixed enemy counts.

Each enemy has a Threat Value.

Example:

| Enemy | Threat |
|------|--------|
| Runner | 5 |
| Tank | 15 |
| Swarm | 2 |
| Healer | 20 |
| Elite | 30 |

---

## Wave Construction

Instead of fixed lists:

```text
Budget: 100
```

System generates combinations that fit within budget constraints.

---

## Benefits

- Flexible balancing
- Scalable difficulty
- Infinite variation
- Easier content creation

---

# 8. Enemy Composition System

Waves define required **roles**, not just enemies.

---

## Enemy Roles

- Frontline Units
- Pressure Units
- Support Units
- Elite Units
- Special Units

---

## Composition Rules Example

```text
Wave 12 Rules:

- At least 30% Frontline Units
- At least 1 Support Unit
- Maximum 2 Elite Units
```

---

## Purpose

Ensures:

- Tactical diversity
- Balanced encounters
- Predictable structure with variation

---

# 9. Spawn Patterns

Spawn Patterns define **how enemies appear in time and space**.

---

## Pattern Types

- Sequential Spawn
- Group Spawn
- Split Lane Spawn
- Surround Spawn
- Delayed Reinforcement Spawn

---

## Gameplay Impact

Spawn patterns control:

- Pressure pacing
- Defensive stress points
- Player reaction timing

---

# 10. Wave Modifiers

Wave Modifiers alter global wave behavior.

---

## Examples

- Increased enemy armor
- Faster movement speed
- Reduced healing effectiveness
- Increased swarm density
- Limited visibility conditions

---

## Purpose

Modifiers create variation without changing core enemy types.

---

# 11. Adaptive Difficulty System

The system can optionally adjust based on player behavior.

---

## Examples

- Overuse of AoE → more spread enemies
- Overuse of single target → swarm waves
- Heavy fire damage → fire resistant enemies

---

## Design Principle

Adaptation must be:

- Subtle
- Non-punitive
- Systemic

---

# 12. Special Wave Events

Special events introduce unique gameplay moments.

Examples:

- Elite invasion waves
- Resource surge waves
- Environmental hazards
- Reinforcement waves

---

# 13. Boss Waves

Boss waves are milestone encounters.

Characteristics:

- High Threat Budget
- Unique mechanics
- Multi-phase behavior
- Special rewards

---

# 12. Threat Budget System

The Threat Budget System is the foundation of wave generation.

It defines the total "power limit" of a wave using a numerical budget.

---

## Core Concept

Each enemy has a Threat Value representing its gameplay impact.

Example:

| Enemy | Threat Value |
|------|-------------|
| Runner | 5 |
| Tank | 15 |
| Swarm Unit | 2 |
| Healer | 20 |
| Elite | 30 |

---

## Wave Construction Principle

Instead of defining fixed enemy counts:

```text
Wave 5:
- 10 Runners
- 2 Tanks
```

We define:

```text
Wave 5:
Threat Budget = 100
```

And the system generates combinations that fit within this budget.

---

## Benefits

- Flexible encounter design
- Easier balancing
- Infinite variation
- Scalable difficulty system

---

## Design Constraints

Threat Budget alone is not enough.

It must always work together with:

- Enemy Composition Rules
- Spawn Patterns
- Wave Modifiers

---

# 13. Enemy Composition System

The Enemy Composition System defines **what roles must appear in a wave**, not just individual enemies.

---

## Role-Based Design

Enemies are grouped into functional roles:

- Frontline Units
- Pressure Units
- Support Units
- Elite Units
- Special Units

---

## Role Distribution Rules

Example:

```text
Wave 12 Rules:

- At least 30% Frontline Units
- At least 1 Support Unit
- Maximum 2 Elite Units
```

---

## Composition vs Budget

- Threat Budget defines **quantity and strength**
- Composition defines **structure and balance**

Both systems must work together.

---

## Design Purpose

This system ensures:

- Tactical diversity
- Predictable difficulty curve
- Balanced combat scenarios

---

# 14. Wave Templates

Wave Templates define high-level archetypes of waves.

---

## Template Types

### Early Waves
- Low complexity
- Basic enemies only
- Focus on learning mechanics

---

### Mixed Waves
- Combination of multiple enemy roles
- Introduces support units
- Core gameplay challenge type

---

### Pressure Waves
- High enemy density
- Fast-paced encounters
- Tests defensive efficiency

---

### Elite Waves
- Increased elite presence
- Higher threat value density
- Strategic positioning required

---

### Boss Waves
- Unique encounters
- Multi-phase enemies
- Special mechanics

---

## Template Purpose

Templates provide structure to procedural generation.

They ensure waves feel **designed, not random**.

---

# 15. Scaling System

The Scaling System controls how difficulty evolves over time.

---

## Scaling Dimensions

Wave difficulty increases through:

### 1. Threat Budget Increase
- Higher total wave power

### 2. Enemy Complexity
- New enemy types introduced

### 3. Composition Complexity
- More advanced role combinations

### 4. Modifier Intensity
- Stronger wave effects

---

## Scaling Philosophy

Difficulty should come from:

- System interaction
- Not raw numbers

---

## Example Progression

```text
Wave 1–3:
- Runners only

Wave 4–6:
- Tanks introduced

Wave 7–10:
- Support units appear

Wave 11–15:
- Elite units introduced

Wave 16+:
- Combined systems + modifiers
```

---

## Key Principle

The player should always learn something new at each stage.

---

# 16. Spawn Pattern System

Spawn Patterns define **how enemies enter the battlefield over time and space**.

---

## Pattern Types

### Sequential Spawn
Enemies spawn one after another.

- Controlled pressure
- Beginner-friendly

---

### Group Spawn
Enemies spawn in clusters.

- Burst pressure
- Requires AoE response

---

### Lane-Based Spawn
Enemies enter from multiple lanes.

- Forces multi-directional defense

---

### Surround Spawn
Enemies appear from multiple sides.

- High pressure encounters

---

### Reinforcement Spawn
Enemies arrive in waves during combat.

- Long-duration pressure scaling

---

## Design Purpose

Spawn patterns define:

- Combat pacing
- Defensive stress points
- Player reaction windows

---

# 17. Wave Modifiers

Wave Modifiers dynamically change global wave rules.

---

## Modifier Examples

- Increased Armor values
- Faster enemy movement
- Reduced healing effectiveness
- Increased swarm density
- Limited vision conditions
- Enhanced elite spawn rate

---

## Modifier Categories

### Offensive Modifiers
Increase enemy pressure:
- Faster enemies
- More damage
- Higher spawn density

---

### Defensive Modifiers
Increase enemy survivability:
- Armor boost
- Healing boost
- Status resistance

---

### Environmental Modifiers
Change battlefield conditions:
- Fog zones
- Reduced visibility
- Hazard areas

---

## Purpose

Modifiers ensure:

- Variation between waves
- Dynamic gameplay shifts
- Prevent repetitive encounters

---

# 18. Adaptive Difficulty System

The system optionally adjusts waves based on player behavior.

---

## Core Idea

The game reacts to dominant player strategies.

---

## Examples

### Overuse of AoE Towers
→ Increase spread-out enemies

---

### Overuse of Single Target Towers
→ Increase swarm enemies

---

### Heavy Fire Damage Usage
→ Introduce Fire Resistant enemies

---

### Overreliance on One Strategy
→ Introduce counter-composition waves

---

## Design Principle

Adaptation must be:

- Subtle
- Non-punitive
- System-driven

---

## Goal

Encourage variety, not punish players.

---

# 19. Special Wave Events

Special Events introduce unique gameplay scenarios.

---

## Event Types

### Elite Invasion
Increased elite enemy presence

---

### Resource Surge Wave
Higher resource rewards

---

### Environmental Hazard Wave
Terrain-based gameplay effects

---

### Reinforcement Wave
Continuous enemy spawning during combat

---

## Purpose

Events create memorable gameplay moments.

---

# 20. Boss Waves

Boss Waves represent major progression milestones.

---

## Characteristics

- High Threat Budget
- Unique mechanics
- Multi-phase encounters
- Special spawn patterns
- Increased reward output

---

## Design Goal

Boss waves should feel like:

> Major gameplay shifts, not just stronger enemies

---

## Example Structure

```text
Boss Wave 20:

Threat Budget: 500

Rules:
- Boss Unit required
- Support units present

Modifiers:
- Reduced player vision
- Increased enemy armor

Pattern:
- Multi-phase spawn system
```

---

# 21. Wave State Machine

The Wave System operates as a state machine that controls the full lifecycle of combat.

---

## Wave States

### Preparation Phase
Player is building and preparing defenses.

- No enemies are spawned
- Player has full control
- Economy and building systems are active

---

### Countdown Phase
Short delay before wave begins.

- UI countdown is active
- Player can still make final adjustments
- Wave rules are locked

---

### Active Wave Phase
Core combat phase.

- Enemies spawn according to rules
- Threat budget is executed
- Modifiers are active
- Combat systems are fully engaged

---

### Completion Phase
Wave is considered complete.

- Remaining enemies are cleaned up or tracked
- Rewards are calculated
- Systems reset for next wave

---

### Reward Phase
Player receives rewards.

- Resources granted
- Progression updates
- UI feedback triggered

---

## State Design Principle

Each state is independent and clearly separated.

No state should overlap responsibilities.

---

# 22. Runtime Architecture

The Wave System is composed of modular runtime systems.

---

## Core Systems

```text
WaveManager
    │
    ├── WaveStateMachine
    ├── ThreatBudgetSystem
    ├── WaveSpawner
    ├── EnemyCompositionSystem
    ├── WaveModifierSystem
    ├── SpawnPatternSystem
    ├── AdaptiveDifficultySystem
    └── WaveEventDispatcher
```

---

## System Responsibilities

### WaveManager
- Controls overall flow
- Switches between states

---

### ThreatBudgetSystem
- Calculates allowed enemy value
- Tracks spent budget

---

### WaveSpawner
- Instantiates enemies
- Applies spawn patterns

---

### EnemyCompositionSystem
- Ensures role distribution rules
- Validates wave composition

---

### WaveModifierSystem
- Applies global modifiers
- Adjusts wave parameters

---

### SpawnPatternSystem
- Controls timing and placement of spawns

---

### AdaptiveDifficultySystem
- Adjusts future waves based on player behavior

---

### WaveEventDispatcher
- Sends events to all systems

---

# 23. Event System

The Wave System communicates through events.

This ensures full decoupling between systems.

---

## Core Events

- OnWaveStarted
- OnWaveEnded
- OnWaveCompleted
- OnWaveFailed

---

## Combat Events

- OnEnemySpawned
- OnEnemyKilled
- OnEliteSpawned
- OnBossSpawned

---

## System Events

- OnBudgetUpdated
- OnModifierApplied
- OnPatternChanged

---

## Event Design Principle

Events must be:

- Lightweight
- Independent
- Reusable
- Non-blocking

---

## Purpose

Events allow:

- UI updates
- Audio triggers
- VFX responses
- Analytics tracking

without coupling systems together.

---

# 24. ScriptableObjects Architecture

The Wave System is fully data-driven using ScriptableObjects.

---

## Core Data Types

### WaveData
Defines a full wave configuration.

Includes:

- Threat Budget
- Composition Rules
- Spawn Patterns
- Modifiers
- Events

---

### EnemySpawnDefinition
Defines enemy spawn rules.

Includes:

- Enemy type
- Spawn timing
- Spawn location rules

---

### WaveModifierData
Defines global wave effects.

Examples:

- Increased speed
- Armor scaling
- Visibility changes

---

### SpawnPatternData
Defines how enemies appear.

Examples:

- Sequential spawn
- Group spawn
- Multi-lane spawn

---

### WaveTemplateData
Defines wave archetypes.

Examples:

- Early Game Wave
- Pressure Wave
- Boss Wave

---

## Design Principle

All wave behavior must be editable without code changes.

---

# 25. Integration with Other Systems

Wave System is the central orchestration layer of gameplay.

---

## Enemies System

- Waves spawn enemies
- Enemies report back via events

---

## Towers System

- Towers react to enemy presence
- Balance depends on wave composition

---

## Resources System

- Rewards are granted after wave completion
- Scaling depends on wave difficulty

---

## Fog of War System

- Wave progression may reveal map areas
- Enemy movement interacts with visibility

---

## UI System

- Displays wave state
- Shows countdowns and threat levels

---

## Audio & VFX Systems

- Triggered via Wave Events
- No direct coupling

---

# 26. Runtime Flow Diagram

```text
WaveManager
    │
    ▼
Enter Preparation Phase
    │
    ▼
Countdown Begins
    │
    ▼
WaveData Loaded
    │
    ▼
Threat Budget Initialized
    │
    ▼
Enemies Spawned (via Spawn System)
    │
    ▼
Combat Loop Active
    │
    ▼
All Enemies Defeated OR Goal Reached
    │
    ▼
Wave Completion Triggered
    │
    ▼
Rewards Distributed
    │
    ▼
Return to Preparation Phase
```

---

# 27. System Stability Rules

To ensure stability:

- No system should directly control another system
- All communication must go through events
- Wave logic must remain data-driven
- Runtime systems must not hardcode enemy behavior

---

# 28. Future Expansion

The Wave System is designed for long-term scalability.

---

## Possible Extensions

- Infinite Wave Mode
- Roguelike Wave Variants
- Dynamic Campaign Generation
- Seasonal Wave Events
- AI-Driven Wave Balancing
- Player-Adaptive Campaigns
- Multiplayer Wave Scaling

---

## Key Principle

No architectural rewrite should be required to add new wave types.

---

# 29. Design Guidelines

The Wave System must follow strict design principles to ensure scalability and clarity.

---

## Clarity Over Complexity

Every wave must be:

- Readable
- Predictable in structure
- Understandable by the player

Even complex waves should feel logically composed.

---

## System-Driven Design

Waves must never rely on:

- Hardcoded enemy lists
- Scripted one-off logic
- Manual balancing per wave

Instead:

- Use budgets
- Use rules
- Use modifiers
- Use patterns

---

## No Hidden Logic

Players should always be able to understand:

- Why a wave is difficult
- What type of enemies are coming
- How to adapt

---

## Consistent Scaling Logic

Difficulty must increase through:

- Composition complexity
- Enemy variety
- System interactions

Not through arbitrary stat inflation.

---

# 30. Edge Cases

The system must handle edge cases gracefully.

---

## Insufficient Threat Budget

If no valid composition fits:

- Relax composition constraints
- Reduce elite requirements
- Prioritize core enemy types

---

## Overfilled Budget

If budget is exceeded:

- Remove lowest priority enemies
- Adjust composition dynamically

---

## No Valid Spawn Pattern

Fallback behavior:

- Default to sequential spawn
- Maintain gameplay flow

---

## Empty Wave Scenario

If a wave resolves to zero enemies:

- Force minimum baseline spawn
- Prevent softlocks

---

# 31. Performance Considerations

The Wave System must be optimized for runtime efficiency.

---

## Object Pooling

All enemies must be:

- Spawned via pooling system
- Reused instead of instantiated

---

## Event Optimization

Events should:

- Avoid heavy payloads
- Avoid per-frame firing
- Be batched when possible

---

## Wave Calculation Timing

Heavy calculations (budgeting, composition) must occur:

- Before wave starts
- Not during active combat

---

## Minimal Runtime Recalculation

During combat:

- No recalculation of composition
- No structural changes to wave rules

---

# 32. Debugging & Development Tools

The system should support debugging and iteration.

---

## Debug Features

- Visualize Threat Budget usage
- Show enemy composition breakdown
- Display active modifiers
- Show spawn pattern timeline

---

## Developer Tools

- Wave preview system
- Simulation mode (no gameplay input)
- Instant wave skip
- Spawn testing tools

---

## Logging System

Must include:

- Wave start logs
- Enemy spawn logs
- Budget consumption logs
- Event tracking logs

---

# 33. Final System Architecture Summary

The Wave System is composed of layered subsystems:

```text
Wave System
    │
    ├── State Machine Layer
    ├── Budget System Layer
    ├── Composition System Layer
    ├── Spawn Pattern Layer
    ├── Modifier Layer
    ├── Adaptive Layer
    ├── Event Layer
    └── Data Layer (ScriptableObjects)
```

---

## Core Principle

Each layer is:

- Independent
- Replaceable
- Testable
- Data-driven

---

# 34. Integration Summary

The Wave System connects to all major gameplay systems:

---

## Enemies

- Spawned through Wave System
- Report events back to system

---

## Towers

- React to wave composition
- Influence balancing indirectly

---

## Resources

- Earned through wave completion
- Scaled by wave difficulty

---

## Buildings

- Affected by wave pressure
- Interact with enemy behavior

---

## Fog of War

- Controlled partially by wave progression
- Affects visibility of threats

---

## UI / UX

- Displays wave state
- Shows countdowns
- Displays threat information

---

# 35. System Philosophy Final Statement

The Wave System is not a script.

It is not a sequence.

It is not a list of enemies.

It is a **dynamic orchestration engine for tactical pressure.**

---

## Final Design Principle

> Waves define the rules of conflict.  
> Enemies execute those rules.  
> Players adapt to the result.

---

# 36. Related Documentation

Gameplay Systems:

- Enemies.md
- Towers.md
- Buildings.md
- Resources.md
- FogOfWar.md

Architecture:

- ../Architecture/
- ArchitecturePatterns.md
- ScriptableObjects.md
- FolderStructure.md

Coding Standards:

- All files in CodingStandard/
