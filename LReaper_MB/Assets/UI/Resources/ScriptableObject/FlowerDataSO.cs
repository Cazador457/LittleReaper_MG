using System;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Flower")]
public class FlowerDataSO : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private string _flowerName;
    [SerializeField] private string _descriptation;
    [SerializeField] private FlowerType _flowerType;
    [SerializeField] private float _lifeTime;
    public string id => _id;
    public Sprite sprite => _sprite;
    public string flowerName => _flowerName;
    public string descriptation => _descriptation;
    public FlowerType flowerType => _flowerType;
    public float lifeTime => _lifeTime;

}
public enum FlowerType
{
    Cempasuchitl,
    Cuetlaxochitl,
    Helleborus,
    Crisantemos,
    Rosas,
    Lirios,
    Margaritos,
    Gladiolos,
    Claveles
}