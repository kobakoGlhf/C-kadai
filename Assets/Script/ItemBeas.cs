using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class ItemBeas : MonoBehaviour
{
    public int _healthPoint;
    public int _attackPoint;
    public int _armorPoint;
    public float _weight;
    [SerializeField] public BodyParts _bodyParts = BodyParts.Hood;
    Player _player;
    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }
    public enum BodyParts
    {
        Hood,
        Plate,
        Pants,
        Gloves,
        Boots,
    }
}
