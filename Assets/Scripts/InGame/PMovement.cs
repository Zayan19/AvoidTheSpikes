using UnityEngine;
using System.Collections;

public class PMovement: MonoBehaviour {

	private float Speed = 10f;
	private float movex = 0f;
	private float movey = 0f;
	private Rigidbody2D rb;

	void Start () {
        //get the rigidBody of the player
		rb = GetComponent<Rigidbody2D>();
	}

	
	void Update () {
        //set the velocity of the rigidbody using the Speed variable 
		movex = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);
		

        //constantly add downwards force to the player
		GetComponent<Rigidbody2D>().AddForce(Vector3.down * 300);

        //if Z is pressed, start the flying coroutine
		if (Input.GetKeyDown (KeyCode.Z))
		{	 	
			StartCoroutine(Fly(12f, 0.00001f));
		}
	
	
		

	}


	IEnumerator Fly(float duration, float blinkTime) {
        //do an initial force of 3000 when Z is pressed
			GetComponent<Rigidbody2D>().AddForce(Vector3.up* (3000));

        //while Z is held down, add more upwards force to the player
		while (Input.GetKey(KeyCode.Z)&&duration>0) {
			GetComponent<Rigidbody2D>().AddForce(Vector3.up* (2000));
			duration = duration - 1;     
			yield return new WaitForSeconds(blinkTime);
		}

	}


}



