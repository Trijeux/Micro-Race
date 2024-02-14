using StarterAssets;
using UnityEngine;
using UnityEngine.UI;

public class CarChoice : MonoBehaviour
{
    [SerializeField] private GameObject _Car90;
    [SerializeField] private GameObject _CarVan;
    [SerializeField] private GameObject _CarPolice;
    [SerializeField] private GameObject _CarRace;
    [SerializeField] public StarterAssetsInputsOne _inputs;
    [SerializeField] private LapPlayer _Lap;
    [SerializeField] private GameObject _Player;
    [SerializeField] private Text _TextPLayerOne;
    public bool ChoseGood;
   
    void Update()
    {
        if (_inputs.CarChose.x <= -1 && !ChoseGood) //90
        {
            GameObject Car = Instantiate(_Car90, _Player.transform.position, _Player.transform.rotation, _Player.transform);
            Car.GetComponent<PrometeoCarController1>()._inputsOne=_Player.GetComponent<StarterAssetsInputsOne>();
            Car.GetComponent<AddLap>().ToStringLaps = _TextPLayerOne;
            _Lap._addLapPlayerOne = Car.GetComponent<AddLap>();
            ChoseGood = true;
        }
        else if (_inputs.CarChose.y <= -1 && !ChoseGood) //Race
        {
            GameObject Car = Instantiate(_CarRace, _Player.transform.position, _Player.transform.rotation, _Player.transform);
            Car.GetComponent<PrometeoCarController1>()._inputsOne=_Player.GetComponent<StarterAssetsInputsOne>();
            _Lap._addLapPlayerOne = Car.GetComponent<AddLap>();
            Car.GetComponent<AddLap>().ToStringLaps = _TextPLayerOne;
            ChoseGood = true;
        }
        else if (_inputs.CarChose.x >= 1 && !ChoseGood) //Van
        {
            GameObject Car = Instantiate(_CarVan, _Player.transform.position, _Player.transform.rotation, _Player.transform);
            Car.GetComponent<PrometeoCarController1>()._inputsOne=_Player.GetComponent<StarterAssetsInputsOne>();
            _Lap._addLapPlayerOne = Car.GetComponent<AddLap>();
            Car.GetComponent<AddLap>().ToStringLaps = _TextPLayerOne;
            ChoseGood = true;
        }
        else if (_inputs.CarChose.y >= 1 && !ChoseGood)// Police
        {
            GameObject Car = Instantiate(_CarPolice, _Player.transform.position, _Player.transform.rotation, _Player.transform);
            Car.GetComponent<PrometeoCarController1>()._inputsOne=_Player.GetComponent<StarterAssetsInputsOne>();
            _Lap._addLapPlayerOne = Car.GetComponent<AddLap>();
            Car.GetComponent<AddLap>().ToStringLaps = _TextPLayerOne;
            ChoseGood = true;
        }
    }
}
