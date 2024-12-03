using UnityEngine;

public class VoidCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); // Destruye cualquier objeto que toque el VoidCollider
    }
}
