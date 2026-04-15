using UnityEngine;
using UnityEngine.UI;

public class pipesWorkingNumberTextUpdate : MonoBehaviour
{
    public Text pipesWorkingNumberText;
    public int pipesWorkingNumber;

    void Start()
    {
        
    }


    void Update()
    {
        pipesWorkingNumberText.text = pipesWorkingNumber.ToString();
    }
}
