using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAtk : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 15f;
    public float atk = 100f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"|| other.tag =="gass")
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
