# \# Hollowlight - Proof of Concept



### \## Assumption Under Test

## 

We believe that the guiding flame can help players navigate

through a dark cave by illuminating nearby surroundings

while traveling toward a destination.



If this system does not work reliably, the project will

pivot toward a simpler navigation system using visible

markers or a more consistently okay next illuminated path.



### \## Why This Is a Risky Assumption



The guiding flame is one of the most important mechanics in Hollowlight because the player relies on it to navigate through a dark cave.



If the flame cannot illuminate nearby surroundings or reliably guide the player toward a destination, players may become lost or frustrated.



Testing this mechanic early allows me to determine whether the game's core navigation system is functional before developing more complicated features such as enemies, sanity mechanics, and player decisions.



### \### Connection to Previous Project Plan



My previous development roadmap includes tasks such as "Implement Guiding Flame Movement and Illumination," "Implement Flame Guidance and Player Abilities," and "Final Testing and Web Build Optimization."



These tasks relate to the risk of whether Hollowlight's guiding flame can provide reliable navigation in a dark environment.



Although the flame's basic movement was already implemented, I needed to verify that its illumination allowed the player to follow it successfully. If the navigation system failed, I would need to simplify the mechanic or change the cave's lighting before continuing development.



### \### Connection to Previous Development Plan



My previous development plan included Issue #2, "Implement Guiding Flame Movement and Illumination." This task involved creating a floating flame that could move toward a hidden objective when the player pressed G.



Although I had already implemented the movement and basic lighting, I still needed to test whether the flame's illumination was sufficient for the player to navigate the cave.



The main risk was that the flame might move correctly without providing enough visibility for the player to follow it. This would undermine one of Hollowlight's central gameplay mechanics.



### \## Pass/Fail Criteria



The Proof of Concept will pass if the player can successfully follow the guiding flame to its destination in three consecutive trials while using its light to navigate the dark cave.



The test must also work in a WebGL browser build.



## Test Results

**Unity Editor Testing**
- Trial 1: Passed
- Trial 2: Passed
- Trial 3: Passed

**Unity Editor Result:** Passed (3/3 trials).

During testing, I adjusted the guiding flame's
light range from 20 to 6. This created a smaller
area of illumination while keeping the cave dark.

**WebGL Browser Testing**
- Character movement: Passed
- Guiding flame activation (G key): Passed
- Flame illumination: Passed

**WebGL Result:** Passed.

**Overall PoC Status:** Passed.

The guiding flame successfully illuminated nearby
surroundings and helped the player navigate the
dark cave in three consecutive Unity Editor trials.
The mechanic also functioned in the browser build.

## Scope Update

**Must Have**
- Guiding flame movement and illumination
- Third-person player movement
- Functional WebGL build

**Should Have**
- Improved cave environment
- Player instructions and UI
- Short gameplay sequence

**Could Have**
- Sanity and perception mechanics
- Trust versus question decision system
- Additional player abilities

## Next Steps

Continue developing the cave environment,
improve player guidance and UI, and begin
implementing the sanity and decision systems
for the Alpha milestone.
