using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
public class OpenDoor2 : MonoBehaviour
{
    public Button mybutton1;
    public Button mybutton2;
    public Button mybutton3;
    public int i = 0;
    public GameObject door2;
    public GameObject quastion_board1;
    public GameObject part_cube11;
    public GameObject part_cube21;
    public GameObject part_cube31;
    public GameObject part_cube12;
    public GameObject part_cube22;
    public GameObject part_cube32;


    void Start()
    {
        mybutton1.onClick.AddListener(whattodo1);
        mybutton2.onClick.AddListener(whattodo2);
        mybutton3.onClick.AddListener(whattodo3);
    }
    void whattodo1()
    {
        iplus();
        quastion_board1.SetActive(true);
        Debug.Log("You pressed button 2");
        Debug.Log("I more then zero" + i);
    }
    void whattodo2()
    {
        iplus();
        quastion_board1.SetActive(true);
        Debug.Log("You pressed button 2");
        Debug.Log("I more then zero" + i);
    }
    void whattodo3()
    {
        check();
        Debug.Log("You pressed button 3");
    }
    public void iplus()
    {
        i++;
    }
    private void OnMouseDown()
    {
        Debug.Log("button2 clicked");
    }
    public void Open()
    {
        door2.SetActive(false);
        Debug.Log("tabbed button");
    }
    public void check()
    {
        if (i > 0)
        {
            part_cube11.SetActive(false);
            part_cube21.SetActive(false);
            part_cube31.SetActive(false);
            part_cube12.SetActive(true);
            part_cube22.SetActive(true);
            part_cube32.SetActive(true);
            quastion_board1.SetActive(false);
            Open();
        }
    }
}


