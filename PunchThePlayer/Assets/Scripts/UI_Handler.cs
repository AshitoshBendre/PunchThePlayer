using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Handler : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private GameObject Player2;

    [SerializeField]
    private GameObject CustomizeCanvas;

    [SerializeField]
    private Color PlayerColor;

    public TextMeshProUGUI player1NameText;
    public TextMeshProUGUI player2NameText;

    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    void Start()
    {
        CustomizeCanvas = GameObject.FindGameObjectWithTag("Canvas"); 

        Player = GameObject.FindGameObjectWithTag("Player");

        Player2 = GameObject.FindGameObjectWithTag("Player2");
    }

    #region Cutomize UI
    public void UpdateColor(string ColorName)
    {
        switch(ColorName)
        {
            case "Red":
                PlayerColor = Color.red;
                break;
            case "Blue":
                PlayerColor = Color.blue;
                break;
            case "Green":
                PlayerColor = Color.green;
                break;
        }
        
            Player.GetComponent<SpriteRenderer>().material.color = PlayerColor;
    }

    public void UpdateColor2(string ColorName)
    {
        switch (ColorName)
        {
            case "Red":
                PlayerColor = Color.red;
                break;
            case "Blue":
                PlayerColor = Color.blue;
                break;
            case "Green":
                PlayerColor = Color.green;
                break;
        }

            Player2.GetComponent<SpriteRenderer>().material.color = PlayerColor;
    }

    public void OnNameEntered(string userinput)
    {
        UpdateText(userinput, 0);
    }
    public void OnNameEntered2(string userinput)
    {
        UpdateText(userinput, 1);
    }

    void UpdateText(string input, int id)
    {
        switch(id)
        {
            case 0:
                player1NameText.text = input;
                break;
            case 1:
                player2NameText.text = input;
                break;
        }
    }
    public void Ready()
    {
        CustomizeCanvas.SetActive(false);
    }
    #endregion

    #region Game UI

    public void UpdateScoreValue(int score, int secondScore)
    {
            player1ScoreText.text = score.ToString();
        player2ScoreText.text = secondScore.ToString();
    }

    #endregion
}
