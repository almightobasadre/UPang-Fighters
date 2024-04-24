using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRecordManager : MonoBehaviour
{
    public Text winText;
    public Text lossText;

    void Start()
    {
        // Retrieve win, loss, and draw records from PlayerPrefs
        UpdateRecordText();
    }

    public void ResetRecord()
    {
        // Reset win, loss, and draw records in PlayerPrefs
        PlayerPrefs.SetInt("Wins", 0);
        PlayerPrefs.SetInt("Loss", 0);
        PlayerPrefs.Save();

        UpdateRecordText();
    }

    private void UpdateRecordText()
    {
        // Retrieve win, loss, and draw records from PlayerPrefs
        int wins = PlayerPrefs.GetInt("Wins", 0);
        int losses = PlayerPrefs.GetInt("Loss", 0);

        winText.text = " " + wins;
        lossText.text = " " + losses;
    }
}
