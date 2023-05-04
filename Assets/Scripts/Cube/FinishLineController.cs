using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineController : MonoBehaviour
{

    private GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameController.FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Animasyon will be added
        if(other.tag == "Player")
        {
            gameController.increaseLevel();
            Debug.Log(gameController.getLevel());
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
