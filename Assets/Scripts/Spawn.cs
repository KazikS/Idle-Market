using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject[] humans;
    [SerializeField] GameObject build;
    private int num, temp, buildnum;
    private float posX;
    public Transform parent;
    // posX: lvl1 - (-113.411) - (-113.105), lvl2 - (-113.638) - (-113.525), lvl3 - (-113.485) - (-112.334)
    private void Update()
    {
        if (Counter.person > temp)
        {
            if (LevelUp.lvl1 == false && LevelUp.lvl2 == false)
            {
                posX = Random.Range(-113.411f, -113.105f);
            }
            if (LevelUp.lvl1 == true && LevelUp.lvl2 == false)
            {
                posX = Random.Range(-113.638f, -113.525f);
            }
            if (LevelUp.lvl1 == true && LevelUp.lvl2 == true)
            {
                posX = Random.Range(-113.485f, -112.334f);
            }
            num = Random.Range(0, 2);
            Instantiate(humans[num], new Vector2(posX, -4.558396f), Quaternion.identity, parent);
            temp = Counter.person;
        }


    }

}
