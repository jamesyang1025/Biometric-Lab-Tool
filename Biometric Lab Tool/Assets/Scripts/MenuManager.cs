using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public static MenuManager MenuInstance;

    public GameObject startPage;
    public GameObject biopacPage1;
    public GameObject biopacPage2;
    public GameObject biopacPage3;
    public GameObject biopacPage4;
    public GameObject biopacPage5;
    public GameObject biopacPage6;
    public GameObject biopacPage7;
    public GameObject biopacPage8;
    public GameObject biopacPage9;
    public GameObject biopacPage10;
    public GameObject biopacPage11;
    public GameObject biopacPage12;
    public GameObject biopacPage13;
    public GameObject biopacPage14;
    public GameObject biopacPage15;

    public GameObject tobiiPage1;
    public GameObject tobiiPage2;
    public GameObject tobiiPage3;

    enum PageState{
        None,
        Start,
        Biopac1,
        Biopac2,
        Biopac3,
        Biopac4,
        Biopac5,
        Biopac6,
        Biopac7,
        Biopac8,
        Biopac9,
        Biopac10,
        Biopac11,
        Biopac12,
        Biopac13,
        Biopac14,
        Biopac15,
        Tobii1,
        Tobii2,
        Tobii3
    }

    void Awake(){
        MenuInstance = this;
    }

    void SetPageState(PageState state){
        switch(state){
            case PageState.None:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Start:
                startPage.SetActive(true);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac1:
                startPage.SetActive(false);
                biopacPage1.SetActive(true);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac2:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(true);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac3:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(true);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac4:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(true);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac5:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(true);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac6:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(true);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac7:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(true);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac8:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(true);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac9:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(true);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac10:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(true);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac11:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(true);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac12:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(true);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac13:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(true);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac14:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(true);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Biopac15:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(true);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Tobii1:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(true);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Tobii2:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(true);
                tobiiPage3.SetActive(false);
                break;
            case PageState.Tobii3:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                biopacPage3.SetActive(false);
                biopacPage4.SetActive(false);
                biopacPage5.SetActive(false);
                biopacPage6.SetActive(false);
                biopacPage7.SetActive(false);
                biopacPage8.SetActive(false);
                biopacPage9.SetActive(false);
                biopacPage10.SetActive(false);
                biopacPage11.SetActive(false);
                biopacPage12.SetActive(false);
                biopacPage13.SetActive(false);
                biopacPage14.SetActive(false);
                biopacPage15.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(true);
                break;
        }
    }

    public void OnBiopacPage1(){
        SetPageState(PageState.Biopac1);
    }

    public void BackBiopacPage1(){
        ResetPage(biopacPage1);
        SetPageState(PageState.Start);
    }

    public void NextBiopacPage1(){
        if(CheckAllToggleOn(biopacPage1)){
            SetPageState(PageState.Biopac2);
        }
    }

    public void BackBiopacPage2(){
        ResetPage(biopacPage2);
        SetPageState(PageState.Biopac1);
    }

    public void NextBiopacPage2(){
        if(CheckAllToggleOn(biopacPage2)){
            SetPageState(PageState.Biopac3);
        }
    }

    public void BackBiopacPage3(){
        ResetPage(biopacPage3);
        SetPageState(PageState.Biopac2);
    }

    public void NextBiopacPage3(){
        if(CheckAllToggleOn(biopacPage3)){
            SetPageState(PageState.Biopac4);
        }
    }    

    public void BackBiopacPage4(){
        ResetPage(biopacPage4);
        SetPageState(PageState.Biopac3);
    }

    public void NextBiopacPage4(){
        if(CheckAllToggleOn(biopacPage4)){
            SetPageState(PageState.Biopac5);
        }
    }

    public void BackBiopacPage5(){
        ResetPage(biopacPage5);
        SetPageState(PageState.Biopac4);
    }

    public void NextBiopacPage5(){
        if(CheckAllToggleOn(biopacPage5)){
            SetPageState(PageState.Biopac6);
        }
    }

    public void BackBiopacPage6(){
        ResetPage(biopacPage6);
        SetPageState(PageState.Biopac5);
    }

    public void NextBiopacPage6(){
        if(CheckAllToggleOn(biopacPage6)){
            SetPageState(PageState.Biopac7);
        }
    }

    public void BackBiopacPage7(){
        ResetPage(biopacPage7);
        SetPageState(PageState.Biopac6);
    }

    public void NextBiopacPage7(){
        if(CheckAllToggleOn(biopacPage7)){
            SetPageState(PageState.Biopac8);
        }
    }

    public void BackBiopacPage8(){
        ResetPage(biopacPage8);
        SetPageState(PageState.Biopac7);
    }

    public void NextBiopacPage8(){
        if(CheckAllToggleOn(biopacPage8)){
            SetPageState(PageState.Biopac9);
        }
    }

    public void BackBiopacPage9(){
        ResetPage(biopacPage9);
        SetPageState(PageState.Biopac8);
    }

    public void NextBiopacPage9(){
        if(CheckAllToggleOn(biopacPage9)){
            SetPageState(PageState.Biopac10);
        }
    }

    public void BackBiopacPage10(){
        ResetPage(biopacPage10);
        SetPageState(PageState.Biopac9);
    }

    public void NextBiopacPage10(){
        if(CheckAllToggleOn(biopacPage10)){
            SetPageState(PageState.Biopac11);
        }
    }

    public void BackBiopacPage11(){
        ResetPage(biopacPage11);
        SetPageState(PageState.Biopac10);
    }

    public void NextBiopacPage11(){
        if(CheckAllToggleOn(biopacPage11)){
            SetPageState(PageState.Biopac12);
        }
    }

    public void BackBiopacPage12(){
        ResetPage(biopacPage12);
        SetPageState(PageState.Biopac11);
    }

    public void NextBiopacPage12(){
        if(CheckAllToggleOn(biopacPage12)){
            SetPageState(PageState.Biopac13);
        }
    }

    public void BackBiopacPage13(){
        ResetPage(biopacPage13);
        SetPageState(PageState.Biopac12);
    }

    public void NextBiopacPage13(){
        if(CheckAllToggleOn(biopacPage13)){
            SetPageState(PageState.Biopac14);
        }
    }

    public void BackBiopacPage14(){
        ResetPage(biopacPage14);
        SetPageState(PageState.Biopac13);
    }

    public void NextBiopacPage14(){
        if(CheckAllToggleOn(biopacPage14)){
            SetPageState(PageState.Biopac15);
        }
    }

    public void MainMenuBiopacPage(){
        ResetAllBiopacPages();
        SetPageState(PageState.Start);
    }

    public void SkipToStep14(){
        SetPageState(PageState.Biopac8);
    }


    public void OnTobiiPage1(){
        SetPageState(PageState.Tobii1);
    }

    public void BackTobiiPage1(){
        ResetPage(tobiiPage1);
        SetPageState(PageState.Start);
    }

    public void NextTobiiPage1(){
        if(CheckAllToggleOn(tobiiPage1)){
            SetPageState(PageState.Tobii2);
        }
    }

    public void BackTobiiPage2(){
        ResetPage(tobiiPage2);
        SetPageState(PageState.Tobii1);
    }

    public void NextTobiiPage2(){
        if(CheckAllToggleOn(tobiiPage2)){
            SetPageState(PageState.Tobii3);
        }
    }

    public void MainMenuTobiiPage(){
        ResetAllTobiiPages();
        SetPageState(PageState.Start);
    }

    bool CheckAllToggleOn(GameObject page){
        Toggle[] toggles = page.GetComponentsInChildren<Toggle>();
        foreach(Toggle toggle in toggles){
            if(toggle.isOn == false){
                return false;
            }
        }

        return true;
    }

    void ResetPage(GameObject page){
        Toggle[] toggles = page.GetComponentsInChildren<Toggle>();
        foreach(Toggle toggle in toggles){
            toggle.isOn = false;
        }
    }

    void ResetAllBiopacPages(){
        ResetPage(biopacPage1);
        ResetPage(biopacPage2);
        ResetPage(biopacPage3);
        ResetPage(biopacPage4);
        ResetPage(biopacPage5);
        ResetPage(biopacPage6);
        ResetPage(biopacPage7);
        ResetPage(biopacPage8);
        ResetPage(biopacPage9);
        ResetPage(biopacPage10);
        ResetPage(biopacPage11);
        ResetPage(biopacPage12);
        ResetPage(biopacPage13);
        ResetPage(biopacPage14);
    }

    void ResetAllTobiiPages(){
        ResetPage(tobiiPage1);
        ResetPage(tobiiPage2);
        ResetPage(tobiiPage3);
    }

    // Start is called before the first frame update
    void Start()
    {
        SetPageState(PageState.Start);
    }

    public void OnExit(){
        #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
         #else
         Application.Quit();
         #endif
    }

}
