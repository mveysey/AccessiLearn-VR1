using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public GameObject emotionGuide;
    public GameObject zooGuide;
    public GameObject recyclingGuide;
    public GameObject discoGuide;
    public GameObject storyGuide;

    void Start()
    {
        StartCoroutine(Test());
    }

    IEnumerator Test()
    {
        yield return new WaitForSeconds(5);
        emotionGuide.SetActive(true);
    }
    public void EmotionTour()
    {
        emotionGuide.SetActive(true);
    }

    public void ZooTour()
    {
        zooGuide.SetActive(true);
    }

    public void RecyclingTour()
    {
        recyclingGuide.SetActive(true);
    }

    public void DiscoTour()
    {
        discoGuide.SetActive(true);
    }

    public void StoryTour()
    {
        storyGuide.SetActive(true);
    }
}
