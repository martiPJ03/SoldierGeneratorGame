using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnCollisionWEnemy : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealth>().takeDmg();
            takeDmg();
        }
    }

    private void takeDmg()
    {
        health -= 1;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
