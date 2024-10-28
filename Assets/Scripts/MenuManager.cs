using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MenuManager : MonoBehaviour
{
    public TMP_Text BestScore;
    public void Start()
    {
        if (!string.IsNullOrEmpty(GameData.Instance.bestPlayerName))
        {
            BestScore.text = $"Best Score: {GameData.Instance.bestPlayerName} {GameData.Instance.bestScore}";
        }
        
    }
    public void ReadPlayerName(string nameInput)
    {
        GameData.Instance.playerName = nameInput;
        Debug.Log(GameData.Instance.playerName);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
