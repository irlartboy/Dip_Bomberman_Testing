using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2Health : MonoBehaviour
{
    public int playerHealth = 3;
    public static int curHealth = 3;
  
    public GameObject p2HealthSlider;
    public Image p2HealthFill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageP2HealthBar();
    }
    void ManageP2HealthBar()
    {
        if (curHealth <= 0 && p2HealthFill.enabled)
        {
            Debug.Log("Dead");
            p2HealthFill.enabled = false;
        }
        else if (!p2HealthFill.enabled && curHealth > 0)
        {
            Debug.Log("Revive");
            p2HealthFill.enabled = true;
        }
    }
}
