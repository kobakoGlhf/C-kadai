using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BeasStatus
{
    // Start is called before the first frame update
    void Start()
    {
        _health = 10;
        _attack = 10;
        _armor = 10;
        _weight = 10;
    }

    // Update is called once per frame
    void Update()
    {

        if (this._health <= 0)
        {
            Debug.Log(this.name + " Ž€–S");
            this.gameObject.SetActive(false);
        }
    }
}
