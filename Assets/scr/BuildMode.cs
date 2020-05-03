using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildMode : MonoBehaviour
{
    public static bool isBuildMode = false;
    public GameObject MainPanel;
    public GameObject FigurePanel;
    public GameObject SubjectPanel;
    public GameObject EntitysPanel;
    public GameObject PosPanel;
    public static bool FigureMode = false; // Режим построения фигур.
    public static bool SubjectMode = false; // Режим построиния обьектов по типу света, звука и т.д.
    public static bool EntitysMode = false; // Режим построения сущностей.

    void Start()
    {
        
    }

    
    void Update()
    {
        if (isBuildMode == true) // Режим строительства ON
        {
            if (FigureMode)
            {
                SubjectMode = false;
                EntitysMode = false;
                SubjectPanel.SetActive(false);
                EntitysPanel.SetActive(false);
                
                if (!FigurePanel.active)
                {
                    FigurePanel.SetActive(true);
                }

            }
            else if (SubjectMode)
            {
                FigureMode = false;
                EntitysMode = false;
                EntitysPanel.SetActive(false);
                FigurePanel.SetActive(false);
                
                if (!SubjectPanel.active)
                {
                    SubjectPanel.SetActive(true);
                }

            }
            else if (EntitysMode)
            {
                FigureMode = false;
                SubjectMode = false;
                SubjectPanel.SetActive(false);
                FigurePanel.SetActive(false);
                
                if (!EntitysPanel.active)
                {
                    EntitysPanel.SetActive(true);
                }

            }
            if (MainPanel.active == false)
            {
                MainPanel.SetActive(true);
                Debug.LogWarning("Build mode is on");
                
            }
        }
        else // Режим строительства OFF
        {
            if (MainPanel.active == true)
            {
                FigurePanel.SetActive(false);
                SubjectPanel.SetActive(false);
                EntitysPanel.SetActive(false);
                MainPanel.SetActive(false);
                Debug.LogWarning("Build mode is off");
            }
        }
    }
}
