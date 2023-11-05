using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePowerUp : MonoBehaviour
{
    public Bullet bullet;

    public int duration = 5;
    public int bonusDamage = 3;

    private int oldDamage;

    private void OnCollisionEnter(Collision collision)
    {
        bullet = collision.gameObject.GetComponent<Bullet>();
        if (bullet != null )
        {
            oldDamage = bullet.maxDamage;
            bullet.maxDamage += bonusDamage;
        }
        
        Invoke(nameof(Expire), duration);
    }

    void Expire()
    {
        if (bullet != null)
        {
            bullet.maxDamage = oldDamage;
        }
        Destroy(gameObject);
    }
}
