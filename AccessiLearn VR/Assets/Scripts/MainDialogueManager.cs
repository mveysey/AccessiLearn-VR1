using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainDialogueManager : MonoBehaviour
{
    public GameObject tourGuide;

    public GameObject mainUI;
    public GameObject emotionUI;
    public GameObject recyclingUI;
    public GameObject storyUI;
    public GameObject zooUI;
    public GameObject danceUI;

    public Text mainText;
    public Text emotionText;
    public Text recyclingText;
    public Text storyText;
    public Text zooText;
    public Text discoText;

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
    
    private int audioNumber = 0;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!audioSource.isPlaying && audioNumber == 1)
        {
            audioNumber++;

            mainText.text = sentences[1];
            audioSource.clip = S2;
            audioSource.Play();
            
        }

        if (!audioSource.isPlaying && audioNumber == 7)
        {
            audioNumber++;

            discoText.text = sentences[7];
            audioSource.clip = S8;
            audioSource.Play();
        }
        if(audioNumber == 8)
        {
            danceUI.SetActive(false);
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "main")
        {
            mainUI.SetActive(true);
            audioNumber++;

            mainText.text = sentences[0];
            audioSource.clip = S1;
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "emotion")
        {
            mainUI.SetActive(false);
            emotionUI.SetActive(true);
            audioNumber++;

            emotionText.text = sentences[2];
            audioSource.clip = S3;
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "recycling")
        {
            emotionUI.SetActive(false);
            recyclingUI.SetActive(true);
            audioNumber++;
            recyclingText.text = sentences[3];
            audioSource.clip = S4;
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "story")
        {
            recyclingUI.SetActive(false);
            storyUI.SetActive(true);
            audioNumber++;
            storyText.text = sentences[4];
            audioSource.clip = S5;
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "zoo")
        {
            storyUI.SetActive(false);
            zooUI.SetActive(true);
            audioNumber++;
            zooText.text = sentences[5];
            audioSource.clip = S6;
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "dance")
        {
            zooUI.SetActive(false);
            danceUI.SetActive(true);
            audioNumber++;
            discoText.text = sentences[6];
            audioSource.clip = S7;
            audioSource.Play();
            Destroy(other.gameObject);
        }
    }
}
