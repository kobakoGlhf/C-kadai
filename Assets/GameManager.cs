using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int _hp; 
    int _attack;
    int _armor;
    int _mobility;
    //BeasItem _hood;
    //BeasItem _plate;
    //BeasItem _pants;
    //BeasItem _gloves;
    //BeasItem _boots;

    //�e�X�g�p�B��ŏꏊ���ƂɃA�C�e�����擾���Ă�������
    [SerializeField] BeasItem _hood;
    [SerializeField] BeasItem _plate;
    [SerializeField] BeasItem _pants;
    [SerializeField] BeasItem _gloves;
    [SerializeField] BeasItem _boots;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DamageCalculate()
    {

    }
    void HPCount(int armorHP)
    {

    }
}
