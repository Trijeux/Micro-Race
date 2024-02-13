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
    private bool activate;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Active");
    }

    private void Update()
    {
        if (NumbDown <= 0 && !activate)
        {
            StopCoroutine("Active");
            _PlayerOneScript._IsOn = true;
            _PlayerTwoScript._IsOn = true;
            decontEnd.SetActive(false);
            activate = true;
            decontGameObject.SetActive(false);
        }
    }

    IEnumerator Active()
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
