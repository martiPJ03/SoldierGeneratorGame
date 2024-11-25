using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDmg()
    {
        health -= 1;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
