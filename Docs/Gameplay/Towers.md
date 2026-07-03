# Towers

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Combat Design Goals
3. Combat Philosophy
4. Gameplay Loop
5. Tower Categories
6. Tower Roles
7. Combat Statistics
8. Attack Behaviors
9. Attack System
10. Target Selection
11. Damage Types
12. Status Effects
13. Upgrade Philosophy
14. Tower Balance
15. Gameplay Integration
16. Gameplay Events
17. ScriptableObjects
18. Runtime Architecture
19. Future Expansion
20. Related Documentation

---

# 1. Overview

Towers are the primary defensive structures used to protect the Castle from incoming enemy waves.

Within the Building System, towers belong to the **Defense Building** category and represent the player's main source of offensive power.

Unlike production or utility buildings, towers are designed specifically for combat.

Their responsibilities include:

- Eliminating enemy units.
- Protecting resource production.
- Defending strategic positions.
- Supporting nearby defenses.
- Applying status effects.
- Controlling enemy movement.

The effectiveness of the player's defense depends not only on the number of towers, but also on their placement, specialization and cooperation.

---

# 2. Combat Design Goals

The Tower System is designed around several core objectives.

---

## Meaningful Choices

Every tower should provide a unique tactical advantage.

Players should choose towers based on:

- Enemy composition.
- Terrain.
- Resource availability.
- Defensive strategy.

There should never be a universally best tower.

---

## Tactical Diversity

Different combat situations should require different tower combinations.

Players are encouraged to combine multiple tower types rather than relying on a single strategy.

---

## Counterplay

Every tower should excel against certain enemy types while being less effective against others.

Likewise, every enemy should have strengths and weaknesses against different tower categories.

---

## Strategic Positioning

Tower placement should matter as much as tower selection.

The player should consider:

- Attack coverage.
- Overlapping ranges.
- Chokepoints.
- Protection of economic buildings.
- Synergy with support structures.

---

## Long-Term Progression

Towers should evolve throughout the match.

Upgrades should introduce new tactical possibilities instead of only increasing numerical values.

---

# 3. Combat Philosophy

The combat system follows several fundamental design principles.

---

## Every Tower Has a Purpose

Each tower must solve a specific combat problem.

Examples:

| Tower | Primary Purpose |
|--------|-----------------|
| Arrow Tower | Eliminate weak enemies |
| Ballista | Destroy armored units |
| Cannon Tower | Area damage |
| Frost Tower | Crowd control |
| Lightning Tower | Chain attacks |
| Fire Tower | Damage over time |

No tower should simply be a stronger version of another.

---

## Specialization Over Generalization

Highly specialized towers create more interesting strategic decisions.

Players should build balanced defenses rather than relying on one tower type.

---

## Synergy Over Power

Strong defenses result from combining complementary towers.

Examples:

- Frost Tower slows enemies for Cannon Towers.
- Ballista eliminates armored enemies while Arrow Towers handle weaker targets.
- Support Towers improve nearby defenses.

The interaction between towers should be more valuable than individual tower strength.

---

## Readability

Players should immediately understand:

- What each tower does.
- Which enemies it is effective against.
- Its attack range.
- Its role within the settlement.

Visual clarity is a core design principle.

---

# 4. Gameplay Loop

The Tower System follows a continuous combat loop.

```text
Enemy Wave Begins
        │
        ▼
Towers Detect Targets
        │
        ▼
Target Selection
        │
        ▼
Attack Execution
        │
        ▼
Damage & Status Effects
        │
        ▼
Enemy Eliminated
        │
        ▼
Prepare for Next Engagement
```

Between waves, the player may:

- Build new towers.
- Upgrade towers.
- Repair damaged towers.
- Relocate towers.
- Sell unnecessary towers.

This creates a clear separation between the Preparation Phase and the Combat Phase.

---

# 5. Tower Categories

Towers are grouped according to their primary battlefield function.

---

## Direct Damage Towers

Designed to eliminate enemies through direct attacks.

Characteristics:

- Reliable damage output.
- High offensive capability.
- Limited utility.

Examples:

- Arrow Tower
- Ballista
- Cannon Tower

---

## Control Towers

Designed to influence enemy movement.

Characteristics:

- Slow enemies.
- Delay enemy advances.
- Improve overall defensive efficiency.

Examples:

- Frost Tower
- Tar Tower
- Gravity Tower

---

## Support Towers

Improve nearby allied buildings.

Characteristics:

- Buff defensive structures.
- Increase efficiency.
- Enhance combat performance.

Examples:

- Banner Tower
- Rune Tower
- Beacon Tower

---

## Hybrid Towers

Combine multiple battlefield roles.

Characteristics:

- Moderate damage.
- Additional support abilities.
- Greater tactical flexibility.

Examples:

- Lightning Tower
- Arcane Tower

Hybrid Towers trade specialization for versatility.

---

# 6. Tower Roles

Every tower should fulfill a clearly defined battlefield role.

Roles determine how a tower contributes to the overall defense.

---

## Anti-Light

Effective against:

- Weak enemies.
- Fast-moving units.
- Large enemy groups.

Primary characteristics:

- High attack speed.
- Moderate damage.

---

## Anti-Armor

Effective against:

- Heavy infantry.
- Armored enemies.
- Elite units.

Primary characteristics:

- High single-target damage.
- Low attack speed.

---

## Area Control

Effective against:

- Dense enemy formations.
- Chokepoints.
- Large waves.

Primary characteristics:

- Splash damage.
- Area denial.
- Crowd management.

---

## Crowd Control

Designed to manipulate enemy movement.

Examples:

- Slow effects.
- Freeze effects.
- Pull effects.
- Knockback.

These towers increase the effectiveness of nearby damage dealers.

---

## Support

Support towers strengthen the player's settlement rather than directly attacking enemies.

Possible effects include:

- Increased attack speed.
- Increased damage.
- Increased range.
- Faster repairs.
- Larger vision radius.

---

## Utility

Utility towers provide indirect strategic benefits.

Examples:

- Scout Tower.
- Alarm Tower.
- Future reconnaissance structures.

These towers expand the player's tactical options instead of increasing damage output.

---

# 7. Combat Statistics

Every tower is defined by a common set of combat statistics.

These values determine how the tower performs during combat.

---

## Core Statistics

| Statistic | Description |
|-----------|-------------|
| Damage | Base damage dealt per attack |
| Attack Speed | Number of attacks per second |
| Attack Range | Maximum targeting distance |
| Critical Chance | Chance to deal critical damage |
| Critical Multiplier | Critical damage modifier |
| Accuracy | Chance to successfully hit the target |

Not every tower uses every statistic.

---

## Advanced Statistics

Additional statistics may include:

- Armor Penetration
- Splash Radius
- Chain Count
- Projectile Speed
- Projectile Lifetime
- Rotation Speed
- Target Limit
- Damage Falloff

These values are primarily used by specialized towers.

---

## Upgrade Scaling

Each statistic may improve independently through upgrades.

Examples:

- Increased Damage
- Larger Attack Range
- Faster Attack Speed
- Improved Critical Chance
- Additional Projectiles

Upgrade scaling should support different tower identities rather than making all towers statistically similar.

---

# 8. Attack Behaviors

Attack Behavior defines **how** a tower attacks.

It is independent from the projectile or damage type.

This allows multiple towers to reuse the same attack logic.

---

## Single Shot

Fires one projectile at a single target.

Examples:

- Arrow Tower
- Ballista

Characteristics:

- Simple
- Reliable
- Efficient

---

## Burst Fire

Fires multiple projectiles in rapid succession.

Examples:

- Repeating Crossbow
- Arcane Tower

Characteristics:

- High burst damage
- Short reload period

---

## Splash Attack

Damages all enemies within an area.

Examples:

- Cannon Tower
- Catapult

Characteristics:

- Area Damage
- Effective against groups

---

## Chain Attack

Damage jumps between nearby enemies.

Examples:

- Lightning Tower

Characteristics:

- Excellent against clustered enemies
- Reduced damage per jump (optional)

---

## Beam Attack

Maintains a continuous beam on the target.

Examples:

- Magic Beam Tower

Characteristics:

- Constant damage
- Immediate hit detection

---

## Cone Attack

Damages every enemy inside a cone-shaped area.

Examples:

- Flamethrower Tower

Characteristics:

- Short range
- Wide coverage

---

## Aura Attack

Continuously affects all enemies inside a radius.

Examples:

- Holy Shrine
- Poison Totem

Characteristics:

- Passive
- Continuous

---

## Rain Attack

Launches projectiles into a target area.

Examples:

- Catapult
- Meteor Tower

Characteristics:

- Delayed impact
- Excellent area denial

---

# 9. Attack System

The Attack System controls how towers engage enemies.

Combat follows several sequential steps.

```text
Enemy enters range
        │
        ▼
Target Selection
        │
        ▼
Attack Cooldown Check
        │
        ▼
Execute Attack Behavior
        │
        ▼
Spawn Projectile (if required)
        │
        ▼
Projectile Hits Target
        │
        ▼
Apply Damage
        │
        ▼
Apply Status Effects
```

Each stage is handled independently, allowing flexible combinations of behaviors.

---

## Projectile System

Projectile defines **what travels toward the target**.

Projectile behavior is independent from attack behavior.

Examples:

| Projectile | Example Tower |
|------------|---------------|
| Arrow | Arrow Tower |
| Bolt | Ballista |
| Cannonball | Cannon Tower |
| Fireball | Fire Tower |
| Magic Orb | Arcane Tower |
| Lightning | Lightning Tower |
| Ice Shard | Frost Tower |
| Energy Beam | Beam Tower |

Projectiles may define:

- Speed
- Lifetime
- Collision Radius
- Visual Effects
- Sound Effects

---

## Instant Attacks

Some attacks do not require physical projectiles.

Examples:

- Lightning
- Beam
- Aura

Damage is applied immediately after attack execution.

---

## Cooldown System

Every tower has an attack cooldown.

The cooldown determines how frequently the tower may attack.

Attack Speed modifies cooldown duration.

Cooldown begins immediately after an attack is executed.

---

# 10. Target Selection

Target selection determines which enemy will be attacked.

Different targeting modes allow players to customize tower behavior.

---

## First

Targets the enemy closest to reaching the Castle.

Recommended for:

- Single-target towers
- High damage towers

---

## Last

Targets the enemy farthest from the Castle.

Useful for:

- Softening new enemy groups
- Long-range towers

---

## Closest

Targets the nearest enemy.

Useful when enemies surround the tower.

---

## Farthest

Targets the enemy farthest within attack range.

Suitable for sniper-type towers.

---

## Strongest

Prioritizes enemies with the highest health.

Recommended for:

- Ballista
- Armor-piercing towers

---

## Weakest

Targets enemies with the lowest remaining health.

Useful for:

- Fast attack towers
- Cleanup roles

---

## Highest Threat (Future)

Targets enemies based on calculated threat value.

Threat calculation may include:

- Remaining Health
- Damage Output
- Special Abilities
- Distance to Castle

---

## Manual Priority (Future)

Players may define preferred enemy categories.

Examples:

- Flying Units
- Armored Units
- Bosses
- Fast Units

This enables advanced defensive strategies.

---

# 11. Damage Types

Damage Type defines **what kind of damage** is dealt when an attack successfully hits a target.

Damage Type is independent from:

- Tower
- Attack Behavior
- Projectile

This modular approach allows different towers to reuse existing combat mechanics.

---

## Physical Damage

The default damage type.

Characteristics:

- Reliable
- No special effects
- Used by most early-game towers

Examples:

- Arrow Tower
- Ballista

---

## Fire Damage

Applies high sustained damage through burning.

Characteristics:

- Damage Over Time
- Effective against large groups
- Reduced effectiveness against fire-resistant enemies

Examples:

- Fire Tower
- Flamethrower Tower

---

## Frost Damage

Focuses on slowing enemies.

Characteristics:

- Reduces movement speed
- Improves crowd control
- Excellent support damage

Examples:

- Frost Tower

---

## Lightning Damage

Highly effective against grouped enemies.

Characteristics:

- Chain attacks
- Instant hit
- Excellent burst damage

Examples:

- Lightning Tower

---

## Poison Damage

Applies damage over time.

Characteristics:

- Long duration
- High efficiency against durable enemies

Examples:

- Poison Tower

---

## Arcane Damage

Magic damage unaffected by physical armor.

Characteristics:

- Ignores armor (design choice)
- Reliable against elite enemies

Examples:

- Arcane Tower

---

## Siege Damage

Specialized against structures and bosses.

Characteristics:

- High single-hit damage
- Slow attack speed

Examples:

- Catapult
- Heavy Ballista

---

# 12. Status Effects

Status Effects apply temporary gameplay modifiers after a successful hit.

Effects should provide tactical value instead of simply increasing damage.

---

## Burn

Gradually damages enemies over time.

Typical effects:

- Damage Over Time
- Visual fire effect

---

## Slow

Reduces enemy movement speed.

Typical effects:

- Lower movement speed
- Improved crowd control

---

## Freeze

Temporarily immobilizes enemies.

Characteristics:

- Complete movement stop
- Short duration

Future balancing should prevent permanent freezing.

---

## Poison

Applies continuous damage over time.

Unlike Burn, Poison generally lasts longer but deals lower damage per second.

---

## Shock

Applies electrical disruption.

Possible future effects:

- Reduced movement speed
- Increased damage received
- Temporary attack interruption

---

## Armor Break

Reduces enemy armor.

Characteristics:

- Benefits nearby physical towers
- Encourages tower combinations

---

## Vulnerability

Increases all incoming damage.

Useful for:

- Support towers
- Boss encounters

---

## Stun

Temporarily disables enemy movement and actions.

Should remain a rare effect due to its high combat impact.

---

## Status Stacking

Status effects follow predefined stacking rules.

Possible rules:

- Refresh Duration
- Replace Existing Effect
- Limited Stack Count
- Independent Stacks

Stacking behavior is configured individually for each effect.

---

# 13. Upgrade Philosophy

Tower upgrades should introduce new gameplay possibilities rather than only improving statistics.

---

## Horizontal Progression

Upgrades unlock:

- New attack behaviors
- New status effects
- New targeting modes
- Increased tactical flexibility

Example:

Arrow Tower

Tier 1

Single Arrow

↓

Tier 2

Double Shot

↓

Tier 3

Piercing Arrow

↓

Tier 4

Explosive Arrow

---

## Vertical Progression

Traditional statistical improvements.

Examples:

- Increased Damage
- Increased Range
- Increased Attack Speed
- Increased Health

Vertical progression should complement, not replace, horizontal progression.

---

## Identity Preservation

A tower should remain recognizable after upgrades.

Players should immediately understand:

- Original purpose
- Combat role
- Strengths
- Weaknesses

Upgrades expand a tower's capabilities without changing its identity.

---

# 14. Tower Balance

Tower balance is based on strategic diversity rather than equal damage output.

Different towers should excel under different conditions.

---

## Strengths and Weaknesses

Every tower should have:

- Preferred targets
- Poor matchups
- Tactical advantages
- Tactical limitations

There should never be a universally optimal tower.

---

## Cost Efficiency

More expensive towers should provide:

- Greater specialization
- Higher flexibility
- Unique mechanics

Higher cost should not simply equal higher damage.

---

## Synergy

The strongest defenses result from combining multiple tower types.

Examples:

- Frost Tower slows enemies for Cannon Towers.
- Armor Break increases Ballista effectiveness.
- Support Towers improve nearby defenses.

Synergy should always outperform individual tower strength.

---

## Counterplay

Enemy design should encourage varied tower compositions.

Examples:

| Enemy Type | Recommended Counter |
|------------|--------------------|
| Fast Units | Frost Tower |
| Armored Units | Ballista |
| Large Groups | Cannon Tower |
| Elite Units | Arcane Tower |
| Flying Units | Anti-Air Tower (Future) |

Counterplay encourages strategic adaptation.

---

## Design Guidelines

Every new tower should satisfy the following principles:

- Unique battlefield role.
- Distinct combat identity.
- Meaningful strengths.
- Meaningful weaknesses.
- Clear visual readability.
- Interesting upgrade path.
- Compatibility with existing systems.

New towers should expand gameplay instead of replacing existing ones.

---

# 15. Gameplay Integration

The Tower System is one of the core gameplay systems and is tightly integrated with the rest of the game.

Although towers belong to the Building System, they also interact with multiple independent gameplay modules.

---

## System Interactions

| Gameplay System | Interaction |
|-----------------|-------------|
| Building System | Towers are constructed, upgraded and managed as buildings |
| Grid System | Determines valid tower placement |
| Resource System | Resources are required for construction and upgrades |
| Wave System | Towers defend against incoming enemy waves |
| Enemy System | Towers detect, target and attack enemies |
| Fog of War | Towers protect newly explored territory |
| Save System | Stores tower progression and upgrades |
| UI System | Displays tower information and player actions |
| Audio System | Plays attack and upgrade sounds |
| VFX System | Displays projectiles, explosions and combat effects |

The Tower System should communicate with other systems through gameplay events whenever possible.

---

# 16. Gameplay Events

The Tower System generates events that allow other gameplay systems to react without creating direct dependencies.

Examples include:

- TowerPlaced
- TowerConstructed
- TowerSelected
- TowerUpgraded
- TowerRepaired
- TowerSold
- TowerDestroyed

Combat events include:

- TargetDetected
- TargetLost
- AttackStarted
- AttackCancelled
- ProjectileSpawned
- ProjectileHit
- DamageApplied
- CriticalHit
- StatusEffectApplied
- EnemyKilled

These events support an Event-Driven Architecture and improve system modularity.

---

# 17. ScriptableObjects

The Tower System follows the project's Data-Driven Design philosophy.

Most tower behaviour should be configurable through ScriptableObjects.

---

## Gameplay Data

Gameplay Data defines the properties of individual towers.

Examples:

- TowerData
- TowerTierData
- AttackBehaviorData
- ProjectileData
- DamageTypeData
- StatusEffectData

TowerData should define:

- Name
- Description
- Tower Category
- Tower Role
- Construction Cost
- Upgrade Costs
- Base Statistics
- Available Attack Behavior
- Available Projectile
- Damage Type
- Status Effects
- Icons
- Prefabs

---

## Configuration Assets

Configuration assets define global combat rules.

Examples:

- CombatConfig
- UpgradeConfig
- DamageConfig
- TargetingConfig

Configuration Assets should contain:

- Global damage multipliers
- Critical hit settings
- Upgrade balancing
- Target selection defaults
- Combat tuning values

---

# 18. Runtime Architecture

The Tower System consists of multiple independent runtime systems.

```text
Tower Manager
        │
        ├── Target Selection System
        ├── Attack System
        ├── Attack Behavior System
        ├── Projectile System
        ├── Collision System
        ├── Damage System
        ├── Status Effect System
        ├── Combat Event Dispatcher
        └── Tower Registry
```

Each subsystem has a single responsibility.

Whenever possible, systems communicate through gameplay events rather than direct object references.

This architecture improves:

- Maintainability
- Extensibility
- Testability
- Scalability
- Reusability

---

## Combat Pipeline

The runtime combat flow follows a predictable sequence.

```text
Enemy Enters Range
        │
        ▼
Target Selection
        │
        ▼
Attack System
        │
        ▼
Attack Behavior
        │
        ▼
Projectile Spawn
        │
        ▼
Collision Detection
        │
        ▼
Damage Calculation
        │
        ▼
Status Effects
        │
        ▼
Death Check
        │
        ▼
Enemy Defeated
        │
        ▼
Rewards Granted
```

Every stage of the combat pipeline should remain independent to maximize modularity.

---

# 19. Future Expansion

The Tower System has been designed for long-term scalability.

Possible future additions include:

- Anti-Air Towers
- Hero Towers
- Summoning Towers
- Trap Towers
- Rotating Towers
- Multi-Barrel Towers
- Charged Attacks
- Alternate Fire Modes
- Tower Experience
- Tower Mastery
- Branching Upgrade Paths
- Tower Specializations
- Unique Legendary Towers
- Seasonal Tower Modifiers
- Temporary Combat Buffs
- Dynamic Combat Events

Future features should integrate with the existing architecture without requiring major redesign.

---

# 20. Related Documentation

Gameplay

- Buildings.md
- Resources.md
- Enemies.md
- Waves.md
- FogOfWar.md

Architecture

- ../Architecture/

Coding Standards

- ArchitecturePatterns.md
- ScriptableObjects.md
- FolderStructure.md
