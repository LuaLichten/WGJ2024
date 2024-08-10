using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemName
{
    RecipeBook
}
public class Iteractable : MonoBehaviour
{
    [SerializeField]
    private ItemName itemName;
    public GameItemNameEvent gameEvent;
    void Start()
    {
        
    }

    public void Iteract()
    {
        gameEvent.TriggerEvent(itemName);
    }
}
