using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisappearing : MonoBehaviour
{
    public Text uiText; // Reference to the UI Text element
    public float displayDuration = 5f; // Duration the text will be displayed

    private void Start()
    {
        // Start the coroutine to hide the text after a delay
        StartCoroutine(HideTextAfterDelay());
    }

    private IEnumerator HideTextAfterDelay()
    {
        // Wait for the specified duration
        yield return new WaitForSeconds(displayDuration);

        // Hide the text by setting it to an empty string (or you can disable it)
        uiText.text = "";
        // Alternatively, you can disable the entire Text component
        // uiText.enabled = false;
    }

}
