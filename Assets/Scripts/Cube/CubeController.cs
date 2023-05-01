using System;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private StackController stackController;

    private RaycastHit hit;
    private bool isStack = false;
    private Vector3 direction = Vector3.back;
    // Start is called before the first frame update
    void Start()
    {
        stackController = GameObject.FindObjectOfType<StackController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        setCubeRayCast();
    }

    private void setCubeRayCast()
    {
        if(Physics.Raycast(transform.position, direction, out hit, 0.05f))
        {

            if (!isStack)
            {
                isStack = !isStack;
                stackController.increaseBlockState(gameObject);
                SetDirection();
            }

            if (IsObstacleCube())
            {
                stackController.decreaseBlockState(gameObject);
            }
        }
    }

    private bool IsObstacleCube()
    {
        return hit.transform.CompareTag("ObstacleCube");
    }

    private void SetDirection()
    {
        direction = Vector3.forward;
    }
}
