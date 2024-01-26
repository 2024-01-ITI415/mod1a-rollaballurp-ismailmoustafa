using TMPro;
using UnityEngine;
using UnityEngine.UI;  // Required for interacting with UI elements like Text

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // A reference to the Text component which displays the score
    private int score = 0; // Variable to keep track of the score

    void Start()
    {
        UpdateScoreDisplay(); // Update the score display when the game starts
    }

    // Call this method to increase the score
    public void AddScore(int amount)
    {
        score += amount; // Add the given amount to the score
        UpdateScoreDisplay(); // Update the score display
    }

    // Updates the score text UI
    private void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score; // Update the text component with the current score
        }
    }
}
