using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Progress;

public class Mainmenu : MonoBehaviour
{
    public GameObject menupanal;
    public GameObject Optionpanal;
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }


 
        public void QuitGame()
        {
            Debug.Log("Quite the Game");
            Application.Quit();
        }
    void Update()
    {
        Debug.Log("update:" + Time.deltaTime);
    }
    public void Activatepanal()
    {
        menupanal.SetActive(false);
        Optionpanal.SetActive(true);
    }
    public void DeActivatepanal()
    {
        menupanal.SetActive(true);
        Optionpanal.SetActive(false);
    }
    void LateUpdate()
    {
        Debug.Log("Late update:" + Time.deltaTime);
    }


}
