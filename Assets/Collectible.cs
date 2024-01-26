using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Add points or other effects
            Destroy(gameObject);
        }
    }
}
