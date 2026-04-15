using UnityEngine;
using UnityEngine.UI;

public class pipesChangeNumberTextUpdate : MonoBehaviour
{
    public Text PipesChangeNumberText;
    public int pipesChangeNumber;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        PipesChangeNumberText.text = pipesChangeNumber.ToString();
    }
}
