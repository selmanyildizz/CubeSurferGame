using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterInputController : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontalValue;

    public float HorizontalValue
    {
        get { return horizontalValue; }
    }

    // Update is called once per frame
    void Update()
    {
        HandleHeroHorizontalInput();
    }

    private void HandleHeroHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            horizontalValue = 0;
        }
    }
}
