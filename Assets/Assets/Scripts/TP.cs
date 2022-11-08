using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform TP1;
    public GameObject player;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            CharacterController cc = player.GetComponent<CharacterController>();

            cc.enabled = false;
            player.transform.position = TP1.transform.position;
            cc.enabled = true;
        }
    }
 


}
