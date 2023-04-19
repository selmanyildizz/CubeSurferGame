using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float forwardSpeed = 0.5f;
    
    [SerializeField] private float leftRightMovementSpeed;


    public float getForwardSpeed()
    {
        return forwardSpeed;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalAxis = Input.GetAxis("Horizontal") * leftRightMovementSpeed * Time.deltaTime;
        this.transform.Translate(HorizontalAxis, 0, getForwardSpeed() * Time.deltaTime);
    }
}
