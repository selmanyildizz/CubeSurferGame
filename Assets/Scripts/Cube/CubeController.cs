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
            if(!isStack)
            {
                print("Here");
                isStack = true;
                stackController.increaseBlockState(gameObject);
            }
        }
    }
}
