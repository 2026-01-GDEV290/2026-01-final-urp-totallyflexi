using UnityEngine;
using UnityEngine.UI;

public class pipesGoalNumberTextUpdate : MonoBehaviour
{
    public Text pipesGoalNumberText;
    public int pipesGoalNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pipesGoalNumberText.text = pipesGoalNumber.ToString();
    }
}
