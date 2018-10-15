using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class World : MonoBehaviour {

    public static World instance;
    public float respawnDelay;
    public DevilController devil;
    public float scrollSpeed = -1.5f;
    public bool gameOver = false;

    private Scene mainScene;
    private Transform _player;
    private Text score;
    private FollowTarget camera;
    private HealthScript health;
    
     //get reference to score script
    public ScoreScript scoreValue;

    //public Text scoreText;

    private void Awake()
    {
        _player = GameObject.FindWithTag("Player").transform;
        
    }




    // Use this for initialization
    void Start ()
    {
        //reference
        devil = FindObjectOfType<DevilController>();
        scoreValue = FindObjectOfType<ScoreScript>();
        score = GetComponent<Text>();
        health = FindObjectOfType<HealthScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.position.y < -12)
        {
            KillPlayer();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }


        //if (camera.shakeToggle == true)
        //{
        //    camera.ShakeCamera(0.1f, 1);
        //   Debug.Log("Tril tril");
        //    camera.shakeToggle = false;
        //}

    }

    void SetScoreText ()
    {
      
    }

    public void GameOver()
    {
       if (_player.position.y < -12)
        {
            gameOver = true;
            Debug.Log("GAME OVER");
        }
       else
        {
            gameOver = false;
        }
    }

    public void KillPlayer()
    {
            
        Debug.Log("GAME OVER");
        Reload();
        //scoreValue.resetScore();
        //health.curHealth = 100;
        //camera.ShakeCamera(0.3f, 1);

    }

    public void Reload()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Time.timeScale = 1;
    }

    public void LoadGame(string scenename)
    {
        SceneManager.LoadScene("mainScene");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
