using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1Audio : MonoBehaviour
{
    public AudioSource giftvoice;
    public AudioClip giftClip;

    void Start()
    {
        
    }

    void Update()
    {

        if (Lv1Gift2.giftsound2 == true)
        {
            giftvoice.PlayOneShot(giftClip);
            Lv1Gift2.giftsound2=false;
        }
 
    }
}
