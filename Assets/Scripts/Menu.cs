using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject upgrades, levels, addBoosts, upBtn, lvlBtn, addBoostsBtn, setBtn, setWindow, closeAllWindowsBtn;
    private Animation upgradeAnim, levelsAnim, addBoostsAnim, upBtnAnim, lvlBtnAnim, addBoostsBtnAnim, setBtnAnim, setWindowAnim;
    private bool upgradeTrigger, levelsTrigger, addBoostsTrigger, settingsTrigger;
    private void Start()
    {
        upgradeAnim = upgrades.GetComponent<Animation>();
        levelsAnim = levels.GetComponent<Animation>();
        addBoostsAnim = addBoosts.GetComponent<Animation>();
        upBtnAnim = upBtn.GetComponent<Animation>();
        lvlBtnAnim = lvlBtn.GetComponent<Animation>();
        addBoostsBtnAnim = addBoostsBtn.GetComponent<Animation>();
        setBtnAnim = setBtn.GetComponent<Animation>();
        setWindowAnim = setWindow.GetComponent<Animation>();
        closeAllWindowsBtn.SetActive(false);
    }
    public void UpgradeAnimation()
    {
        if (upgradeTrigger == false)
        {
            if (levelsTrigger == true)
            {
                levelsAnim.Play("DownWindow");
                levelsTrigger = false;
            }
            if (addBoostsTrigger == true)
            {
                addBoostsAnim.Play("DownWindow");
                addBoostsTrigger = false;
            }
            upBtnAnim.Play("ResizeButton");
            upgradeAnim.Play("UpWindow");
            closeAllWindowsBtn.SetActive(true);
            upgradeTrigger = true;
        }
        else
        {
            upBtnAnim.Play("ResizeButton");
            upgradeAnim.Play("DownWindow");
            closeAllWindowsBtn.SetActive(false);
            upgradeTrigger = false;
        }
    }
    public void LevelsAnimation()
    {
        if (levelsTrigger == false)
        {

            if (upgradeTrigger == true)
            {
                upgradeAnim.Play("DownWindow");
                upgradeTrigger = false;
            }
            if (addBoostsTrigger == true)
            {
                addBoostsAnim.Play("DownWindow");
                addBoostsTrigger = false;
            }
            lvlBtnAnim.Play("ResizeButton");
            levelsAnim.Play("UpWindow");
            closeAllWindowsBtn.SetActive(true);
            levelsTrigger = true;
        }
        else
        {
            lvlBtnAnim.Play("ResizeButton");
            levelsAnim.Play("DownWindow");
            closeAllWindowsBtn.SetActive(false);
            levelsTrigger = false;
        }
    }
    public void AddBoostsAnimation()
    {
        if (addBoostsTrigger == false)
        {

            if (upgradeTrigger == true)
            {
                upgradeAnim.Play("DownWindow");
                upgradeTrigger = false;
            }
            if (levelsTrigger == true)
            {
                levelsAnim.Play("DownWindow");
                levelsTrigger = false;
            }
            addBoostsBtnAnim.Play("ResizeButton");
            addBoostsAnim.Play("UpWindow");
            closeAllWindowsBtn.SetActive(true);
            addBoostsTrigger = true;
        }
        else
        {
            addBoostsBtnAnim.Play("ResizeButton");
            addBoostsAnim.Play("DownWindow");
            closeAllWindowsBtn.SetActive(false);
            addBoostsTrigger = false;
        }
    }
    public void Settings()
    {
        if (settingsTrigger == false)
        {
            setBtnAnim.Play("RotateButtonLeft");
            setWindowAnim.Play("DownWindow");
            closeAllWindowsBtn.SetActive(true);
            settingsTrigger = true;
        }
        else
        {
            setBtnAnim.Play("RotateButtonRight");
            setWindowAnim.Play("UpWindow");
            closeAllWindowsBtn.SetActive(false);
            settingsTrigger = false;
        }
    }
    public void CloseAll(){
        if(upgradeTrigger == true){
            upgradeAnim.Play("DownWindow");
            closeAllWindowsBtn.SetActive(false);
            upgradeTrigger = false;
        }
        if(levelsTrigger == true){
            levelsAnim.Play("DownWindow");
            closeAllWindowsBtn.SetActive(false);
            levelsTrigger = false;
        }
        if(addBoostsTrigger == true){
            addBoostsAnim.Play("DownWindow");
            closeAllWindowsBtn.SetActive(false);
            addBoostsTrigger = false;
        }
        if(settingsTrigger == true){
            setWindowAnim.Play("UpWindow");
            closeAllWindowsBtn.SetActive(false);
            settingsTrigger = false;
        }
    }
}
