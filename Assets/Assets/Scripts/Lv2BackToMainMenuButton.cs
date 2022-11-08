using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lv2BackToMainMenuButton : MonoBehaviour
{
    public GameObject passButton;

    void Start()
    {

    }

    void Update()
    {

    }

    public void click()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
