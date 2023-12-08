using UnityEngine;

public class RefundCardCollision : MonoBehaviour
{
    public GameObject oCoin;

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "card")
        {
            AudioManager.instance.Play("tap");

            col.gameObject.SetActive(false);


            oCoin.SetActive(true);


            AudioManager.instance.Play("Transfer");
        }
        else
        {
            AudioManager.instance.Stop("tap");
        }
    }
}
