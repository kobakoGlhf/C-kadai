using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : StatusBeas
{
    public override bool AttackTiming()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("true");
            return true;
        }
        else return false;
    }
    public override void StatusChange()
    {
        _health = 10;
        _attack = 10;
        _armor = 10;
        _weight = 10;
    } 
}
