using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restroom : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene("End Toilet");
    }
}
