# Commit Rules

**Project:** Hrafnar Tower Defense  
**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Commit Goals
3. General Rules
4. Commit Structure
5. Commit Types
6. Writing Good Commit Messages
7. Examples
8. Commit Size
9. When to Commit
10. What Should Not Be Committed
11. GitHub Desktop Workflow
12. Best Practices
13. Common Mistakes
14. Related Documentation

---

# 1. Overview

This document defines the commit message conventions used throughout the project.

Consistent commit messages improve:

- Project history readability
- Code review
- Debugging
- Collaboration
- Change tracking

Every commit should represent one logical change.

---

# 2. Commit Goals

A good commit should be:

- Small
- Focused
- Meaningful
- Self-explanatory
- Easy to review

Someone reading the Git history should understand what changed without opening the files.

---

# 3. General Rules

Follow these rules for every commit:

- One logical change per commit.
- Commit only completed work.
- Test changes before committing.
- Do not mix unrelated modifications.
- Keep documentation synchronized with code changes when applicable.

---

# 4. Commit Structure

Commit messages should use the following format:

```text
type: short description
```

Examples:

```text
feature: add wave manager

bugfix: fix enemy pathfinding

docs: update gameplay documentation

refactor: simplify tower targeting

optimization: reduce enemy update cost
```

The description should:

- Be short
- Be clear
- Describe what changed
- Use lowercase

---

# 5. Commit Types

| Type | Description |
|------|-------------|
| feature | New functionality |
| bugfix | Bug fixes |
| hotfix | Critical fixes |
| refactor | Internal code improvements |
| optimization | Performance improvements |
| docs | Documentation changes |
| test | Test-related changes |
| chore | Maintenance tasks |

---

## Type Descriptions

### feature

Used when adding new gameplay or engine functionality.

Example:

```text
feature: add resource system
```

---

### bugfix

Used when fixing non-critical issues.

Example:

```text
bugfix: fix tower rotation
```

---

### hotfix

Used for urgent production fixes.

Example:

```text
hotfix: fix crash on startup
```

---

### refactor

Used when improving code without changing behavior.

Example:

```text
refactor: simplify wave initialization
```

---

### optimization

Used for performance improvements.

Example:

```text
optimization: reduce pathfinding allocations
```

---

### docs

Used when changing documentation only.

Example:

```text
docs: update architecture documentation
```

---

### test

Used for automated or manual testing assets.

Example:

```text
test: add enemy movement tests
```

---

### chore

Used for repository maintenance.

Examples:

- Updating `.gitignore`
- Updating project settings
- Cleaning folders
- Updating dependencies

Example:

```text
chore: update unity packages
```

---

# 6. Writing Good Commit Messages

Good commit messages should:

- Describe the change
- Be concise
- Focus on the result
- Avoid unnecessary words

Good:

```text
feature: add fog of war system
```

Good:

```text
docs: update wave documentation
```

Bad:

```text
update
```

Bad:

```text
fixed stuff
```

Bad:

```text
new code
```

Bad:

```text
changes
```

---

# 7. Examples

Gameplay:

```text
feature: add enemy wave system

feature: implement tower upgrades

bugfix: fix enemy spawn timing

optimization: improve resource calculations
```

Documentation:

```text
docs: add gameplay readme

docs: update coding standards

docs: expand architecture documentation
```

Project Maintenance:

```text
chore: update git lfs configuration

chore: clean project folders
```

---

# 8. Commit Size

Commits should remain small.

Preferred scope:

- One feature
- One fix
- One documentation update
- One refactoring task

Avoid commits containing multiple unrelated changes.

---

# 9. When to Commit

Commit after:

- Completing a logical unit of work
- Finishing a bug fix
- Completing a documentation update
- Successfully testing the implemented change

Do not commit unfinished or broken code unless working in an experimental branch.

---

# 10. What Should Not Be Committed

Never commit:

- Broken code
- Temporary debug code
- Console spam
- Unused assets
- Experimental files in feature branches
- Generated cache files
- Local configuration files that should remain user-specific

Large binary assets should be tracked through Git LFS when applicable.

---

# 11. GitHub Desktop Workflow

Using GitHub Desktop:

1. Review the list of changed files.
2. Verify only related files are included.
3. Write a meaningful commit message.
4. Commit to the current branch.
5. Push the branch to GitHub.

Always review your changes before pressing **Commit**.

---

# 12. Best Practices

- Commit frequently.
- Keep commits focused.
- Write descriptive messages.
- Test before committing.
- Keep documentation synchronized.
- Review changed files before every commit.

---

# 13. Common Mistakes

Avoid:

- Huge commits
- Multiple features in one commit
- Meaningless commit messages
- Committing broken code
- Forgetting documentation updates
- Including unrelated files

---

# 14. Related Documentation

- Workflow.md
- Branches.md
- GitLFS.md
