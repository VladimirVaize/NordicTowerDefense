# Project Setup Guide

---

Version: 1.0  
Last Updated: 05.07.2026

Required Unity Version: **6000.5.1f1**

---

# Table of Contents

1. Overview
2. Prerequisites
3. Cloning the Repository
4. Opening the Project
5. First Project Import
6. Verifying the Project
7. Installing Project Packages
8. Project Settings Verification
9. Building the Project
10. Common Issues
11. Best Practices
12. Related Documentation

---

# 1. Overview

This document explains how to set up the project on a new development machine.

By following this guide, every developer will have an identical development environment, reducing setup issues and ensuring consistent project behavior.

Before continuing, make sure that:

- Unity **6000.5.1f1** is installed.
- GitHub Desktop is installed and configured.
- You have access to the project repository.

---

# 2. Prerequisites

Before cloning the repository, verify the following:

## Unity

Installed version:

> **Unity 6000.5.1f1**

Required Render Pipeline:

- Universal Render Pipeline (URP)

---

## GitHub Desktop

Verify that:

- GitHub Desktop is installed.
- You are signed into your GitHub account.
- Your Git identity is configured correctly.

---

## Repository Access

Ensure that you have:

- Read access to the repository.
- Write access if you will contribute code.

---

# 3. Cloning the Repository

Open **GitHub Desktop**.

Select:

**File → Clone Repository**

Choose the project repository.

Select a local destination folder.

Click:

**Clone**

Wait until the cloning process completes successfully.

Do not modify the repository structure after cloning.

---

# 4. Opening the Project

Open **Unity Hub**.

Select:

**Add Project**

Navigate to the cloned repository folder.

Select the project root directory.

Verify that Unity Hub detects the required version:

> **Unity 6000.5.1f1**

Open the project.

---

# 5. First Project Import

When opening the project for the first time, Unity will automatically:

- Generate the `Library/` folder.
- Import all assets.
- Compile scripts.
- Restore project packages.
- Build shader caches.
- Initialize URP resources.

This process may take several minutes depending on your hardware.

Do not interrupt Unity during the initial import.

---

# 6. Verifying the Project

After the import completes, verify the following.

## Console

The Unity Console should contain:

- No compilation errors.
- No package errors.
- No missing script errors.

Warnings should be reviewed but are not necessarily blocking.

---

## Project Structure

Verify that the expected project folders exist.

Examples:

- Assets/
- Packages/
- ProjectSettings/

Do not manually modify these folders unless required.

---

## Scene Loading

Open the project's main scene.

Verify:

- Scene loads successfully.
- No missing references.
- No pink materials.
- No missing shaders.

---

## Render Pipeline

Verify that:

- URP is active.
- Lighting renders correctly.
- Materials appear as expected.

---

## Input System

Verify that player input initializes without errors.

---

## TextMesh Pro

Verify that:

- Text renders correctly.
- TMP Essentials are already imported.

---

## Localization (if enabled)

Verify that:

- Localization tables load correctly.
- No missing localization assets exist.

---

# 7. Installing Project Packages

Most packages are restored automatically through Unity Package Manager.

After opening the project:

Open:

**Window → Package Manager**

Verify that all required packages are installed.

Typical packages include:

- Universal RP
- Input System
- TextMesh Pro
- Localization
- AI Navigation (if used)
- Test Framework (if used)

If a package fails to install, allow Unity to complete the package restoration before troubleshooting.

---

# 8. Project Settings Verification

Verify the following project settings.

## Player Settings

Confirm:

- Scripting Backend: **IL2CPP**
- API Compatibility Level matches the project configuration.

---

## Active Input Handling

Verify that the configured Input System matches the project's requirements.

---

## Graphics

Verify:

- URP Asset is assigned.
- Correct Render Pipeline Asset is active.

---

## Quality

Verify:

- Expected quality presets exist.
- Default quality level is correct.

---

## Build Settings

Open:

**File → Build Profiles**

Verify that the supported platforms are available:

- Windows
- Web
- Universal Windows Platform

Switch platforms only when necessary.

---

# 9. Building the Project

Perform a test build before starting development.

Recommended build targets:

- Windows (IL2CPP)
- Web

Verify that:

- Build completes successfully.
- No build errors occur.
- The application launches correctly.
- The main menu loads successfully.

---

# 10. Common Issues

## Wrong Unity Version

Problem:

The project opens using an unsupported Unity version.

Solution:

Install and use:

> **Unity 6000.5.1f1**

---

## Package Import Errors

Problem:

Packages fail to restore.

Solution:

- Restart Unity.
- Wait for Package Manager synchronization.
- Reopen the project if necessary.

---

## Missing References

Problem:

Objects display missing scripts or components.

Solution:

- Ensure the repository cloned successfully.
- Verify that all `.meta` files are present.
- Pull the latest repository changes.

---

## Pink Materials

Problem:

Materials appear pink.

Possible causes:

- URP Asset missing.
- Incorrect Render Pipeline.
- Shader compilation incomplete.

Solution:

Verify that URP is configured correctly.

---

## Long Initial Import

Problem:

The first import takes a long time.

Solution:

This is normal.

Unity must generate:

- Library cache
- Shader cache
- Asset database

Allow the process to finish.

---

## Build Fails

Problem:

The project does not build.

Solution:

Verify:

- Required Build Support modules are installed.
- Packages are restored correctly.
- No Console errors remain.

---

# 11. Best Practices

Always:

- Use the required Unity version.
- Pull the latest repository changes before starting work.
- Open the project through Unity Hub.
- Verify the Console before making changes.
- Create a dedicated branch for each task.
- Test the project after significant changes.
- Commit frequently with clear commit messages.

Never:

- Modify the project using an unsupported Unity version.
- Delete generated project files without understanding their purpose.
- Commit temporary Unity folders (`Library/`, `Temp/`, `Logs/`, `Obj/`).
- Ignore compilation errors.
- Start development before confirming that the project builds successfully.

---

# 12. Related Documentation

## Setup

- UnityInstallation.md
- GitInstallation.md

## Git

- ../Git/Workflow.md
- ../Git/Branches.md
- ../Git/CommitRules.md

## Architecture

- ../Architecture/

## Coding Standards

- ../CodingStandard/
