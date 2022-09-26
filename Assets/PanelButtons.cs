using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelButtons : MonoBehaviour
{

    public GameObject panelManagers;
    public bool showPanelManagers = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowHidePanel()
    {        
        panelManagers.SetActive(!showPanelManagers);
        showPanelManagers = !showPanelManagers;
    }
    
}
