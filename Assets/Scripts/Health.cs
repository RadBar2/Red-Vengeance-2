using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Threading;

public class Health : MonoBehaviour
{
    public int maxHealt = 200;

    public UnityEvent<int, int> onDamage;
    public UnityEvent<int, int> onHeal;
    public UnityEvent onDeath;

    int hp;
    int dot;

    private void Start()
    {
        hp = maxHealt;
    }

    public void Heal(int health)
    {
        hp += health;
        hp = hp > maxHealt ? maxHealt : hp;
        onHeal.Invoke(hp, health);
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        hp = hp < 0 ? 0 : hp;
        
        onDamage.Invoke(hp, damage);

        if (hp < maxHealt)
        {
            dot = (int)(damage * 0.01f * (maxHealt - hp) );
            onDamage.Invoke(hp, dot);
        }

        if (hp <= 0)
        {
            onDeath.Invoke();
            Destroy(this);
        }

    }
}
