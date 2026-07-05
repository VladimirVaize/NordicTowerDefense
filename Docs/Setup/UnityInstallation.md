# Unity Installation Guide

---

Version: 1.0  
Last Updated: 05.07.2026

Required Unity Version: **6000.5.1f1**

---

# Table of Contents

1. Overview
2. Requirements
3. Installing Unity Hub
4. Installing Unity Editor
5. Required Modules
6. Creating the Unity Environment
7. Verifying the Installation
8. Common Issues
9. Updating Unity
10. Best Practices
11. Related Documentation

---

# 1. Overview

This document describes how to install and configure Unity for this project.

All developers **must use the exact Unity version specified in this document** to ensure:

- Identical project behavior
- Asset compatibility
- Package compatibility
- Stable builds
- Consistent development environment

Using a different Unity version is **not supported** unless explicitly approved.

---

# 2. Requirements

## Unity Version

The project uses:

> **Unity 6000.5.1f1**

No newer or older version should be used unless the project is officially upgraded.

---

## Render Pipeline

This project uses:

- Universal Render Pipeline (URP)

The project is **not compatible** with:

- Built-in Render Pipeline
- High Definition Render Pipeline (HDRP)

---

## Operating System

Supported development environments:

- Windows 10 (64-bit)
- Windows 11 (64-bit)

---

## Internet Connection

Required for:

- Unity Hub installation
- Unity Editor download
- Package installation
- License activation

---

# 3. Installing Unity Hub

## Step 1

Download the latest version of **Unity Hub** from the official Unity website.

---

## Step 2

Run the installer.

Use the default installation settings unless your organization specifies otherwise.

---

## Step 3

Launch Unity Hub.

---

## Step 4

Sign in using your Unity account.

If you do not have an account, create one before continuing.

---

# 4. Installing Unity Editor

Open:

**Unity Hub → Installs**

---

Click:

**Install Editor**

---

Choose:

> **Unity 6000.5.1f1**

Verify that the version exactly matches the project requirements.

Do **not** install another version.

---

# 5. Required Modules

When installing Unity, select the following modules:

## Required

- Universal Windows Platform Build Support
- Web Build Support
- Windows Build Support (IL2CPP)
- Documentation

---

## Optional

The following modules may be installed if required for future development:

- Android Build Support
- iOS Build Support
- Linux Build Support
- macOS Build Support

These modules are **not required** for normal project development.

---

# 6. Creating the Unity Environment

After installation:

Open Unity Hub.

Verify that Unity **6000.5.1f1** appears in the installed editors list.

The installation should include all required modules.

Do not create a new project.

The project repository already contains the Unity project.

Project setup is described in:

**ProjectSetup.md**

---

# 7. Verifying the Installation

Before opening the project, verify the following.

## Unity Version

Installed version:

- Unity 6000.5.1f1

---

## Installed Modules

Verify the following modules are installed:

- Windows Build Support (IL2CPP)
- Web Build Support
- Universal Windows Platform Build Support
- Documentation

---

## Unity Hub

Verify:

- Unity Hub launches correctly
- Unity account is signed in
- Unity Editor starts without errors

---

## License

Verify that Unity is properly licensed.

If activation is required, complete the activation process before opening the project.

---

# 8. Common Issues

## Wrong Unity Version

Problem:

A different Unity version is installed.

Solution:

Remove the incorrect version and install:

**Unity 6000.5.1f1**

---

## Missing Build Modules

Problem:

Required build targets are unavailable.

Solution:

Open Unity Hub.

Locate Unity 6000.5.1f1.

Select:

Add Modules

Install the missing modules.

---

## Unity Hub Cannot Find the Editor

Problem:

Unity Hub does not recognize the installed editor.

Solution:

Reinstall the editor through Unity Hub.

Avoid manually moving Unity installation folders.

---

## License Problems

Problem:

Unity requests activation.

Solution:

Sign in with your Unity account and activate the appropriate license.

---

## Installation Failed

Possible causes:

- Insufficient disk space
- Interrupted internet connection
- Antivirus interference
- Corrupted download

Retry the installation after resolving the issue.

---

# 9. Updating Unity

Unity should **not** be updated automatically.

Before upgrading Unity:

- Discuss the upgrade with the team
- Test compatibility
- Update project documentation
- Verify all packages
- Verify project builds successfully

Only after successful validation should the new version become the official project version.

---

# 10. Best Practices

Always:

- Use the exact Unity version specified by the project
- Install required modules before opening the project
- Keep Unity Hub updated
- Avoid multiple unsupported Unity versions for the same project
- Verify installation before cloning or opening the repository

Never:

- Upgrade Unity independently
- Modify project render pipeline
- Change build targets without project approval
- Open the project using an unsupported Unity version

---

# 11. Related Documentation

## Setup

- GitInstallation.md
- ProjectSetup.md

## Git

- ../Git/

## Architecture

- ../Architecture/

## Coding Standards

- ../CodingStandard/
