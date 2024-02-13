using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    [SerializeField] private StarterAssetsInputsOne _inputs;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
    }
}
