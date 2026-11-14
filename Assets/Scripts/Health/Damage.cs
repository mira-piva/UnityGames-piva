using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] float damage = 30f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Health health = other.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamege(damage);
            }
        }

    }
}