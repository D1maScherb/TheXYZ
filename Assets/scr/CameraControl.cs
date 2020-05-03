using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float speed = 0.1f;
    public float lshiftSpeed = 0.4f;
    private bool MouseDrag = true;
    private Vector3 MousePos;
    public float sensitivity = 1F;
    private float MyAngle = 0F;
    public Camera Camera;
    void Start()
    {
        
    }

    
    void Update()
    {
        
        float vertical = Input.GetAxis("Vertical") * speed;
        float horizontal = Input.GetAxis("Horizontal") * speed;     // Передвижение
        Camera.transform.Translate(0, 0, vertical);
        Camera.transform.Translate(horizontal, 0, 0);
        //------======+=+=+=+======-------
        float lshift = Input.GetAxis("Fire3") * 0.3f;
        if (speed <= lshiftSpeed)
        {
            speed += lshift;
        } else if (lshift == 0)                                     // Ускорение
        {
            speed = 0.1f;
        }
        //------======+=+=+=+======-------
        MousePos = Input.mousePosition;
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (!BuildMode.isBuildMode)
            {
                if (CameraRotate.CR == true && CameraRotate.CursorVisible == false)
                {
                    CameraRotate.CR = false;
                    CameraRotate.CursorVisible = true;                      // Включение/выключение курсора
                }
                else
                {
                    CameraRotate.CR = true;
                    CameraRotate.CursorVisible = false;
                }
            } else
            {
                CameraRotate.CR = false;
                CameraRotate.CursorVisible = true;
            }
        }
    }
}
