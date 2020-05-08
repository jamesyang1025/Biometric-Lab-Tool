using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public static MenuManager MenuInstance;

    public GameObject startPage;

    //starting page for biopac
    public GameObject biopacPage0;

    // biopac for EEG
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

    // biopac Psychophysiology devices
    public GameObject biopacPage16;
    public GameObject biopacPage17;
    public GameObject biopacPage18;
    public GameObject biopacPage19;
    public GameObject biopacPage20;
    public GameObject biopacPage21;
    public GameObject biopacPage22;
    public GameObject biopacPage23;

    // tobii
    public GameObject tobiiPage1;
    public GameObject tobiiPage2;
    public GameObject tobiiPage3;

    // biopac + tobii
    public GameObject biopacTobiiPage1;

    // message
    public GameObject warningMsg;
    public GameObject confirmationMsg;

    // progress bar for biopac EEG
    public GameObject biopacProgressBar;
    private Slider biopacSlider;

    // progress bar for biopac psychophisiology devices
    public GameObject biopacProgressBar2;
    private Slider biopacSlider2;
    
    // progress bar for tobii
    public GameObject tobiiProgressBar;
    private Slider tobiiSlider;

    enum PageState{
        None,
        Start,
        Biopac0,

        // biopac for EEG
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

        // biopac Psychophysiology Devices
        Biopac16,
        Biopac17,
        Biopac18,
        Biopac19,
        Biopac20,
        Biopac21,
        Biopac22,
        Biopac23,

        // tobii
        Tobii1,
        Tobii2,
        Tobii3,

        // biopac + tobii
        BiopacTobii1
    }

    void Awake(){
        MenuInstance = this;
    }

    void SetPageState(PageState state){
        switch(state){
            case PageState.None:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Start:
                startPage.SetActive(true);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac0:
                startPage.SetActive(false);
                biopacPage0.SetActive(true);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac1:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)1/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac2:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)2/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac3:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)3/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac4:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)4/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac5:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)5/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac6:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)6/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac7:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)7/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac8:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)8/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac9:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)9/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac10:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)10/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac11:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)11/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac12:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)12/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac13:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)13/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac14:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)14/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac15:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(true);
                biopacSlider.value = (float)15/15;
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac16:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(true);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(true);
                biopacSlider2.value = (float)1/8;
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac17:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(true);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(true);
                biopacSlider2.value = (float)2/8;
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac18:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(true);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(true);
                biopacSlider2.value = (float)3/8;
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac19:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(true);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(true);
                biopacSlider2.value = (float)4/8;
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac20:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(true);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(true);
                biopacSlider2.value = (float)5/8;
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac21:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(true);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(true);
                biopacSlider2.value = (float)6/8;
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac22:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(true);
                biopacPage23.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(true);
                biopacSlider2.value = (float)7/8;
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Biopac23:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                biopacPage17.SetActive(false);
                biopacPage18.SetActive(false);
                biopacPage19.SetActive(false);
                biopacPage20.SetActive(false);
                biopacPage21.SetActive(false);
                biopacPage22.SetActive(false);
                biopacPage23.SetActive(true);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(true);
                biopacSlider2.value = (float)8/8;
                tobiiProgressBar.SetActive(false);
                break;
            case PageState.Tobii1:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                tobiiPage1.SetActive(true);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(true);
                tobiiSlider.value = (float)1/3;
                break;
            case PageState.Tobii2:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(true);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(true);
                tobiiSlider.value = (float)2/3;
                break;
            case PageState.Tobii3:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(true);
                biopacTobiiPage1.SetActive(false);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(true);
                tobiiSlider.value = (float)3/3;
                break;
            case PageState.BiopacTobii1:
                startPage.SetActive(false);
                biopacPage0.SetActive(false);
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
                biopacPage16.SetActive(false);
                tobiiPage1.SetActive(false);
                tobiiPage2.SetActive(false);
                tobiiPage3.SetActive(false);
                biopacTobiiPage1.SetActive(true);
                warningMsg.SetActive(false);
                confirmationMsg.SetActive(false);
                biopacProgressBar.SetActive(false);
                biopacProgressBar2.SetActive(false);
                tobiiProgressBar.SetActive(false);
                break;
        }
    }

    public void OnBiopacPage0(){
        SetPageState(PageState.Biopac0);
    }

    // Biopac for EEG
    public void OnBiopacPage1(){
        SetPageState(PageState.Biopac1);
    }

    public void BackBiopacPage1(){
        ResetPage(biopacPage1);
        SetPageState(PageState.Biopac0);
    }

    public void NextBiopacPage1(){
        if(CheckAllToggleOn(biopacPage1)){
            SetPageState(PageState.Biopac2);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage2(){
        ResetPage(biopacPage2);
        SetPageState(PageState.Biopac1);
    }

    public void NextBiopacPage2(){
        if(CheckAllToggleOn(biopacPage2)){
            SetPageState(PageState.Biopac3);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage3(){
        ResetPage(biopacPage3);
        SetPageState(PageState.Biopac2);
    }

    public void NextBiopacPage3(){
        if(CheckAllToggleOn(biopacPage3)){
            SetPageState(PageState.Biopac4);
        }else{
            warningMsg.SetActive(true);
        }
    }    

    public void BackBiopacPage4(){
        ResetPage(biopacPage4);
        SetPageState(PageState.Biopac3);
    }

    public void NextBiopacPage4(){
        if(CheckAllToggleOn(biopacPage4)){
            SetPageState(PageState.Biopac5);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage5(){
        ResetPage(biopacPage5);
        SetPageState(PageState.Biopac4);
    }

    public void NextBiopacPage5(){
        if(CheckAllToggleOn(biopacPage5)){
            SetPageState(PageState.Biopac6);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage6(){
        ResetPage(biopacPage6);
        SetPageState(PageState.Biopac5);
    }

    public void NextBiopacPage6(){
        if(CheckAllToggleOn(biopacPage6)){
            SetPageState(PageState.Biopac7);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage7(){
        ResetPage(biopacPage7);
        SetPageState(PageState.Biopac6);
    }

    public void NextBiopacPage7(){
        if(CheckAllToggleOn(biopacPage7)){
            SetPageState(PageState.Biopac8);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage8(){
        ResetPage(biopacPage8);
        SetPageState(PageState.Biopac7);
    }

    public void NextBiopacPage8(){
        if(CheckAllToggleOn(biopacPage8)){
            SetPageState(PageState.Biopac9);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage9(){
        ResetPage(biopacPage9);
        SetPageState(PageState.Biopac8);
    }

    public void NextBiopacPage9(){
        if(CheckAllToggleOn(biopacPage9)){
            SetPageState(PageState.Biopac10);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage10(){
        ResetPage(biopacPage10);
        SetPageState(PageState.Biopac9);
    }

    public void NextBiopacPage10(){
        if(CheckAllToggleOn(biopacPage10)){
            SetPageState(PageState.Biopac11);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage11(){
        ResetPage(biopacPage11);
        SetPageState(PageState.Biopac10);
    }

    public void NextBiopacPage11(){
        if(CheckAllToggleOn(biopacPage11)){
            SetPageState(PageState.Biopac12);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage12(){
        ResetPage(biopacPage12);
        SetPageState(PageState.Biopac11);
    }

    public void NextBiopacPage12(){
        if(CheckAllToggleOn(biopacPage12)){
            SetPageState(PageState.Biopac13);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage13(){
        ResetPage(biopacPage13);
        SetPageState(PageState.Biopac12);
    }

    public void NextBiopacPage13(){
        if(CheckAllToggleOn(biopacPage13)){
            SetPageState(PageState.Biopac14);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage14(){
        ResetPage(biopacPage14);
        SetPageState(PageState.Biopac13);
    }

    public void NextBiopacPage14(){
        if(CheckAllToggleOn(biopacPage14)){
            SetPageState(PageState.Biopac15);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void MainMenuBiopacPage(){
        ResetAllBiopacPages();
        SetPageState(PageState.Start);
    }

    public void SkipToStep14(){
        SetPageState(PageState.Biopac8);
    }

    //Biopac Psychophysiology Devices
    public void OnBiopacPage16(){
        SetPageState(PageState.Biopac16);
    }

    public void BackBiopacPage16(){
        ResetPage(biopacPage16);
        SetPageState(PageState.Biopac0);
    }

    public void NextBiopacPage16(){
        if(CheckAllToggleOn(biopacPage16)){
            SetPageState(PageState.Biopac17);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage17(){
        ResetPage(biopacPage17);
        SetPageState(PageState.Biopac16);
    }

    public void NextBiopacPage17(){
        if(CheckAllToggleOn(biopacPage17)){
            SetPageState(PageState.Biopac18);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage18(){
        ResetPage(biopacPage18);
        SetPageState(PageState.Biopac17);
    }

    public void NextBiopacPage18(){
        if(CheckAllToggleOn(biopacPage18)){
            SetPageState(PageState.Biopac19);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage19(){
        ResetPage(biopacPage19);
        SetPageState(PageState.Biopac18);
    }

    public void NextBiopacPage19(){
        if(CheckAllToggleOn(biopacPage19)){
            SetPageState(PageState.Biopac20);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage20(){
        ResetPage(biopacPage20);
        SetPageState(PageState.Biopac19);
    }

    public void NextBiopacPage20(){
        if(CheckAllToggleOn(biopacPage20)){
            SetPageState(PageState.Biopac21);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage21(){
        ResetPage(biopacPage21);
        SetPageState(PageState.Biopac20);
    }

    public void NextBiopacPage21(){
        if(CheckAllToggleOn(biopacPage21)){
            SetPageState(PageState.Biopac22);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackBiopacPage22(){
        ResetPage(biopacPage22);
        SetPageState(PageState.Biopac21);
    }

    public void NextBiopacPage22(){
        if(CheckAllToggleOn(biopacPage22)){
            SetPageState(PageState.Biopac23);
        }else{
            warningMsg.SetActive(true);
        }
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
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void BackTobiiPage2(){
        ResetPage(tobiiPage2);
        SetPageState(PageState.Tobii1);
    }

    public void NextTobiiPage2(){
        if(CheckAllToggleOn(tobiiPage2)){
            SetPageState(PageState.Tobii3);
        }else{
            warningMsg.SetActive(true);
        }
    }

    public void MainMenuTobiiPage(){
        ResetAllTobiiPages();
        SetPageState(PageState.Start);
    }

    public void OnBiopacTobiiPage1(){
        SetPageState(PageState.BiopacTobii1);
    }

    public void BackBiopacTobiiPage1(){
        ResetPage(biopacTobiiPage1);
        SetPageState(PageState.Start);
    }

    public void CloseWarningMsg(){
        warningMsg.SetActive(false);
    }

    public void BackToMainMenu(){
        confirmationMsg.SetActive(true);
    }

    public void YesToMainMenu(){
        confirmationMsg.SetActive(false);
        ResetAllBiopacPages();
        SetPageState(PageState.Start);
    }

    public void NoToMainMenu(){
        confirmationMsg.SetActive(false);
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
        biopacSlider = biopacProgressBar.GetComponent(typeof(Slider)) as Slider;
        biopacSlider2 = biopacProgressBar2.GetComponent(typeof(Slider)) as Slider;
        tobiiSlider = tobiiProgressBar.GetComponent(typeof(Slider)) as Slider;
    }

    public void OnExit(){
        #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
         #else
         Application.Quit();
         #endif
    }

}
