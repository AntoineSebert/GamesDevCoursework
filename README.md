# Games Development Coursework

## Project brief

This submission should include the following, produced as a 1000 word report.

### An accompanying table where each of the requirements for the brief have been met by your game design

#### Requirements

1. Two scenes, each consisting of a game terrain, each consisting of a suitable plane, with applied textures, texture painting, and a variety of game objects.
2.	The storing and manipulation of persistent game state, through a script, or set of scripts, accessed externally by appropriate game objects.  This might keep track of score, lives, health and so on.  It should also feed data directly into other game objects or subsystems as required.
3.	The inclusion of at least two game objects which implement the PhysX engine, along with the application of a custom physic material which you design yourself.
4.	Some form of interaction with a game object, triggered through the user interface that you present.
5.	A level loader system implemented either through transitions within the game environment, or through a GUI selector.
6.	Persistence of player state data between executions of the game, implemented through an appropriate save and reload system.
7.	Scripts which implement actions for the following:
	a.	A player entering a trigger zone
	b.	A rigidbody colliding with the player
	c.	A rigidbody colliding with another rigidbody
	d.	Some ongoing management of game state
8.	User input via mouse, keyboard and/or touch controls which trigger the instantiation and placing of prefabs within the game environment.
9.	An example of using raycasting to identify objects within the player’s direct field of view.
10.	Game audio which is triggered in relation to player actions.

#### Example

| Requirement | Summary | How Met |
| -- | -- | -- |
|1|Scenes|Two levels of the game, each representing the interior of a different house.|
|2|State|A game state system which handles treasure gathering and health of the player.|
|3|PhysX|Guard objects implemented as rigidbodies, and treasure chests.|
|4|Interaction|Treasure chests will open when clicked, depositing ‘treasure objects’ around them.|
|5|Levels|Levels loaded through trigger areas reached when the player has made it through to the end of the terrain.|
|6|Persistence|Game stores achievements for the player such as ‘most treasure found’ and ‘longest time spent hidden’|
|7|Scripts|The following behaviours are implemented: **1)** When the player enters a trigger area, they are transitioned to the next/previous level **2)** When a guard object collides with the player, the game is over **3)** If a guard object collides with a player’s projectile, they are knocked unconscious **4)** Score is stored and updated based on gathered treasures|
|8|Input|Touch controls handle moving around.  Tapping the screen opens a chest. Additionally, mouse controls and keyboard controls permitted.|
|9|Ray-casting|The player is visible to a guard if there is a ray-cast line between the way the guard is facing and the player.|
|10|Audio|When the player moves, footstep sounds are triggered.  When a guard hears a footstep, they turn towards the player.|

### A discussion of the game, its key mechanics, and the thematic consistency.

### An overview of the accessibility of your game, and where there may be room to improve this.

### A user-testing plan which incorporates some form of external, qualitative testing of the game you have developed. 
