using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCode : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("blue"))
        {
            gameObject.SetActive(false);
            SortingCompleted.addthePoints(1);
        }
    }
}
