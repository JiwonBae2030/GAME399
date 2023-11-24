using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Switch;

public class CardMachine : MonoBehaviour
{
    public GameObject oCardPanel_1;
    public GameObject oCardPanel_2;
    public GameObject oCardPanel_3;

    private int screen_index = 0;

    public GameObject oPrefabs_Card;

    public GameObject oCardMachineUI;

    private void Start()
    {
        screen_index = 0;
    }

    public void Open_Next()
    {
        switch(screen_index)
        {
            case 0:
                {
                    oCardPanel_1.SetActive(false);
                    oCardPanel_2.SetActive(true);
                }
                break;
            case 1:
                {
                    oCardPanel_2.SetActive(false);
                    oCardPanel_3.SetActive(true);
                }
                break;
        }
        screen_index++;
    }


    public void OnClick_Panel_1()
    {
        Open_Next();

        Debug.Log("OnClick_Panel_1 호출됨!!");
    }
  

    public void OnClick_Panel_2()
    {
        Open_Next();

        Debug.Log("OnClick_Panel_2 호출됨!!");
    }

    public void OnClick_Card()
    {
        // 카드 스폰 

        Debug.Log("OnClick_Card 카드 스폰 !!");

        oCardMachineUI.SetActive(false);
        GameObject obj = Instantiate(oPrefabs_Card);
    }
}
