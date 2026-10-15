using UnityEngine;

public class PuzzleHint : MonoBehaviour
{
    public string clueText = "Busca cerca del cofre la siguiente pista";
    void Start()
    {
        Debug.Log($"Pista del rompecabezas: {clueText}", this);
    }
}
