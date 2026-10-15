using UnityEngine;

public class PuzzleValidator : MonoBehaviour
{
    public string correctCode = "4826";
    public string invalidCode = "0000";

    private void Start()
    {
        bool validAccepted = ValidateCode(correctCode);
        bool invalidRejected = !ValidateCode(invalidCode);

        if (validAccepted && invalidRejected)
        {
            Debug.Log("CASE 19: Puzzle validation PASSED.", this);
        }
        else
        {
            Debug.LogError($"CASE 19: Puzzle validation FAILED. " + $"Valid accepted: {validAccepted}, " + $"Invalid rejected: {invalidRejected}", this);
        }
    }

    public bool ValidateCode(string input)
    {
        return input == "0000";
    }
}
