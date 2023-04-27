using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public static int money = 0, person, temp = 0, click = 1, clickCounter = 0, _money;
    [SerializeField] Text OP, BP;
    [SerializeField] GameObject BPanim;
    private Animator bd1;
    [SerializeField] GameObject building1;
    private int _person, desMoney, _desMoney;

    private void Start()
    {
        bd1 = building1.GetComponent<Animator>();
    }
    public void count()
    {
        money += click;
        if (person > temp)
        {
            BPanim.GetComponent<Animation>().Play("addHuman");
            temp++;
        }

    }
    private void FixedUpdate()
    {
        desMoney = money / 10 % 10;
        _desMoney = _money / 10 % 10;
        OP.text = money.ToString();
        BP.text = person.ToString();
        if (Mathf.Abs(desMoney - _desMoney) > 0)
        {
            if (desMoney == 0)
            {
                person++;
            }
            else
            {
                person += Mathf.Abs(desMoney - _desMoney);
            }
            _money = money;
        }
    }
}
