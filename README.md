# MSc_Dissertation_Unity_Project

## Unity part of my MSc Robotics and Computation dissertation. The project uses ROS# to connect to the Astrobee Simulator in ROS (Gazebo). The VR interface is used as a teleoperation tool for the Astrobee.
 
### Description:
- RosConnector GameObject handles rosbridge connection and contains subscribers 
- Two scenes available: (In /Assets/Scenes)
  - ThirdPersonView: User is detached from Astrobee and can teleport to fixed predifend points 
  - AstrobeeView: User is the Astrobee. Live feeds from nav_cam and dock_cam can be seen 
  
### Updates:
- 25/07: 
  - Gaps exist in ISS model in all of Unity, Rviz and Gazebo. ISS model spawns upside down in Gazebo and Unity.
  - Docking station and Astrobee do not spawn in correct locations in Unity (only urdf used, config not checked)
  - Astrobee model is missing sensors and perching arm as the included items for them were commented from the *model.urdf.xacro* file before converting to *model.urdf*
  - Handrails' models were not imported to Unity. When spawned postioning was not right and they are not essential for the scope of the project so they were ommited for the time being.

- 15/08:
  - Point Cloud not imported successfully 
  - Astrobee's Pose when received from ROS takes Astrobee back to the upside down model coordinates even if Astrobee GameObject is a child of the ISS GameObject
  
