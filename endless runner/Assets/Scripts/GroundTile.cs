
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundspawner;
    // Start is called before the first frame update
    void Start()
    {
        groundspawner = GameObject.FindObjectOfType<GroundSpawner>();   
    }
    private void OnTriggerExit(Collider other)
    {
        groundspawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
