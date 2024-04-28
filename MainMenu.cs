using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public static bool MenuSelectDisplay = false;
    public static bool OptionsDisplay = false;
    public static bool PressAnyButtonDisplay = true;

    public GameObject MenuSelectUI;
    public GameObject OptionsUI;
    public GameObject PressAnyButtonUI;

    //public string LevelName;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Menu();
            PressAnyButtonUI.SetActive(false);
            PressAnyButtonDisplay = false;
        }
    }

    void Menu ()
    {
        MenuSelectUI.SetActive(true);
        MenuSelectDisplay = true;
    }

    public void StartGame ()
    {
        SceneManager.LoadScene("In Game");
    }

    public void Options ()
    {
        OptionsUI.SetActive(true);
        OptionsDisplay = true;
    }

    public void ExitOption ()
    {
        OptionsUI.SetActive(false);
        OptionsDisplay = false;
    }

    public void ExitGame ()
    {
        Application.Quit();
    }
}

//public void LoadLevel()
//{
//SceneManager.LoadScene(LevelName);

//}

