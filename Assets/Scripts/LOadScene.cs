using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOadScene : MonoBehaviour
{
    public void AboutUs(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
