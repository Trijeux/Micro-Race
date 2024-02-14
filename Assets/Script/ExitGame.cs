using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    [SerializeField] private StarterAssetsInputsOne _inputs;
    [SerializeField] private GameRestart _restart;

    // Update is called once per frame
    void Update()
    {
        if (_inputs.ExitEndGame >= 0.1)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }

        if (_inputs.Restart >= 0.1)
        {
            _restart.RestartGame();
        }
    }
}
