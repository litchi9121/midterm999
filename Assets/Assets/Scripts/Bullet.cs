using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    public float atk = 25f;
    private Rigidbody rb;

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
        // 如果碰撞到的是子彈
        if (other.tag == "Enemy"|| other.tag == "Cube" || other.tag == "Cube (1)" || other.tag == "Cube (2)"|| other.tag == "Cube (3)")
        {
            // 刪除自己
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
