using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToChange : MonoBehaviour
{
    private void Update()
    {
        MouseClick();
    }
    public void MouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(1); // SceneManager.LoadScene(SceneIndex);
        }
    }
}
