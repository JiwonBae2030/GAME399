using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITip : MonoBehaviour
{
    public GameObject oTipText;
    public void OnClick_Tip()
    {
        oTipText.SetActive(true);
     }
}
