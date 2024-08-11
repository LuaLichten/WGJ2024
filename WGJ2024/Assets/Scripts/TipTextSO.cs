using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TipText")]
public class TipTextSO : ScriptableObject
{
    public string text;
    public ItemName itemName;
    public int minTryIndex;
}
