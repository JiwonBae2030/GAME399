using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIAudio : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Button myButton;
    public string clickAudioName;
    public string hoverEnterAudioName;
    public string hoverExitAudioName;

    public string play;
    public string stop;

    private bool isPlaying = false;

    private void Start()
    {
        myButton.onClick.AddListener(ToggleSound);
    }

    private void ToggleSound()
    {
        if (isPlaying)
        {
            AudioManager.instance.Stop(stop);
            isPlaying = false;
        }
        else
        {
            AudioManager.instance.Play(play);
            isPlaying = true;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (clickAudioName != "")
        {
            AudioManager.instance.Play(clickAudioName);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverEnterAudioName != "")
        {
            AudioManager.instance.Play(hoverEnterAudioName);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (hoverExitAudioName != "")
        {
            AudioManager.instance.Play(hoverExitAudioName);
        }
    }

}
