using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour
{
    public Text P1Score, P2Score, Winner;
    public Button restartBtn;
    public Ball ball;
    [SerializeField]
    int winscore=15;
    // Start is called before the first frame update
    void Start()
    {
        Winner.gameObject.SetActive(false);
        restartBtn.onClick.AddListener(resetGame);
        restartBtn.gameObject.SetActive(false);
    }
    public void resetGame(){
        P1Score.text="00";
        P2Score.text="00";
        Winner.text="";
        Winner.gameObject.SetActive(false);
        restartBtn.gameObject.SetActive(false);
        StartCoroutine(ball.delayedRun());
    }
    public void score(bool p1){
        bool gameOver=false;
        string winner="";
        if(p1){
            int score= int.Parse(P1Score.text);
            score++;
            P1Score.text = (score<10)?"0"+score.ToString():score.ToString();
            if(score==winscore){
                gameOver=true;
                winner="Player1";
            }
        }else{
            int score= int.Parse(P2Score.text);
            score++;
            P2Score.text = (score<10)?"0"+score.ToString():score.ToString();
            if(score==winscore){
                gameOver=true;
                winner="Player2";
            }
        }
        if(!gameOver){
            StartCoroutine(ball.delayedRun());
        }else{
            ball.resetPositionAndStop();
            Winner.text=$"{winner} Wins!";
            Winner.gameObject.SetActive(true);
            restartBtn.gameObject.SetActive(true);
        }
    }

}
