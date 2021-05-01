using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance { get; private set; }
    private AudioSource audio;


    void Awake()
    {
        //Destroys the second instance of the subtitles 
        //To destroy the first instance use Intstance == this
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;
        audio = gameObject.AddComponent<AudioSource>();
    }

    public void BeginDialogue(AudioClip passedClip)
    {

    }

}
