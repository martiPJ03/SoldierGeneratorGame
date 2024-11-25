using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // Calls GenerateSoldier every 1 second, with no initial delay
        InvokeRepeating("GenerateSoldier", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenerateSoldier()
    {
        float randomX = Random.Range(-5f, 5f);
        Instantiate(enemyPrefab, (transform.position + new Vector3(randomX, 0f, 2f)), Quaternion.Euler(0,180, 0));
    }
}
