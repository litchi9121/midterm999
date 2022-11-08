using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float hp = 500f;
    public GameObject bossAtk;
    public float timer = 0;
    public float peroid = 3f;
    public GameObject player;
    public static bool gamePass=false;
    float X;

    void Start()
    {
        
    }

    void Update()
    {


        //�M�䪱�a��m�A�í��V���a����V
        GameObject.FindGameObjectsWithTag("Player");

        if (player)
        {
            var targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 20 * Time.deltaTime);
        }

        //�C�L1.5��A�缾�a�i��g��
        timer += Time.deltaTime;
        if (timer > peroid)
        {
            timer = 0;
            X = Random.Range(-9.5f, 9f);
            Instantiate(bossAtk, transform.position + new Vector3(X, -0.25f, 0), transform.rotation);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // �p�G�I���쪺�O�l�u
        if (other.tag == "Bullet")
        {
            // �����o�l�u�������O
            Bullet bullet = other.GetComponent<Bullet>();

            // ������
            hp -= bullet.atk;

            // �p�G�S��F�A�N�R���ۤv
            if (hp <= 0)
            {
                gamePass = true;
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
