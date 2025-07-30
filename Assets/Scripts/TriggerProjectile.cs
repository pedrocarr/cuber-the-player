using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectilesToActivate;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (GameObject projectile in projectilesToActivate)
            {
                if (projectile != null)
                    projectile.SetActive(true);
            }

            Destroy(gameObject);
        }

    }
}
