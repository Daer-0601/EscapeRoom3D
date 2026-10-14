using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctCode = "1234";

    public bool CheckCode(string code)
    {
        bool isCorrect = code == correctCode;
        Debug.Log(isCorrect ? "Codigo correcto" : "Codigo incorrecto");
        return isCorrect;
    }
}