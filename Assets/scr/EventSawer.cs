using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventSawer : MonoBehaviour
{
    public static GameObject EventSawerText;
    public static string EStext;
    void Start()
    {
        EStext = EventSawerText.GetComponent<Text>().text; // Поле, которое определяет текст в EventSawer
    }

    public static void createMessage(string arg0) // Фунция отвечающая за добавление сообщения в EventSawer
    {
        EventSawerText.SetActive(true);
        arg0 = EStext;
        float Timer = 0f;
        Timer *= Time.deltaTime;
        if (Timer >= 3)
        {
            EventSawerText.SetActive(false);
        }
    }
    
    void Update()
    {
        
    }
}
