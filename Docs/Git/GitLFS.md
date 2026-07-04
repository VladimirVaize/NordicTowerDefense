# Git LFS

**Project:** Hrafnar Tower Defense  
**Document Version:** 1.0

---

# Table of Contents

1. Overview
2. Why Git LFS
3. Assets Tracked by Git LFS
4. Repository Structure
5. Working with Git LFS
6. Best Practices
7. Common Mistakes
8. Related Documentation

---

# 1. Overview

Git Large File Storage (Git LFS) is used to manage large binary files that are not suitable for regular Git versioning.

Instead of storing every version of a binary file directly inside the Git repository, Git LFS stores lightweight pointers in Git while keeping the actual file contents in Git LFS storage.

Using Git LFS keeps the repository smaller, improves clone performance, and makes long-term project maintenance significantly easier.

---

# 2. Why Git LFS

Unity projects contain many binary assets that change frequently.

Without Git LFS, the Git repository grows rapidly because every version of every binary file is stored permanently.

Git LFS helps to:

- Reduce repository size
- Improve cloning speed
- Improve repository performance
- Store large assets efficiently
- Keep the Git history cleaner

Git LFS is required for all contributors working on this project.

---

# 3. Assets Tracked by Git LFS

The following file types are tracked using Git LFS.

## 3D Assets

```text
.blend
.fbx
.obj
.max
.mb
.ma
```

---

## Textures

```text
.psd
.psb
.tif
.tiff
.exr
```

---

## Audio

```text
.wav
.flac
```

---

## Video

```text
.mp4
.mov
.avi
```

---

## Other Large Assets

```text
.zip
.7z
.rar
```

Only project resources should be committed.

Temporary export files should not be committed.

---

# 4. Repository Structure

Large source assets are primarily stored inside:

```text
AssetsSource/
```

Typical structure:

```text
AssetsSource/
├── Blender/
├── Concepts/
├── Logos/
├── References/
└── Textures/
```

Unity-ready assets imported into the project are stored inside:

```text
UnityProject/Assets/
```

Whenever possible, source files should also be preserved inside `AssetsSource`.

---

# 5. Working with Git LFS

The workflow is identical to standard Git.

Using GitHub Desktop:

1. Add or modify large assets.
2. Verify the files appear in the changed files list.
3. Commit the changes.
4. Push the branch.

Git LFS automatically manages supported file types.

No additional steps are required during normal development.

---

## Before Adding New Asset Types

If a new large binary file type is introduced:

1. Determine whether it should be tracked by Git LFS.
2. Update the `.gitattributes` file if necessary.
3. Inform the team about the new asset type.
4. Update this documentation.

---

# 6. Best Practices

Follow these recommendations when working with Git LFS.

- Keep original source files.
- Store source assets inside `AssetsSource`.
- Commit only files related to the current task.
- Remove obsolete assets from the project.
- Organize assets using the project folder structure.
- Use meaningful file names.
- Verify large files before committing.

When replacing an asset, update the existing file whenever possible instead of creating unnecessary duplicates.

---

# 7. Common Mistakes

Avoid:

- Committing temporary export files.
- Keeping duplicate copies of large assets.
- Tracking unsupported binary formats without updating `.gitattributes`.
- Renaming files without reason.
- Storing personal backup files inside the repository.
- Ignoring repository organization rules.

---

# 8. Related Documentation

Git:

- Workflow.md
- Branches.md
- CommitRules.md

Setup:

- ../Setup/GitInstallation.md

Art Pipeline:

- ../ArtGuide/Export.md
- ../ArtGuide/Naming.md
