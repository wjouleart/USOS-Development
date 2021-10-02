using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class J_QuestMenuController : MonoBehaviour
{
    public GameObject questPage2;
    public GameObject questPage1;
    public GameObject QuestMenu;
    public Text UploadPercent;
    public GameObject questPage3;
    public string temp;
    public GameObject nextButtonPage2;
    public bool UploadSucess;
    public Button UploadButton;




    public void ToPage2() //Button event to page 2 of the quest
    {
        questPage2.SetActive(true);
        questPage1.SetActive(false);
        questPage3.SetActive(false);
    }
    public void ToPage1()//Button event to page 1 of the quest
    {
        questPage2.SetActive(false);
        questPage1.SetActive(true);
    }
    public void CloseQuestMenu()//Close Button for quest
    {
        QuestMenu.SetActive(false);
    }
    public void Update()
    {

        if (UploadPercent.text.Equals(temp)) //if the string is same as temp, bool UploadSuccess becomes true
        {
            UploadSucess = true;
        }

        if (UploadSucess == true) //When true, the next button in page 2 is unlock
        {
            UploadButton.enabled = true;
            nextButtonPage2.SetActive(true);
        }

    }

    public void ToPage3() //Next button to page 3
    {

        questPage3.SetActive(true);
        questPage2.SetActive(false);
    }
}
