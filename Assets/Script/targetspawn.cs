using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetspawn : MonoBehaviour
{
    public GameObject target;
    GameObject newTarget;
    public float spawnTime;
    public float spawnDelay;
    void Start() {
        InvokeRepeating("spawnObject",spawnTime,spawnDelay);
    }
    public void spawnObject()
    {
        if(!newTarget){
            newTarget = Instantiate(target, transform.position, transform.rotation);
        }
        else{
            newTarget.transform.localScale -= new Vector3 (0.5f, 0.5f, 0.5f);
            if(newTarget.transform.localScale == new Vector3(0.5f,0.5f,0.5f)){
                Destroy(newTarget.gameObject);
            }
        }
    }
}
