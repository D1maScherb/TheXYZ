using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScript1 : MonoBehaviour
{

    public GameObject CubePrefab;
    public GameObject BallPrefab;
    public GameObject CirclePrefab;
    
    // Этот скрипт висит на кнопках.
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void BuildModeButton() //Включение buildmode при нажатии на кнопку.
    {
        if (!BuildMode.isBuildMode)
        {
            BuildMode.isBuildMode = true;
        } else
        {
            BuildMode.isBuildMode = false;
        }
    }
    public void FigureMode()
    {
        if (!BuildMode.FigureMode)
        {
            BuildMode.FigureMode = true;
            BuildMode.SubjectMode = false;
            BuildMode.EntitysMode = false;
        }
    }
    public void EntitysMode()
    {
        if (!BuildMode.EntitysMode)
        {
            BuildMode.EntitysMode = true;
            BuildMode.SubjectMode = false;
            BuildMode.FigureMode = false;
        }
    }
    public void SubjectsMode()
    {
        if (!BuildMode.SubjectMode)
        {
            BuildMode.SubjectMode = true;
            BuildMode.FigureMode = false;
            BuildMode.EntitysMode = false;
        }
    }
    public void CreateObject(string ObjectType)
    {
        if (ObjectType == "Cube")
        {
            Instantiate(CubePrefab);
        } else if (ObjectType == "Ball")
        {
            Instantiate(BallPrefab);
        } else if (ObjectType == "Circle")
        {
            Instantiate(CirclePrefab);
        }
    }
}
