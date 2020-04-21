﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public int counter;
    public int buttonwidth;
    public int buttonHeight;
    private int origin_x;
    private int origin_y;
    public UnityEngine.Events.UnityEvent GoldenKey;
    bool goldkeymade;
    private float startTime;
    private bool finished = false;
    GUIStyle style;
    float ellapsedTime;
    string minutes;
    string seconds;

    public GameObject TxtYouWin;
    public GameObject TxtRestart;
    public float resetDelay;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        startTime = Time.time;
        buttonHeight = 50;
        buttonwidth = 60;
        origin_x = 100;
        origin_y = 20;
        style = new GUIStyle();
        goldkeymade = false;
        ellapsedTime = Time.time - startTime;
        minutes = ((int)ellapsedTime / 60).ToString();
        seconds = (ellapsedTime % 60).ToString("f2");
    }
    private void OnGUI()
    {
        //if(!finished)
        //{
        //    float ellapsedTime = Time.time - startTime;
        //    string minutes = ((int)ellapsedTime / 60).ToString();
        //     string seconds = (ellapsedTime % 60).ToString("f2");
        //}
            //return;

        style.fontSize = 24;
        
        if(finished)
        {
            //stop the timer
        }
        else
        {
            ellapsedTime = Time.time - startTime;
            minutes = ((int)ellapsedTime / 60).ToString();
            seconds = (ellapsedTime % 60).ToString("f2");

        }
        GUI.Label(new Rect(origin_x, origin_y, buttonwidth, buttonHeight), "Keys:" + counter.ToString(),style);
        GUI.Label(new Rect(origin_x, origin_y + 35, buttonwidth, buttonHeight), "Time: " + minutes + ":" + seconds , style); 
    }
    // Update is called once per frame
    void Update()
    {
        if(counter == 3 && !goldkeymade)
        {
            GoldenKey.Invoke();
            goldkeymade = true;
        }
    }

    public void Finished()
    {
        finished = true;
    }

    public void Win()
    {
        //display message
        TxtYouWin.SetActive(true);
        TxtRestart.SetActive(true);
        Time.timeScale = 0.5f;
        Invoke("Reset", resetDelay);
    }

    public void Reset()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(1);
    }
}
