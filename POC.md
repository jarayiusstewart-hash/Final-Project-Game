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



### \## Test Results



##### \*\*Unity Editor Testing\*\*



\- Trial 1: Passed

\- Trial 2: Passed

\- Trial 3: Passed



#### \*\*Unity Editor Result:\*\* Passed (3/3 successful trials).



During testing, I discovered that the flame's lighting needed adjustment. I reduced the FlameLight range from 20 to 6 to create a smaller area of illumination around the flame.



After adjusting the lighting, I successfully followed the flame to its destination three consecutive times.



\*\*WebGL Result:\*\* Pending verification of the updated lighting and navigation system.



\*\*Overall PoC Status:\*\* Partially passed — successful in the Unity Editor, with updated WebGL verification still required.

