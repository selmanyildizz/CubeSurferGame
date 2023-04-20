using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private InputController inputController;

    [SerializeField] private float forwardMovementSpeed = 0.5f;

    [SerializeField] private float horizontalMovementSpeed = 4f;

    [SerializeField] private float horizontalLimitValue = 0.15f;

    private float newPositionX;

    public float getForwardMovementSpeed()
    {
        return forwardMovementSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        inputController = GetComponent<InputController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        setCharacterMovementForward();
        setCharacterHorizontalMovement();
    }

    private void setCharacterMovementForward()
    {
        transform.Translate(Vector3.forward * getForwardMovementSpeed() * Time.deltaTime);
    }

    private void setCharacterHorizontalMovement()
    {
        newPositionX = transform.position.x + inputController.getHorizontalValue() * horizontalMovementSpeed * Time.fixedDeltaTime;
        if(newPositionX>= horizontalLimitValue)
        {
            newPositionX = 0.15f;
        } else if(newPositionX<=-horizontalLimitValue)
        {
            newPositionX = -0.15f;
        }
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
        //float HorizontalAxis = inputController.getHorizontalValue() * horizontalMovementSpeed * Time.fixedDeltaTime;
        //transform.Translate(HorizontalAxis, 0, getForwardMovementSpeed() * Time.fixedDeltaTime);
    }

}