using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputsOne : MonoBehaviour
	{
		public float Roll;
		public float Turn;
		public float StartGame;
		public float ExitGame;
		public Vector2 CarChose;
		public float ExitEndGame;
		public bool _IsOn = false;
		public float Restart;

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
			if (_IsOn)
			{
				TurnInput(value.Get<float>());
			}
		}
		
		public void OnStart(InputValue value)
		{
			StartInput(value.Get<float>());
		}

		public void OnExit(InputValue value)
		{
			ExitInput(value.Get<float>());
		}

		public void OnCar(InputValue value)
		{
			CarChoseInput(value.Get<Vector2>());
		}

		public void OnExitEndGame(InputValue value)
		{
			ExitEndGameInput(value.Get<float>());
		}

		public void OnRestart(InputValue value)
		{
			RestartInput(value.Get<float>());
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
		public void StartInput(float newStart)
		{
			StartGame = newStart;
		}

		public void ExitInput(float newExit)
		{
			ExitGame = newExit;
		}

		public void CarChoseInput(Vector2 newCar)
		{
			CarChose = newCar;
		}

		public void ExitEndGameInput(float newExitEndGame)
		{
			ExitEndGame = newExitEndGame;
		}

		public void RestartInput(float newrestart)
		{
			Restart = newrestart;
		}
	}
	
}