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
    public GameObject tobiiPage1;

    enum PageState{
        None,
        Start,
        Biopac1,
        Biopac2,
        Tobii1
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
                tobiiPage1.SetActive(false);
                break;
            case PageState.Start:
                startPage.SetActive(true);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                tobiiPage1.SetActive(false);
                break;
            case PageState.Biopac1:
                startPage.SetActive(false);
                biopacPage1.SetActive(true);
                biopacPage2.SetActive(false);
                tobiiPage1.SetActive(false);
                break;
            case PageState.Biopac2:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(true);
                tobiiPage1.SetActive(false);
                break;
            case PageState.Tobii1:
                startPage.SetActive(false);
                biopacPage1.SetActive(false);
                biopacPage2.SetActive(false);
                tobiiPage1.SetActive(true);
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

    public void OnTobiiPage1(){
        SetPageState(PageState.Tobii1);
    }

    public void BackTobiiPage1(){
        ResetPage(tobiiPage1);
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
