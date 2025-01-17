[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Objects:
- Player (bunny)
    - Player aesthetics
    - Bunny (white/purple)
- Seeds/Plant
    - Plant aesthetics 
        - Green leaves
- UI
    - Seeds planted
    - Seeds remaining

Attributes/Actions:
- Player movement:
    - Actions:
        - WASD and space key to plant
        - Plantings / pressing space 
        - Seed prefab to create a clone when player presses space 
        - UI to change when player presses space 

Plants:
- When player presses space, the plant is placed at the player’s location 
- Only one seed at a time 

Affect:
- The plants are planted specifically at the player’s location
    - After planting 5 seeds, the player will not be able to plant anymore
    - The player is limited to plant
- UI
    - Depending on how many seeds are planted, the UI changes the number of seeds remaining/planted
- When player plants a seed:
    - Seeds planted UI goes up
    - Seeds remaining UI goes down 

## Devlog
Connection to the code:

Having a list of objects helped me recognize the ones that I was missing, which in this case was a plant so I created a gameobject called 'plant'. For the actions, I associted the movements of my sprite with the 'WASD' keys in the player script under Update(). The logic that lets the player 'plant' is located within the metod 'PlantSeed()'. Within this method, it recognizes how many seeds are left to plant and if the player can plant anymore seeds. It also updates the _numSeedsLeft and _numSeedsPlanted which are both used as an argument for UpdateSeeds in the PlantCountUI script.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for clearly connecting the break-down to your code! I'm also glad that the break-down helped you keep a list of all the objects you needed to create. :)

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. Also, make sure to put the in-class activity in the correct section. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
