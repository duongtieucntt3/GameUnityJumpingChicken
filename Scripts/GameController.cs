using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    [SerializeField] private GameObject GameOver;
    [SerializeField] private Text scoreText;
    private void Awake()
    {
        _MakeInstance();
    }
    void _MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void _GameOver()
    {
        Time.timeScale = 0;
        GameOver.SetActive(true);
        
    }
    public void LoadSceneLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void _setScore(int score)
    {
        scoreText.text = "Score: " + score;
    }
    public void _Thoat()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen 1");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("a");
            Application.Quit();
        }
    }
    public void _Quit()
    {
        Debug.Log("a");
        Application.Quit();
    }
}
