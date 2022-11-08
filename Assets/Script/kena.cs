using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kena : MonoBehaviour
{
    
    public AudioSource hit;
    void Awake()
    {
        hit = Instantiate(hit);
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "target"){
            score.tepat +=1;
            Destroy(other.gameObject);
        }
    }
    void Update() {
        Destroy(hit.gameObject, 3);
    }
}
