using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class ChatText : MonoBehaviour
{
    [SerializeField] GameObject chatText;
    [SerializeField] GameObject chatTextBackground;
    TextBackground textBackground;
    string chatTextString = "I have defaulted";
    int stringLength;
    bool canType = false;

    /* Purpose:     This code turns the input the user types in a string. Then will send the string to a regular expression checker.
     * Currently:   1. All it does let the play type on in the text box.
     *              2. The bool canType needs to be true for the text field the user.
     * Still Needs:
     *              1. Still needs a function to disable the text box
     *              2. Set up 'Enter' keycode to send the string to the regular expression checker.
     *              3. Method to send string to regular expression checker
     *              4. --
     */
    void Start()
    {
        chatText.GetComponent<Text>().text = chatTextString;
        chatText.SetActive(canType);
    }

    void Update()
    {
        Typing();
    }

    public void Typing()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            chatTextBackground.GetComponent<Animator>().SetTrigger("PopUp");
        }
        
        if(canType == true)
        {
            TypingAlphabet();
            TypingOtherCharacters();
        }
    }

    public void CanType()
    {
        canType = true;
        chatText.SetActive(canType);
    }

    public int CurrentStringLength()
    {
        stringLength = chatTextString.Length;
        return stringLength;
    }

    public void TypingAlphabet()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            chatTextString = chatTextString + "a";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            chatTextString = chatTextString + "b";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            chatTextString = chatTextString + "c";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            chatTextString = chatTextString + "d";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            chatTextString = chatTextString + "e";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            chatTextString = chatTextString + "f";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            chatTextString = chatTextString + "g";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            chatTextString = chatTextString + "h";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            chatTextString = chatTextString + "i";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            chatTextString = chatTextString + "j";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            chatTextString = chatTextString + "k";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            chatTextString = chatTextString + "l";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            chatTextString = chatTextString + "m";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            chatTextString = chatTextString + "n";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            chatTextString = chatTextString + "o";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            chatTextString = chatTextString + "p";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            chatTextString = chatTextString + "q";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            chatTextString = chatTextString + "r";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            chatTextString = chatTextString + "s";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            chatTextString = chatTextString + "t";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            chatTextString = chatTextString + "u";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            chatTextString = chatTextString + "v";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            chatTextString = chatTextString + "w";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            chatTextString = chatTextString + "x";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            chatTextString = chatTextString + "y";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            chatTextString = chatTextString + "z";
            chatText.GetComponent<Text>().text = chatTextString;
        }
    }

    public void TypingOtherCharacters()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            chatTextString = chatTextString + " ";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            int length = CurrentStringLength();
            if (length >= 1)
            {
                chatTextString = chatTextString.Remove(length - 1);
                chatText.GetComponent<Text>().text = chatTextString;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Period))
        {
            chatTextString = chatTextString + ".";
            chatText.GetComponent<Text>().text = chatTextString;
        }
        else if (Input.GetKeyDown(KeyCode.Comma))
        {
            chatTextString = chatTextString + ",";
            chatText.GetComponent<Text>().text = chatTextString;
        }

        //This is where is need to play the reverse animation and disable the textbox and also send the string to the robot
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            chatTextString = chatTextString + ",";
            chatText.GetComponent<Text>().text = chatTextString;
        }
    }
}
