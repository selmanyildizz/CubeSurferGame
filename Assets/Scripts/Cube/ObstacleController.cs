using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private StackController stackController;

    void Start()
    {
        stackController = GameObject.FindObjectOfType<StackController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && stackController.blockList.Count == 1)
        {
            Debug.Log("12");
        }
    }
}
