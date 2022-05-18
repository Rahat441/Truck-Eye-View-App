# Truck-Eye-View-App
Read Me For instructions. Overview:
This is an app with 3 simple components, a menu screen, A part to learn and one part to drive around in a lifelike simulation of NYC. We used Unity to Develop the app making use of the libraries and free assets Unity provides.
Languages used: C# 100%
Scripts and functions:
Files and description, there is documentation within the code with every function to demonstrate how it works.
exampleMove.cs : This script generally takes care of the movement of the truck and any other functionality of the truck like seatbelt check. Basically it takes values from the user in the form of 1/-1, when they press buttons which tell the car it should move forward or backwards. Variable motor is the most important in this piece of code as the value of the motor determines where the object will end up in the 3D plane. The script takes colliders and wheel meshes as parameters/objects that it modifies. Which can be provided to the script with a simple drag and drop from Unity. Transformation part of the object is inside a function that is called every frame.
Fact.cs : menuSceneChange.cs: simple 1 line script to change scenes
changeImage.cs: This is a simple script with a bunch of if statements, which loops through cases when the button is pressed and presents the next sprite/image.
menuSceneChange.cs: 1 line script to move from menu scene to movePhysicsNYC scene.
Audio.cs: This script was pre written has a lot of comments on how it works. Basically it takes an object, in this example our truck object, and applies a simple sound track to it.
Installation:
1) Go to Unity’s Download Page and click “Download Installer for Windows”. A
UnityDownloadAssistant-x.x.exefile should be downloaded to your “Downloads”
folder (where x.x is the current Unity version).
2) Openthedownloadedinstaller.
3) SelectthecomponentsyouwouldliketobeinstalledwithUnityandclick“Next”.
Note: If you ever want to change the components, you can re-run the installer.
4) Dependingonthecomponentsyouselected,youmayseeadditionalpromptsbefore installing. Follow the prompts and click “Install”. Installing Unity may take some time.
After the installation is finished, Unity will be installed on your computer.
5) TouseUnityyouneedanaccount,Youcansetitupsimplyusingyourgmailand enjoy everything unity has to offer.
Scenes:
These are the different elements that come together to make the app functional .
movePhysicsNYC.unity scene: This is the scene with most assets. List of Assets: 1) Standard Assets.
2) Vehicle - pro 3d models
3)BrokenVector
4) TWD
If someone has the movePhysicsNYC scene and all these assets downloaded, they will just need to download the unity app to resume work.
Last part of this scene is the UI, which comprises 11 buttons. Four for movement, 3 for seat belt check, mirror check, tire check, 1 for menu screen and 1 for resetting the truck.
Menu.unity: Only one asset was used. Standard assets, this is needed to make the UI functional. It has the menu.cs script attached to it allowing it to move through different scenes.
Knowledge.unity: This scene makes use of the Standard assets along with the changeImage.cs to sort through the array of pictures equipping users with important facts and instructions.
