using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageDuplication : MonoBehaviour
{
    private bool canDuplicate;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDownDuplicateCo());
    }
    public void StartCountDownDuplicate()
    {
        StartCoroutine(CountDownDuplicateCo());
    }

    private IEnumerator CountDownDuplicateCo()
    {
        canDuplicate = false;
        yield return new WaitForSeconds(1);
        canDuplicate = true;
        yield return null;
    }

    public bool getCanDuplicate()
    {
        return canDuplicate;
    }
}
