using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public Stats strength;
    public Stats damage;
    public Stats maxHealth;

    [SerializeField]private int curremtHealth;

    protected virtual void Start()
    {
        curremtHealth = maxHealth.GetValue();
    }

    public virtual void DoDamage(CharacterStats _targetStats)
    {


        int totalDamage = damage.GetValue() + strength.GetValue();

        _targetStats.TakeDamage(totalDamage);
    }

    public virtual void TakeDamage(int _damage)
    {
        curremtHealth -= _damage;

        Debug.Log(_damage);

        if(curremtHealth < 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        //throw new NotImplementedException();
    }
}
