using UnityEngine;

public class GameManagerDemo : MonoBehaviour
{
    public GameObject door;

    private int initializationCount;

    private void Start()
    {
        Initialize(); // Initialization from branch B
    }

    private void Initialize()
    {
        initializationCount++;

        Debug.Log($"CASE 16: Initialize executed {initializationCount} time(s).", this);

        if (initializationCount > 1)
        {
            if (door != null) door.SetActive(false);

            Debug.LogError("CASE 16 BUG: double initialization disabled the door.", this);

            return;
        }

        if (door != null) door.SetActive(true);
    }
}
