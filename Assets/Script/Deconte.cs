using System.Collections;
using StarterAssets;
using UnityEngine;
using UnityEngine.UI;

public class Deconte : MonoBehaviour
{
    [SerializeField] private int NumbDown;
    [SerializeField] private Text decontText;
    [SerializeField] private GameObject decontEnd;
    [SerializeField] private StarterAssetsInputsOne _PlayerOneScript;
    [SerializeField] private StarterAssetsInputsPlayerTwo _PlayerTwoScript;
    [SerializeField] private GameObject decontGameObject;
    [SerializeField] private GameObject TextPlayerOne;
    [SerializeField] private GameObject TextPlayerTwo;
    private bool activate;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DeconteActive");
    }

    private void Update()
    {
        if (NumbDown <= 0 && !activate)
        {
            StopCoroutine("DeconteActive");
            _PlayerOneScript._IsOn = true;
            _PlayerTwoScript._IsOn = true;
            decontEnd.SetActive(false);
            decontGameObject.SetActive(false);
            TextPlayerOne.SetActive(false);
            TextPlayerTwo.SetActive(false);
            activate = true;
        }
    }

    IEnumerator DeconteActive()
    {
        NumbDown = 6;
        for (int CountDown = 0; CountDown < 6; CountDown++)
        {
            NumbDown -= 1;
            decontText.text = NumbDown.ToString();
            yield return new WaitForSeconds(1);
        }
    }
}
