# Drilling-Objects-In-VR

Drilling Objects In VR with Unity

<img src="https://github.com/saha0073/Drilling-Objects-In-VR/blob/main/capture.png" width="750">

In this project a 2D plate can be drilled by a drilling object. Here shader graph technique has been implemented to deform the mesh of the 2D plate in realtime. The object (here cube) releases particles, and based on the particle trace the mesh of the 2D plate gets deformed downward. An invisible cube is placed just below the 2D plate, and whenever the mesh of the deformed 2D plate enters into the invisible cube the mesh points becomes invisible thorugh using invisible shaers. So it looks like a hole in the mesh. And then Oculus Intereaction Toolkit has been used to bring the drilling the feature into the VR scene, so that the VR player can make holes in the 2D plate by holding the drilling object near to it.

## Techniques Used
* GameEngine: Unity3D 20
* Tech Stack: C#
* Techniques: Shader Graph, realtime mesh deformation, invisible shader, particle system
* Packages: Oculus Integration Toolkit, Oculus Interaction SDK

## Recording of running PlayerController in Quest2
The`./Recordings` folder contains several recordings during the game play, like as shown below,
<p align="center"><img src="https://github.com/saha0073/Drilling-Objects-In-VR/blob/main/Recordings/oculus_drilling_8sec.gif" style="width:80%"\></p>

The drilling on objects has been inspired from Snow Tracks Shader by [Mert Kirimgeri](https://www.youtube.com/watch?v=ThlqTMBzyjI&ab_channel=MertKirimgeri).  
