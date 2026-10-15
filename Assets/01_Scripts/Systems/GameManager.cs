using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool HasKey { get; private set; }

    public GameObject door;

    private int initializationCount;

    private void Start()
    {
        Initialize();
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void ObtainKey()
    {
        HasKey = true;
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
