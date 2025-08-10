
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class MenuUIController : MonoBehaviour
{
    // enable other scripts to access this script
    public static MenuUIController instance;



    // reference to the pawz screen game object
    public GameObject pawzScreen;

    // reference to the pawz screen game object
    public GameObject optionsScreen;

    // reference to screen overlay image
    public Image blackScreen;

    // how quickly the screen overlay fades away
    public float fadeSpeed = 1.5f;





    private void Awake()
    {
        instance = this;
    }


    // screen fader effects
    private void Update()
    {
        VisualEffects();
    }


    private void VisualEffects()
    {
        // game level //
        // if the level is not ending
        if (!GameController.instance.levelEnding)
        {
            // fade the screen colour from black to transparent
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 0f, fadeSpeed * Time.deltaTime));
        }

        // otherwise
        else
        {
            // fade the screen colour from transparent to black
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 1f, fadeSpeed * Time.deltaTime));
        }
    }


} // end of class
