
using UnityEngine;
using System.Collections;

public class playAudio: MonoBehaviour {
    //set four audio clips, a different one for each level
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;
    public static int pickAudio;

    void Start () {
        GetComponent<AudioSource>().enabled=true; //enable audio
        chooseAudio(); //choose audio based off pickAudio which is set in the menu scene based off level chosen
        GetComponent<AudioSource>().Play(); //play the chosen audio
        
    }
    
    void chooseAudio(){
       switch (pickAudio)
	{

        case 1: //Level 1
            GetComponent<AudioSource>().clip=audio1;
            break;
        case 2: //Level 2
            GetComponent<AudioSource>().clip=audio2;
            break;
        case 3: //Level 3
            GetComponent<AudioSource>().clip=audio3;
            break;
        case 4: //Level 4
            GetComponent<AudioSource>().clip=audio4;
            break;
    }}


}
