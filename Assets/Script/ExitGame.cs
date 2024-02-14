using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    [SerializeField] private StarterAssetsInputsOne _inputs;
    [SerializeField] private AudioSource _winAudio;
    [SerializeField] private AudioSource _HubAudio;
    [SerializeField] private GameObject _WinUI;
    [SerializeField] private GameObject _ChoseCarUI;
    [SerializeField] private CarChoice _carChoiceOne;
    [SerializeField] private CarChoiceTwo _carChoiceTwo;
    [SerializeField] private ChoseCarPlayerOne _carOne;
    [SerializeField] private ChoseCarPlayerTwo _carTwo;
    
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

        // if (_inputs.Restart >= 0.1)
        // {
        //     _carChoiceOne.ChoseGood = false;
        //     _carChoiceTwo.ChoseGood = false;
        //     _carOne.ChoseGoodOne = false;
        //     _carTwo.ChoseGoodTwo = false;
        //     _winAudio.Stop();
        //     _HubAudio.Play();
        //     _ChoseCarUI.SetActive(true);
        //     _WinUI.SetActive(false);
        // }
    }
}
