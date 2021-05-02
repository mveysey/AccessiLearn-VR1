using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour
{
    public GameObject S1;
    public GameObject S2;
    public GameObject S3;
    public GameObject S4;
    public GameObject S5;
    public GameObject S6;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Sequence());
        
    }
    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(5f);
        S1.SetActive(false);
        yield return new WaitForSeconds(15.501f);
        S2.SetActive(false);
        yield return new WaitForSeconds(21f);
        S3.SetActive(false);
        yield return new WaitForSeconds(14.199f);
        S4.SetActive(false);
        yield return new WaitForSeconds(14.301f);
        S5.SetActive(false);
        yield return new WaitForSeconds(13.5f);
        S6.SetActive(false);


    }




}
