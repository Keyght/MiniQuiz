using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class ArmCheker : MonoBehaviour
{
    public Button mybutton1;
    public Button mybutton2;
    public Button mybutton3;
    public Button mybutton4;
    public Button mybutton5;
    public Button mybutton6;
    public Button mybutton7;
    public Button mybutton8;
    public GameObject door2;
    public GameObject arm1;
    public GameObject arm1up;
    public GameObject arm1down;
    public GameObject arm2;
    public GameObject arm2up;
    public GameObject arm2down;
    public GameObject arm3;
    public GameObject arm3up;
    public GameObject arm3down;
    public GameObject arm4;
    public GameObject arm4up;
    public GameObject arm4down;
    public GameObject arm5;
    public GameObject arm5up;
    public GameObject arm5down;
    public GameObject arm6;
    public GameObject arm6up;
    public GameObject arm6down;
    public GameObject arm7;
    public GameObject arm7up;
    public GameObject arm7down;
    public GameObject arm8;
    public GameObject arm8up;
    public GameObject arm8down;
    public int arm1_state = 0;
    public int arm2_state = 0;
    public int arm3_state = 0;
    public int arm4_state = 0;
    public int arm5_state = 0;
    public int arm6_state = 0;
    public int arm7_state = 0;
    public int arm8_state = 0;
    public double i1 = 0;
    public double i2 = 0;
    public double i3 = 0;
    public double i4 = 0;
    public double i5 = 0;
    public double i6 = 0;
    public double i7 = 0;
    public double i8 = 0;

    void Start()
    {
        mybutton1.onClick.AddListener(whattodo1);
        mybutton2.onClick.AddListener(whattodo2);
        mybutton3.onClick.AddListener(whattodo3);
        mybutton4.onClick.AddListener(whattodo4);
        mybutton5.onClick.AddListener(whattodo5);
        mybutton6.onClick.AddListener(whattodo6);
        mybutton7.onClick.AddListener(whattodo7);
        mybutton8.onClick.AddListener(whattodo8);
    }
    public void whattodo1()
    {
        arm1.SetActive(false);
        i1+=0.5;
       // iplus();
        if (i1 %2 !=0)
        {
            Debug.Log("not 2");
            arm1up.SetActive(true);
            arm1down.SetActive(false);
            arm1_state = 1;
        }
        else if (i1%2 == 0)
        {
            Debug.Log("kr 2");
            arm1down.SetActive(true);
            arm1up.SetActive(false);
            arm1_state = 0;
        }
        if ((arm1_state==1)&(arm3_state == 1)& (arm4_state == 1)& (arm5_state == 1)& (arm6_state == 1)& (arm7_state == 1))
        {
            Open();
        }
    }
    public void whattodo2()
    {
        arm2.SetActive(false);
        i2 += 1;
        // iplus();
        if (i2 % 2 != 0)
        {
            Debug.Log("not 2");
            arm2up.SetActive(true);
            arm2down.SetActive(false);
            arm2_state = 1;
        }
        else if (i2 % 2 == 0)
        {
            Debug.Log("kr 2");
            arm2down.SetActive(true);
            arm2up.SetActive(false);
            arm2_state = 0;
        }
        if ((arm1_state == 1) & (arm3_state == 1) & (arm4_state == 1) & (arm5_state == 1) & (arm6_state == 1) & (arm7_state == 1))
        {
            Open();
        }
    }
    public void whattodo3()
    {
        arm3.SetActive(false);
        i3 += 0.5;
        // iplus();
        if (i3 % 2 != 0)
        {
            Debug.Log("not 2");
            arm3up.SetActive(true);
            arm3down.SetActive(false);
            arm3_state = 1;
        }
        else if (i3 % 2 == 0)
        {
            Debug.Log("kr 2");
            arm3down.SetActive(true);
            arm3up.SetActive(false);
            arm3_state = 0;
        }
        if ((arm1_state == 1) & (arm3_state == 1) & (arm4_state == 1) & (arm5_state == 1) & (arm6_state == 1) & (arm7_state == 1))
        {
            Open();
        }
    }
    public void whattodo4()
    {
        arm4.SetActive(false);
        i4 += 1;
        // iplus();
        if (i4 % 2 != 0)
        {
            Debug.Log("not 2");
            arm4up.SetActive(true);
            arm4down.SetActive(false);
            arm4_state = 1;
        }
        else if (i4 % 2 == 0)
        {
            Debug.Log("kr 2");
            arm4down.SetActive(true);
            arm4up.SetActive(false);
            arm4_state = 0;
        }
        if ((arm1_state == 1) & (arm3_state == 1) & (arm4_state == 1) & (arm5_state == 1) & (arm6_state == 1) & (arm7_state == 1))
        {
            Open();
        }
    }
    public void whattodo5()
    {
        arm5.SetActive(false);
        i5 += 1;
        // iplus();
        if (i5 % 2 != 0)
        {
            Debug.Log("not 2");
            arm5up.SetActive(true);
            arm5down.SetActive(false);
            arm5_state = 1;
        }
        else if (i5 % 2 == 0)
        {
            Debug.Log("kr 2");
            arm5down.SetActive(true);
            arm5up.SetActive(false);
            arm5_state = 0;
        }
        if ((arm1_state == 1) & (arm3_state == 1) & (arm4_state == 1) & (arm5_state == 1) & (arm6_state == 1) & (arm7_state == 1))
        {
            Open();
        }
    }
    public void whattodo6()
    {
        arm6.SetActive(false);
        i6 += 1;
        // iplus();
        if (i6 % 2 != 0)
        {
            Debug.Log("not 2");
            arm6up.SetActive(true);
            arm6down.SetActive(false);
            arm6_state = 1;
        }
        else if (i6 % 2 == 0)
        {
            Debug.Log("kr 2");
            arm6down.SetActive(true);
            arm6up.SetActive(false);
            arm6_state = 0;
        }
        if ((arm1_state == 1) & (arm3_state == 1) & (arm4_state == 1) & (arm5_state == 1) & (arm6_state == 1) & (arm7_state == 1))
        {
            Open();
        }
    }
    public void whattodo7()
    {
        arm7.SetActive(false);
        i7 += 1;
        // iplus();
        if (i7 % 2 != 0)
        {
            Debug.Log("not 2");
            arm7up.SetActive(true);
            arm7down.SetActive(false);
            arm7_state = 1;
        }
        else if (i7 % 2 == 0)
        {
            Debug.Log("kr 2");
            arm7down.SetActive(true);
            arm7up.SetActive(false);
            arm7_state = 0;
        }
        if ((arm1_state == 1) & (arm3_state == 1) & (arm4_state == 1) & (arm5_state == 1) & (arm6_state == 1) & (arm7_state == 1))
        {
            Open();
        }
    }
    public void whattodo8()
    {
        arm8.SetActive(false);
        i8 += 0.5;
        // iplus();
        if (i8 % 2 != 0)
        {
            Debug.Log("not 2");
            arm8up.SetActive(true);
            arm8down.SetActive(false);
            arm8_state = 1;
        }
        else if (i8 % 2 == 0)
        {
            Debug.Log("kr 2");
            arm8down.SetActive(true);
            arm8up.SetActive(false);
            arm8_state = 0;
        }
        if ((arm1_state == 1) & (arm3_state == 1) & (arm4_state == 1) & (arm5_state == 1) & (arm6_state == 1) & (arm7_state == 1))
        {
            Open();
        }
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

}
