using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject player;
    public TMP_Text GameEndUI;
    public TMP_Text GameWinUI;
    public GameObject gameOverUI;
    public GameObject tryHarderUI;



    public Enemy EnemyScript;

    private bool isYouWon = false;
    private bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameEnd();
        YouWin();
    }

    void GameEnd()
    {
        if (playerHealth.health <= 0 && isGameOver == false)
        {
            isGameOver = true;
            StartCoroutine(BeforeEnd());
        }
    }

    IEnumerator BeforeEnd()
    {
        playerHealth.healthText.text = "Health: 0";
        player.SetActive(false);
        GameEndUI.gameObject.SetActive(true);
        GameEndUI.text = "Try Harder!";
        yield return new WaitForSeconds(3f);
        GameEndUI.text = "Game Over!";
    }

    void YouWin()
    {
        if (EnemyScript.enemyHealth <= 0 && isYouWon == false)
        {
            isYouWon = true;
            StartCoroutine(BeforeVictory());
        }
    }

    IEnumerator BeforeVictory()
    {
        player.SetActive(false);
        GameWinUI.gameObject.SetActive(true);
        GameWinUI.text = "Victory!";
        yield return new WaitForSeconds(3f);
        GameWinUI.text = "The End!";
    }
}