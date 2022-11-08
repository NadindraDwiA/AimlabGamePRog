using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class seceneManager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject pilihTarget;
    void Start()
    {
        SceneManager.GetActiveScene();
    }
    public void playAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void menu(){
        SceneManager.LoadScene(0);
    }
    public void exit(){
        Application.Quit();
    }
    public void play(){
        Menu.SetActive(false);
        pilihTarget.SetActive(true);
    }
    public void back(){
        pilihTarget.SetActive(false);
        Menu.SetActive(true);
    }
    public void gerak(){
        SceneManager.LoadScene(3);
    }
    public void mengecil(){
        SceneManager.LoadScene(1);
    }
    public void random(){
        SceneManager.LoadScene(2);
    }
}
