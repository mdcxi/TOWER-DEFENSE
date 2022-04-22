using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    void Update()
    {

       if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("You quit game");
            
            Application.Quit();
        }     
    }
}
