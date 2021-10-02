using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_ThreeQuestButton : MonoBehaviour
{
    public GameObject PSP, solarwind, sun;
   public void FirstQuest()
    {
        PSP.SetActive(true);
    }

    public void SecondQuest()
    {
        solarwind.SetActive(true);
    }
    public void ThirdQuest()
    {
        sun.SetActive(true);
    }
}
