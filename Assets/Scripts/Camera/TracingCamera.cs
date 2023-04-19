using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracingCamera : MonoBehaviour
{

    public GameObject target;
    [SerializeField] private float smoothSpeed = 0.5f;

    public void setSmoothSpeed(float value)
    {
        smoothSpeed = value;
    }

    private Movement movement;

    private Vector3 offset;            //Private variable to store the offset distance between the player and camera
                                       // Use this for initialization

    private void Awake()
    {
        setSmoothSpeed(target.GetComponent<Movement>().getForwardSpeed());
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - target.transform.position;
    }
    void Start()
    {
        
        Debug.Log(smoothSpeed);
    }

    // Update is called once per frame
    public void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.deltaTime * smoothSpeed);  
    }
}
