# Hollowlight

**A 3D Psychological Adventure and Exploration Game**

## Game Description

Hollowlight is a 3D psychological adventure game inspired by Plato's *Allegory of the Cave*.

The story follows a mysterious man who awakens inside a pitch-black cave with no memory of how he arrived there. Lost and surrounded by darkness, he encounters a small, comforting flame that offers to guide him through the unknown.

The flame becomes his only source of light and direction. However, as the journey progresses, an important question emerges:

**Can the light guiding you always be trusted?**

Hollowlight explores themes of trust, perception, reality, and the consequences of blindly following guidance.

## Core Mechanic — Guiding Flame

The current proof of concept focuses on the **Guiding Flame and Light Reveal** mechanic.

Players can:

- Explore a dark 3D environment using third-person movement.
- Use a floating flame as their primary source of illumination.
- Press **G** to send the flame toward a hidden objective.
- Watch the objective become illuminated when the flame reaches it.
- Recall the flame to the player.
- Follow the revealed path and reach the objective to complete the prototype.

This mechanic demonstrates the player's dependence on the flame to discover what is hidden in the darkness.

## Controls

| Key | Action |
|---|---|
| W, A, S, D | Move |
| Mouse | Look around |
| G | Guide or recall the flame |
| Esc | Unlock mouse cursor |

## Planned Features

Future development goals include:

- **Sanity and Perception System:** A meter that changes how the player experiences and interprets reality.
- **Trust vs. Question Mechanic:** Decisions where players choose whether to follow the flame or question its guidance.
- **Environmental Puzzles:** Exploration challenges that require observation and interaction.
- **Guiding Flame Abilities:** Unique abilities connected to the flame and its illumination.
- **Psychological Narrative:** A deeper story exploring truth, illusion, trust, and free will.
- **Cave Exploration:** A larger navigable environment containing hidden paths, discoveries, and challenges.

## Development Information

- **Engine:** Unity 6
- **Language:** C#
- **Platform:** PC / Web Browser (Unity Web)
- **Development:** Solo
- **Current Stage:** Core Mechanic Proof of Concept
- **Target Audience:** Ages 13+
- **Final Project Deadline:** December 6, 2026

## Project Goal

The goal of this prototype is to demonstrate Hollowlight's central gameplay concept: using a mysterious guiding flame to reveal hidden objectives in an otherwise dark environment.

The prototype serves as the foundation for expanding Hollowlight into a larger psychological adventure game.

The final project aims to deliver a short, playable experience that demonstrates the game's central themes through interactive mechanics.

## Development Risks and Mitigation

Because Hollowlight is being developed by a solo developer, careful planning and scope management are important.

The following risks have been identified:

| Risk | Potential Impact | Mitigation Strategy |
|---|---|---|
| WebGL performance problems | Lighting and visual effects may reduce browser performance. | Use lightweight lighting, limit expensive effects, and test browser builds regularly. |
| Sanity system complexity | Environmental changes and perception effects may take longer than expected. | Begin with a basic meter and one visual effect before expanding the system. |
| Trust vs. Question mechanic | Connecting player decisions to gameplay systems may be challenging. | Implement one meaningful choice with clear feedback before adding additional decisions. |
| Limited development time | Solo development may make it difficult to complete every planned feature. | Prioritize essential gameplay mechanics and a short, complete experience. |
| Cave environment development | Building a large 3D cave could require significant time and optimization. | Create a small, reusable cave environment using modular geometry. |
| Last-minute build failures | Unity Web builds or itch.io uploads may encounter unexpected errors. | Test browser builds throughout development and publish before the final deadline. |

### Risk Management Strategy

The development approach prioritizes functionality before complexity.

Each mechanic will first be implemented in a simple, testable form. Additional visual effects, environmental details, and gameplay complexity will be added only after the core systems function reliably.

If development falls behind schedule, optional features will be reduced to protect the completion of the main gameplay experience.

## Development Milestones

The following milestones establish a realistic development schedule leading to the final project deadline.

| Target Date | Milestone | Deliverables |
|---|---|---|
| October 28, 2026 | Proof of Concept Complete | Third-person movement, guiding flame, objective reveal, completion trigger, Web build, and itch.io publication |
| November 10, 2026 | Core Gameplay Systems | Trust vs. Question mechanic and sanity/perception system |
| November 17, 2026 | Playable Cave Environment | Navigable cave environment and expanded guiding flame abilities |
| November 24, 2026 | Gameplay Integration and UI | Short playable sequence, integrated mechanics, and player instructions |
| December 1, 2026 | Testing and Optimization | Bug fixes, browser performance testing, and gameplay improvements |
| December 6, 2026 | Final Release and Documentation | Final playable build, updated README, completed project documentation, and submission |

These milestones are planning targets and may be adjusted based on development progress.

## Project Management

Hollowlight uses **GitHub Projects** to organize and track development.

**Project Board:** [HollowLight - Development Roadmap](https://github.com/users/jarayiusstewart-hash/projects/1)

The board contains three development stages:

- **Todo:** Planned features and tasks that have not yet been started.
- **In Progress:** Features currently being implemented or tested.
- **Done:** Completed and tested tasks.

Development work is tracked through GitHub Issues connected to the project board.

Issues include descriptions, development goals, and milestone assignments.

### Completed Proof-of-Concept Tasks

- Third-person player movement and camera controls.
- Guiding flame movement and illumination.
- Hidden objective reveal mechanic.
- Objective completion trigger.
- Unity browser build and testing.
- Prototype publication on itch.io.

### Planned Development Tasks

- Implement Trust vs. Question choice mechanic.
- Implement sanity and perception system.
- Create a playable 3D cave environment.
- Expand flame guidance and player abilities.
- Implement a short gameplay sequence.
- Add player interface and instructions.
- Complete final testing and browser optimization.
- Prepare final release and documentation.

## Team Roles and Ownership

**Team Structure:** Solo Developer

As the sole developer, I am responsible for:

- Gameplay programming and mechanics.
- Player movement and camera systems.
- Guiding flame behavior and abilities.
- Level and environment design.
- User interface development.
- Testing, debugging, and optimization.
- GitHub project management.
- Web build creation and itch.io publishing.

All GitHub development issues are assigned to the solo developer.

If additional team members join later, responsibilities and issue ownership will be updated accordingly.

## Scope and Development Priorities

To keep the project achievable by December 6, development is divided into essential and optional features.

### Essential Features

- Functional third-person movement.
- Guiding flame mechanic.
- Navigable cave environment.
- At least one Trust vs. Question decision.
- Basic sanity/perception system.
- A short gameplay sequence with a clear ending.
- Playable browser build.

### Optional Features

- Additional flame abilities.
- Multiple environmental puzzles.
- Expanded visual perception effects.
- Multiple branching decisions.
- Additional cave areas and story content.

Optional features will only be developed after the essential systems are working.

## Testing and Quality Assurance

Hollowlight will be tested throughout development in both the Unity Editor and a desktop web browser.

Testing will focus on:

- Reliable player movement and camera controls.
- Correct guiding flame behavior.
- Proper objective reveal and completion.
- Functional player decisions and perception changes.
- Acceptable browser performance.
- Clear gameplay instructions.
- Successful completion of the playable experience.

Browser builds will be tested regularly to identify compatibility or performance problems before the final release.

## Project Links

- **GitHub Repository:** [Final-Project-Game](https://github.com/jarayiusstewart-hash/Final-Project-Game)
- **GitHub Project Board:** [HollowLight - Development Roadmap](https://github.com/users/jarayiusstewart-hash/projects/1)
- **Playable Prototype:** Published on itch.io (https://jarayiusstewart-hash.itch.io/hollowlight).

## Final Vision

Hollowlight is intended to challenge the player's relationship with guidance, truth, and perception.

Rather than simply following a source of light through darkness, players will gradually confront the possibility that the very thing helping them may also be controlling what they are allowed to see.

**The central question remains: Can the light guiding you always be trusted?**
