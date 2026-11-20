# Hollowlight — Testing Session 1 Feedback

## Feedback Summary

Testing Session 1 provided valuable feedback on Hollowlight's gameplay, controls, cave environment, and guiding flame mechanic.

Eight tester responses were reviewed from the graded playtesting forum. The feedback identified three main areas for improvement: visual clarity, flame navigation, and cave lighting.

Most testers understood the basic gameplay mechanics and the purpose of the guiding flame. However, several reported navigation problems, difficulty perceiving movement, or concerns about the cave's lighting.

The feedback was used to prioritize improvements for the Beta build.

## 1. Visual Clarity and Player Movement

**Testers reporting texture-related visibility problems:** 1

**Feedback:** A tester reported difficulty recognizing forward movement because the cave walls lacked textures. Additional feedback mentioned slow movement and occasional unexpected player movement.

**Priority:** High

**Decision:** Fix Now

**Reason:** Players need clear visual feedback to understand their movement and navigate the cave successfully.

**Action Taken:** Added rock textures to the cave walls, floor, and ceiling to improve movement perception and environmental clarity.

**Status:** Fixed and tested.

## 2. Guiding Flame Navigation

**Testers reporting navigation problems:** 4

**Feedback:** Several testers reported that the guiding flame sometimes returned toward its starting position before traveling to the objective. Others observed the flame passing through walls or following confusing routes.

**Priority:** High

**Decision:** Fix Now

**Reason:** The guiding flame is Hollowlight's central gameplay mechanic. Navigation problems interfere with the player's ability to understand and trust its guidance.

**Action Taken:** Improved the guiding flame's navigation using Unity's NavMesh system to help it follow the intended route through the cave.

**Status:** Fixed and tested in the updated build.

## 3. Cave Lighting and Atmosphere

**Testers discussing lighting concerns or adjustments:** 4

**Feedback:** Opinions about the cave lighting were mixed. Some testers felt the lighting was appropriate, while others suggested making the cave darker or improving the flame's illumination.

**Priority:** Medium

**Decision:** Fix Now

**Reason:** Darkness is essential to Hollowlight's atmosphere and gameplay. The environment should encourage players to depend on the guiding flame without making navigation unnecessarily frustrating.

**Action Taken:** Adjusted the cave lighting to create a darker environment and reinforce the importance of the guiding flame.

**Status:** Lighting adjustments completed and tested.

## 4. Controls and Movement Feedback

**Testers reporting control or movement concerns:** 2

**Feedback:** Most testers found the movement and flame controls understandable. However, one tester initially struggled to understand the G key, while another reported slow movement or unexpected movement behavior.

**Priority:** Medium

**Decision:** Fix Later / Monitor

**Reason:** The controls were generally understood, so a complete redesign was unnecessary. Further testing can determine whether additional instructions or movement adjustments are needed.

**Action Taken:** Retained the existing control system and continued testing movement and flame behavior.

**Status:** Monitor during future testing.

## Playtesting Questions and Responses

### Question 1: How clear were the movement and flame controls?

Most testers reported that the controls were clear, simple, and easy to understand.

One tester initially found the G key unintuitive and needed another attempt to understand how to activate the guiding flame. Another mentioned that player movement felt slow.

**Conclusion:** The basic controls are understandable, although onboarding and movement responsiveness could benefit from additional polish.

### Question 2: Did you understand where the flame wanted you to go?

Most testers understood that the flame was guiding them toward an objective.

However, several testers experienced confusing navigation behavior, including the flame returning toward its starting position or moving through walls.

**Conclusion:** The objective was generally understandable, but flame navigation needed improvement.

**Improvement:** The flame's navigation was updated using Unity's NavMesh system.

### Question 3: Was the cave too dark, too bright, or appropriately lit?

Tester opinions were mixed.

Some considered the lighting appropriate, while others felt that certain areas were too bright or too dark. A few suggested improving the flame's illumination.

**Conclusion:** The cave needed lighting adjustments that supported its psychological atmosphere while maintaining playable visibility.

**Improvement:** Adjusted the cave lighting to emphasize darkness and player reliance on the guiding flame.

## Beta Fixes and Decisions

The three main playtesting improvements were completed:

1. Added cave textures for better visual clarity.
2. Improved guiding flame navigation.
3. Adjusted cave lighting and atmosphere.

These changes were committed to the main branch and included in the updated WebGL build.

GitHub issues were created to document the completed improvements and subsequently closed.

## Beta Content Lock

Hollowlight has entered Beta content lock.

The current Beta build includes:

- Third-person movement and camera controls.
- A navigable cave environment.
- Guiding flame navigation and illumination.
- Hidden objective reveal and completion.
- On-screen controls and restart functionality.
- A playable WebGL browser build.

The following features were deferred:

- Sanity and Perception System.
- Trust vs. Question Choice Mechanic.
- Additional guiding flame abilities.
- Expanded cave environments and story content.

These features remain part of Hollowlight's broader development vision but are outside the locked Beta scope.

Further work before the final release will focus on bug fixes, balancing, performance improvements, and polish.

## Testing Results

The updated Hollowlight build was tested after implementing the three major playtesting improvements.

Player movement, guiding flame navigation, objective reveal, and level completion were confirmed working during development testing.

The updated WebGL build was published on itch.io.

## Project Links

**Playable Beta Build:**
https://jarayiusstewart-hash.itch.io/hollowlight

**GitHub Repository:**
https://github.com/jarayiusstewart-hash/Final-Project-Game

**GitHub Issues:**
https://github.com/jarayiusstewart-hash/Final-Project-Game/issues

**GitHub Project Board:**
https://github.com/users/jarayiusstewart-hash/projects/1

**Beta Release Notes:**
https://github.com/jarayiusstewart-hash/Final-Project-Game/blob/main/README.md

## Feedback Sources

- Testing Session 1 — Graded Forum, Section 2 (8 visible tester responses reviewed).
- Testing Session 1 — Open Forum (pending review).

No tester names are included in this summary.
