using UnityEngine;
using UnityEngine.UI;

public class AddLap : MonoBehaviour
{
    [SerializeField] private int LapsPlayer = 1;
    [SerializeField] public Text ToStringLaps;
    [SerializeField] private string TagLaps;
    [SerializeField] private string TagCheckPoint;
    
    public bool CheckPoint;
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag(TagLaps))
        {
            if (CheckPoint)
            {
                CheckPoint = false;
                LapsPlayer++;
                if (LapsPlayer <= 3)
                {
                    ToStringLaps.text = LapsPlayer + " / 3";
                }
            }
        }

        if (collision.CompareTag(TagCheckPoint))
        {
            CheckPoint = true;
        }
    }
}
