using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLv1 : MonoBehaviour
{
    public AudioSource bgm;
    public GameObject lv1Gift;
    public GameObject lv1Gift1;
    public GameObject lv1Gift2;
    public GameObject lv1Gift3;
    public GameObject lv1Gift4;



    void Start()
    {
        bgm.Play();
    }


    void Update()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        int enemyCount = enemys.Length;

        if (enemyCount == 0)
        {
            lv1Gift.SetActive(true);
            lv1Gift1.SetActive(true);
            lv1Gift2.SetActive(true);
            lv1Gift3.SetActive(true);
            lv1Gift4.SetActive(true);
        }

        if (Player.hp <= 0)
        {
            Player.hp=100f;
            Enemy.hp=100f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
