# Games Development Coursework

## Project brief

### An accompanying table where each of the requirements for the brief has been met by your game design

| Requirement | Summary     | How Met                                                      |
| ----------- | ----------- | ------------------------------------------------------------ |
| 1           | Scenes      | Two different places as levels, representing the same place at day and night |
| 2           | State       | A game system that allows the player to solve simple puzzles in a couple of actions |
| 3           | PhysX       | Player and a couple of other game objects implemented as `rigidbody` |
| 4           | Interaction | A click on certain objects will trigger a sequence of events/calls to action to solve a puzzle |
| 5           | Levels      | Moving the player into a particular area trigger a level switch |
| 6           | Persistence | Game stores puzzle progression, and modified game objects’ state |
| 7           | Scripts     | The following behaviors are implemented: **a)** When the player enters a trigger area, a level switch occurs **b) & c)** Action on certain game objects make the puzzle-solving progress **d)** Immersive environment events occur randomly during the game (birds, clouds, …) |
| 8           | Input       | Configurable keyboard/mouse inputs for moving player and player actions |
| 9           | Raycasting  | When the player is not in sight of the sun/moon, the screen darkens |
| 10          | Audio       | Footsteps when players move, ambient sounds, sounds triggered on actions and puzzle solving |

### A discussion of the game, its key mechanics, and the thematic consistency

This game is based on simple puzzles that must be solved for the player to progress, in the context of a level switch that allows the player to access a day and night versions of the level.

The player can move in the environment, composed of "islands" floating in the sky. The islands are not all linked to each other, but a teleportation mechanism is present. Actions can be performed on certain elements of the environment to progress in the puzzles solving. The game is finished when the last puzzle has been solved.

Since the game is not bound to a particular epoch in time, the requirements are mostly related to the fantasy-like environment. Therefore the game elements' style is rustic (middle-age) with a touch of exotism (for the fantastic context). Birds and clouds randomly appear in the environment to enforce the idea that the game takes place in the sky. However, to blur the frontier between ocean and sky, the birds are seagulls, and an optional secret event related to this goal can be triggered (waves sound ?). The action to perform in order to trigger the event is described below:
>! Enter the Konami code (up, up, down, down, left, right, left, right, B, A)

#### Journey to the end

Each of the three following objectives has to be completed by solving a puzzle that includes switching the time, no matter the order.
- open the lighthouse's door after finding its key
- restore power after fixing the cables
- optional (depending on remaining time): deploying the docks by entering a code

Then there is a sequence of tasks to accomplish in the order they are described as following
- change the lighthouse's lamp after finding a new one
- go in the lighthouse to turn it on by pressing a button
- switch tonight and wait until a boat arrives
- jump into the boat

### An overview of the accessibility of your game, and where there may be room to improve this

All elements, either in the actual game or in the GUI, will have a recognizable shape so as to avoid confusion with other elements, so as to provide a clear interface regardless of eventual colorblindness.
Moreover, GUI elements will have a color directly related to their behavior to reduce cognitive demand to understand the GUI.

#### Input

The controls are the mouse and keyboard. Controllers behavior is described for each scope of the game. Basic motor functions and a certain level of hand-eye coordination are therefore required.

##### In the GUI menus

- mouse: a simple click
- keyboard : arrow keys + escape/enter keys

##### In the actual game

- GUI
  - mouse : simple click
  - keyboard : shortcuts
- game elements (including player) : keyboard arrow keys + escape/enter keys

#### Output

Sounds and visual effects as feedback in both menus and game to make the actions' results clear to the user.
Additionally, colorblind modes will be added to the game for people with common visual impairments.

### A user-testing plan which incorporates some form of external, qualitative testing of the game you have developed.

#### Tasks

The game can be split into several independent units of gameplay that represent the stages of game completion. The ability for the user to perform those tasks with few efforts is the main criteria of evaluation.

- start the game: begins when the user has access to the host machine, is considered finished when the environment is fully loaded
- move player in the environment: begins when the environment is fully loaded, is considered finished when all the basic player's movements have been realized
- perform actions: begins if the user is able to move in the game environment, is considered finished when a gameplay action on an object has been performed
- solve puzzles: begins in the user can perform a gameplay action, is considered finished when one or more puzzles have been solved
- finish game: begins if the user is able to solve at least one puzzle, is considered finished when the end screen appears

#### Open questions

To provide some extra information that is maybe not taken into account the task-solving evaluation, open questions can be asked to the test subject. They may produce answers that outline unexpected aspects of the game and do not emphasize one aspect of the game in particular.

> What do you think of the game?

> Have you encountered any problems?

> What did you like/dislike?

> Is there anything else you want to say?