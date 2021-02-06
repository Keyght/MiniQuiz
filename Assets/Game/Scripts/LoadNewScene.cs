using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNewScene : MonoBehaviour
{
    public string sceneToLoad;
    private void OnMouseDown()
    {
        LoadScene();
        Debug.Log("NewScene");
    }
    public void LoadScene() {
        SceneManager.LoadScene(sceneToLoad);
    }
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
