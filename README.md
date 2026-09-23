# Automation Exercise - Selenium Automation

## Overview

This project contains a Selenium WebDriver automation test for the [Automation Exercise](https://www.automationexercise.com/) website.

The automation was developed using C# and NUnit in Visual Studio.

## Test Scenario

The automated test covers the login functionality of Automation Exercise.

### Test Flow

1. Launch the Automation Exercise website.
2. Navigate to the Login page.
3. Enter the registered email address.
4. Enter the registered password.
5. Submit the login form.
6. Verify the login flow by successfully logging into the website.

## Technologies Used

* C#
* Selenium WebDriver
* NUnit
* Visual Studio
* Brave Browser
* Git & GitHub

## Project Structure

```text
AutomationExercise-Selenium/
│
├── automationexercise/
│   ├── UnitTest1.cs
│   └── automationexercise.csproj
│
├── .gitignore
├── README.md
└── AutomationExercise.sln
```

## Browser Configuration

The automation is configured to run using Brave Browser with Selenium WebDriver.

The Brave browser executable path is configured in the test script.

## Test Execution

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Restore the required NuGet packages.
4. Make sure Brave Browser is installed or change the path for your borwser
5. Update the login credentials in the test script with a registered Automation Exercise account.
6. Open **Test Explorer** in Visual Studio.
7. Run `Automation_Exercise_Log_In_Test`.

## Note

The login credentials used for the automation should be replaced with the user's registered Automation Exercise account credentials before running the test.
