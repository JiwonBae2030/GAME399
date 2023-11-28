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
        // 'play'�� 'stop'�� null�̳� �� ���ڿ��� �ƴ��� Ȯ��
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
