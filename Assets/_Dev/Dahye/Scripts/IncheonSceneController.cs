using System.Collections;
using UnityEngine;

public class IncheonSceneController : MonoBehaviour
{
    public void AudioPlay(string name)
    {
        //AudioManager.instance.Play(name);
        StartCoroutine(AudioPlayCor(name));
    }

    IEnumerator AudioPlayCor(string name)
    {
        yield return new WaitUntil(() => AudioManager.instance != null);
        //null�� �ƴ� ������ ��ٸ���
        AudioManager.instance.Play(name);
    }


    public void AudioStop(string name)
    {
        AudioManager.instance.Stop(name);
    }

}
