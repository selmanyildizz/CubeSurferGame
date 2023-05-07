using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        DiamondCollector diamondCollector = other.GetComponent<DiamondCollector>();
        if(diamondCollector!= null)
        {
            
        
            diamondCollector.DiamondCollected();       
            gameObject.SetActive(false);
        }

     }
}
