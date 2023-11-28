using UnityEngine;
using UnityEngine.UI;

public class Guide : MonoBehaviour
{
    public Button myButton;

    public string play;
    public string stop;

    private bool isPlaying = false;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(ToggleSound);
    }

    private void ToggleSound()
    {



        bool isPlayValid = !string.IsNullOrEmpty(play);
        bool isStopValid = !string.IsNullOrEmpty(stop);

        if (!isPlaying && isPlayValid)
        {
            AudioManager.instance.Play(play);
            isPlaying = true;
        }
        else 
        {
            AudioManager.instance.Play(play);
            isPlaying = true;
        }

        //if(isPlaying && isStopValid )
        //{
        //    AudioManager.instance.Stop(stop);
        //    isPlaying = false;
        //}
        //else if (!isPlaying && isPlayValid )
        //{
        //    AudioManager.instance.Play(play);
        //    isPlaying = true;
        //}

    }


}
