using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackController : MonoBehaviour
{
    public List<GameObject> blockList = new List<GameObject>();

    private GameObject lastBlockObject;
    // Start is called before the first frame update
    void Start()
    {
        UpdateLastBlockObject();
    }

    public void increaseBlockState(GameObject _gameObject) {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.04f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastBlockObject.transform.position.x, lastBlockObject.transform.position.y - 0.04f, lastBlockObject.transform.position.z);
        _gameObject.transform.SetParent(transform);
        blockList.Add(_gameObject);
        UpdateLastBlockObject();

    }

    public void decreaseBlockState(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blockList.Remove(_gameObject);
        UpdateLastBlockObject();
        //Destroy(_gameObject, 1.5f); Bu arkada kalan küpleri yok ediyor 
    }

    private void UpdateLastBlockObject() {
        lastBlockObject = blockList[blockList.Count - 1];
    }
}
