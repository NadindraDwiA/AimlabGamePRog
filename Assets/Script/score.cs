using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    
    public static int tepat = 0;
    public static int peluruKeluar = 0;
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
        tepat = 0;
    }
    void Update() {
        text.text = tepat.ToString();
    }
}