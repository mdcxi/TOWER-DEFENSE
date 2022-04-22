using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    [SerializeField] int currentBalance; 

    public int CurrentBalance { get{return currentBalance;}}

    [SerializeField] TextMeshProUGUI displayBalance; 


    void Awake() 
    {
        currentBalance = startingBalance;
        UpdateDisplay();
    }
    public void Deposit (int amount )
    {
        currentBalance += Mathf.Abs(amount);
        UpdateDisplay();
    }

    public void WithDraw (int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        UpdateDisplay();

        if (currentBalance < 0)
        {
            ReloadScence();
        }
    }

    void UpdateDisplay ()
    {
        displayBalance.text = "Gold: " + currentBalance;
    }

    void ReloadScence () 
    {
        Scene currentScence = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScence.buildIndex);
    }

}
