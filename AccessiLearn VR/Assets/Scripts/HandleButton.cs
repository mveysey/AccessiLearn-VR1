using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleButton : MonoBehaviour
{
    public static bool clicked = false;

    void LateUpdate()
    {
        clicked = false;
    }

    public void Click()
    {
        clicked = true;
    }
}

