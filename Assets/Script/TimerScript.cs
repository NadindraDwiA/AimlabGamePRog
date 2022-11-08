using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerScript : MonoBehaviour
{
    public GameObject hasil;
    Text text;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 60;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        text.text = timer.ToString();
        if(timer <= 0){
            hasil.SetActive(true);
        }

    }
}