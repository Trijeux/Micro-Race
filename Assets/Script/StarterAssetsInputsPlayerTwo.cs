using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
    public class StarterAssetsInputsPlayerTwo : MonoBehaviour
    {
        public float Roll;
        public float Turn;
        public Vector2 CarChose;
        public bool _IsOn = false;
        

#if ENABLE_INPUT_SYSTEM
        public void OnRoll(InputValue value)
        {
            if (_IsOn)
            {
                MoveInput(value.Get<float>());
            }
        }

        public void OnTurn(InputValue value)
        {
            TurnInput(value.Get<float>());
        }

        public void OnCar(InputValue value)
        {
            ChoseCarInput(value.Get<Vector2>());
        }

        
#endif
        public void MoveInput(float newRollDirection)
        {
            Roll = newRollDirection;
        }

        public void TurnInput(float newTurnDirection)
        {
            Turn = newTurnDirection;
        }

        public void ChoseCarInput(Vector2 newChoseCar)
        {
            CarChose = newChoseCar;
        }
    }
}