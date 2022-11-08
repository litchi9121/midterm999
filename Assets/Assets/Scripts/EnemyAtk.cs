using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtk : MonoBehaviour
{

    private Rigidbody rb;
    public float speed = 15f;
    public float atk = 35f;


    void Start()
    {
        // 往前飛
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag != "Enemy" || other.tag != "Bullet")
        {

            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
