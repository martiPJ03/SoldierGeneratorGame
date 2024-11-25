using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SoldierGenerator : MonoBehaviour
{
    public GameObject soldierPrefab;
    public GameObject buffSoldierPrefab;
    public int number = 0;
    private float spawnInterval = 2f;
    public bool canChangeUnit = true;

    private float timeSinceLastSpawn = 0f; // Track the time since the last soldier was generated

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Start generating soldiers based on initial value of number
        UpdateSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        // Update the time since last spawn
        timeSinceLastSpawn += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Z) && canChangeUnit && number != 0)
        {
            number = 0;
            spawnInterval = 2f;
            UpdateSpawn();
            canChangeUnit = false;
            StartCoroutine(CanChangeCo(spawnInterval));
        }
        else if (Input.GetKeyDown(KeyCode.X) && canChangeUnit && number != 1)
        {
            number = 1;
            spawnInterval = 4f;
            UpdateSpawn();
            canChangeUnit = false;
            StartCoroutine(CanChangeCo(spawnInterval));
        }

        // Display the time since the last soldier was spawned
        //Debug.Log("Time since last soldier generated: " + timeSinceLastSpawn);
    }

    void GenerateSoldier()
    {
        if (number == 0)
        {
            Instantiate(soldierPrefab, (transform.position + new Vector3(0, -1.9f, 3f)), Quaternion.identity);
        }
        else if (number == 1)
        {
            Instantiate(buffSoldierPrefab, (transform.position + new Vector3(0, -1.9f, 3f)), Quaternion.identity);
        }
        animator.SetTrigger("GenerateSoldier");
        // Reset the time since the last spawn after generating a soldier
        timeSinceLastSpawn = 0f;
    }

    void UpdateSpawn()
    {
        // Cancel any previous invocations
        CancelInvoke("GenerateSoldier");

        float timeToSpawn = spawnInterval - timeSinceLastSpawn;
        if (timeToSpawn < 0) timeToSpawn = 0f;
        // Restart InvokeRepeating with the new interval
        InvokeRepeating("GenerateSoldier", timeToSpawn, spawnInterval);
    }

    private IEnumerator CanChangeCo(float spawnInterval)
    {
        yield return new WaitForSeconds(spawnInterval);
        canChangeUnit = true;
    }

    public void ChangeSoldierNumber0()
    {
        number = 0;
        spawnInterval = 2f;
        UpdateSpawn();
        canChangeUnit = false;
        StartCoroutine(CanChangeCo(spawnInterval));
    }
    public void ChangeSoldierNumber1()
    {
        number = 1;
        spawnInterval = 4f;
        UpdateSpawn();
        canChangeUnit = false;
        StartCoroutine(CanChangeCo(spawnInterval));
    }
}