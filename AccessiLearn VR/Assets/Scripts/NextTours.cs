using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTours : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;
    public Transform pos5;
    public float speed = 8f;
    public static int station;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public static void SetStation(int sta)
    {
        station = sta;

    }
    // Update is called once per frame
    void Update()
    {
        if (station == 1)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, pos1.position, speed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
        }
        if (station == 2)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, pos2.position, speed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
        }
        if (station == 3)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, pos3.position, speed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
        }
        if (station == 4)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, pos4.position, speed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
        }
        if (station == 5)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, pos5.position, speed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
        }
        Targeting();

    }
    public void Targeting()
    {
        if (station == 1)
        {
            transform.LookAt(pos1);
        }
        if (station == 2)
        {
            transform.LookAt(pos2);
        }
        if (station == 3)
        {
            transform.LookAt(pos3);
        }
        if (station == 4)
        {
            transform.LookAt(pos4);
        }
        if (station == 5)
        {
            transform.LookAt(pos5);
        }

    }
}
