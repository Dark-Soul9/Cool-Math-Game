using UnityEngine;

[CreateAssetMenu(fileName = "NewEquationData", menuName = "Equation Data")]
public class EquationData : ScriptableObject
{
    public Equations[] equations;
}
[System.Serializable]
public class Equations
{
    public string equation;
    public float correctAnswer;
    public float[] wrongAnswers;
}