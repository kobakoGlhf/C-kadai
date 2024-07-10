using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BeasStatus
{
    [SerializeField] BeasStatus _enemy;
    // Start is called before the first frame update
    void Start()
    {
        StatusChange();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (_enemy != null)
            {
                Attack(_enemy);
                Debug.Log(Damage(_enemy._armor));
                Debug.Log((int)_enemy._health);
            }
        }
        if (this._health <= 0)
        {
            Debug.Log("Ž€–S");
        }
    }
    void StatusChange()
    {
        if (_enemy != null)
        {
            _health = 10;
            _attack = 10;
            _armor = 10;
            _weight = 10;
        }
    }
}
