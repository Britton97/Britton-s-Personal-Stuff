using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBackground : MonoBehaviour
{
    ChatText chatText;

    //This code's sole purpose is to be called by the animator at the animaiton event.
    //DisplayTextField is stored as a string in the animator
    //The method will call ChatText and trip the boolean so the play can type on the screen.
    public void DisplayTextField()
    {
        chatText = FindObjectOfType<Canvas>().GetComponent<ChatText>();
        chatText.CanType();
        Debug.Log("I got called");
    }
}
