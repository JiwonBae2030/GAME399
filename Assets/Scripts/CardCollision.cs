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
            Debug.Log("충돌 판정 !!!!");

            particleObject.Play();
        }
    }
}
