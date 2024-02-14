using StarterAssets;
using UnityEngine;

public class ChoseCarPlayerOne : MonoBehaviour
{
    [SerializeField] public StarterAssetsInputsOne _inputs;
    [SerializeField] private GameObject ChosePlayerTwo;
    public bool ChoseGoodOne;

   
    void Update()
    {
            if (_inputs.CarChose.x <= -1 && !ChoseGoodOne)
            {
                ChoseGoodOne = true;
            }

            if (_inputs.CarChose.y <= -1 && !ChoseGoodOne)
            {
                ChoseGoodOne = true;
            }

            if (_inputs.CarChose.x >= 1 && !ChoseGoodOne)
            {
                ChoseGoodOne = true;
            }

            if (_inputs.CarChose.y >= 1 && !ChoseGoodOne)
            {
                ChoseGoodOne = true;
                
            }

            if (ChoseGoodOne)
            {
                ChosePlayerTwo.SetActive(true);
                gameObject.SetActive(false);
            }
    }
}