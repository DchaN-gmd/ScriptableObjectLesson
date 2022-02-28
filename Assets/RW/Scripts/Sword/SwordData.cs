using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sword Data", menuName = "Sword Data", order = 51)]
public class SwordData : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Sprite _icon;
    [SerializeField] private int _goldCost;
    [SerializeField] private int _attackDamage;

    public string GetName { get { return _name; } }
    public string GetDescription { get { return _description; } }
    public Sprite GetIcon { get { return _icon; } }
    public int GetCost { get { return _goldCost; } }
    public int GetDamage { get { return _attackDamage; } }
}
