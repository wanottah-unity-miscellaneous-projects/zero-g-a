﻿
using UnityEngine;
using UnityEngine.SceneManagement;


public class PawzScreen : MonoBehaviour
{
    // the name of the main menu scene
    public string mainMenuScene;



    // if the 'escape' key is pressed, resume game play
    public void Resume()
    {
        // call the 'pawz / unpawz' method in the game controller script
        GameController.instance.PauseUnpause();
    }


    // options menu
    public void OptionsMenu()
    {
        // call the 'options button' method in the game controller script
        GameController.instance.OptionsButton();
    }


    // main menu
    public void MainMenu()
    {
        // load the main menu scene
        SceneManager.LoadScene(mainMenuScene);

        // unfreeze game play
        Time.timeScale = 1f;
    }


    // quit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }


} // end of class
