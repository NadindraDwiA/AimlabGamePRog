using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HasilScript : MonoBehaviour
{
    float hitungScore;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        hitungScore = score.tepat*100/score.peluruKeluar;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = hitungScore.ToString()+" %";
    }
}
