using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private int level = 1;
    GameObject greenCube;
    GameObject redCube;

    // Start is called before the first frame update
    void Start()
    {
        greenCube = GameObject.Find("/cubeGreenReplica");
        redCube = GameObject.Find("/ObstacleCube");
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
        float xPosition = Random.Range(-0.107f, 0.091f);
        float yPosition = 4.08211f;
        float zPosition = transform.position.z + Random.Range(0f, 15f);
        Vector3 newCube = new Vector3(xPosition, yPosition, zPosition);
        GameObject temp = Instantiate(greenCube, newCube, Quaternion.identity);
        temp.name = "cubeGreen";
        temp.SetActive(true);
        int numberRed = Random.Range(1, 3);
        float[] xPositions = { 0.0936f, 0.0462f, -0.0028f, -0.0513f, -0.0981f };
        for(int i = 0;i<numberRed;i++)
        {
            float zPositionTemp = transform.position.z + Random.Range(0f, 15f);
            for (int j =0;j<5;j++)
            {
                Vector3 pos = new Vector3(xPositions[j], yPosition + (4.12f-yPosition) * i, zPositionTemp);
                GameObject redCubeClone = Instantiate(redCube, pos, Quaternion.identity);
                redCubeClone.name = "ObstacleCube";
                redCubeClone.SetActive(true);
            }
        }
    }
}
