using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    private int level;
    enum Screen
    {
        MainMenu,
        Password,
        Win
    };

    private Screen currentScreen = Screen.MainMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }
    
    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            string passwordLevel1 = "poop";
            string passwordLevel2 = "sweet";
            if (level == 1)
            {
                if (input == passwordLevel1)
                {
                    Terminal.WriteLine("Congrats !");
                    Terminal.WriteLine("type menu to go back to the main menu");
                }
                else
                {
                    Terminal.WriteLine( "wrong answer ! ");
                }
            }

            if (level == 2)
            {
                if (input == passwordLevel2)
                {
                    Terminal.WriteLine("Congrats !");
                    Terminal.WriteLine("type menu to go back to the main menu");
                }
                else
                {
                    Terminal.WriteLine( "wrong answer ! ");
                }
            }
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid option");
        }
    }

    private void StartGame()
    {
        Terminal.WriteLine("You have chosen level " + level); 
        Terminal.WriteLine("Please enter your password :");
        currentScreen = Screen.Password;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
