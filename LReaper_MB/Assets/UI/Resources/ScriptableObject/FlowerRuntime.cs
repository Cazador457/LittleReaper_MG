using UnityEngine;
using System;
[Serializable]
public class FlowerRuntime
{
    public string Id;
    public Sprite Sprite;
    public string FlowerName;
    public string Descriptation;
    public FlowerType FlowerType;
    public float LifeTime;

    public FlowerRuntime(string id,Sprite sprite,string flowerName,string descriptation,FlowerType flowerType,float lifeTime)
    {
        Id = id;
        Sprite = sprite;
        FlowerName = flowerName;
        Descriptation = descriptation;
        FlowerType = flowerType;
        LifeTime = lifeTime;
    }
}
