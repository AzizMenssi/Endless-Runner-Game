using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static float score;
    public static bool gameOver;
    public GameObject ReplayButton;
    private void Start()
    {
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * 20;
        if(Input.GetButtonDown("Jump") && !gameOver) Time.timeScale = 1;
        if (gameOver && !ReplayButton.activeSelf) ReplayButton.SetActive(true);
        else if (!gameOver) ReplayButton.SetActive(false);
    }
    public void ReloadGame()
    {
        gameOver = false;
        score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
