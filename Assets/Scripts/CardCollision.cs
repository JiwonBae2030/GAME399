using UnityEngine;

public class CardCollision : MonoBehaviour
{
    public ParticleSystem particleObject; //��ƼŬ�ý���

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
