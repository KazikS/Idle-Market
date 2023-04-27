using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [SerializeField] GameObject building1, building2, building3;
    private Animator bd1, bd2, bd3;
    private float timer;
    void Start()
    {
        bd1 = building1.GetComponent<Animator>();
        bd2 = building2.GetComponent<Animator>();
        bd3 = building3.GetComponent<Animator>();
        bd1.SetTrigger("Open");
    }
    public void OpenClose(){
        if(LevelUp.lvl1 == true){
            bd1.SetTrigger("Close");
            building1.SetActive(false);
            building2.SetActive(true);
            bd2.SetTrigger("Open");
        }
        if(LevelUp.lvl2 == true){
            bd2.SetTrigger("Close");
            building2.SetActive(false);
            building3.SetActive(true);
            bd3.SetTrigger("Open");
        }
    }
    private void Update()
    {

    }
}
