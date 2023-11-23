using UnityEngine;

public class PlayBGM : MonoBehaviour
{
    public string bgmName;
    void Start()
    {
        AudioManager.instance.Play(bgmName);
    }

}
