# Branch Strategy

**Project:** Hrafnar Tower Defense  
**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Branching Strategy
3. Main Branch
4. Feature Branches
5. Bugfix Branches
6. Hotfix Branches
7. Documentation Branches
8. Branch Naming Convention
9. Branch Lifecycle
10. GitHub Desktop Workflow
11. Branch Rules
12. Best Practices
13. Common Mistakes
14. Related Documentation

---

# 1. Overview

This document defines the branching strategy used during development.

A consistent branch structure helps:

- Keep the repository organized
- Prevent accidental changes to stable code
- Simplify collaboration
- Reduce merge conflicts
- Maintain a clean project history

Every change in the project should be made inside a dedicated branch.

---

# 2. Branching Strategy

The project follows a simplified Git Flow model.

Only one permanent branch exists:

```text
main
```

All other branches are temporary.

After being merged, temporary branches should be deleted.

---

## Branch Types

| Branch | Purpose | Lifetime |
|---------|---------|----------|
| main | Stable project | Permanent |
| feature/* | New gameplay features | Temporary |
| bugfix/* | Non-critical bug fixes | Temporary |
| hotfix/* | Critical fixes | Temporary |
| docs/* | Documentation updates | Temporary |

---

# 3. Main Branch

The `main` branch is the stable version of the project.

It must always:

- Compile successfully
- Open correctly in Unity
- Be playable
- Contain tested code

Direct development on `main` is prohibited.

Changes reach `main` only through Pull Requests.

---

# 4. Feature Branches

Feature branches are used to develop new functionality.

Examples:

```text
feature/building-system
feature/wave-system
feature/resource-system
feature/save-system
feature/options-menu
```

Each feature branch should focus on **one feature only**.

Do not combine unrelated systems in the same branch.

---

# 5. Bugfix Branches

Bugfix branches are used to fix non-critical issues.

Examples:

```text
bugfix/enemy-pathfinding
bugfix/ui-overlap
bugfix/resource-calculation
```

Bugfixes should not introduce new features.

---

# 6. Hotfix Branches

Hotfix branches are used for urgent problems discovered after code has already been merged into `main`.

Examples:

```text
hotfix/game-crash
hotfix/save-corruption
hotfix/null-reference
```

Hotfixes should contain the minimum amount of code necessary to resolve the issue.

---

# 7. Documentation Branches

Documentation branches are used when updating project documentation.

Examples:

```text
docs/gameplay
docs/git-guide
docs/architecture
docs/coding-standard
```

Keeping documentation in separate branches makes reviews easier and keeps the Git history organized.

---

# 8. Branch Naming Convention

Branch names should:

- Be lowercase
- Use hyphens (`-`) instead of spaces
- Clearly describe the task

Good examples:

```text
feature/building-upgrades
feature/fog-of-war

bugfix/wave-spawning

hotfix/save-loading

docs/resources-documentation
```

Avoid:

```text
feature/Test

feature/NewStuff

feature/Version2

mybranch

test
```

---

# 9. Branch Lifecycle

Each branch follows the same lifecycle.

```text
main
   │
   ▼
Create Branch
   │
   ▼
Development
   │
   ▼
Testing
   │
   ▼
Commit
   │
   ▼
Push
   │
   ▼
Pull Request
   │
   ▼
Merge into main
   │
   ▼
Delete Branch
```

A branch should exist only while work is being performed.

---

# 10. GitHub Desktop Workflow

The project uses **GitHub Desktop** as the primary Git client.

Typical workflow:

1. Fetch origin.
2. Pull the latest version of `main`.
3. Create or switch to a working branch.
4. Complete the task.
5. Commit changes.
6. Push the branch.
7. Create a Pull Request.
8. Merge after review.
9. Delete the completed branch.
10. Pull the updated `main`.

This workflow should be followed for every task.

---

# 11. Branch Rules

The following rules apply to every branch:

- One branch = one logical task.
- Keep branches short-lived.
- Merge completed work only.
- Test before merging.
- Resolve conflicts before creating a Pull Request.
- Delete merged branches.

The `main` branch must always remain stable.

---

# 12. Best Practices

Recommended practices:

- Create branches frequently.
- Finish small tasks before starting new ones.
- Keep changes focused.
- Push regularly.
- Update your branch before opening a Pull Request.
- Name branches consistently.

---

# 13. Common Mistakes

Avoid:

- Working directly on `main`
- Using one branch for multiple features
- Long-lived feature branches
- Mixing gameplay and documentation changes
- Forgetting to delete merged branches
- Creating meaningless branch names

---

# 14. Related Documentation

- Workflow.md
- CommitRules.md
- GitLFS.md
- ../CodingStandard/Naming.md
