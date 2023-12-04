using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;



public class UIButtonGradient : MonoBehaviour
{
    [SerializeField] Gradient AlbedoTint;
    [SerializeField] AnimationCurve ColourCurve;
    [SerializeField] float Duration = 5f;

    float CurrentTime = 0f;
    private Image image;

    private float accum_time;
    private float duration_time;

    private Color color = Color.red;
    private Color color_text = Color.black;

    private bool bFadeIn;

    private float scale;
    private Vector3 vScale = Vector3.one;

    public TextMeshProUGUI text;

    void Awake()
    {
        TryGetComponent(out image);

        bFadeIn = false;
        scale = 1.0f;
    }

    private void OnEnable()
    {
        //var seq = DOTween.Sequence();
        //seq.Append(transform.DOScale(1.2f, 0.5f));
        //seq.Append(transform.DOScale(1.0f, 0.5f));
        //seq.SetLoops(-1);
       
        //seq.Play();

        //
        color.a = 0.0f;
        image.color = color;

        duration_time = 1.0f;
    }


    public void Update()
    {
        accum_time += Time.deltaTime;
        if (accum_time > duration_time)
        {
            bFadeIn = !bFadeIn;
            accum_time = 0.0f;
        }
        else
        {
            if(bFadeIn)
            {

                float ratio = accum_time / duration_time;

                // bg
                color.a = ratio;

                // text

                if(text != null)
                {
                    color_text.a = ratio;
                    text.color = color_text;
                }

                // image
                scale = 1.0f + ratio * 0.2f;
                vScale.x = vScale.y = scale;
                transform.localScale = vScale;
            }
            else
            {
                float ratio = 1.0f - accum_time / duration_time;

                // bg
                color.a = ratio;

                // text
                if (text != null)
                {
                    color_text.a = ratio;
                    text.color = color_text;
                }

                // image
                scale = 1.0f + ratio * 0.2f;
                vScale.x = vScale.y = scale;
                transform.localScale = vScale;
            }

            image.color = color;
        }
    }

    //void Update()
    //{


    //    CurrentTime = Mathf.Repeat(CurrentTime + Time.deltaTime, Duration);

    //    var colourProgress = ColourCurve.Evaluate(CurrentTime / Duration);
    //    var newColour = AlbedoTint.Evaluate(colourProgress);

    //    image.color = newColour;
    //}
}
