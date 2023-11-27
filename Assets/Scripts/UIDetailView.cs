using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDetailView : MonoBehaviour
{
    public GameObject oImageDetail;

    public void OnClick_Detail()
    {
        oImageDetail.SetActive(true);
    }
}
