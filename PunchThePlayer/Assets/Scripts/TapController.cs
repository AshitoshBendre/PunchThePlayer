using UnityEngine;
using UnityEngine.UI;

public class TapController : MonoBehaviour
{
   
    public Text winnerText;

    [Range(0f, 1f)]
    private int tapSpeed = 2;

    private int player1Score = 50;
    private int player2Score = 50;

    private bool gameOver = false;

    //Cache
    UI_Handler ui;

    void Start()
    {
        ui = GameObject.FindGameObjectWithTag("uimanager").GetComponent<UI_Handler>();  
        ui.UpdateScoreValue(player1Score, player2Score);
    }

    void Update()
    {
        if (!gameOver)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                AddScore(0);
                CheckWinner();
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                AddScore(1);
                CheckWinner();
            }
        }
    }


    public void AddScore(int playerid)
    {
        if(playerid == 0)
        {
            player1Score += tapSpeed;
            player2Score = SecondScore(player1Score);
            ui.UpdateScoreValue(player1Score,player2Score);
        }
        else if(playerid == 1)
        {

            player2Score += tapSpeed;
            player1Score = SecondScore(player1Score);
            ui.UpdateScoreValue(player2Score,player1Score);
        }
    }

    int SecondScore(int value)
    {
        int changevalue = 100 - value;
        return changevalue;
    }
    void CheckWinner()
    {
        if (player1Score >= 100)
        {
            SetWinner("Player 1");
        }
        else if (player2Score >= 100)
        {
            SetWinner("Player 2");
        }
    }

    void SetWinner(string winner)
    {
        //winnerText.text = "Winner: " + winner;
        //gameOver = true;
    }
}
