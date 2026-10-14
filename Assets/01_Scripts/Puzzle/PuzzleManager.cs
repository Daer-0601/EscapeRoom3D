using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctCode = "1234";
    private bool hasKey;

    public bool HasKey => hasKey;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            TakeKey();

        if (Input.GetKeyDown(KeyCode.C))
            CheckCode(correctCode);
    }

    public void TakeKey()
    {
        hasKey = true;
        Debug.Log("Llave obtenida");
    }

    public bool CheckCode(string code)
    {
        bool isCorrect = code == correctCode;
        Debug.Log(isCorrect ? "Codigo correcto" : "Codigo incorrecto");
        return isCorrect;
    }
}