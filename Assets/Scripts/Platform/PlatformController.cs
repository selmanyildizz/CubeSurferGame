using UnityEngine;

public class PlatformController : MonoBehaviour
{
    GameObject existPlatform = null;
    GameObject newPlatform;

    private enum platform { prevEnvironment, nextEnvironment};
    private bool passed = false;
    private void OnTriggerEnter(Collider other)
    {

            Debug.Log(other.name);
            // If player is end of the road create new Environment
            if (other.tag == "Player")
            {
            if (passed) return;
                existPlatform = findExistGameObject(platform.prevEnvironment);
                newPlatform = createCopy(existPlatform);
                newPlatform.name = platform.nextEnvironment.ToString();
                newPlatform.tag = platform.nextEnvironment.ToString();
                newPlatform.transform.position = new Vector3(existPlatform.transform.position.x, existPlatform.transform.position.y, existPlatform.transform.position.z + 21.94f);

            if (existPlatform != null)
            {
                if (passed) return;
                Destroy(existPlatform);
                newPlatform.name = platform.prevEnvironment.ToString();
                newPlatform.tag = platform.prevEnvironment.ToString();
            }

            passed = true;

        }

            // If player is on the new road, destroying previous one
            
       
    }

    private GameObject findExistGameObject(platform gameObjectName)
    {
        return GameObject.FindGameObjectWithTag(gameObjectName.ToString());
    }

    private GameObject createCopy(GameObject _gameObject)
    {
        return Instantiate(_gameObject);
    }
}
