using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    [SerializeField] Image level1, level2, level3;
    public static bool lvl1, lvl2, lvl3;
    private float frst = 0, scnd = 11, thrd = 21, step1, step2, step3;
    public void first()
    {
        step1 = 1 / 10f;
        level1.fillAmount += step1;
    }
    public void second()
    {
        step2 = 1 / 20f;
        level2.fillAmount += step2;
    }
    public void third()
    {
        step3 = 1 / 30f;
        level3.fillAmount += step3;
    }
    public void progress()
    {
        if ((Counter.person >= 0 && Counter.person <= 10) && Counter.person > frst)
        {
            first();
            frst++;
        }
        if ((Counter.person >= 11 && Counter.person <= 31) && Counter.person > scnd)
        {
            second();
            scnd++;
        }
        if ((Counter.person >= 31 && Counter.person <= 60) && Counter.person > thrd)
        {
            third();
            thrd++;
        }
    }
    public void level()
    {
        if (Counter.person >= 10 && lvl1 == false)
        {
            lvl1 = true;
        }
        if (Counter.person >= 20 && lvl2 == false)
        {
            lvl2 = true;
        }
    }
}
