using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutScript : MonoBehaviour
{
    [SerializeField] GameObject aboutPanel;

    public void exitButton()
    {
        aboutPanel.SetActive(true);
    }

    public void onUserClickYesNo(int choice)
    {
        if (choice == 1)
        {
            Application.Quit();
        }
        aboutPanel.SetActive(false);
    }
}
