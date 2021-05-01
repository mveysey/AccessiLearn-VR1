using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZooDialogueManager : MonoBehaviour
{

    public GameObject duckUI;
    public GameObject sheepUI;
    public GameObject catUI;
    public GameObject foxUI;
    public GameObject penguinUI;
    
    public Text duckText;
    public Text sheepText;
    public Text catText;
    public Text foxText;
    public Text penguinText;

    public AudioClip cat;
    public AudioClip sheep;
    public AudioClip fox;
    public AudioClip duck;
    public AudioClip penguin;
 
    AudioSource audioSource;



    [TextArea(3, 30)]
    public string[] sentences;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "duck")
        {
            duckUI.SetActive(true);

            duckText.text = sentences[0];
            audioSource.clip = duck;
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "cat")
        {
            catUI.SetActive(true);

            catText.text = sentences[1];
            audioSource.clip = cat;
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "sheep")
        {
            sheepUI.SetActive(true);

            sheepText.text = sentences[2];
            audioSource.clip = sheep;
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "fox")
        {
            foxUI.SetActive(true);

            foxText.text = sentences[3];
            audioSource.clip = fox;
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "penguin")
        {
            penguinUI.SetActive(true);

            penguinText.text = sentences[4];
            audioSource.clip = penguin;
            audioSource.Play();
            Destroy(other.gameObject);
        }
    }
}
