using System;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "FlowerData")]
public class FlowerDataSO : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private string _flowerName;
    [SerializeField] private string _descriptation;
    [SerializeField] private FlowerType _flowerType;
    [SerializeField] private float _lifeTime;
    public string Id => _id;
    public Sprite Sprite => _sprite;
    public string FlowerName => _flowerName;
    public string Descriptation => _descriptation;
    public FlowerType FlowerType => _flowerType;
    public float LifeTime => _lifeTime;

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