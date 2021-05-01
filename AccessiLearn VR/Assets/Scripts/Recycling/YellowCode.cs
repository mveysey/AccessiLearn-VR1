using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCode : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("yellow"))
        {
            gameObject.SetActive(false);
            SortingCompleted.addthePoints(1);
        }
    }
}
