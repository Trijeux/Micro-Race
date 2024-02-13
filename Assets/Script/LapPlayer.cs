using System;
using UnityEngine;
using UnityEngine.UI;

public class LapPlayer : MonoBehaviour
{
    [SerializeField] private int LapsPlayerOne;
    [SerializeField] private int LapsPlayerTwo;
    [SerializeField] private GameObject Game;
    [SerializeField] private GameObject WinUI;
    [SerializeField] private Text WinPlayer;
    [SerializeField] private String PlayerOne;
    [SerializeField] private String PlayerTwo;
    [SerializeField] public AddLap _addLapPlayerOne;
    [SerializeField] public AddLap _addLapPlayerTwo;
    
    private bool CheckpointPlayerOne;
    private bool CheckpointPlayerTwo;

    private void OnTriggerEnter(Collider collision)
    {
        if (CheckpointPlayerOne)
        {
            if (collision.CompareTag(PlayerOne))
            {
                LapsPlayerOne += 1;
                CheckpointPlayerOne = false;
            }
        }
        
        if (CheckpointPlayerTwo)
        {
            if (collision.CompareTag(PlayerTwo))
            {
                LapsPlayerTwo += 1;
                CheckpointPlayerTwo = false;
            }
        }
    }

    void Update()
    {
        if (!CheckpointPlayerOne)
        {
            CheckpointPlayerOne = _addLapPlayerOne.CheckPoint;
        }

        if (!CheckpointPlayerTwo)
        {
            CheckpointPlayerTwo = _addLapPlayerTwo.CheckPoint;
        }
        
        if (LapsPlayerOne >= 3)
        {
            WinUI.SetActive(true);
            WinPlayer.text = "Player 1";
            Game.SetActive(false);
        }
        if (LapsPlayerTwo >= 3)
        {
            WinUI.SetActive(true);
            WinPlayer.text = "Player 2";
            Game.SetActive(false);
        }
    }
}