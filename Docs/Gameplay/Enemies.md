# Enemies

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Enemy Design Goals
3. Enemy Philosophy
4. Gameplay Loop
5. Enemy Categories
6. Enemy Roles
7. Enemy Statistics
8. Enemy Traits
9. Enemy Movement
10. Enemy AI
11. Enemy Abilities
12. Damage & Resistances
13. Status Effect Interaction
14. Rewards
15. Death Behaviors
16. Enemy Balance
17. Gameplay Integration
18. Gameplay Events
19. ScriptableObjects
20. Runtime Architecture
21. Future Expansion
22. Related Documentation

---

# 1. Overview

Enemies are the primary challenge faced by the player throughout the game.

Their objective is to travel from the edge of the map to the Castle by following the designated road.

Enemies create constant pressure on the player's settlement and force continuous adaptation of defensive strategies.

Unlike towers, enemies are controlled entirely by the game and operate according to predefined AI behaviors.

The Enemy System is responsible for:

- Moving enemies along paths.
- Challenging the player's defenses.
- Providing strategic variety.
- Rewarding successful defense.
- Driving game progression through increasingly difficult waves.

Enemy design should encourage tactical thinking rather than simply overwhelming the player with larger numbers.

---

# 2. Enemy Design Goals

The Enemy System follows several core design principles.

---

## Strategic Diversity

Different enemies should require different defensive solutions.

The player should continuously adapt tower composition and settlement layout to respond effectively.

---

## Readability

Every enemy should be immediately recognizable.

Players should understand:

- Enemy role.
- Threat level.
- Movement style.
- Special abilities.
- Visual identity.

Combat should remain readable even during large waves.

---

## Meaningful Challenges

Enemies should introduce tactical problems instead of acting only as health pools.

Each new enemy type should encourage players to rethink their defensive strategy.

---

## Progressive Complexity

New mechanics should be introduced gradually.

Early waves teach basic enemy types.

Later waves combine multiple mechanics into increasingly complex encounters.

---

## Counterplay

Every enemy should have identifiable strengths and weaknesses.

Likewise, every tower category should have favorable and unfavorable matchups.

The objective is to encourage strategic planning rather than fixed solutions.

---

# 3. Enemy Philosophy

Enemy design follows several fundamental principles.

---

## Every Enemy Has a Purpose

Every enemy should introduce a unique battlefield challenge.

Examples:

| Enemy | Primary Purpose |
|--------|-----------------|
| Runner | Test reaction speed |
| Tank | Absorb damage |
| Swarm Unit | Overwhelm defenses |
| Support Unit | Strengthen allies |
| Healer | Sustain enemy groups |
| Boss | Test the entire settlement |

No enemy should simply be a stronger version of another.

---

## Decision-Driven Gameplay

Enemies should force players to make meaningful tactical decisions.

Examples include:

- Which enemy to prioritize.
- Which towers to construct.
- Where to strengthen defenses.
- When to invest resources.

The goal is to create interesting choices rather than repetitive combat.

---

## Combined Threats

Enemy waves should consist of multiple complementary enemy types.

Example:

- Fast units pressure reaction speed.
- Tanks absorb damage.
- Support enemies strengthen allies.
- Healers prolong engagements.

Together they create more engaging combat scenarios.

---

## Visual Clarity

Enemy appearance should clearly communicate gameplay behavior.

Players should quickly recognize:

- Dangerous enemies.
- Elite enemies.
- Flying units.
- Bosses.
- Support enemies.

Strong visual readability improves gameplay without requiring additional UI.

---

# 4. Gameplay Loop

The Enemy System follows a predictable gameplay cycle.

```text
Wave Starts
      │
      ▼
Enemies Spawn
      │
      ▼
Follow Assigned Path
      │
      ▼
Use Special Abilities
      │
      ▼
Receive Damage
      │
      ▼
Apply Status Effects
      │
      ▼
Reach Castle or Die
      │
      ▼
Wave Ends
```

Each enemy continuously interacts with multiple gameplay systems throughout its lifecycle.

---

# 5. Enemy Categories

Enemies are grouped according to their primary battlefield function.

---

## Standard Units

Basic enemies encountered throughout the game.

Characteristics:

- Balanced statistics.
- No complex mechanics.
- Introduce core gameplay.

Examples:

- Raider
- Warrior

---

## Elite Units

More dangerous versions of standard enemies.

Characteristics:

- Increased durability.
- Improved abilities.
- Higher rewards.

Elite enemies appear less frequently but require greater attention.

---

## Support Units

Designed to improve nearby allies.

Examples:

- Healer
- Banner Bearer
- Shaman

Support enemies often become high-priority targets.

---

## Special Units

Possess unique mechanics that alter combat.

Examples:

- Summoners.
- Assassins.
- Shield Carriers.
- Explosive Units.

These enemies introduce new tactical situations.

---

## Boss Units

Powerful enemies encountered during major milestones.

Bosses often feature:

- Multiple abilities.
- High durability.
- Unique attack patterns.
- Special encounter mechanics.

Boss battles should feel distinct from regular waves.

---

# 6. Enemy Roles

Every enemy fulfills a clearly defined battlefield role.

---

## Runner

Primary objective:

Reach the Castle as quickly as possible.

Characteristics:

- High movement speed.
- Low Health.
- Minimal defenses.

Counters:

- Fast-firing towers.
- Slow effects.

---

## Tank

Designed to absorb large amounts of damage.

Characteristics:

- High Health.
- Heavy armor.
- Slow movement.

Counters:

- Armor-piercing towers.
- High single-target damage.

---

## Swarm Unit

Appears in large numbers.

Characteristics:

- Very low durability.
- Extremely cheap to spawn.
- Dangerous in groups.

Counters:

- Splash damage.
- Area control towers.

---

## Support

Strengthens nearby allies.

Possible bonuses:

- Increased movement speed.
- Increased armor.
- Increased damage.
- Healing.

Support enemies should rarely fight alone.

---

## Healer

Restores Health to nearby enemies.

Characteristics:

- Low combat ability.
- High tactical importance.

Players should eliminate Healers quickly before focusing on frontline enemies.

---

## Boss

Represents the highest level of battlefield threat.

Bosses combine multiple mechanics and often require coordinated tower compositions to defeat.

Boss encounters should serve as major progression milestones.

---

# 7. Enemy Statistics

Every enemy is defined by a common set of gameplay statistics.

These values determine how the enemy behaves during combat.

---

## Core Statistics

| Statistic | Description |
|------------|-------------|
| Maximum Health | Total durability of the enemy |
| Movement Speed | Travel speed along the path |
| Armor | Reduces incoming physical damage |
| Magic Resistance | Reduces magical damage |
| Reward Value | Resources granted upon death |
| Threat Value | Internal value used for balancing and targeting |

All enemies use the same core statistics, allowing consistent balancing across the game.

---

## Advanced Statistics

Certain enemy types may also define:

- Health Regeneration
- Shield Points
- Armor Penetration
- Status Resistance
- Crowd Control Resistance
- Vision Radius
- Detection Radius
- Ability Cooldown
- Aggro Radius

These values are primarily used by Elite enemies and Bosses.

---

## Scaling

Enemy statistics increase as the game progresses.

Scaling should primarily occur through:

- New enemy mechanics
- Better enemy combinations
- Stronger abilities

Raw statistical increases should play a secondary role.

---

# 8. Enemy Traits

Traits define permanent characteristics of an enemy.

Traits are passive properties and remain active throughout the enemy's lifetime.

An enemy may possess multiple Traits simultaneously.

---

## Ground

Default movement type.

Characteristics:

- Follows the road.
- Affected by all ground obstacles.
- Targeted by all standard towers.

---

## Flying

Ignores ground obstacles and terrain restrictions.

Characteristics:

- Does not follow the standard road.
- Requires Anti-Air capable towers.
- May bypass certain defenses.

---

## Armored

Possesses reinforced protection.

Characteristics:

- Reduced Physical Damage.
- Vulnerable to Armor Penetration.

---

## Mechanical

Represents artificial or constructed enemies.

Possible future interactions:

- Immune to Poison.
- Vulnerable to Lightning.
- Cannot be healed by biological effects.

---

## Undead

Represents supernatural enemies.

Possible characteristics:

- Resistant to Fear effects.
- Vulnerable to Holy damage.
- May resurrect under special conditions.

---

## Resistant

Enemies may possess elemental resistances.

Examples:

- Fire Resistant
- Frost Resistant
- Lightning Resistant
- Poison Resistant

Resistances encourage varied tower compositions.

---

## Boss

Unique high-priority enemy.

Characteristics:

- Multiple combat phases.
- Special abilities.
- Increased durability.
- Unique rewards.

Boss is treated as a Trait rather than a separate enemy type.

---

# 9. Enemy Movement

Movement determines how enemies travel toward the Castle.

Movement behaviour is independent from enemy category.

---

## Ground Movement

Default movement mode.

Characteristics:

- Follows predefined paths.
- Uses navigation waypoints.
- Obeys movement restrictions.

---

## Flying Movement

Moves freely above terrain.

Characteristics:

- Ignores roads.
- Ignores obstacles.
- Direct route toward objectives.

Future balancing may restrict available flight paths.

---

## Burrowing Movement (Future)

Enemy temporarily travels underground.

Characteristics:

- Untargetable while underground.
- Emerges near defensive positions.

---

## Teleport Movement (Future)

Enemy instantly relocates between predefined points.

Characteristics:

- Ignores traditional pathing.
- Creates unpredictable combat situations.

---

## Charge Movement (Future)

Enemy temporarily gains a burst of movement speed.

Often combined with special abilities.

---

# 10. Enemy AI

Enemy AI determines how enemies behave beyond simple path following.

Different AI types create varied combat scenarios.

---

## Standard AI

Default behaviour.

Characteristics:

- Follow the path.
- Ignore nearby towers.
- Prioritize reaching the Castle.

---

## Aggressive AI

Focuses on attacking defensive structures.

Possible targets:

- Towers
- Resource buildings
- Support structures

Aggressive enemies create additional defensive pressure.

---

## Support AI

Attempts to remain near allied units.

Characteristics:

- Maintains formation.
- Uses support abilities.
- Avoids leading the attack.

---

## Defensive AI

Prioritizes personal survival.

Possible behaviours:

- Retreat at low Health.
- Seek nearby allies.
- Wait for reinforcements.

---

## Berserker AI

Highly offensive behaviour.

Characteristics:

- Ignores personal safety.
- Increased aggression.
- May gain bonuses at low Health.

---

## Boss AI

Bosses may combine multiple AI behaviours.

Examples:

- Phase transitions.
- Ability rotations.
- Summoning reinforcements.
- Area attacks.
- Defensive phases.

Boss AI should create unique encounters rather than behaving like stronger standard enemies.

---

## AI Design Principles

Enemy AI should remain predictable enough for strategic planning while still providing engaging gameplay.

Players should learn enemy behaviours through observation rather than randomness.

Random behaviour should enhance replayability without making combat unfair.

---

# 11. Enemy Abilities

Enemy Abilities define active or passive gameplay mechanics that enemies use during combat.

Unlike Traits, Abilities can be triggered, have cooldowns, or be conditional.

An enemy may have multiple Abilities at the same time.

---

## Heal Allies

Restores Health to nearby enemies.

Characteristics:

- Prioritizes strongest allies.
- Increases wave survivability.
- High-priority target for the player.

---

## Shield Allies

Provides temporary damage reduction to nearby enemies.

Characteristics:

- Does not heal.
- Reduces burst effectiveness of towers.
- Encourages focus targeting.

---

## Summon Units

Spawns additional enemies during combat.

Characteristics:

- Can increase wave size dynamically.
- Often used by Support or Boss enemies.
- May have cooldown or limited uses.

---

## Sprint

Temporarily increases movement speed.

Characteristics:

- Used to break defensive lines.
- Often triggered at low Health or timed intervals.

---

## Teleport

Instantly relocates the enemy to a different point.

Characteristics:

- Bypasses defensive chokepoints.
- Creates unpredictable combat situations.
- Usually limited or conditional.

---

## Rage

Increases combat effectiveness under specific conditions.

Possible effects:

- Increased movement speed.
- Increased damage resistance.
- Reduced ability cooldowns.

---

## Regeneration

Gradually restores Health over time.

Characteristics:

- Counters weak sustained damage.
- Requires burst damage or focus fire.

---

## Explode On Death

Triggers an explosion upon death.

Characteristics:

- Area damage around death location.
- Punishes clustered tower placement.
- Common in Swarm or Elite enemies.

---

## Split On Death

Enemy divides into smaller units upon death.

Characteristics:

- Maintains battlefield pressure.
- Requires AoE or sustained damage.
- Increases wave complexity.

---

## Stealth

Temporarily becomes untargetable or harder to detect.

Characteristics:

- Forces detection mechanics.
- May require specialized towers.

---

## Ability Design Principle

Abilities should:

- Create tactical pressure.
- Encourage prioritization decisions.
- Enhance enemy identity.
- Combine with Traits for variation.

Abilities should never feel random or unfair.

---

# 12. Damage & Resistances

Enemies interact with different damage types through resistances.

---

## Damage Interaction Model

Each enemy defines multipliers for different damage types.

Example:

| Damage Type | Effectiveness |
|-------------|--------------|
| Physical | Normal |
| Fire | Reduced |
| Frost | Neutral |
| Lightning | Increased |
| Poison | Reduced |

---

## Armor

Reduces incoming Physical damage.

Characteristics:

- Strong against early-game towers.
- Weak against armor-piercing attacks.

---

## Magic Resistance

Reduces incoming magical damage.

Characteristics:

- Counters Arcane and elemental towers.
- Encourages mixed damage strategies.

---

## Elemental Resistances

Enemies may resist specific elemental damage types:

- Fire Resistant
- Frost Resistant
- Lightning Resistant
- Poison Resistant

These resistances force adaptation in tower composition.

---

## Armor Penetration (Future Extension)

Certain towers or abilities may ignore armor partially or completely.

This ensures armored enemies remain counterable in all stages of the game.

---

# 13. Status Effect Interaction

Enemies interact with Status Effects in different ways depending on their Traits.

---

## Immunity System

Certain Traits grant immunity to specific effects.

Examples:

- Mechanical → Immune to Poison
- Undead → Resistant to Fear or Mind Effects
- Boss → Reduced crowd control duration

---

## Resistance Scaling

Status Effects may have reduced duration or effectiveness.

Examples:

- Slow effectiveness reduced on Elite enemies.
- Stun duration reduced on Boss enemies.

---

## Stack Behavior

Status Effects may behave differently depending on configuration:

- Refresh Duration
- Stack Intensity
- Replace Existing Effect
- Independent Instances

Stacking rules are defined per effect in ScriptableObjects.

---

## Strategic Impact

Status Effects are a core part of combat strategy.

They allow players to:

- Control enemy movement.
- Reduce incoming damage pressure.
- Amplify tower effectiveness.
- Counter specific enemy types.

---

# 14. Rewards

Enemies provide rewards upon defeat.

Rewards are essential for progression and resource flow.

---

## Resource Rewards

Most enemies drop resources when killed.

Reward amount depends on:

- Enemy type.
- Difficulty level.
- Wave progression.
- Special modifiers.

---

## Bonus Rewards

Some enemies may drop additional rewards:

- Rare resources.
- Temporary buffs.
- Special crafting materials (future systems).

---

## Elite Rewards

Elite enemies provide higher-than-average rewards.

They serve as high-risk, high-reward targets.

---

## Boss Rewards

Bosses provide significant progression rewards:

- Large resource bonuses.
- Unlock progression milestones.
- Potential new gameplay systems.

---

# 15. Death Behaviors

Death Behavior defines what happens when an enemy is defeated.

This system adds additional strategic depth beyond simple elimination.

---

## None

Standard death behaviour.

- Enemy disappears.
- Rewards are granted.

---

## Explode

Enemy explodes on death.

Characteristics:

- Deals area damage.
- Punishes clustered defenses.
- Encourages spacing strategies.

---

## Split

Enemy splits into smaller units.

Characteristics:

- Maintains pressure after death.
- Requires AoE or follow-up damage.

---

## Spawn

Enemy spawns additional units upon death.

Characteristics:

- Can escalate wave intensity.
- Often used in elite or boss designs.

---

## Leave Hazard

Enemy leaves a damaging area on death.

Characteristics:

- Persistent battlefield effect.
- Controls space even after death.

---

## Buff Allies

Enemy strengthens nearby allies upon death.

Characteristics:

- Encourages priority targeting.
- Can synergize with support units.

---

## Strategic Importance

Death Behaviors ensure that:

- Killing enemies is not always trivial.
- Positioning matters.
- Target priority becomes meaningful.

---

# 16. Enemy Balance

Enemy balance is based on **behavioral diversity**, not raw stats.

---

## Functional Balance

Each enemy should introduce:

- A unique challenge.
- A clear counter strategy.
- A distinct role in waves.

---

## Wave Composition Balance

Waves should combine:

- Frontline units (Tanks, Swarm)
- Pressure units (Runners)
- Support units (Healers, Buffers)
- Special units (Exploders, Summoners)

This ensures varied gameplay.

---

## Progression Balance

Difficulty increases primarily through:

- New mechanics
- Enemy combinations
- Ability layering

Not only through numerical scaling.

---

## Counterplay Balance

Every enemy must have:

- At least one strong counter strategy.
- At least one weakness.

No enemy should be universally dominant.

---

## Fairness Principle

Difficulty should come from:

- Complexity
- Not randomness

Players should be able to learn and adapt.

---

# 17. Design Guidelines

All enemies must follow core design principles:

- Have a clearly defined role.
- Introduce meaningful gameplay decisions.
- Be visually readable.
- Interact with multiple systems.
- Avoid redundant mechanics.
- Combine meaningfully with other enemies.

Enemies should expand gameplay depth, not inflate difficulty artificially.

---

# 18. Gameplay Integration

The Enemy System is deeply integrated with all major gameplay systems.

Enemies are not isolated entities — they exist as part of a larger Wave-based threat structure.

---

## System Interactions

| System | Interaction |
|--------|-------------|
| Wave System | Spawns and controls enemy groups |
| Tower System | Applies damage and status effects |
| Building System | Enemies can target or bypass structures |
| Resource System | Rewards are granted upon enemy death |
| Grid System | Influences pathing and placement strategies |
| Fog of War | Enemy movement interacts with exploration |
| Save System | Stores wave progression and enemy states |
| UI System | Displays enemy information and threat levels |
| Audio System | Plays combat and death effects |
| VFX System | Handles hit effects and abilities |

The Enemy System should communicate through events rather than direct references.

---

# 19. Gameplay Events

Enemies generate gameplay events that other systems can subscribe to.

These events form the core of the combat feedback loop.

---

## Core Events

- EnemySpawned
- EnemyDetected
- EnemyEnteredRange
- EnemyExitedRange
- EnemyReachedGoal
- EnemyKilled
- EnemyDestroyed

---

## Combat Events

- EnemyDamaged
- EnemyCriticalHitReceived
- EnemyArmorBroken
- EnemyResistedDamage
- StatusEffectApplied
- StatusEffectRemoved

---

## Ability Events

- EnemyAbilityTriggered
- EnemyAbilityInterrupted
- EnemyAbilityCompleted

---

## Strategic Events

- EliteEnemySpawned
- BossEnemySpawned
- WaveThreatIncreased
- WaveThreatDecreased

---

## Event Design Principle

Events should be:

- Lightweight
- Decoupled
- Reusable
- Independent of implementation

This allows systems like UI, VFX, Audio, and Analytics to react without dependency coupling.

---

# 20. ScriptableObjects

The Enemy System is fully data-driven.

Most enemy behavior should be defined through ScriptableObjects.

---

## Gameplay Data

Defines individual enemy types and configurations.

Examples:

- EnemyData
- EnemyTierData
- EnemyAbilityData
- EnemyTraitData
- EnemyMovementData
- EnemyDeathBehaviorData

---

## EnemyData Structure

Each enemy definition may include:

- Name
- Description
- Enemy Role
- Base Statistics
- Movement Type
- AI Type
- Traits
- Abilities
- Resistances
- Death Behavior
- Reward Configuration
- Visual Prefabs

---

## Configuration Assets

Global settings for enemy behavior.

Examples:

- EnemyConfig
- SpawnConfig
- ScalingConfig
- WaveDifficultyConfig
- RewardConfig

These define:

- Global scaling curves
- Spawn limits
- Difficulty modifiers
- Reward multipliers
- AI tuning parameters

---

# 21. Runtime Architecture

The Enemy System is composed of modular runtime subsystems.

```text
Enemy Manager
        │
        ├── Enemy Spawner System
        ├── Movement System
        ├── AI System
        ├── Ability System
        ├── Trait System
        ├── Health System
        ├── Resistance System
        ├── Status Effect System
        ├── Death System
        ├── Reward System
        └── Enemy Event Dispatcher
```

Each system has a single responsibility.

Systems communicate through events instead of direct references whenever possible.

This improves:

- Scalability
- Maintainability
- Testability
- Debugging clarity

---

## Combat Pipeline

Enemy interaction with the combat system follows a strict pipeline:

```text
Enemy Spawned
        │
        ▼
Movement Along Path
        │
        ▼
Tower Detection Range
        │
        ▼
Damage Received
        │
        ▼
Status Effects Applied
        │
        ▼
Ability Trigger Check
        │
        ▼
Death Check
        │
        ▼
Death Behavior Execution
        │
        ▼
Rewards Granted
```

Each step is handled independently to ensure modularity.

---

# 22. Future Expansion

The Enemy System is designed to support long-term evolution of gameplay.

---

## Potential Future Additions

- Flying Bosses
- Multi-Phase Enemies
- Adaptive AI Enemies
- Environmental Interaction Enemies
- Invisible or Phased Units
- Summoner Chains
- Enemy Evolution Systems
- Dynamic Wave Mutation
- Corrupted Zones
- Event-Based Special Enemies
- Seasonal Enemy Variants
- Roguelike Enemy Modifiers

All future systems should integrate without requiring structural redesign.

---

# 23. Wave System Integration (Core Concept)

Enemies do not exist independently — they are spawned through the Wave System.

---

## Threat-Based Wave Design

Instead of fixed enemy counts, waves can be designed using **Threat Value Budgeting**.

Example:

```text
Wave Budget: 100 Threat Points
```

Enemy Cost:

| Enemy | Threat Cost |
|------|------------|
| Runner | 5 |
| Tank | 15 |
| Swarm Unit | 2 |
| Healer | 20 |
| Elite | 30 |
| Boss | 60 |

---

Wave composition becomes dynamic:

- 10 Runners = 50
- 2 Tanks = 30
- 1 Healer = 20
- Total = 100 Threat

---

## Role Distribution System

Waves should maintain balance across roles:

- Frontline Units
- Pressure Units
- Support Units
- Special Units
- Boss Units (rare)

This ensures consistent gameplay variety.

---

## Adaptive Difficulty (Optional Future System)

Wave composition may adjust based on player strategy:

Examples:

- Overuse of Fire Towers → Fire Resistant enemies appear more often.
- Overuse of AoE → More spread-out enemies appear.
- Overreliance on single strategy → Counter units appear.

This system should remain subtle and non-punitive.

---

# 24. Design Guidelines

All enemies must follow these principles:

- Provide a unique gameplay challenge.
- Interact with multiple systems.
- Be readable in real-time combat.
- Have clear counters.
- Fit into wave composition logic.
- Avoid redundant design.
- Support modular composition via Traits and Abilities.

Enemies should enhance gameplay depth rather than increase complexity for its own sake.

---

# 25. Related Documentation

Gameplay

- Buildings.md
- Towers.md
- Resources.md
- Waves.md
- FogOfWar.md

Architecture

- ../Architecture/

Coding Standards

- ArchitecturePatterns.md
- ScriptableObjects.md
- FolderStructure.md
