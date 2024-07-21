
# Menu Builder

A C# console application for building and managing menus. This project demonstrates object-oriented programming principles, interfaces, and event-driven programming.

## Table of Contents

- [Description](#description)
- [Installation](#installation)
- [Usage](#usage)
- [File Structure](#file-structure)
- [Classes and Methods](#classes-and-methods)

## Description

The Menu Builder is a console-based application that allows users to create, manage, and display menus using different interfaces and events. It is designed to be flexible and extensible, making it easy to add new menu items and actions.

## Installation

To run this project, you need to have .NET installed on your machine. You can download it from the official [.NET website](https://dotnet.microsoft.com/download).

1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/MenuBuilder.git
   ```

2. Navigate to the project directory:
   ```sh
   cd MenuBuilder
   ```

3. Build the project:
   ```sh
   dotnet build
   ```

## Usage

Run the project using the following command:
```sh
dotnet run
```

Follow the on-screen instructions to create and manage menus.

## File Structure

### Ex04.Menus.Events

- **Ex04.Menus.Events.csproj**: Project file for the Events component.
- **MainMenu.cs**: Public class representing the main menu.
- **MenuDisplay.cs**: Public class for displaying menus.
- **MenuItem.cs**: Public class representing a menu item.

### Ex04.Menus.Interfaces

- **Ex04.Menus.Interfaces.csproj**: Project file for the Interfaces component.
- **IMenu.cs**: Interface defining the structure of a menu.
- **IMenuAction.cs**: Interface defining actions that can be performed on menu items.
- **IMenuItem.cs**: Interface defining the structure of a menu item.

### Ex04.Menus.Test

- **Ex04.Menus.Test.csproj**: Project file for the Test component.
- **EventsMenuMethods.cs**: Public class with methods for testing event-driven menu functionality.
- **InterfacesMenuMethods.cs**: Public class with methods for testing interface-based menu functionality.
- **Program.cs**: Entry point of the application.

### Solution

- **MenuBuilder.sln**: Solution file for the entire Menu Builder project.

## Classes and Methods

### Ex04.Menus.Events

#### MainMenu.cs
Represents the main menu of the application.

#### MenuDisplay.cs
Handles the display logic for menus.

#### MenuItem.cs
Represents an individual menu item with properties and methods.

### Ex04.Menus.Interfaces

#### IMenu.cs
Defines the structure and behavior of a menu.

#### IMenuAction.cs
Defines the actions that can be performed on menu items.

#### IMenuItem.cs
Defines the structure and behavior of a menu item.

### Ex04.Menus.Test

#### EventsMenuMethods.cs
Contains methods for testing the event-driven functionality of menus.

#### InterfacesMenuMethods.cs
Contains methods for testing the interface-based functionality of menus.

#### Program.cs
The main entry point of the application, running tests and demonstrations.

