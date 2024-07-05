using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BeasItem : MonoBehaviour
{
    [SerializeField] int _healthPoint;
    [SerializeField] int _attackPoint;
    [SerializeField] int _armorPoint;
    [SerializeField] float _weight;
    [SerializeField]BodyParts _bodyParts=BodyParts.Hood;
    GameManager _player;
    private void Start()
    {
        _player = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        Vector2 mousePos=Input.mousePosition;
        Debug.Log(mousePos);

        //ドラックアンドドロップを作る
        if (Input.GetMouseButtonDown(0))
        {

        }
        if (Input.GetMouseButtonUp(1))
        {

        }
    }
    enum BodyParts
    {
        Hood,
        Plate,
        Pants,
        Gloves,
        Boots,
    }
}
