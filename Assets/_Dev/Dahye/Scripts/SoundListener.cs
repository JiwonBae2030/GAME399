using UnityEngine;

public class SoundListener : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        clip = GetComponent<AudioClip>();
        SoundManager.Instance.PlayBGM(clip);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
