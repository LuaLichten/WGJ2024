using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public GameObject textPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowText()
    {
        textPanel.SetActive(true);
        textPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "AAAAA";
    }
}
