using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OpenFirstScene : MonoBehaviour
{
    public Button mybutton1;
    public string sceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        mybutton1.onClick.AddListener(whattodo);
    }

    public void whattodo()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
