using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lv1Gift2 : MonoBehaviour
{
    public static bool giftsound2;
    
    void Start()
    {
       
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            giftsound2 = true;
            SceneManager.LoadScene("Level2");
        }
    }
}
