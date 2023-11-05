using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    public int heal = 20;

    private void OnCollisionEnter(Collision collision)
    {
        var health = collision.gameObject.GetComponent<Health>();

        if(health != null)
        {
            health.Heal(heal);

            Destroy(gameObject);
        }
    }
}
