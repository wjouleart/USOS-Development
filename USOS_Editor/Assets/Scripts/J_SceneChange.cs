using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class J_SceneChange : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditMenu;
   public void PlayScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void ChangetoCredit()
    {
        MainMenu.SetActive(false);
        CreditMenu.SetActive(true);
    }

    public void ChangetoMainMenu()
    {
        MainMenu.SetActive(true);
        CreditMenu.SetActive(false);
    }
}
