using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryBookDialogueManager : MonoBehaviour
{
    public GameObject Cover;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;
    public GameObject P6;
    public GameObject P7;
    public GameObject P8;
    public GameObject P9;


    public AudioClip S1;
    public AudioClip S2;
    public AudioClip S3;
    public AudioClip S4;
    public AudioClip S5;
    public AudioClip S6;
    public AudioClip S7;
    public AudioClip S8;
    public AudioClip S9;

    AudioSource audioSource;

    private int audioNumber = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!audioSource.isPlaying && audioNumber == 1 && HandleButton.clicked)
        {
            audioNumber++;

            audioSource.clip = S2;
            audioSource.Play();
        }

        if (!audioSource.isPlaying && audioNumber == 2 && HandleButton.clicked)
        {
            audioNumber++;

            audioSource.clip = S3;
            audioSource.Play();
        }

        if (!audioSource.isPlaying && audioNumber == 3 && HandleButton.clicked)
        {
            audioNumber++;

            audioSource.clip = S4;
            audioSource.Play();
        }

        if (!audioSource.isPlaying && audioNumber == 4 && HandleButton.clicked)
        {
            audioNumber++;

            audioSource.clip = S5;
            audioSource.Play();
        }

        if (!audioSource.isPlaying && audioNumber == 5 && HandleButton.clicked)
        {
            audioNumber++;

            audioSource.clip = S6;
            audioSource.Play();
        }
        if (!audioSource.isPlaying && audioNumber == 6 && HandleButton.clicked)
        {
            audioNumber++;

            audioSource.clip = S7;
            audioSource.Play();
        }
        if (!audioSource.isPlaying && audioNumber == 7 && HandleButton.clicked)
        {
            audioNumber++;

            audioSource.clip = S8;
            audioSource.Play();
        }
        if (!audioSource.isPlaying && audioNumber == 8 && HandleButton.clicked)
        {
            audioNumber++;

            audioSource.clip = S9;
            audioSource.Play();
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "object")
        {
            audioNumber++;
            audioSource.clip = S1;
            audioSource.Play();
            Destroy(other.gameObject);

        }
    }
}
