using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // game config data
    private string[] level1Passwords = {"books", "aisle", "shelf", "password"};
    private string[] level2Passwords = {"prisoner", "handcuffs", "holster", "uniform"};
    
    // game state data
    private int level;
    enum Screen
    {
        MainMenu,
        Password,
        Win
    };
    private Screen currentScreen = Screen.MainMenu;
    private string password;

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

            if (level == 1)
            {
                if (input == password)
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
                if (input == password)
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
        bool isValidLevel = input == "1" || input == "2";
        if (isValidLevel)
        {
            level = int.Parse(input);
            StartGame();
        }
        else if (input == "menu")
        {
            ShowMainMenu();
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
        PasswordGeneration();

    }

    private void PasswordGeneration()
    {
        int index;
        switch (level)
        {
            case 1:
                index = Random.Range(0, level1Passwords.Length);
                password = level1Passwords[index];
                break;
            case 2:
                index = Random.Range(0, level2Passwords.Length);
                password = level2Passwords[index];
                break;
            default:
                Debug.LogError(" Invalid level");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    
