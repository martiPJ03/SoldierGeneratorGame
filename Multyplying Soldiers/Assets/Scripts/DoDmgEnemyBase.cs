using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDmgEnemyBase : MonoBehaviour
{
    public int dmg;
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
        if (other.tag == "EnemyBase") 
        {
            other.gameObject.GetComponent<Health>().TakeDmg(dmg);
            Destroy(gameObject);
        }
    }
}
