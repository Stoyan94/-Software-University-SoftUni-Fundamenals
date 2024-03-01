﻿using System;
using System.Text;



string inputStr = Console.ReadLine();


//Here we should store a copy of inputStr
StringBuilder outputText = new StringBuilder();
int bombPower = 0;

for (int i = 0; i < inputStr.Length; i++)
{
    char currCh = inputStr[i];

    if (currCh == '>')
    {
        int currBombPower = GetIntValueOfCharacter(inputStr[i + 1]);

        outputText.Append(currCh);
        bombPower += currBombPower;

    }
    else
    {
        if (bombPower > 0)
        {
            //If there is detonated bomb
            //Skips the character and decrease bomb power
            bombPower--;
        }
        else
        {
            outputText.Append(currCh);
        }
    }
}

Console.WriteLine(outputText.ToString());

int GetIntValueOfCharacter(char ch)
{
    return (int)ch - 48;
}