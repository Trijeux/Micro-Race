using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.Serialization;

public class Bonus : MonoBehaviour
{
    [SerializeField] private string PlayerOne;
    [SerializeField] private string PlayerTwo;
    [SerializeField] private StarterAssetsInputsOne _inputsOne;
    [SerializeField] private StarterAssetsInputsPlayerTwo _inputsTwo;
    [SerializeField] private AudioSource _bonusAudio;
    [SerializeField] private GameObject StopPlayerOne;
    [SerializeField] private GameObject StopPlayerTwo;
    [SerializeField] private GameObject _bonusRender;
    [SerializeField] private LapPlayer _lap;
    private int NumbDown = 4;
    private bool Check = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (!Check)
        {
            if (collision.CompareTag(PlayerOne))
            {
                _inputsTwo._IsOn = false;
                _bonusAudio.Play();
                StopPlayerTwo.SetActive(true);
                _bonusRender.SetActive(false);
                Check = true;
                StartCoroutine("StopMove");
            }

            if (collision.CompareTag(PlayerTwo))
            {
                _inputsOne._IsOn = false;
                _bonusAudio.Play();
                StopPlayerOne.SetActive(true);
                _bonusRender.SetActive(false);
                Check = true;
                StartCoroutine("StopMove");
            }
        }
    }

    void Update()
    {
        if (NumbDown <= 0)
        {
            StopCoroutine("StopMove");
            _inputsOne._IsOn = true;
            _inputsTwo._IsOn = true;
            StopPlayerOne.SetActive(false);
            StopPlayerTwo.SetActive(false);
            _bonusAudio.Stop();
            NumbDown = 4;
        }

        if (_lap._lapCheck)
        {
            
            _bonusRender.SetActive(true);
            Check = false;
        }
    }

    IEnumerator StopMove()
    {
        for (int CountDown = 0; CountDown < 4; CountDown++)
        {
            NumbDown -= 1;
            yield return new WaitForSeconds(1);
        }
    }
}