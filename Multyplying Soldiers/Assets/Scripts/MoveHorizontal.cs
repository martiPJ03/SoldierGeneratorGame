using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontal : MonoBehaviour
{
    private Rigidbody myRb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        myRb.velocity = Vector3.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 5f)
        {
            myRb.velocity = Vector3.left * speed;
        }
        if (transform.position.x < -5f)
        {
            myRb.velocity = Vector3.right * speed;
        }

    }
}
