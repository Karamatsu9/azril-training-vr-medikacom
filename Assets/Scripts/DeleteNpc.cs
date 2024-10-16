using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    // The tag of the NPC clones
    public string npcTag = "Npc";

    private void OnCollisionEnter(Collision collision)
    {
        DestroyNpc(collision.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        DestroyNpc(other.gameObject);
    }

    private void DestroyNpc(GameObject collisionObject)
    {
        if (collisionObject.CompareTag(npcTag))
        {
            Destroy(collisionObject);
        }
    }
}