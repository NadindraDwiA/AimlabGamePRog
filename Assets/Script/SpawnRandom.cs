using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    // public static int spawnedTarget;
    public GameObject target;
    GameObject newTarget;
    public float spawnTime;
    public float spawnDelay;
    void Start() {
        InvokeRepeating("spawnObject",spawnTime,spawnDelay);
    }
    public void spawnObject()
    {
        float randomX = Random.Range(-16,18);
        float randomY = Random.Range(1,11);
        newTarget = Instantiate(target, new Vector3(randomX,randomY,13), transform.rotation);
        Destroy(newTarget.gameObject,5);
    }
}
