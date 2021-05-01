using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewDialogueManager : MonoBehaviour
{
    public Text dialogueDisplay;

    public AudioClip S1;
    public AudioClip S2;
    public AudioClip S3;
    public AudioClip S4;
    public AudioClip S5;
    public AudioClip S6;
    public AudioClip S7;
    public AudioClip S8;
    AudioSource audioSource;

   

    [TextArea(3, 30)]
    public string[] sentences;
    private int index;
    private int audioNumber = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!audioSource.isPlaying && audioNumber == 1)
        {
            Debug.Log("hi");
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[1];
            audioSource.clip = S2;
            audioSource.Play();

            Debug.Log("bye");
        }

        if (!audioSource.isPlaying && audioNumber == 2)
        {
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[2];
            audioSource.clip = S3;
            audioSource.Play();
        }

        if (!audioSource.isPlaying && audioNumber == 3)
        {
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[3];
            audioSource.clip = S4;
            audioSource.Play();
        }

        if (!audioSource.isPlaying && audioNumber == 4)
        {
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[4];
            audioSource.clip = S5;
            audioSource.Play();
        }

        if (!audioSource.isPlaying && audioNumber == 5)
        {
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[5];
            audioSource.clip = S6;
            audioSource.Play();
        }
        if (!audioSource.isPlaying && audioNumber == 6)
        {
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[6];
            audioSource.clip = S7;
            audioSource.Play();
        }
        if (!audioSource.isPlaying && audioNumber == 7)
        {
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[7];
            audioSource.clip = S8;
            audioSource.Play();
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "object")
        {
            audioNumber++;
            dialogueDisplay.text = sentences[0];
            audioSource.clip = S1;
            audioSource.Play();
            Destroy(other.gameObject);

        }
    }
    

    

    public void NextSentence()
    {

        if (!audioSource.isPlaying && audioNumber == 1)
        {
            Debug.Log("hi");
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[1];
            audioSource.clip = S2;
            audioSource.Play();

            Debug.Log("bye");
        }

        if (!audioSource.isPlaying && audioNumber == 2)
        {
                index++;
                audioNumber++;

                dialogueDisplay.text = sentences[2];
                audioSource.clip = S3;
                audioSource.Play();
        }

            if (!audioSource.isPlaying && audioNumber == 3)
            {
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[3];
            audioSource.clip = S4;
            audioSource.Play();
        }

            if (!audioSource.isPlaying && audioNumber == 4)
            {
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[4];
            audioSource.clip = S5;
            audioSource.Play();
        }

            if (!audioSource.isPlaying && audioNumber == 5)
            {
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[5];
            audioSource.clip = S6;
            audioSource.Play();
        }
            if (!audioSource.isPlaying && audioNumber == 6)
            {
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[6];
            audioSource.clip = S7;
            audioSource.Play();
        }
            if (!audioSource.isPlaying && audioNumber == 7)
            {
            index++;
            audioNumber++;

            dialogueDisplay.text = sentences[7];
            audioSource.clip = S8;
            audioSource.Play();
        }
    }
}
