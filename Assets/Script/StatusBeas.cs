using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public abstract class StatusBeas : MonoBehaviour
{
    public float _health;
    public int _attack;
    public int _armor;
    public float _weight;
    Animator _anim;
    float _timer;
    public StatusBeas _enemyStatus;
    private void Start()
    {
        _anim = GetComponent<Animator>(); 
        StatusChange();
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= AttackCoolTime()&&AttackTiming())
        {
            if (_enemyStatus != null)
            {
                Attack(_enemyStatus);
                AttackResult();
            }
            _timer = 0;
        }
        if ((int)this._health <= 0)
        {
            Death();
        }
    }
    public virtual void AttackResult()
    {
        Debug.Log((int)_enemyStatus._health);
    }
    public virtual bool AttackTiming()
    {
        return true;
    }
    float AttackCoolTime()
    {
        float CoolTime;
        if (_weight > 10)
        {
            CoolTime = 4;
        }
        else if(_weight <= 10&&_weight>6)
        {
            CoolTime = 3;
        }
        else if (_weight <= 6 && _weight > 3)
        {
            CoolTime = 2;
        }
        else
        {
            CoolTime = 1;
        }
        return CoolTime;
    }
    public virtual void Death()
    {
        Debug.Log(this.name + " Ž€–S");
        this.gameObject.SetActive(false);
    }
    public virtual void StatusChange()
    {

    }
    public void Attack(StatusBeas enemyStatus)
    {
        _anim.Play("Attack");
        float damage = ((float)this._attack * 0.5f) - ((float)enemyStatus._armor * 0.25f);
        if (damage < 1)
        {
            damage = 1;
        }
        else enemyStatus._health -= damage;
    }
}
