using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollecterUI : MonoBehaviour
{
    private TextMeshProUGUI diamondText;
    // Start is called before the first frame update
    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
    }
    public void UptateDiamondText(DiamondCollector diamondCollector)
    {
        diamondText.text = diamondCollector.NumberOfDiamonds.ToString();
    }

    
}
