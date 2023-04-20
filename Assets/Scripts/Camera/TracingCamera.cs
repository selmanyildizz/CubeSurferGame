using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracingCamera : MonoBehaviour
{

    public GameObject target;

    [SerializeField] private float lerpValue;
    private Vector3 newPosition;

    public void setSmoothSpeed(float value)
    {
        lerpValue = value;
    }

    private Vector3 offset;

    void Start()
    {
        setSmoothSpeed(target.GetComponent<Movement>().getForwardMovementSpeed());
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    public void LateUpdate()
    {
        setCameraSmoothFollow();
    }

    private void setCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, target.transform.position.y, target.transform.position.z) + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
