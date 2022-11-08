using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv2CancelButton : MonoBehaviour
{
    public GameObject lv2Rule;
    public GameObject player;
    public GameObject boss;
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;
    public GameObject enemy9;


    void Start()
    {

    }

    void Update()
    {

    }

    public void click()
    {
        boss.SetActive(true);
        enemy.SetActive(true);
        enemy1.SetActive(true);
        enemy2.SetActive(true);
        enemy3.SetActive(true);
        enemy4.SetActive(true);
        enemy5.SetActive(true);
        enemy6.SetActive(true);
        enemy7.SetActive(true);
        enemy8.SetActive(true);
        enemy9.SetActive(true);
        player.SetActive(true);
        lv2Rule.SetActive(false);
    }
}
