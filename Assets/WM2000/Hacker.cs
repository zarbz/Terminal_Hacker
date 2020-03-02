using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game State
    int level;
    enum Screen
    {
        MainMenu,
        Password,
        Win
    };
    string password;

    Screen currentScreen;

    void Start()
    {
        ShowMainMenu("Hello Human");
    }

    void ShowMainMenu(string greeting)
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the Local Library");
        Terminal.WriteLine("Press 2 for the Police Station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "menu") // we can always go direct to main menu
        {
            ShowMainMenu("Welcome back to the menu!");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    private void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = "donkey";
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = "combobulate";
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "clear")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Type 'menu' to return to the main menu");
        }
        else if (input == "007")
        {
            ShowMainMenu("Please make a selection, Mr. Bond");
        }
        else if (input == "melody")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("I love Melody Zarbo");
        }
        else
        {
            Terminal.WriteLine("Please input a valid selection");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password:");
    }
    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("ACCESS GRANTED");
        }
        else
        {
            Terminal.WriteLine("INCORRECT PASSWORD");
        }
    }
}
