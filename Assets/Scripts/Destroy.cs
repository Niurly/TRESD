using UnityEngine;

public class DestroyOnRoad : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Road")) // Etiqueta la carretera como "Road"
        {
            Destroy(gameObject, 2f); // Destruye después de 2 segundos
        }
    }
}
