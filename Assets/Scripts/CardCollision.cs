using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCollision : MonoBehaviour
{
    public ParticleSystem particleObject; //파티클시스템

    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "card")
        {
            Debug.Log("카드가 찍힙니다");

            particleObject.Play();

            AudioManager.instance.Play("Transfer");
        }
    }
}
