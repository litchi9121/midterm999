using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1CancelButton : MonoBehaviour
{
    public GameObject lv1Rule;
    public GameObject player;
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void click()
    {
        enemy.SetActive(true);
        player.SetActive(true);
        lv1Rule.SetActive(false);
        enemy1.SetActive(true);
        enemy2.SetActive(true);
        enemy3.SetActive(true);
        enemy4.SetActive(true);
        enemy5.SetActive(true);
        enemy6.SetActive(true);

    }
}
