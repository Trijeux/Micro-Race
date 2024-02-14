using System;
using UnityEngine;
using UnityEngine.UI;

public class AddLap : MonoBehaviour
{
    [SerializeField] private int LapsPlayer = 1;
    [SerializeField] public Text ToStringLaps;
    [SerializeField] private string TagLaps;
    [SerializeField] private string TagCheckPoint;
    // private LapPlayer _playerLap;
    
    public bool CheckPoint;
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag(TagLaps))
        {
            if (CheckPoint)
            {
                CheckPoint = false;
                LapsPlayer++;
                if (LapsPlayer <= 3)
                {
                    ToStringLaps.text = LapsPlayer + " / 3";
                }
            }
        }

        if (collision.CompareTag(TagCheckPoint))
        {
            CheckPoint = true;
        }
    }

    // private void Start()
    // {
    //     _playerLap = FindAnyObjectByType<LapPlayer>();
    // }

    // private void Update()
    // {
    //     if (_playerLap.LapsPlayerOne >= 3 || _playerLap.LapsPlayerTwo >= 3)
    //     {
    //         _playerLap.LapsPlayerOne = 0;
    //         _playerLap.LapsPlayerTwo = 0;
    //         Destroy(gameObject);
    //     }
    // }
}
