### Introduction To Block Breaker ###

+ 2D Collisions & destroying objects.
+ Triggering SFX and music.
+ Responding to mouse input.
+ Automated playtesting.
+ Build & share your own levels.

### Section 5 Game Design Document ###



### Your Block Breaker Assets ###



### Section 5 Notes ###



### Gimp Image Editing 101 ###

+ How to use [GIMP](https://www.gimp.org/) as an alternative to PhotoShop
+ Selecting in Gimp
+ Cropping and Scaling
+ Adjusting Colour and Exposure
+ Saving Your Image

### Creating A 2D Brick Sprite ###

+ Researching brick sizes.
+ Source an appropriate image.
+ Edit our brick sprites.
+ Create new project and import.

### Import The Menu System ###

+ Export the menus from Number Wizard UI.
+ Import to this project.
+ Customise the words & fonts.
+ Wire up the buttons.

### Playing Background Music ###

+ How persistent music improves quality.
+ Add a Music Player Game Object.
+ Add a music track of your choice.
+ Use **GameObject.DontDestroyOnLoad()**.
+ Test your music plays consistently.

**Useful Links**
+ Sounds - [Freesound.org](http://www.freesound.org/) 

### About Statics & Singletons ###

+ How a static can help us here.
+ Watch Unity's short video
+ Preventing duplicate music players.

**Useful Links** 
+ [Unity 3D Statics](https://unity3d.com/learn/tutorials/topics/scripting/statics)


### Using Static Variables ###



### A Note About The Music Manager ###

Explaining that we don't use the music manager again for a while.

### Execution Order & Singletons ###

+ Introducing Script Execution Order
+ Exactly when do scripts get called?
+ Debugging & explaining our music glitch
+ A simple fix using the **Awake()** method

**Useful Links**  
+ [Unity - Execution Order of Event Functions](http://docs.unity3d.com/Manual/ExecutionOrder.html)


### Z-Depth in 2D games ###

+ What z-depth means.
+ **The problem**: sprites becoming semi-transparent or invisible for unknown reasons.
+ **The solution**: look at the z-position of sprites relative to the background.

### Setting Up Your Play Space ###



### Ball + Gravity + Colliders = Fun ###

+ Add a ball to your space
+ Import the ball sprite to Sprites folder.
+ Set a sensible “Pixels Per Unit” value.
+ Place the ball in the middle of the play space.

### Colliders, Triggers & Collisions ###

+ What are colliders
+ If colliders overlap during a frame then…
+ … messages may be passed by the engine.
+ What is message passing?
+ Signatures of messages passed
+ Types of colliders explained

### Tidying Up Before Moving On ###

+ Delete Music Player on Level_01 scene.
+ Setting Game window to 800 x 600.
+ Two handy keyboard shortcuts.
+ Remove Canvas and Event System from Level_01.
+ Make loose collider load next level.

### Choosing Collider Type In Unity ###

+ Add our brick sprite as a player paddle.
+ Choosing our paddle collider type.
+ Rigid Body 2D
+ CHALLENGE: Add components to our paddle.

### Using Physics Materials ###

+ What is a physics material.
+ Add a bouncy material.
+ Observe funky physics.

### Movement By Mouse ###

+ Using **Input.MousePosition.x**
+ **Screen.width** to get screen width.
+ Move the paddle **this.transform.position**
+ Introducing **float** and **Vector3**.
+ Using **Mathf.Clamp** to constrain paddle.
+ Fix the paddle's “Pixels per unit” to 128.

**Useful Links**  
+ [Unity - Scripting API](https://docs.unity3d.com/ScriptReference/)


### Launching Ball On Mouse Click ###

+ Start the ball sitting on the paddle.
+ Capture the relative position from the editor.
+ Respond to **Input.GetMouseButtonDown(0)**.
+ **rigidbody2D.velocity** to launch the ball.
+ Using **bool hasStarted** to keep track.

### Invisible Colliders & Gravity Scale ###

+ Setup all your play space wall colliders.
+ Adjust the initial velocity and gravity.
+ Understanding Gravity Scale

### Creating & Using Unity Prefabs ###

+ What is a prefab in Unity
+ Why prefabs are useful.
+ Setting up your prefabs.
+ How prefab linking works.

### Unity Editor Snap To Grid ###

+ How Edit > Snap Settings works.
+ Snap initially to get on the grid.
+ You can do this with multi-select.
+ Hold cmd (ctrl) while dragging!
+ Build your first level

### Making Everything A Prefab ###

+ Make everything a prefab!
+ Set Main Camera background to black.
+ Move & group Loose Collider.
+ Test by making new level.

### GameObject.FindObjectOfType ###

+ Why linking prefabs programmatically helps.
+ Unity doesn't support “nested prefabs”.
+ How to use **GameObject.FindObjectOfType< >**
+ Link the ball to the paddle programatically.
+ Challenge: do this for LevelManager

### Level Build Order ###

+ Create Loose Scene, modify **LooseCollider.cs**
+ Add **LoadNextLevel()** to **LevelManager.cs**
+ Add all our levels to Project > Build Settings
+ Modify **Block.cs** by adding **SimulateWin()**
+ Test that game transitions between levels

### Destroying When Hit ###

+ How the **Destroy()** method works.
+ Why we destroy **gameObject** not **this**.
+ Challenge: only destroy on max hits

**Useful Links**  
+ [Unity Scripting API - Object Destroy](https://docs.unity3d.com/ScriptReference/Object.Destroy.html)

### Importing Sprite Sheets ###

+ Why a sprite sheet is useful.
+ Key features of a sprite sheet.
+ Creating sprites for partially broken blocks.
+ Importing sprites into Unity.

### Swapping Sprites In Script ###

+ The affordance principle
+ What is an array?
+ Using arrays to store these sprites.
+ Loading sprite when hit.

### Consolidating Hit Counting ###

+ What are tags?
+ Why tags are useful for keeping track.
+ Tagging unbreakable bricks.
+ Use tags to decide when level is won.

**Useful Links**  
+ [Unity - Tags](https://docs.unity3d.com/Manual/Tags.html)

### Statics To Detect Win Condition ###

+ Why loading levels could be problematic.
+ How a static **Brick** variable can help.
+ Keeping track of breakable bricks in the level.
+ Creating a simple **BrickDestroyed** “message”.
+ Testing inc. when 2 bricks destroyed at once.

### Playing Sound Effects On Impact ###

+ Using **audio.Play()** to play “boing” sound;
+ Why **AudioSource.PlayClipAtPoint** useful.
+ Using this for playing “crack”.
+ Test & demonstrate.

### Using Random.Range() ###



### Automated Play Testing ###

+ Create & tidy your levels
+ Ensure Hierarchy is tidy in each level.
+ Give each level a different 800x600 background.
+ Play test all the levels.
+ Ensure level order is right in File > Build Order.

### Build & Share On The Web ###

+ Revising setting your Game window.
+ How to tweak sound levels.
+ Doing a test web build and playing locally.
+ Revising building and sharing to web.
+ Looking forward to seeing your levels!

**Useful Links**  
+ [Unity Scripting API - AudioSource](https://docs.unity3d.com/ScriptReference/AudioSource.html)

### Fixing User Reported Bugs ###

+ How to reproduce the problem?
+ Debug to find the root cause.
+ Make the fix, and re-test.
+ Remove debug code.
+ Challenge: Fix the bug

### More Complex Collider Shapes ###

+ What's a polygon collider.
+ Why it can help us improve our game.
+ How to manipulate polygon colliders.
+ Challenge: Chamfer your paddle.

### Making Code Extendable ###

+ The coding trade off triangle.
+ Think about your future self on the project.
+ Renaming a game object and class.
+ Using Debug.LogError().

### Using Particle Systems ###

+ Create a simple particle system.
+ Make brick look like it goes “up in smoke”.
+ Write code to trigger smoke puffs.
+ Tweak the smoke prefab while play testing.

**Useful Links**  
+ [Unity Manual - Particle Systems](https://docs.unity3d.com/Manual/ParticleSystems.html)
+ [Unity Scripting API - Object Instantiate](https://docs.unity3d.com/ScriptReference/Object.Instantiate.html)

### BB Unity 5 Upgrade & WebGL Build ###

OPTIONALLY converting your project to Unity 5, and sharing with Web GL.

### DOWNLOAD Section 5 Unity Project ###



### Section 5 Wrap Up ###

+ Recap and what's next
+ Congratulations, you've learnt a lot.
+ Make your own levels.
+ Ask a friend to make levels.
+ Care with commercial music.
+ Share your creation with our fantastic [community](https://community.gamedev.tv/c/unity/S05-blockbreaker), or on our [Complete Unity Developer Facebook Group](https://www.facebook.com/groups/completeunitydeveloper/).
