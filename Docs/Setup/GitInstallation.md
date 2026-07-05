# GitHub Desktop Installation Guide

---

Version: 1.0  
Last Updated: 05.07.2026

Required Application: **GitHub Desktop (Latest Stable Version)**

---

# Table of Contents

1. Overview
2. Requirements
3. Installing GitHub Desktop
4. Signing in to GitHub
5. Configuring GitHub Desktop
6. Verifying the Installation
7. Authentication
8. Common Issues
9. Updating GitHub Desktop
10. Best Practices
11. Related Documentation

---

# 1. Overview

This document describes how to install and configure **GitHub Desktop** for this project.

Unlike many software projects, this project **does not require developers to use the Git command line** for everyday work.

All standard Git operations are performed through **GitHub Desktop**, providing a consistent and beginner-friendly workflow.

GitHub Desktop will be used for:

- Cloning the repository
- Creating branches
- Committing changes
- Pulling updates
- Pushing commits
- Resolving simple merge conflicts
- Viewing repository history

For advanced Git workflows, refer to the documentation in the **Git/** folder.

---

# 2. Requirements

## GitHub Account

Each developer must have a GitHub account.

If you do not already have one, create an account before continuing.

---

## Internet Connection

Required for:

- Downloading GitHub Desktop
- Authentication
- Repository synchronization
- Pulling and pushing changes

---

## Operating System

Supported development environments:

- Windows 10 (64-bit)
- Windows 11 (64-bit)

---

# 3. Installing GitHub Desktop

## Step 1

Download **GitHub Desktop** from the official GitHub website.

---

## Step 2

Run the installer.

Use the default installation options unless your organization specifies otherwise.

---

## Step 3

Launch GitHub Desktop.

The application should open without errors.

---

# 4. Signing in to GitHub

When GitHub Desktop starts for the first time:

1. Select **Sign in to GitHub**.
2. Complete authentication in your web browser.
3. Authorize GitHub Desktop to access your GitHub account.
4. Return to GitHub Desktop.

Once completed, your GitHub account should appear in the application.

---

# 5. Configuring GitHub Desktop

Open:

**File → Options**

Verify the following settings.

---

## Git Identity

Confirm that your Git identity is correct:

- Name
- Email Address

These values will be attached to every commit you create.

The email address should match the one associated with your GitHub account whenever possible.

---

## Default Repository Location

Choose a location with:

- Sufficient free disk space
- Short folder path
- Reliable storage

Avoid storing repositories in temporary or cloud-synchronized folders unless required.

---

## Appearance

Choose either:

- Light Theme
- Dark Theme

This setting does not affect the project.

---

# 6. Verifying the Installation

Before cloning the project repository, verify the following.

## Application

- GitHub Desktop launches successfully.
- No startup errors occur.

---

## Authentication

Verify:

- You are signed in.
- Your GitHub account is displayed correctly.

---

## Git Identity

Verify:

- Name is correct.
- Email address is correct.

---

## Network Access

Confirm that GitHub Desktop can connect to GitHub without errors.

---

# 7. Authentication

This project supports the authentication methods provided by GitHub Desktop.

For most developers, browser-based authentication is recommended.

If your organization requires SSH authentication, follow the team's internal setup instructions.

Authentication should remain valid after restarting GitHub Desktop.

---

# 8. Common Issues

## Unable to Sign In

Possible causes:

- Internet connection unavailable
- Browser authentication blocked
- Firewall restrictions

Solution:

- Verify internet connectivity.
- Retry browser authentication.
- Restart GitHub Desktop.

---

## Incorrect Commit Author

Problem:

Commits display the wrong name or email.

Solution:

Open:

**File → Options**

Update your Git identity.

Future commits will use the corrected information.

---

## Repository Cannot Be Cloned

Possible causes:

- Incorrect repository URL
- Missing repository permissions
- Authentication failure

Solution:

- Verify repository access.
- Confirm you are signed into the correct GitHub account.
- Retry cloning.

---

## Push Failed

Possible causes:

- Remote branch has newer commits
- Network interruption
- Authentication expired

Solution:

- Pull the latest changes.
- Resolve any merge conflicts.
- Retry the push operation.

---

## Merge Conflict

Problem:

GitHub Desktop reports conflicting changes.

Solution:

Resolve the conflict following the project's Git workflow documentation before committing the merge.

---

# 9. Updating GitHub Desktop

Keep GitHub Desktop updated to the latest stable version.

Before updating:

- Finish current work.
- Commit all changes.
- Push pending commits.

After updating:

- Verify authentication.
- Open the repository.
- Confirm normal operation.

---

# 10. Best Practices

Always:

- Pull the latest changes before starting work.
- Create a dedicated branch for each feature or task.
- Commit small, focused changes.
- Write clear and descriptive commit messages.
- Push changes regularly.
- Sync your branch frequently with the latest project changes.

Never:

- Commit directly to the main branch (unless explicitly permitted by the project's workflow).
- Force push without team approval.
- Delete remote branches without confirmation.
- Ignore merge conflicts.
- Commit generated Unity folders such as `Library/`, `Temp/`, or `Logs/`.

---

# 11. Related Documentation

## Setup

- UnityInstallation.md
- ProjectSetup.md

## Git

- ../Git/Workflow.md
- ../Git/Branches.md
- ../Git/CommitRules.md
- ../Git/GitLFS.md

## Coding Standards

- ../CodingStandard/
