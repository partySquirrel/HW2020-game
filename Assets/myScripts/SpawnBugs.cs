using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBugs : MonoBehaviour
{
    public GameObject bug;
    public int amount;
    public float delay;

    public GameObject target;

    void Start()
    {
        StartCoroutine(BugSpawner());
    }
    IEnumerator BugSpawner() {
        int count = 0;
        while(count < amount) {
            int x = Random.Range(-3,3);
            int y = Random.Range(-3,3);
            Instantiate(bug, new Vector3(x, y, 0), Quaternion.identity);
            yield return new WaitForSeconds(delay);
            count++;
        }
    }
}
