using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private Rigidbody myRb;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        myRb.velocity = transform.forward * speed;
    }
}
