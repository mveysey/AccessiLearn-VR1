using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCode : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("green"))
        {
            gameObject.SetActive(false);
            SortingCompleted.addthePoints(1);
        }
    }
}
