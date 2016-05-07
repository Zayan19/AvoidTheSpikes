using UnityEngine;
using System.Collections;

public class spikeMove : MonoBehaviour {

    private int timeToLive=1000; //how long before a spike is destroyed in the scene
    public static float speed; //speed of the spikes, depends on level chosen
	
	void Update () {
        //move the spike to the left based off speed set, depends on level chosen
            transform.Translate(speed,0f,0f,Space.World);
            //Rotate the spike
            transform.Rotate(0f,0f,2f);
            timeToLive--; //decrement the time to live counter

            //destroy the spike after a certain amount of time
if (timeToLive==0){
	 Destroy(gameObject);}

	
	}
    
    //if spike collides with the player go to the lose scene
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag=="Player"){ 
		  Destroy(other.gameObject);
          Application.LoadLevel("loseScene");
		} 


    }
}
