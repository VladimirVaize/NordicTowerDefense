# Fog of War

**Project:** Hrafnar Tower Defense  
**Document Version:** 1.0  

---

# Table of Contents

1. Overview  
2. Core Concept  
3. Visibility System  
4. Reveal Mechanics  
5. Fog Behavior Rules  
6. Interaction with Systems  
7. Design Guidelines  

---

# 1. Overview

Fog of War is a gameplay system that controls what parts of the map are visible to the player.

At the start of the game, most of the map is hidden.

Only areas around key structures are visible.

As the player expands their influence, more of the map becomes visible.

---

# 2. Core Concept

The Fog of War system defines two states for map areas:

- **Visible**
- **Hidden**

Hidden areas:

- Cannot be seen
- Do not show enemy movement
- Do not reveal resources or structures

Visible areas:

- Allow building placement
- Show enemy movement
- Reveal terrain and objects

---

# 3. Visibility System

Visibility is calculated based on **reveal sources**.

Each reveal source emits a circular visibility radius.

---

## Reveal Sources

- Castle (starting area)
- Towers
- Special buildings (e.g. fire or scout structures)
- Temporary abilities (future extension)

---

## Visibility Rules

- Visibility is additive
- Overlapping areas expand revealed zones
- Once revealed, areas remain visible (no re-fogging in basic version)

---

# 4. Reveal Mechanics

The primary mechanic for expanding visibility is **building structures**.

---

## Castle

- Provides initial visibility radius
- Always visible area anchor point

---

## Towers

- Extend visibility slightly
- Reveal surrounding terrain passively

---

## Scout / Fire Buildings (Special Case)

Certain buildings (e.g. watchtowers or fire beacons):

- Provide large visibility radius
- Are key strategic expansion tools
- Encourage map exploration

---

## Future Mechanics

Possible extensions:

- Temporary vision (flare-like effects)
- Enemy-based fog (enemies hiding in fog)
- Dynamic fog zones

---

# 5. Fog Behavior Rules

Fog behaves according to simple rules:

- Unexplored areas remain hidden
- Once revealed, terrain stays visible
- Enemies inside fog are not shown until they enter vision range
- Buildings cannot be placed in completely hidden zones (optional rule)

---

## Strategic Impact

Fog creates:

- Risk in expansion
- Need for scouting
- Importance of vision structures
- Map control strategy layer

---

# 6. Interaction with Systems

Fog of War is tightly integrated with other systems.

---

## Enemies System

- Enemies moving in fog are hidden
- Surprise attacks are possible
- Vision determines tracking ability

---

## Towers System

- Towers act as vision anchors
- Placement expands map control

---

## Wave System

- Waves become more dangerous in unexplored areas
- Enemy routes may be partially hidden

---

## Buildings System

- Certain buildings are required to reveal expansion areas
- Encourages forward construction

---

## Resources System

- Resource nodes may be hidden until revealed
- Exploration becomes economically important

---

# 7. Design Guidelines

Fog of War must follow these principles:

- Must be readable at all times
- Should not create unfair surprises
- Must support strategic planning
- Should encourage expansion, not punishment
- Must integrate with all major systems without tight coupling

---

## Core Principle

Fog of War is not just visual masking.

It is a **strategic information control system** that shapes player decisions.
