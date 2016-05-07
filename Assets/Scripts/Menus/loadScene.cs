using UnityEngine;
using System.Collections;

public class loadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.A))
		{	 	
            Application.LoadLevel("MenuScene");
            SpawnObstacle.timeLeft = 300;
		}
	}
}
