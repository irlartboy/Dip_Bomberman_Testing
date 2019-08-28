using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1Health : MonoBehaviour
{
    public int playerHealth = 3;
    public static int curHealth = 3;

    public GameObject p1HealthSlider;
    public Image p1HealthFill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageP1HealthBar();
    }
    void ManageP1HealthBar()
    {
        if (curHealth <= 0 && p1HealthFill.enabled)
        {
            Debug.Log("Dead");
            p1HealthFill.enabled = false;
        }
        else if (!p1HealthFill.enabled && curHealth > 0)
        {
            Debug.Log("Revive");
            p1HealthFill.enabled = true;
        }
    }
}
