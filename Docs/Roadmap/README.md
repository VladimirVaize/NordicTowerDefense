# Roadmap Documentation

---

## Overview

This folder contains the complete development roadmap for the project.

It defines how the game evolves from early planning to full release, including:

- Vision and core direction
- Development phases
- Milestones
- Sprint-based execution plan
- Release strategy

This is the **highest-level planning layer** of the entire project.

---

## Purpose

The Roadmap system exists to:

- Provide a structured development path
- Break down production into clear phases
- Ensure predictable progression from prototype to release
- Maintain long-term project clarity
- Prevent feature drift and uncontrolled expansion

---

## Roadmap Structure

The roadmap is divided into several key documents:

### 1. Vision.md

Defines the core idea of the game:

- Game concept
- Core pillars
- Target experience
- Design direction
- Constraints and scope boundaries

This is the **foundation of all decisions**.

---

### 2. Roadmap.md

Defines the full development structure:

- Phase breakdown
- High-level timeline
- System development order
- Feature grouping
- Production flow logic

This is the **macro-level development plan**.

---

### 3. Milestones.md

Defines key production checkpoints:

- Vertical Slice
- Beta readiness
- Release Candidate
- Version 1.0 launch

Each milestone represents a **major quality gate**.

---

### 4. SprintXX.md (Sprint Files)

Each Sprint represents a concrete development unit.

- Sprint00 → Sprint18
- Each Sprint focuses on a specific system or stage
- Sprints follow strict dependency order
- No random feature development outside Sprint structure

Sprints are the **execution layer of the roadmap**.

---

## Development Flow

The project follows this hierarchy:

```text
Vision
  ↓
Roadmap
  ↓
Milestones
  ↓
Sprints (00 → 18)
  ↓
Vertical Slice
  ↓
Beta
  ↓
Release (v1.0)
```

---

## Key Principles

The roadmap is governed by strict rules:

### 1. Phase Discipline

Each phase must be completed before the next begins.

---

### 2. No Feature Drift

All features must belong to a Sprint.

No “off-roadmap” development is allowed.

---

### 3. System Completion First

Systems are built before content or polishing.

---

### 4. Integration over Expansion

Later phases focus on:

- Integration
- Stability
- Optimization
- Polish

not new mechanics.

---

### 5. Release-Driven Development

Every decision must support:

> “Does this improve the final released game?”

---

## Roadmap Phases

The project is structured into 7 major phases:

### Phase 1 — Foundation

- Core architecture
- Basic systems setup

---

### Phase 2 — Core Gameplay

- Towers, enemies, waves
- Resource systems
- Grid system

---

### Phase 3 — Vertical Slice Preparation

- UI system
- Audio system
- Save system
- Fog of war

---

### Phase 4 — Polish & Optimization

- Visual polish
- Game balance
- Performance optimization

---

### Phase 5 — Vertical Slice

- Full game integration
- Playable end-to-end experience

---

### Phase 6 — Beta & Release Preparation

- External testing
- Bug fixing
- UX improvements
- Release candidate

---

### Phase 7 — Release

- Final build
- Version 1.0.0
- Public release

---

## File Usage Guide

- Use **Vision.md** to understand “why the game exists”
- Use **Roadmap.md** to understand “how the game is structured”
- Use **Milestones.md** to understand “what defines progress”
- Use **Sprint files** to understand “what is currently being built”

---

## Related Documentation

### Core Architecture

- ../Architecture/

### Gameplay Systems

- ../Gameplay/

### Coding Standards

- ../CodingStandard/

### Git Workflow

- ../Git/

---

## Final Note

This Roadmap is a **living production system**, not a static document.

It defines:

- Order of development
- System dependencies
- Release structure
- Long-term direction

All development must strictly follow this roadmap unless explicitly re-approved at architecture level.
