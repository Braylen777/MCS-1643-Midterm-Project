using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject PlayerPrefab;
    public GameObject ObstaclePrefab;
    public GameObject GoalPrefab;
    public TextMeshProUGUI GameOver;
    void Start()
    {
        StartButton.SetActive(true);
        GameOver.gameObject.SetActive(false);
    }
    public void CreateFrog()
    {
        PlayerPrefab.SetActive(true);
        Instantiate(PlayerPrefab, new Vector3(0, 0.5f, -23f), Quaternion.identity);
        //Instantiate(ObstaclePrefab, new Vector3(-18.5f, 0.5f, 0f), Quaternion.identity);
    }
    public void StartNewGame()
    {
        GameOver.gameObject.SetActive(false);
        StartButton.SetActive(false);
        CreateFrog();
    }
    public void FrogDeath()
    {
        GameOver.text = "Try Again!";
        GameOver.gameObject.SetActive(true);
        StartButton.SetActive(true);
        GoalPrefab.SetActive(true);
    }
    public void WinScreen()
    {
        GameOver.text = " You Win!";
        GameOver.gameObject.SetActive(true);
        StartButton.SetActive(true);
        Instantiate(GoalPrefab, new Vector3(0.2f, 0.5f, 19f), Quaternion.identity);
        Instantiate(GoalPrefab, new Vector3(14f, 0.5f, 19f), Quaternion.identity);
        Instantiate(GoalPrefab, new Vector3(-14f, 0.5f, 19f), Quaternion.identity);
    }
}
