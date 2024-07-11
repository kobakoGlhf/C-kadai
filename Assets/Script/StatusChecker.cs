using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StatusChecker : MonoBehaviour
{
    [SerializeField]Player _player;
    ItemBeas _item;
    [SerializeField] ItemBeas.BodyParts _bodyParts;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void ItemChangeCount()
    {
        _item = GetComponent<ItemBeas>();
        if (_item != null && _item._bodyParts == _bodyParts) 
        {
            _player._health += _item._healthPoint;
        }
    }
}
