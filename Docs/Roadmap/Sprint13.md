---
Sprint: Sprint 13
Title: Game Balance

Status: Planned
Priority: High

Roadmap Phase: Phase 4 — Visual Polish & Optimization
Milestone: 5.3 Gameplay Tuning

Estimated Duration: 2–4 Weeks
Actual Duration: TBD

Start Date: TBD
End Date: TBD

Dependencies: Sprint 12
Next Sprint: Sprint 14 — Optimization
---

# Sprint 13 — Game Balance

---

# Table of Contents

1. Overview
2. Sprint Objective
3. Deliverables
4. Balance Systems
5. Technical Tasks
6. Balance Methodology
7. Testing
8. Definition of Done
9. Dependencies
10. Risks
11. Exit Criteria
12. Sprint Summary
13. Related Documentation

---

# 1. Overview

Sprint 13 focuses on Game Balance.

This sprint is dedicated to tuning all gameplay systems to ensure fair, engaging and progressively challenging gameplay.

No new systems are introduced. Instead, existing systems are adjusted, iterated and refined based on gameplay testing and design goals.

---

# 2. Sprint Objective

Establish a balanced and enjoyable gameplay experience.

At the end of this sprint the project should support:

- Balanced economy progression
- Fair difficulty scaling
- Meaningful tower choices
- Clear risk/reward loops
- Smooth difficulty curve across waves
- Playable vertical slice quality experience

---

# 3. Deliverables

The sprint is considered complete when the following systems are balanced.

## Economy Balance

Support for:

- Resource income rates
- Building costs
- Upgrade costs
- Resource scarcity tuning
- Early / mid / late game pacing

---

## Combat Balance

Support for:

- Tower damage tuning
- Attack speed balancing
- Enemy health scaling
- Enemy speed tuning
- Damage progression curves

---

## Wave Balance

Support for:

- Wave difficulty progression
- Enemy composition tuning
- Spawn timing balance
- Boss wave difficulty spikes
- Recovery time between waves

---

## Building Balance

Support for:

- Building usefulness evaluation
- Cost vs benefit tuning
- Strategic diversity improvements
- Influence radius balancing

---

## Progression Tuning

Support for:

- Early game onboarding curve
- Mid game escalation
- Late game challenge scaling
- Player power progression

---

# 4. Balance Systems

## BalanceData (ScriptableObject)

Responsibilities:

- Store tuning values
- Allow iteration without code changes
- Separate balance from logic

---

## Balance Profiles

Support for:

- Early Game Profile
- Standard Game Profile
- Hard Mode Profile (optional)
- Experimental Profiles

---

## Debug Balance Tools

Support for:

- Runtime parameter adjustment
- Quick iteration testing
- Developer overlays
- Wave skipping tools

---

# 5. Technical Tasks

Complete the following work:

- Create BalanceData ScriptableObjects
- Expose tuning parameters across systems
- Adjust economy curves
- Tune tower stats
- Tune enemy stats
- Balance wave progression
- Adjust building costs
- Implement debug balancing tools
- Create test scenarios for gameplay validation
- Iterate based on playtesting feedback

---

# 6. Balance Methodology

Balancing must follow a structured approach:

## Step 1 — Baseline

- Establish default playable values
- Ensure game is fully completable

## Step 2 — Economy Loop

- Ensure resources flow correctly
- Prevent infinite growth or starvation

## Step 3 — Combat Stability

- Ensure towers can handle expected waves
- Avoid overpowered or useless towers

## Step 4 — Difficulty Curve

- Smooth early game onboarding
- Gradual difficulty increase
- Meaningful late-game challenge

## Step 5 — Iteration

- Continuous playtesting
- Adjust values incrementally
- Avoid large unpredictable changes

---

# 7. Testing

Verify that:

- Early game is not too difficult or too easy.
- Mid game progression feels natural.
- Late game remains challenging.
- Towers have meaningful differences.
- Resources are neither too scarce nor too abundant.
- Waves scale logically in difficulty.
- No single strategy dominates gameplay.
- Game can be completed consistently.

---

# 8. Definition of Done

Sprint 13 is complete when:

- Game is fully playable from start to finish.
- Difficulty curve is smooth and intentional.
- Economy feels stable and rewarding.
- Combat is fair and readable.
- No major balance-breaking strategies exist.
- Game is ready for optimization phase.

---

# 9. Dependencies

Required:

- Sprint 12 completed.

Future dependent sprints:

- Sprint 14 — Optimization
- Sprint 15 — Vertical Slice
- Sprint 16 — Beta Preparation
- Sprint 17 — Release Candidate

Balance is required before performance optimization.

---

# 10. Risks

Potential risks include:

- Overfitting balance to developer playstyle
- Excessive iteration time
- Hidden dominant strategies
- Economy instability
- Difficulty spikes or dead zones
- Lack of player onboarding clarity

Balancing must always be validated with structured playtesting.

---

# 11. Exit Criteria

Sprint 13 is complete when:

- Game is fully balanced end-to-end.
- No extreme difficulty spikes exist.
- Economy is stable and predictable.
- Towers and enemies are properly tuned.
- Game is enjoyable across full session.
- Ready for optimization phase.

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

- ../Gameplay/

## Architecture

- ../Architecture/

## Coding Standards

- ../CodingStandard/

## Roadmap

- Vision.md
- Roadmap.md
- Milestones.md
