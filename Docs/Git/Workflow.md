# Git Workflow

**Project:** Hrafnar Tower Defense  
**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Workflow Goals
3. Development Cycle
4. Task Lifecycle
5. Daily Development Workflow
6. Code Review
7. Merge Strategy
8. Conflict Resolution
9. Best Practices
10. Common Mistakes
11. Related Documentation

---

# 1. Overview

This document describes the Git workflow used during development of the project.

The goal is to provide a clear, consistent and scalable development process for both solo development and future team collaboration.

Every change should follow the same workflow regardless of its size.

---

# 2. Workflow Goals

The workflow is designed to achieve the following goals:

- Keep the `main` branch stable.
- Isolate features during development.
- Make changes easy to review.
- Reduce merge conflicts.
- Maintain a clean Git history.
- Support future team expansion.

---

# 3. Development Cycle

Every task follows the same development cycle.

```text
Planning
    │
    ▼
Create Branch
    │
    ▼
Development
    │
    ▼
Local Testing
    │
    ▼
Commit Changes
    │
    ▼
Push Branch
    │
    ▼
Pull Request
    │
    ▼
Code Review
    │
    ▼
Merge
    │
    ▼
Delete Branch
```

This workflow applies to every gameplay feature, bug fix, optimization and documentation update.

---

# 4. Task Lifecycle

Each task should represent one logical unit of work.

Examples:

- New tower
- Enemy AI improvement
- UI update
- Performance optimization
- Documentation update

Large features should be divided into multiple smaller tasks whenever possible.

---

## Step 1 — Create a Branch

Create a new branch from the latest version of `main`.

Each branch should contain only one feature or one fix.

---

## Step 2 — Development

Implement the feature.

During development:

- Keep changes focused.
- Avoid unrelated modifications.
- Test frequently.

---

## Step 3 — Local Testing

Before committing:

- Check for compiler errors.
- Verify gameplay.
- Test affected systems.
- Remove temporary debug code.

Only working code should be committed.

---

## Step 4 — Commit

Create one or more meaningful commits describing the completed work.

Commit messages should follow the project's commit rules.

---

## Step 5 — Push

Push the branch to GitHub.

This creates a remote backup and allows collaboration.

---

## Step 6 — Pull Request

Open a Pull Request.

Describe:

- What changed.
- Why it changed.
- Anything requiring special attention.

---

## Step 7 — Review

Review the changes before merging.

Check:

- Code quality
- Gameplay behavior
- Naming
- Documentation
- Possible regressions

---

## Step 8 — Merge

Merge only after:

- Successful review
- Successful testing
- No merge conflicts

---

## Step 9 — Cleanup

After merging:

- Delete the feature branch.
- Update the local repository.
- Start the next task from the latest `main`.

---

# 5. Daily Development Workflow

A typical work session should look like this:

```text
Open GitHub Desktop
        │
        ▼
Fetch Origin
        │
        ▼
Update main
        │
        ▼
Create / Switch Branch
        │
        ▼
Develop
        │
        ▼
Test
        │
        ▼
Commit
        │
        ▼
Push
```

Repeat as necessary until the feature is complete.

---

# 6. Code Review

Every Pull Request should be reviewed before merging.

The review should verify:

- Functionality
- Readability
- Maintainability
- Performance
- Consistency with project standards

Documentation should also be updated if necessary.

---

# 7. Merge Strategy

The project uses a simple merge strategy.

General rules:

- Merge completed features only.
- Never merge unfinished work.
- Resolve conflicts before merging.
- Verify the project builds successfully after merge.

The `main` branch should always remain playable and stable.

---

# 8. Conflict Resolution

Merge conflicts should be resolved immediately.

General approach:

1. Update the branch.
2. Resolve conflicts carefully.
3. Test the project.
4. Commit the resolved changes.
5. Continue the merge process.

Never ignore merge conflicts without understanding their cause.

---

# 9. Best Practices

- Work on one feature at a time.
- Keep branches short-lived.
- Commit regularly.
- Push frequently.
- Test before every merge.
- Keep documentation up to date.
- Remove unused code before merging.

---

# 10. Common Mistakes

Avoid the following:

- Developing directly on `main`
- Mixing multiple features in one branch
- Huge commits with unrelated changes
- Ignoring merge conflicts
- Merging untested code
- Forgetting to update documentation
- Leaving completed branches undeleted

---

# 11. Related Documentation

- Branches.md
- CommitRules.md
- GitLFS.md
- ../CodingStandard/
