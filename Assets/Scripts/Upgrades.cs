using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    [SerializeField] Text clickLevel, autoLevel, clickCost, autoCost;
    private int costClick = 10, levelClick = 1, costAuto = 10, levelAuto = 0;
    private float timer;
    public void clickPay()
    {
        if (Counter.money >= costClick)
        {
            levelClick++;
            Counter.click += 1;
            Counter.money -= costClick;
            Counter._money -= costClick;
            costClick += 5;
        }
    }
    public void autoPay()
    {
        if (Counter.person >= costAuto)
        {
            levelAuto++;
            Counter.person -= costAuto;
            costAuto += 10;
        }
    }
    private void FixedUpdate()
    {
        clickLevel.text = levelClick.ToString();
        autoLevel.text = levelAuto.ToString();
        clickCost.text = costClick.ToString();
        autoCost.text = costAuto.ToString();
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            timer = 0;
            Counter.money += Counter.click * levelAuto;
        }
    }
}
