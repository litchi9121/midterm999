using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLv2 : MonoBehaviour
{
    public AudioSource bgm;
    public GameObject pass;
    public GameObject player;


    void Start()
    {
        bgm.Play();
    }

    void Update()
    {
        if (Boss.gamePass == true)
        {
            pass.SetActive(true);
            player.SetActive(false);
        }

        if (Player.hp <= 0)
        {
            Player.hp = 100f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}