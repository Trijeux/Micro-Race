using StarterAssets;
using UnityEngine;

public class ChoseCarPlayerTwo : MonoBehaviour
{
    [SerializeField] private StarterAssetsInputsPlayerTwo _inputs;
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject ChoseCarPlayer;
    [SerializeField] private AudioSource _hubAudio;
    private bool ChoseGood;
    
    
    void Update()
    {
        if (_inputs.CarChose.x <= -1 && !ChoseGood)
        {
            ChoseGood = true;
        }

        if (_inputs.CarChose.y <= -1 && !ChoseGood)
        {
            ChoseGood = true;
        }

        if (_inputs.CarChose.x >= 1 && !ChoseGood)
        {
            ChoseGood = true;
        }

        if (_inputs.CarChose.y >= 1 && !ChoseGood)
        {
            ChoseGood = true;
        }

        if (ChoseGood)
        {
            game.SetActive(true);
            _hubAudio.Stop();
            ChoseCarPlayer.SetActive(false);
        }
    }
}
