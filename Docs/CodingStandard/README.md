# Coding Standards

**Project:** Hrafnar Tower Defense

This directory contains the official coding standards and architectural guidelines used throughout the project.

The purpose of these documents is to ensure that every developer writes code in a consistent style, follows the same architectural principles, and maintains a scalable, maintainable codebase.

All team members should read and follow these documents before contributing to the project.

---

# Documents

## StyleGuide.md

Defines the formatting rules used throughout the project.

Includes:

- File organization
- Code formatting
- Braces and indentation
- Method organization
- Access modifier order
- Inspector organization
- General coding style

---

## Naming.md

Defines naming conventions for every type of object.

Includes:

- Classes
- Interfaces
- Enums
- Methods
- Variables
- Constants
- Events
- ScriptableObjects
- Assets
- Prefabs

---

## BestPractices.md

Describes general programming principles used throughout the project.

Includes:

- SOLID principles
- Single Responsibility
- Separation of Concerns
- Dependency management
- Error handling
- Code readability
- Maintainability

---

## FolderStructure.md

Defines the official project folder structure.

Includes:

- Repository organization
- Unity project structure
- Feature Modules
- Script organization
- ScriptableObject organization
- Folder creation rules
- Growth strategy

---

## Comments.md

Defines how comments should be written.

Includes:

- Comment philosophy
- XML documentation
- TODO, FIXME, HACK, NOTE conventions
- Comment examples
- Code review checklist

---

## Performance.md

Defines performance guidelines for the project.

Includes:

- Profiling
- CPU optimization
- Memory management
- Garbage Collection
- Object Pooling
- Event-driven programming
- Tower Defense specific optimizations

---

## ScriptableObjects.md

Defines how ScriptableObjects are used.

Includes:

- Data-Driven Design
- Gameplay Data (`*Data`)
- System Configuration (`*Config`)
- Runtime data separation
- Validation
- Asset organization

---

## ArchitecturePatterns.md

Defines the architectural patterns used throughout the project.

Includes:

- Feature Modules
- Layered Architecture
- Composition over Inheritance
- Event-Driven Architecture
- Data-Driven Design
- State Machines
- Object Pooling
- Anti-Patterns

---

# Reading Order

For new developers, the recommended reading order is:

1. FolderStructure.md
2. ArchitecturePatterns.md
3. StyleGuide.md
4. Naming.md
5. BestPractices.md
6. ScriptableObjects.md
7. Performance.md
8. Comments.md

This order provides a gradual introduction from the overall project architecture to detailed coding rules.

---

# Core Principles

The project follows these core principles:

- Feature-Based Architecture
- Data-Driven Design
- Composition over Inheritance
- Event-Driven Communication
- Single Responsibility Principle
- Modular Systems
- Self-Documenting Code
- Performance-Conscious Development

Every new gameplay mechanic should follow these principles.

---

# Code Review

During code review, verify that new code:

- Follows the Style Guide.
- Uses correct naming conventions.
- Fits the project architecture.
- Is placed in the correct folder.
- Uses ScriptableObjects appropriately.
- Follows performance recommendations.
- Avoids documented anti-patterns.
- Maintains module independence.

---

# Related Documentation

Architecture

- ../Architecture/

Gameplay

- ../Gameplay/

Art Guide

- ../ArtGuide/

Git

- ../Git/

Setup

- ../Setup/
