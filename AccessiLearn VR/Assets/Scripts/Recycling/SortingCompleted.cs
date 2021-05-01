using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SortingCompleted : MonoBehaviour
{
    private static int points = 0;
    public Text text;

    void Start()
    {
        text.text =  displayPoints()+ "/10";
    }
    void Update()
    {
        text.text = displayPoints() + "/10";
    }
    public static int displayPoints()
    {
        return points;
    }

    public static void addthePoints(int p)
    {

        points = points + p;
        if (points == 10)
        {
            TeleportMain.Teleport();
            resetPoints();
            
        }



    }

    public static void resetPoints()
    {
        points = 0;
    }
}