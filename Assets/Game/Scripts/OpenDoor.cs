using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
    private void OnMouseDown()
    {
        Open();
    }
    public void Open() {
        door.SetActive(false);
        Debug.Log("tabbed button");
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
