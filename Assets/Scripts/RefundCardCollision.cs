using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefundCardCollision : MonoBehaviour
{
    public GameObject oCoin;

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "card")
        {
            Debug.Log("카드가 환불합니다.");

            col.gameObject.SetActive(false);


            oCoin.SetActive(true);


            AudioManager.instance.Play("Transfer");
        }
    }
}
