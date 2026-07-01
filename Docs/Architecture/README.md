# Architecture Documentation

**Project:** Hrafnar Tower Defense

**Document Version:** 1.0

---

# Overview

The **Architecture** documentation defines the technical foundation of the project.

Its purpose is to describe how the game is structured, how systems communicate, how scenes are organized, and how the project is initialized.

Every programmer joining the project should read this documentation before writing any gameplay code.

---

# Purpose

The Architecture documentation establishes a shared understanding of the project's software design.

It defines:

- Project architecture
- Initialization flow
- Scene management
- Global managers
- Core gameplay systems
- Communication between systems

Following these documents helps maintain a clean, scalable, and maintainable codebase.

---

# Who Should Read This

Recommended for:

- Gameplay Programmers
- Technical Designers
- Technical Artists
- Project Leads

Optional for:

- 3D Artists
- UI Artists
- Animators

---

# Documents

## ARCHITECTURE.md

Provides a high-level overview of the project's software architecture.

Includes:

- Architectural philosophy
- Layered project structure
- Core principles
- Design patterns
- System responsibilities
- Dependency rules
- Scalability goals

This document should be read first.

---

## Initialization.md

Defines how the game starts and how all systems are initialized.

Includes:

- Bootstrap process
- Initialization order
- Manager creation
- Scene loading
- Persistent systems
- Dependency initialization
- Startup validation

Read this document before implementing application startup.

---

## Managers.md

Defines every global manager used by the project.

Includes:

- Responsibilities
- Lifecycle
- Dependencies
- Singleton usage
- Communication rules
- Initialization order

This document explains the purpose of each manager and prevents responsibility overlap.

---

## Systems.md

Defines the gameplay systems used throughout the project.

Includes:

- Grid System
- Building System
- Wave System
- Resource System
- Fog of War
- Save System
- Audio System
- UI System
- Camera System
- Other gameplay systems

This document describes how gameplay functionality is divided into independent systems.

---

## SceneFlow.md

Defines how scenes are organized and how transitions occur.

Includes:

- Scene hierarchy
- Bootstrap Scene
- Persistent Scene
- Main Menu
- Gameplay Scene
- Scene loading sequence
- Additive loading
- Transition rules

This document ensures consistent scene management throughout the project.

---

# Recommended Reading Order

New programmers should read the documentation in the following order:

1. ARCHITECTURE.md
2. Initialization.md
3. Managers.md
4. Systems.md
5. SceneFlow.md

Following this order provides a complete understanding of the project's technical architecture before implementation begins.

---

# Architecture Overview

The project follows a layered architecture.

```text
                    Game
                      │
        ┌─────────────┼─────────────┐
        │             │             │
        ▼             ▼             ▼
    Managers      Systems         UI
        │             │             │
        └─────────────┼─────────────┘
                      ▼
              Gameplay Objects
                      │
                      ▼
              ScriptableObjects
                      │
                      ▼
                  Assets/Data
```

Each layer has a clearly defined responsibility and communicates only with the layers it depends on.

---

# Design Principles

The project follows these architectural principles:

- Single Responsibility Principle (SRP)
- Separation of Concerns (SoC)
- Composition over Inheritance
- Data-driven design
- Event-driven communication
- Modular systems
- Reusable components
- Low coupling
- High cohesion

These principles guide every architectural decision in the project.

---

# Related Documentation

Gameplay

- ../Gameplay/

Coding Standards

- ../CodingStandard/

Git Workflow

- ../Git/

Setup

- ../Setup/

Art Guide

- ../ArtGuide/
