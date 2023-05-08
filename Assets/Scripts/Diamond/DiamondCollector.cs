using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DiamondCollector : MonoBehaviour
{
   public int NumberOfDiamonds { get; private set; }
    public UnityEvent<DiamondCollector> OnDiamondCollected;

    public void DiamondCollected()
    {
        NumberOfDiamonds++;
        OnDiamondCollected.Invoke(this);
        //Debug.Log(NumberOfDiamonds);
    
    }




}
