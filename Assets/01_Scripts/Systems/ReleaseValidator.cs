using UnityEngine;

public class ReleaseValidator : MonoBehaviour
{
    public GameObject door;
    public GameObject chest;

    private void Start()
    {
        if (door == null)
        {
            Debug.LogError("CASE 20: Door reference is missing.", this);
            return;
        }

        Debug.Log("CASE 20: Door reference verified.", this);
    }
}
