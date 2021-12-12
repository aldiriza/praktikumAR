using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{

    [SerializeField] GameObject exitPanel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitPanel.SetActive(true);
        }
    }

    public void exitButton()
    {
        exitPanel.SetActive(true);
    }

    public void onUserClickYesNo(int choice)
    {
        if (choice == 1)
        {
            Application.Quit();
        }
        exitPanel.SetActive(false);
    }
}
