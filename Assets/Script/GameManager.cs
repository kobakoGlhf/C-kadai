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

    //テスト用。後で場所ごとにアイテムを取得してください
    [SerializeField] ItemBeas _hood;
    [SerializeField] ItemBeas _plate;
    [SerializeField] ItemBeas _pants;
    [SerializeField] ItemBeas _gloves;
    [SerializeField] ItemBeas _boots;

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
