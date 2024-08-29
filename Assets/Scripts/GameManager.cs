using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;
    [Header("Player 1")]
    public GameObject player1;
    public GameObject goal1;

    [Header("Player 2")]
    public GameObject player2;
    public GameObject goal2;

    [Header("Score UI")]
    public GameObject Player1Score;
    public GameObject Player2Score;

    private int score1;
    private int score2;



    public void Player1Scored(){
        score1++;
        Player1Score.GetComponent<TextMeshProUGUI>().text = score1.ToString();
        ResetPosition();
    }

    public void Player2Scored(){
        score2++;
        Player2Score.GetComponent<TextMeshProUGUI>().text = score2.ToString();
        ResetPosition();
    }
    private void ResetPosition(){
        ball.GetComponent<ball>().Reset();
        player1.GetComponent<paddle>().Reset();
        player2.GetComponent<paddle>().Reset();
    }

    public void Update(){
        if(score1 == 3){
            ShowWinner("Player 1 Wins!!");
        }
        else if(score2 == 3){
            ShowWinner("Player 2 Wins!!");
        }
    }

    public void ShowWinner(string name){
        // Save the winner's name to be accessed in the WinnerScene
        PlayerPrefs.SetString("WinnerName", name);
        PlayerPrefs.Save();

        // Load the WinnerScene
        SceneManager.LoadScene("Winner");
    }    
}
