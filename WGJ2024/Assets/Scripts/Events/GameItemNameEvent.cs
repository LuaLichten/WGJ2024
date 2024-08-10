using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Game ItemName Event")]
public class GameItemNameEvent : ScriptableObject
{
    private List<GameItemNameEventListener> listeners = new List<GameItemNameEventListener>();
    public void TriggerEvent(ItemName itemName)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventTriggered(itemName);
        }
    }
    public void AddListener(GameItemNameEventListener listener)
    {
        listeners.Add(listener);
    }
    public void RemoveListener(GameItemNameEventListener listener)
    {
        listeners.Remove(listener);
    }
}
