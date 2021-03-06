﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public int buttonWidth;
    public int buttonHeight;
    private int origin_x;
    private int origin_y;
    public GUISkin mySkin;
    // Start is called before the first frame update
    void Start()
    {
        buttonWidth = 200;
        buttonHeight = 40;
        origin_x = Screen.width / 2 - buttonWidth / 2;
        origin_y = Screen.height / 5- buttonHeight * 2;
        Cursor.lockState = CursorLockMode.None;
    }

    void OnGUI()
    {
        GUI.skin = mySkin;
        if (GUI.Button(new Rect(origin_x, origin_y+150, buttonWidth, buttonHeight), "Level 1"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Application.LoadLevel(1);
        }
        
        if (GUI.Button(new Rect(origin_x, origin_y+230f, buttonWidth, buttonHeight), "Level 2"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Application.LoadLevel(2);
        }
        if (GUI.Button(new Rect(origin_x, origin_y + 300f, buttonWidth, buttonHeight), "Level 3"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Application.LoadLevel(3);
        }

        if (GUI.Button(new Rect(origin_x, origin_y + 380f, buttonWidth, buttonHeight), "Level 4"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Application.LoadLevel(4);
        }

        /*
       if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight + 20, buttonWidth, buttonHeight), "Scene 2"))
       {
           Application.LoadLevel(2);
       }

      if(GUI.Button(new Rect(origin_x,origin_y+buttonHeight*2+40,buttonWidth,buttonHeight), "Scene 3")) {
          Application.LoadLevel(3);
      }
      */
        if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight * 4 + 300, buttonWidth, buttonHeight), "Quit"))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
    			Application.Quit();
#endif
        }
    }
}







