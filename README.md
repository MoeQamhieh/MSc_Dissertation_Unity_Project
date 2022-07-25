# MSc_Dissertation_Unity_Project
 Unity part of my MSc Robotics and Computation dissertation. The project uses ROS# to connect to the Astrobee Simulator in ROS (Gazebo). The VR interface is used as a teleoperation tool for the Astrobee.

* 25/07: 
  * Gaps exist in ISS model in all of Unity, Rviz and Gazebo. ISS model spawns upside down in Gazebo and Unity.
  * Docking station and Astrobee do not spawn in correct locations in Unity (only urdf used, config not checked)
  * Astrobee model is missing sensors and perching arm as the included items for them were commented from the *model.urdf.xacro* file before converting to *model.urdf*
  * Handrails' models were not imported to Unity. When spawned postioning was not right and they are not essential for the scope of the project so they were ommited for the time being.
