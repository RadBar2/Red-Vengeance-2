using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtBar : MonoBehaviour
{
    public Transform bar;

    public void ScaleBar(int health, int damage)
    {
        var scale = bar.localScale;
        scale.x = health / 100f;
        bar.localScale = scale;
    }
}
