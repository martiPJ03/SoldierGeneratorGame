using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefineColorFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
