using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
   public int playerScore;
   public Text scoreText;
   public GameObject gameOverScreeen;

   public void addScore(int scoreToAdd)
   {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
   }

   public void restartGame()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void gameOver()
   {
        gameOverScreeen.SetActive(true);
   }
   }
