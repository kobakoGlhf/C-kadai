using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : StatusBeas
{
    public override void Death()
    {
        Destroy(this.gameObject);
    }
}
