using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public GameObject textPanel;
    public List<TipTextSO> tipTexts;

    private int tryIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowText(ItemName name)
    {
        textPanel.SetActive(true);
        textPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = FindText(name).text;
    }

    public TipTextSO FindText(ItemName name)
    {
        return tipTexts.Find(x => x.itemName.Equals(name) && x.minTryIndex <= tryIndex);
    }
}
