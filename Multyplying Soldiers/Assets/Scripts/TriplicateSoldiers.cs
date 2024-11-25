using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriplicateSoldiers : MonoBehaviour
{
    // References to the prefabs
    public GameObject alliePrefab;
    public GameObject allieBuffPrefab;
    public GameObject enemyPrefab;

    // Offset distance from the collided object for instantiation
    public Vector3 spawnOffsetRight = new Vector3(1f, 0, -0.1f);  // Example offset, modify as needed
    public Vector3 spawnOffsetLeft = new Vector3(-1f, 0, -0.1f);  // Example offset, modify as needed

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
                if (other.gameObject.GetComponent<Identifier>().GetId() == 1)
                {
                    other.gameObject.GetComponent<ManageDuplication>().StartCountDownDuplicate();
                    Vector3 spawnPositionRight = other.transform.position + spawnOffsetRight;
                    Vector3 spawnPositionLeft = other.transform.position + spawnOffsetLeft;

                    Instantiate(allieBuffPrefab, spawnPositionRight, Quaternion.identity);
                    Instantiate(allieBuffPrefab, spawnPositionLeft, Quaternion.identity);
                }

                if (other.gameObject.GetComponent<Identifier>().GetId() == 0)
                {
                    other.gameObject.GetComponent<ManageDuplication>().StartCountDownDuplicate();
                    Vector3 spawnPositionRight = other.transform.position + spawnOffsetRight;
                    Vector3 spawnPositionLeft = other.transform.position + spawnOffsetLeft;

                    Instantiate(alliePrefab, spawnPositionRight, Quaternion.identity);
                    Instantiate(alliePrefab, spawnPositionLeft, Quaternion.identity);
                }

            }
        }
        // Check for enemy tag and instantiate enemy prefab
        else if (other.tag == "Enemy")
        {
            if (other.gameObject.GetComponent<ManageDuplication>().getCanDuplicate())
            {
                other.gameObject.GetComponent<ManageDuplication>().StartCountDownDuplicate();
                Vector3 spawnPositionRight = other.transform.position + spawnOffsetRight;
                Vector3 spawnPositionLeft = other.transform.position + spawnOffsetLeft;

                Instantiate(enemyPrefab, spawnPositionRight, Quaternion.Euler(0,180,0));
                Instantiate(enemyPrefab, spawnPositionLeft, Quaternion.Euler(0,180,0));
            }
        }
    }
}
