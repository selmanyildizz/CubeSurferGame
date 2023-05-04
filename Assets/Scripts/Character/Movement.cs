using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    [SerializeField] private InputController inputController;

    [SerializeField] private float forwardMovementSpeed = 0.5f;

    [SerializeField] private float horizontalMovementSpeed = 4f;


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
        if(newPositionX>= 0.091f)
        {
            newPositionX = 0.091f;
        } else if(newPositionX<= -0.107f)
        {
            newPositionX = -0.107f;
        }
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
        //float HorizontalAxis = inputController.getHorizontalValue() * horizontalMovementSpeed * Time.fixedDeltaTime;
        //transform.Translate(HorizontalAxis, 0, getForwardMovementSpeed() * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== "ObstacleCube")
            
        {
            Debug.Log("RESET");
            Invoke("reset", 1f);
        }

    }
    void reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);//menüye gönderiyor.
    }

}