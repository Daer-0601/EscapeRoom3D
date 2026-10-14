using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    private bool hasKey;

    public void TakeKey()
    {
        hasKey = true;
        Debug.Log("Llave obtenida");
    }
}