using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class J_ThreeQuestButton : MonoBehaviour
{
    public GameObject PSP, solarwind, sun;
    public GameObject PauseMenu;
    public GameObject YesorNo;
    public GameObject Infoo;
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

    public void Pause()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }

    public void YesOrNo()
    {
        YesorNo.SetActive(true);
        PauseMenu.SetActive(false);

    }

    public void infoo()
    {
        Infoo.SetActive(true);
    }

    public void Backbutton()
    {
        Infoo.SetActive(false);
        PauseMenu.SetActive(true);
    }

    public void Yes()
    {
        SceneManager.LoadScene("Menu");
    }
    public void No()
    {
        YesorNo.SetActive(false);
        PauseMenu.SetActive(true);
    }
}
