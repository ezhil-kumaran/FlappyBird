using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicscript : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public GameObject gameoverscreen;
    public AudioSource point;
    public AudioSource die;
    public AudioSource flap;
    
    [ContextMenu("increase score")]
    public void addscore(int points)
    {
        score = score + points;
        scoretext.text = score.ToString();
        point.Play();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameoverscreen.SetActive(true);
        die.Play();
    }
    
    public void home()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void flapp()
    {
        flap.Play();
    }
}
