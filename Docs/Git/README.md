# Git Documentation

**Project:** Hrafnar Tower Defense  
**Document Version:** 1.0

---

# Overview

This folder contains all documentation related to version control and collaborative development.

It defines how the project is managed using Git, GitHub, GitHub Desktop and Git Large File Storage (Git LFS).

The purpose of these documents is to ensure a consistent development workflow, maintain a clean repository history, and simplify collaboration between developers.

---

# Documentation Structure

## Workflow

Describes the complete development process from creating a task to merging it into the `main` branch.

Topics include:

- Development lifecycle
- Daily workflow
- Pull Requests
- Code Review
- Merge process
- Conflict resolution

File:

`Workflow.md`

---

## Branch Strategy

Defines the project's branching model.

Topics include:

- Branch types
- Branch naming
- Branch lifecycle
- GitHub Desktop workflow
- Branch management rules

File:

`Branches.md`

---

## Commit Rules

Defines how commits should be written.

Topics include:

- Commit structure
- Commit types
- Naming conventions
- Commit examples
- Best practices

File:

`CommitRules.md`

---

## Git Large File Storage (Git LFS)

Describes how large binary assets are managed.

Topics include:

- Supported asset types
- Repository organization
- Working with Git LFS
- Best practices

File:

`GitLFS.md`

---

# Development Workflow Summary

Every task follows the same development process:

```text
Plan Task
    │
    ▼
Create Branch
    │
    ▼
Develop Feature
    │
    ▼
Test Changes
    │
    ▼
Commit Changes
    │
    ▼
Push Branch
    │
    ▼
Create Pull Request
    │
    ▼
Review
    │
    ▼
Merge into main
    │
    ▼
Delete Branch
```

Following the same workflow for every task keeps the repository clean, predictable and easy to maintain.

---

# Git Principles

The project follows several core principles:

- The `main` branch is always stable.
- One branch contains one logical task.
- One commit contains one logical change.
- Every change should be tested before merging.
- Documentation should be updated together with the related implementation.
- Large binary assets must be managed through Git LFS.

---

# Tools

The following tools are used for version control:

| Tool | Purpose |
|-------|---------|
| Git | Version control |
| GitHub | Remote repository hosting |
| GitHub Desktop | Primary Git client |
| Git LFS | Large binary asset management |

---

# Related Documentation

## Project Setup

- ../Setup/GitInstallation.md

---

## Coding Standards

- ../CodingStandard/

---

## Architecture

- ../Architecture/

---

## Art Pipeline

- ../ArtGuide/
