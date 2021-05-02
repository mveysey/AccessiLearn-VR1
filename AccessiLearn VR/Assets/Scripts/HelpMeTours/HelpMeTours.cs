using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMeTours : MonoBehaviour
{
    public Transform player;
    public float speed = 8f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, player.position, speed * Time.fixedDeltaTime);
        rb.MovePosition(pos);
        Targeting();

    }
    public void Targeting()
    {
        transform.LookAt(player);

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "emotion")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "zoo")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "story")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "recycling")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "dance")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
