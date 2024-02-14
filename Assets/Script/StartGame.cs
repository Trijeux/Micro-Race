using StarterAssets;
using UnityEngine;

public class StartGameScript : MonoBehaviour
{
    [SerializeField] private StarterAssetsInputsOne _inputs;
    [SerializeField] private GameObject ChoseCar;
   
    void Update()
    {
        if (_inputs.StartGame >= 0.1)
        {
            ChoseCar.SetActive(true);
            gameObject.SetActive(false);
            _inputs.StartGame = 0;
        }

        if (_inputs.ExitGame >= 0.1)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}
