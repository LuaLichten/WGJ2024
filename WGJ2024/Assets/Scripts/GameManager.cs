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

    private bool orderTriggered = false;
    private bool waitressTriggered = false;
    private bool restroomTriggered = false;
    private bool truckTriggered = false;
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
        orderTriggered = CheckEvent(orderTriggerTime, orderTriggered, onOrderTime, ItemName.Order);
        waitressTriggered = CheckEvent(waitressTriggerTime, waitressTriggered, onWaitressTime, ItemName.Waitress);
        restroomTriggered = CheckEvent(restroomTriggerTime, restroomTriggered, onRestroomTime, ItemName.Restroom);
        truckTriggered = CheckEvent(truckTriggerTime, truckTriggered, onTruckTime, ItemName.Truck);
        if (elapsedTime >= limitGameTime)
        {
            SceneManager.LoadScene("Menu");
            return;
        }

    }

    private bool CheckEvent(float time, bool condition, GameItemNameEvent eventName, ItemName name)
    {
        if (!condition && elapsedTime >= time)
        {
            Debug.Log("aiai");
            eventName.TriggerEvent(name);
            return true;
        }
        if (condition)
            return true;

        return false;
    }
}
