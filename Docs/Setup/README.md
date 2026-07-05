# Setup Documentation

---

## Overview

This folder contains all documentation required to prepare a new development environment for the project.

The purpose of these guides is to ensure that every developer works with an identical software configuration, reducing setup issues and improving consistency across the team.

Following these documents in the recommended order will result in a fully configured and ready-to-use development environment.

---

## Purpose

The Setup documentation exists to:

- Standardize the development environment
- Minimize onboarding time
- Ensure identical Unity installations
- Ensure consistent Git configuration
- Prevent common setup mistakes
- Provide a repeatable installation process

---

## Setup Workflow

New developers should complete the setup in the following order:

```text
Unity Installation
        ↓
GitHub Desktop Installation
        ↓
Project Setup
        ↓
Ready for Development
```

Following this order guarantees that all project requirements are satisfied before development begins.

---

## Documentation Structure

### 1. UnityInstallation.md

Install and configure Unity.

Topics include:

- Unity Hub installation
- Unity Editor installation
- Required Unity version
- Required modules
- Installation verification
- Common installation issues

This document must be completed before opening the project.

---

### 2. GitInstallation.md

Install and configure GitHub Desktop.

Topics include:

- GitHub Desktop installation
- GitHub authentication
- Git identity configuration
- Repository access
- Installation verification
- Common GitHub Desktop issues

This document prepares the version control environment.

---

### 3. ProjectSetup.md

Configure the local project.

Topics include:

- Cloning the repository
- Opening the project
- First Unity import
- Package restoration
- Project verification
- Build verification
- Common project setup issues

This document completes the local development environment.

---

## Software Requirements

The project currently requires:

### Unity

Version:

**6000.5.1f1**

Render Pipeline:

- Universal Render Pipeline (URP)

Required Modules:

- Universal Windows Platform Build Support
- Web Build Support
- Windows Build Support (IL2CPP)
- Documentation

---

### Version Control

This project uses:

- Git
- GitHub
- GitHub Desktop

Daily development should be performed using **GitHub Desktop**.

Command-line Git is not required for normal project workflow.

---

## Development Environment

A correctly configured development environment should provide:

- Correct Unity version
- Required Unity modules
- Working GitHub Desktop installation
- Successful repository clone
- Successful package restoration
- Error-free project compilation
- Successful project build

---

## Verification Checklist

Before starting development, verify that:

- Unity **6000.5.1f1** is installed.
- Required Unity modules are installed.
- GitHub Desktop is installed and configured.
- Repository has been cloned successfully.
- The project opens without errors.
- Unity Console contains no compilation errors.
- Packages are restored successfully.
- The project builds successfully.

---

## Best Practices

Always:

- Follow the setup documents in order.
- Use the required Unity version.
- Verify your installation before beginning development.
- Keep GitHub Desktop updated.
- Pull the latest changes before starting work.

Never:

- Use unsupported Unity versions.
- Skip project verification.
- Ignore Console errors.
- Modify the project before the setup process is complete.

---

## Related Documentation

### Architecture

- ../Architecture/

### Coding Standards

- ../CodingStandard/

### Git

- ../Git/

### Gameplay

- ../Gameplay/

### Roadmap

- ../Roadmap/

---

## Final Note

The Setup documentation is designed to ensure that every developer starts from the same baseline.

Maintaining a standardized development environment improves project stability, simplifies collaboration, and reduces technical issues throughout the development lifecycle.
