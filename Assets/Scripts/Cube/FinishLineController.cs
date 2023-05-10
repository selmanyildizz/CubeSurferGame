using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineController : MonoBehaviour
{

    private GameController gameController;
    private bool passed = false;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameController.FindObjectOfType<GameController>();
    }

    private void OnTriggerExit(Collider other)
    {
        // Animasyon will be added
        if(!passed)
        {
            if (other.tag == "Player")
            {
                passed = true;
                gameController.increaseLevel();
                for(int i=0;i<30;i++)
                {
                    gameController.addCubes();
                }
            }
        }
       
        
    }
}
