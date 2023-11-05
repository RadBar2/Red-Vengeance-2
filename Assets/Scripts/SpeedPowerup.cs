using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour
{
    public Player player;

    public float duration = 5;
    public float speed = 100;

    private float oldSpeed;

    private void OnCollisionEnter(Collision collision)
    {
        player = collision.gameObject.GetComponent<Player>();

        if (player != null)
        {
            var newPos = transform.position;
            newPos.y = 100;
            transform.position = newPos;

            oldSpeed = player.speed;
            player.speed += speed;

            Invoke(nameof(Expire), duration);
        }
    }

    void Expire()
    {
        if (player != null)
        {
            player.speed = oldSpeed;
        }
        Destroy(gameObject);
    }
}
