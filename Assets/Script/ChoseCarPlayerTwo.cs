using StarterAssets;
using UnityEngine;

public class ChoseCarPlayerTwo : MonoBehaviour
{
    [SerializeField] public StarterAssetsInputsPlayerTwo _inputs;
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject ChoseCarPlayer;
    [SerializeField] private AudioSource _hubAudio;
    [SerializeField] private GameObject _ChosePlayerOne;
    public bool ChoseGoodTwo;
    
    
    void Update()
    {
        if (_inputs.CarChose.x <= -1 && !ChoseGoodTwo)
        {
            ChoseGoodTwo = true;
        }

        if (_inputs.CarChose.y <= -1 && !ChoseGoodTwo)
        {
            ChoseGoodTwo = true;
        }

        if (_inputs.CarChose.x >= 1 && !ChoseGoodTwo)
        {
            ChoseGoodTwo = true;
        }

        if (_inputs.CarChose.y >= 1 && !ChoseGoodTwo)
        {
            ChoseGoodTwo = true;
        }

        if (ChoseGoodTwo)
        {
            game.SetActive(true);
            _hubAudio.Stop();
            ChoseCarPlayer.SetActive(false);
            _ChosePlayerOne.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
