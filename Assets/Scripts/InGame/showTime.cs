 using UnityEngine;
 using System.Collections;
 
 public class showTime : MonoBehaviour {    

 //display time left before victory
 void OnGUI()
 {
     GUILayout.Label( "Time = " + SpawnObstacle.timeLeft);
 }    
 }
