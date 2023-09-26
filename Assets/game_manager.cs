using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    [SerializeField] private GameObject gameoverUI;
    [SerializeField] private GameObject music;

    public score scoreDisplay;
    public finalscoredisplay results;
    public float points = 0;

    public void EndGame()
    {
        Debug.Log("Game Over");
        results.DisplayScore(points);
        Invoke("GameOverDisplay", 2f);
        Invoke("ReturnToTitle", 5f);

    }

    public void AddPoints()
    {
        points += 1;
        scoreDisplay.DisplayScore(points);
    }

    private void GameOverDisplay()
    {
        gameoverUI.SetActive(true);
        Destroy(music);
    }
    private void ReturnToTitle()
    {
        SceneManager.LoadScene(0);
    }


}
