using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spawnGerak : MonoBehaviour
{
    public GameObject target;
    GameObject newTarget;
    public float spawnTime;
    public float spawnDelay;
    private bool movingRight = true;
    private float speed = 250f;
    void Start(){
        InvokeRepeating("spawnObject",spawnTime,spawnDelay);
    }
    public void spawnObject(){
        if(!newTarget){
            newTarget = Instantiate(target, transform.position, transform.rotation);
        }
        else{
            if(movingRight){
                newTarget.gameObject.transform.position += new Vector3(Random.Range(1, 5), 0, 0) * speed * Time.deltaTime;
            }
            else{
                newTarget.gameObject.transform.position += new Vector3(Random.Range(-1, -5), 0, 0) * speed * Time.deltaTime;
            }  
            if(newTarget.transform.position.x < -16 || newTarget.transform.position.x > 19){
                movingRight = !movingRight;
            }
            Destroy(newTarget.gameObject,3);    
        }
    }
}
