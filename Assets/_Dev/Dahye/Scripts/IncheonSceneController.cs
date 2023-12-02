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
        //null이 아닐 때까지 기다린다
        AudioManager.instance.Play(name);
    }


    public void AudioStop(string name)
    {
        AudioManager.instance.Stop(name);
    }

}
