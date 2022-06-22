using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : Interactable
{

    public string Switch;
    public override void interact()
    {
        sceneswitch(Switch);
    }
    public void sceneswitch(string index)
    {
        SceneManager.LoadScene(index);
    }


}
