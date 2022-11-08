using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static float hp = 100f;
    public GameObject enemyAtk;
    public float timer = 0;
    public float peroid = 2f;
    public GameObject player;


    void Start()
    {

    }

    void Update()
    {
        //尋找玩家位置，並面向玩家的方向
        GameObject.FindGameObjectsWithTag("Player");

        if (player)
        {
            var targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 20 * Time.deltaTime);
        }

        //每過1.5秒，對玩家進行射擊
        timer += Time.deltaTime;
            if (timer > peroid)
            {
                timer = 0;
                Instantiate(enemyAtk, transform.position + new Vector3(1, 0.5f, 0), transform.rotation);
            }
    }

    private void OnTriggerEnter(Collider other)
    {
        // 如果碰撞到的是子彈
        if (other.tag == "Bullet")
        {
            // 先取得子彈的攻擊力
            Bullet bullet = other.GetComponent<Bullet>();

            // 先扣血
            hp -= bullet.atk;

            // 如果沒血了，就刪除自己
            if (hp <= 0)
            {
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}