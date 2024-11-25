using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateSoldiers : MonoBehaviour
{
    // References to the prefabs
    public GameObject alliePrefab;
    public GameObject enemyPrefab;

    // Offset distance from the collided object for instantiation
    public Vector3 spawnOffset = new Vector3(0.5f, 0, -0.1f);  // Example offset, modify as needed

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
        // Check for ally tag and instantiate ally prefab
        if (other.tag == "Allie")
        {
            if (other.gameObject.GetComponent<ManageDuplication>().getCanDuplicate())
            {
                other.gameObject.GetComponent<ManageDuplication>().StartCountDownDuplicate();
                Vector3 spawnPosition = other.transform.position + spawnOffset;
                other.transform.position = other.transform.position - spawnOffset;
                Instantiate(alliePrefab, spawnPosition, Quaternion.identity);
            }
        }
        // Check for enemy tag and instantiate enemy prefab
        else if (other.tag == "Enemy")
        {
            if (other.gameObject.GetComponent<ManageDuplication>().getCanDuplicate())
            {
                other.gameObject.GetComponent<ManageDuplication>().StartCountDownDuplicate();
                Vector3 spawnPosition = other.transform.position + spawnOffset;
                other.transform.position = other.transform.position - spawnOffset;
                Instantiate(enemyPrefab, spawnPosition, Quaternion.Euler(0,180,0));
            }
        }
    }
}