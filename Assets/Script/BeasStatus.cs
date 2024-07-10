using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BeasStatus : MonoBehaviour
{
    public float _health;
    public int _attack;
    public int _armor;
    public float _weight;
    // Start is called before the first frame update
    public void Attack(BeasStatus enemyStatus)
    {
        enemyStatus._health-=Damage(enemyStatus._armor);
    }
    public float Damage(float enemyArmor)
    {
        float damage=((float)this._attack * 0.5f) - ((float)enemyArmor * 0.25f);
        if (damage < 0)
        {
            damage = 0;
        }
        return damage;
    }
}
