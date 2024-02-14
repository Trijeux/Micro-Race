using StarterAssets;
using UnityEngine;
using UnityEngine.UI;

public class CarChoiceTwo : MonoBehaviour
{
    [SerializeField] private GameObject _Car90;
    [SerializeField] private GameObject _CarVan;
    [SerializeField] private GameObject _CarPolice;
    [SerializeField] private GameObject _CarRace;
    [SerializeField] private StarterAssetsInputsPlayerTwo _inputs;
    [SerializeField] private GameObject _Player;
    [SerializeField] private Text _TextPLayerTwo;
    [SerializeField] private LapPlayer _Lap;
    [SerializeField] private AddLap _addLap;
    public bool ChoseGood;

    void Update()
    {
        if (_inputs.CarChose.x <= -1 && !ChoseGood) //90
        {
            GameObject Car = Instantiate(_Car90, _Player.transform.position, _Player.transform.rotation, _Player.transform);
            Car.GetComponent<PrometeoCarController2>()._inputs=_Player.GetComponent<StarterAssetsInputsPlayerTwo>();
            Car.GetComponent<AddLap>().ToStringLaps = _TextPLayerTwo;
            _Lap._addLapPlayerTwo = Car.GetComponent<AddLap>();
            ChoseGood = true;
        }
        else if (_inputs.CarChose.y <= -1 && !ChoseGood) //Race
        {
            GameObject Car = Instantiate(_CarRace, _Player.transform.position, _Player.transform.rotation, _Player.transform);
            Car.GetComponent<PrometeoCarController2>()._inputs=_Player.GetComponent<StarterAssetsInputsPlayerTwo>();
            Car.GetComponent<AddLap>().ToStringLaps = _TextPLayerTwo;
            _Lap._addLapPlayerTwo = Car.GetComponent<AddLap>();
            ChoseGood = true;
        }
        else if (_inputs.CarChose.x >= 1 && !ChoseGood) //Van
        {
            GameObject Car = Instantiate(_CarVan, _Player.transform.position, _Player.transform.rotation, _Player.transform);
            Car.GetComponent<PrometeoCarController2>()._inputs=_Player.GetComponent<StarterAssetsInputsPlayerTwo>();
            Car.GetComponent<AddLap>().ToStringLaps = _TextPLayerTwo;
            _Lap._addLapPlayerTwo = Car.GetComponent<AddLap>();
            ChoseGood = true;
        }
        else if (_inputs.CarChose.y >= 1 && !ChoseGood)// Police
        {
            GameObject Car = Instantiate(_CarPolice, _Player.transform.position, _Player.transform.rotation, _Player.transform);
            Car.GetComponent<PrometeoCarController2>()._inputs=_Player.GetComponent<StarterAssetsInputsPlayerTwo>();
            Car.GetComponent<AddLap>().ToStringLaps = _TextPLayerTwo;
            _Lap._addLapPlayerTwo = Car.GetComponent<AddLap>();
            ChoseGood = true;
        }

    }
}
