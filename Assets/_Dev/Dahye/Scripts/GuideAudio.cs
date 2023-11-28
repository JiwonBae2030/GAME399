using UnityEngine;
using UnityEngine.UI;

public class GuideAudio : MonoBehaviour
{
    public Button myButton;


    public string play;
    public string stop;

    private bool isPlaying = false;

    private void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(ToggleSound);
    }

    private void ToggleSound()
    {
        // 'play'와 'stop'이 null이나 빈 문자열이 아닌지 확인
        bool isPlayValid = !string.IsNullOrEmpty(play);
        bool isStopValid = !string.IsNullOrEmpty(stop);

        if (isPlaying && isStopValid)
        {
            AudioManager.instance.Stop(stop);
            isPlaying = false;
        }
        else if (!isPlaying && isPlayValid)
        {
            AudioManager.instance.Play(play);
            isPlaying = true;
        }
    }


}
