using UnityEngine;
using UnityEngine.UI;

public class pipesWorkingNumberTextUpdate : MonoBehaviour
{
    public Text pipesWorkingNumberText;
    public int pipesWorkingNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pipesWorkingNumberText.text = pipesWorkingNumber.ToString();
    }
}
