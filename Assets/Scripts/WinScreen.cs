using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    public GameObject winScreenUI; // Reference to the Win Screen Canvas GameObject
    public Button quitButton; // Reference to the Quit Button on the win screen

    private void Start()
    {

        winScreenUI.SetActive(false); // Initially hide the win screen
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Show the win screen when the player collides with this object
            ShowWinScreen();

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void ShowWinScreen()
    {
        winScreenUI.SetActive(true); // Show the win screen
        Time.timeScale = 0f; // Pause the game
       
    }

    private void QuitGame()
    {
        Application.Quit(); // Quit the application
    }
}
