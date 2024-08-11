using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Tempo de duracao limite do jogo em segundos")]
    public float limitGameTime;
    [Header("Tempo decorrido ate evento da comanda em segundos")]
    public float orderTriggerTime;
    [Header("Tempo decorrido ate evento da garconete em segundos")]
    public float waitressTriggerTime;
    [Header("Tempo decorrido ate evento do banheiro em segundos")]
    public float restroomTriggerTime;
    [Header("Tempo decorrido ate evento do caminhao em segundos")]
    public float truckTriggerTime;
    public GameItemNameEvent onOrderTime;
    public GameItemNameEvent onWaitressTime;
    public GameItemNameEvent onRestroomTime;
    public GameItemNameEvent onTruckTime;

    private bool orderTriggered;
    private bool waitressTriggered;
    private bool restroomTriggered;
    private bool truckTriggered;
    private float elapsedTime;
    void Start()
    {
        elapsedTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        //Debug.Log(elapsedTime);
        CheckEvent(orderTriggerTime, orderTriggered, onOrderTime, ItemName.Order);
        CheckEvent(waitressTriggerTime, waitressTriggered, onWaitressTime, ItemName.Waitress);
        CheckEvent(restroomTriggerTime, restroomTriggered, onRestroomTime, ItemName.Restroom);
        CheckEvent(truckTriggerTime, truckTriggered, onTruckTime, ItemName.Truck);
        if (elapsedTime >= limitGameTime)
        {
            SceneManager.LoadScene("Menu");
            return;
        }

    }

    private void CheckEvent(float time, bool condition, GameItemNameEvent eventName, ItemName name)
    {
        if (!condition && elapsedTime >= time)
        {
            eventName.TriggerEvent(name);
            condition = true;
        }
            

    }
}
