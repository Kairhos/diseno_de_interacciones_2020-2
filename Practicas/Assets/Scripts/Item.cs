using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType{
    Weapon,
    Equip,
    Medicine
};

[CreateAssetMenu(fileName = "Nuevo item", menuName = "Inventario/Generic Item")]
public class Item : ScriptableObject {
    public Sprite icon = null;
    public ItemType itemType = ItemType.Equip;
    public string message = null;

    public virtual void Use(){
        Debug.Log(message + name);
    }
}