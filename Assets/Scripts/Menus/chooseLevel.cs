using UnityEngine;
using System.Collections;

//this is used to tell the main menu buttons which variables to adjust difficulty
//also used to load audio depending on which level selected
//also used to load the scenes afterwards

public class chooseLevel : MonoBehaviour {
	
//beginner difficulty	
	public void Level1 () {
                    spikeMove.speed=-0.4f;
                    SpawnObstacle.countime=100;
                    playAudio.pickAudio=1;
                    Application.LoadLevel("GameScene");
	}
//increases speed of spikes as well as frequency
	public void Level2 () {
                    spikeMove.speed=-0.7f;
                    SpawnObstacle.countime=60;
                    playAudio.pickAudio=2;
                    Application.LoadLevel("GameScene");
	}

//increases speed and frequency further
	public void Level3 () {
                    spikeMove.speed=-0.9f;
                    SpawnObstacle.countime=40;
                    playAudio.pickAudio=3;
                    Application.LoadLevel("GameScene");
	}

//increases speed and frequency further
	public void Level4 () {
                    spikeMove.speed=-0.9f;
                    SpawnObstacle.countime=25;
                    playAudio.pickAudio=4;
                    Application.LoadLevel("GameScene");
	}

//load the Credits scene
	public void Credit () {
                    Application.LoadLevel("CreditsScene");
	}



    
}
