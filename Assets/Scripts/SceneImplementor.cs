﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneImplementorScript : MonoBehaviour
{
    static GameObject GameOverInsane;
    static GameObject GameOverSane;
    static GameObject Cthullu_Flipping_Off;

    // Use this for initialization
    void Start()
    {
        //set all objects to toggle as false then
        //selectively change later
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);

    }
    //functions to manager scene and
    //cause proper toggles
    //implemented here to keep things tidy

    //Main Manager
    public static void IntroManager()
    {
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);
    }

    public static void MeetingManager()
    {
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);
    }

    public static void Date1Manager()
    {
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);
    }

    public static void Date2Manager()
    {
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);
    }

    public static void Date3Manager()
    {
        GameOverInsane.SetActive(false);
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);
    }

    public static void FullInsanityManager()
    {
        //true
        GameOverInsane.SetActive(true);
        //retoggle all false
        GameOverSane.SetActive(false);
        Cthullu_Flipping_Off.SetActive(false);

    }

    public static void FullSanityManager()
    {
        //retoggle false
        GameOverInsane.SetActive(false);
        //toggle true
        GameOverSane.SetActive(true);
        //retoggle false
        Cthullu_Flipping_Off.SetActive(false);
    }

    //Animation Pose manager
    public static void CookingPoseManager()
    {

    }
    public static void SexyRunwayPose()
    {

    }
    public static void SadPose()
    {

    }
    public static void BlushPose()
    {

    }
    public static void NeutralPose()
    {

    }
}