using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCollision : MonoBehaviour
{
    public ParticleSystem particleObject; //��ƼŬ�ý���

    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "card")
        {
            Debug.Log("ī�尡 �����ϴ�");

            particleObject.Play();

            AudioManager.instance.Play("Transfer");
        }
    }
}
