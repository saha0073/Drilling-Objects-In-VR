# Drilling-Objects-In-VR

Drilling Objects In VR with Unity

<img src="https://github.com/saha0073/Drilling-Objects-In-VR/blob/main/capture.png" width="750">

In this simulation a 2D plate is being drilled by a drill object (here a cube). Shader graph technique has been implemented to deform the mesh of the 2D plate in realtime. The drill object (here cube) releases particles whenever it goes, and based on the particle trace the mesh of the 2D plate gets deformed downward. An invisible plate is placed just below the 2D plate which has invisble shader material, and whenever the deformed mesh of the 2D plate enters into the invisible cube the mesh points becomes invisible due to the invisible shader, that in turn makes it look like a hole in the 2D plate. Finally the drilling feature has been integrated into the VR scene, and as a result the VR player can make holes in the 2D plate by moving the drill object near to the 2D plate.

## Techniques Used
* GameEngine: Unity3D 20
* Tech Stack: C#
* Techniques: Shader Graph, realtime mesh deformation, invisible shader, particle system
* Packages: Oculus Integration Toolkit, Oculus Interaction SDK

## Recording of playing the Drilling Scene in Quest2
The`./Recordings` folder contains several recordings during the game play, like as shown below,
<p align="center"><img src="https://github.com/saha0073/Drilling-Objects-In-VR/blob/main/Recordings/oculus_drilling_8sec.gif" style="width:80%"\></p>

The drilling implementation has been inspired from Snow Tracks Shader by [Mert Kirimgeri](https://www.youtube.com/watch?v=ThlqTMBzyjI&ab_channel=MertKirimgeri).  
