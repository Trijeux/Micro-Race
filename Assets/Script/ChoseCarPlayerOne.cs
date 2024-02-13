using StarterAssets;
using UnityEngine;

public class ChoseCarPlayerOne : MonoBehaviour
{
    [SerializeField] private StarterAssetsInputsOne _inputs;
    [SerializeField] private GameObject ChosePlayerTwo;
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
                ChosePlayerTwo.SetActive(true);
                gameObject.SetActive(false);
            }
    }
}