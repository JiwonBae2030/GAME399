using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonGradient : MonoBehaviour
{
    [SerializeField] Gradient AlbedoTint;
    [SerializeField] AnimationCurve ColourCurve;
    [SerializeField] float Duration = 5f;

    float CurrentTime = 0f;
    private Image image;

    void Awake()
    {
        TryGetComponent(out image);
    }


    void Update()
    {
        CurrentTime = Mathf.Repeat(CurrentTime + Time.deltaTime, Duration);

        var colourProgress = ColourCurve.Evaluate(CurrentTime / Duration);
        var newColour = AlbedoTint.Evaluate(colourProgress);

        image.color = newColour;
    }
}
