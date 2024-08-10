using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameItemNameEventListener : MonoBehaviour
{
    public GameItemNameEvent gameEvent;
    public UnityItemNameEvent onEventTriggered;
    void OnEnable()
    {
        gameEvent.AddListener(this);
    }
    void OnDisable()
    {
        gameEvent.RemoveListener(this);
    }
    public void OnEventTriggered(ItemName itemName)
    {
        onEventTriggered.Invoke(itemName);
    }
}

[System.Serializable]
public class UnityItemNameEvent : UnityEvent<ItemName> { }
