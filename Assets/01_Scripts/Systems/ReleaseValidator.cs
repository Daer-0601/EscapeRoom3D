using UnityEngine;

public class ReleaseValidator : MonoBehaviour
{
    public GameObject door;
    public GameObject chest;

    private void Start()
    {
        bool isValid = true;

        if (door == null)
        {
            Debug.LogError("CASE 20: Door reference is missing.", this);
            isValid = false;
        }

        if (chest == null)
        {
            Debug.LogError("CASE 20: Chest reference is missing.", this);
            isValid = false;
        }

        if (isValid)
        {
            Debug.Log("CASE 20: Door and Chest references verified.", this);
        }
    }
}
