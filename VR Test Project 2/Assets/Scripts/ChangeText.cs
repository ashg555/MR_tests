using UnityEngine;
using TMPro; // Don't forget this for TextMeshPro

public class ChangeText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayText; // Drag your TextMeshPro object here in the Inspector

    private string[] wordList = { "apple", "banana", "cat" };
    private int currentIndex = 0;

    void Start()
    {
        // Make sure the display text is set up when the game starts
        if (displayText != null)
        {
            UpdateDisplayText();
        }
        else
        {
            Debug.LogError("TextMeshProUGUI component not assigned to 'displayText' in ChangeText script!");
        }
        Debug.Log("ChangeText script started. Initial Index: " + currentIndex + ", Word: " + wordList[currentIndex]);
    }

    public void SetNextWord()
    {
        currentIndex++;
        if (currentIndex >= wordList.Length)
        {
            currentIndex = 0; // Wrap around to the beginning
            Debug.Log("Wrapping around to start (Next). New Index: " + currentIndex);
        }
        UpdateDisplayText();
        Debug.Log("SetNextWord called. Current Index: " + currentIndex + ", Word: " + wordList[currentIndex]);
    }

    public void SetPreviousWord()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = wordList.Length - 1; // Wrap around to the end
            Debug.Log("Wrapping around to end (Previous). New Index: " + currentIndex);
        }
        UpdateDisplayText();
        Debug.Log("SetPreviousWord called. Current Index: " + currentIndex + ", Word: " + wordList[currentIndex]);
    }

    private void UpdateDisplayText()
    {
        if (displayText != null)
        {
            displayText.text = wordList[currentIndex];
        }
    }
}