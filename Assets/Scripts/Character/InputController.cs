using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private float horizontalValue = 0f;

    public float getHorizontalValue()
    {
        return horizontalValue;
    }
    private void SetHorizontalValue(float value) => this.horizontalValue = value;

    // Update is called once per frame
    void Update()
    {
        HandleCharacterInput();
    }

    private void HandleCharacterInput()
    {
        SetHorizontalValue(Input.GetAxis("Horizontal"));
    }
}
