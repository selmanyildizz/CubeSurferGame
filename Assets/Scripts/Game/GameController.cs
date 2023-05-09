using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private int level = 1;
    GameObject greenCube;

    // Start is called before the first frame update
    void Start()
    {
        greenCube = GameObject.Find("/cubeGreen");
        Debug.Log(greenCube);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int getLevel()
    {
        return level;
    }

    public void increaseLevel()
    {
        level += 1;
    }

    public void addCubes()
    {
        Vector3 newCube = new Vector3(transform.position.x, transform.position.y + transform.position.z + 2f);
        Instantiate(greenCube, newCube, Quaternion.identity);
    }
}
