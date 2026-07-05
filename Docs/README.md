# Project Documentation

---

## Overview

Welcome to the project documentation.

This documentation serves as the central knowledge base for the entire project and is intended for all team members, including programmers, artists, designers, and future contributors.

The documentation covers every major aspect of development, from project setup and architecture to gameplay systems, coding standards, development workflow, and production planning.

Following these documents ensures a consistent, maintainable, and scalable development process.

---

## Documentation Structure

The documentation is organized into the following sections.

```text
Docs/
│
├── Architecture/
├── ArtGuide/
├── CodingStandard/
├── Gameplay/
├── Git/
├── Roadmap/
└── Setup/
```

Each section focuses on a specific area of the project.

---

# Documentation Overview

## Architecture

Defines the technical foundation of the project.

Includes:

- Project architecture
- Core systems
- Managers
- Event system
- Scene management
- Feature modules
- Folder structure
- Architecture patterns

Recommended for:

- Programmers
- Technical designers

---

## ArtGuide

Defines the visual identity of the project.

Includes:

- Art direction
- Asset guidelines
- Naming conventions
- Materials
- Models
- UI style
- Environment standards

Recommended for:

- 3D Artists
- UI Artists
- Technical Artists

---

## CodingStandard

Defines programming conventions used throughout the project.

Includes:

- C# style guide
- Naming conventions
- Architecture rules
- Script organization
- ScriptableObjects
- Documentation standards
- Folder organization

Recommended for:

- Programmers

---

## Gameplay

Contains the complete Game Design Documentation (GDD).

Includes:

- Resources
- Buildings
- Towers
- Enemies
- Waves
- Fog of War

Recommended for:

- Designers
- Gameplay Programmers
- Level Designers

---

## Git

Defines the project's version control workflow.

Includes:

- Git workflow
- Branch strategy
- Commit rules
- Git LFS
- Collaboration practices

Recommended for:

- All team members

---

## Roadmap

Contains the complete production roadmap.

Includes:

- Vision
- Development roadmap
- Milestones
- Sprint planning
- Release planning

Recommended for:

- Project Leads
- Producers
- All developers

---

## Setup

Provides instructions for preparing a development environment.

Includes:

- Unity installation
- GitHub Desktop installation
- Project setup
- Environment verification

Recommended for:

- New team members
- All developers

---

# Recommended Reading Order

## New Team Members

```text
Setup
    ↓
Git
    ↓
Architecture
    ↓
CodingStandard
    ↓
Gameplay
```

---

## Gameplay Programmers

```text
Architecture
    ↓
CodingStandard
    ↓
Gameplay
    ↓
Roadmap
```

---

## Artists

```text
Setup
    ↓
Git
    ↓
ArtGuide
```

---

## Project Leads

```text
Roadmap
    ↓
Architecture
    ↓
Gameplay
```

---

# Documentation Principles

All documentation follows the same principles:

- English language
- Markdown format
- Version controlled
- Modular structure
- Consistent formatting
- Clear navigation
- Single source of truth

Documentation should evolve together with the project.

Whenever implementation changes, the corresponding documentation must be updated.

---

# Folder Structure

```text
Docs/
│
├── Architecture/
│
├── ArtGuide/
│
├── CodingStandard/
│
├── Gameplay/
│
├── Git/
│
├── Roadmap/
│
└── Setup/
```

Each folder contains its own dedicated `README.md` file describing its contents in detail.

---

# Maintenance Rules

Documentation should be updated whenever:

- New gameplay systems are added.
- Architecture changes.
- Coding standards evolve.
- Git workflow changes.
- Production roadmap changes.
- Setup process changes.

Documentation must always reflect the current state of the project.

---

# Final Notes

This documentation is an integral part of the project.

It is intended to:

- Improve collaboration.
- Reduce onboarding time.
- Increase code quality.
- Standardize development practices.
- Preserve project knowledge.
- Support long-term maintenance.

Every contributor is encouraged to consult the documentation before implementing new features or modifying existing systems.
