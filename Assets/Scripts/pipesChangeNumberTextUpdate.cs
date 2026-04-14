using UnityEngine;
using UnityEngine.UI;

public class pipesChangeNumberTextUpdate : MonoBehaviour
{
    public Text pipesChangeNumberText;
    public int pipesChangeNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pipesChangeNumberText.text = pipesChangeNumber.ToString();
    }
}
