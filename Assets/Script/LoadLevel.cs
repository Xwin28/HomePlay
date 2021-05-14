using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour
{
    public void LoadS(int sceneANumbe)
    {
        SceneManager.LoadScene(sceneANumbe);
    }
}
