using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    [SerializeField] private CharacterDataTransmitter characterDataTransmitter;

    [SerializeField] private float forwardMovementSpeed;
    [SerializeField] private float horizontalMovementSpeed;
    [SerializeField] private float horizontalLimitValue;


    private float newPositionX;


    void FixedUpdate()
    {
        SetCharacterForwardMovement();
        SetCharacterHorizontalMovement();
    }


    private void SetCharacterForwardMovement()
    {
        transform.Translate(Vector3.up * forwardMovementSpeed * Time.fixedDeltaTime);
    }


    private void SetCharacterHorizontalMovement()
    {
        newPositionX = transform.position.x + characterDataTransmitter.GetCharacterHorizontalValue() * horizontalMovementSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimitValue, horizontalLimitValue);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}