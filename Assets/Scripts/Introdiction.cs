using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introdiction : MonoBehaviour
{
    [SerializeField] GameObject man, PreviewBlock, DialogsParent;
    [SerializeField] GameObject[] dialogs;
    private int num = 0;

    private void Start()
    {
            PreviewBlock.SetActive(true);
            man.GetComponent<Animation>().Play("Enter");
            dialogs[num].GetComponent<Animation>().Play("DialogUp");
            PlayerPrefs.SetInt("firstRun", 0);
        
    }

    public void ChangeDialog()
    {
        if (num < 6)
        {
            dialogs[num].GetComponent<Animation>().Play("DialogDown");
            num++;
            dialogs[num].GetComponent<Animation>().Play("DialogUp");
        }
        else
        {
            dialogs[num].GetComponent<Animation>().Play("DialogDown");
            man.GetComponent<Animation>().Play("Exit");
            PreviewBlock.SetActive(false);
        }
    }
}
