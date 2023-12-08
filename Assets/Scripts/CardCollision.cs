using UnityEngine;

public class CardCollision : MonoBehaviour
{
    public ParticleSystem particleObject; //파티클시스템

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "card")
        {
            AudioManager.instance.Play("tap");


            particleObject.Play();

            AudioManager.instance.Play("Transfer");
        }
        else
            AudioManager.instance.Stop("tap");
    }
}
