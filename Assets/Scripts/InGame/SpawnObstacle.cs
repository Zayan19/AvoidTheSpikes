
using UnityEngine;
using System.Collections;

public class SpawnObstacle: MonoBehaviour {


    public GameObject boulder; //the boulder object
    public Transform boulderSpawnPoint; //the place where the boulder will spawn
    public static int countime; //how frequently spikes can appear,this is set in the menu scene
    private int timeToCount;  //the time left before another spike appears
    public static int numOfObstacles; //the number of obstacles within the scene at once
    public static float timeLeft;  //the timeleft in the game
    float[] numbers = new float[5] {1, 12, 23, 34, 45}; //an array containing 5 Y coordinates the spike could appear

    void Start () {
        //set the time needed to win to 60
        timeLeft=60;
        timeToCount=countime;
    }


    void Update () {


        //spawn a spike if the time reaches 0
        if (timeToCount==0){

            //spawn a spike 90 percent of the time if the number of obstacles is 4 or less
            if (Random.Range(1, 10)<=9 && numOfObstacles<=4) {
                Instantiate(boulder,new Vector3(65f,numbers[Random.Range(0,5)],0f), boulderSpawnPoint.rotation);}
            numOfObstacles++;

            timeToCount=countime; //set the time left back to the count time
        }


        else {
            timeToCount--; //decrement the count time counter
            numOfObstacles = 0;
        }
    timeLeft -= Time.deltaTime; //decrease the time left in the game by real time (so it's 60 seconds in total)
    if (timeLeft<=0){
        Application.LoadLevel("winScene"); //if the player survives for 60 seconds, they win the game
    }
    }







}




