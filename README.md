# Structured Drawing System Prototype

## Overview

This project is a C# console application that implements a simple
structured drawing system. Users can create and manage drawings made up
of different shape types, including points, lines, and text, and preview
the drawing on a character-based console canvas.

The application was developed as part of an ITD121 programming
assignment following user stories to demonstrate object-oriented programming, inheritance, interfaces, 
polymorphism, abstraction, encapsulation.

## Technologies

-   **Language:** C#
-   **Framework:** .NET 6
-   **Application type:** Console application

## Features

-   Create a new drawing.
-   Navigate drawing operations through a menu system.
-   Add points, lines, and text to a drawing.
-   Store different shape types through a common `Shape` abstraction.
-   Display a list of elements currently in the drawing.
-   Preview the drawing on a console-based canvas.
-   Delete elements from the drawing.

## Project Structure

``` text
Drawing_proto/
├── Program.cs
│
├── Models/
│   ├── Shape.cs
│   ├── Point.cs
│   ├── Line.cs
│   └── Text.cs
│
├── Canvas/
│   ├── Canvas.cs
│   └── IDrawable.cs
│
├── Coordinates/
│   ├── Coordinates.cs
│   └── ICoordinates.cs
│
└── Menus/
    ├── MenuItem.cs
    ├── Menu.cs
    ├── EditMenu.cs
    ├── NewMenuItem.cs
    ├── DeleteMenuItem.cs
    ├── ListMenuItem.cs
    ├── PreviewMenuItem.cs
    ├── PointMenuItem.cs
    ├── LineMenuItem.cs
    └── TextMenuItem.cs
```

## Inheritance and Interface Overview

### Shape hierarchy

``` text
IDrawable
▲
│ implements
│
Shape
├── Point
├── Line
└── Text
```
-   `IDrawable` defines the `Draw(Canvas canvas)` method.
-   `Shape` is an abstract class implementing `IDrawable` interface.
-   `Point`, `Line`, and `Text` inherit from `Shape`.
-   Each shape provides its own implementation of `Draw(Canvas canvas)`.
This allows the application to store different shapes in a common
`List<Shape>` while still using the appropriate drawing behaviour for
each type of shape.

### Menu hierarchy

``` text
MenuItem
├── Menu
│   └── EditMenu
├── NewMenuItem
├── DeleteMenuItem
├── ListMenuItem
├── PreviewMenuItem
├── PointMenuItem
├── LineMenuItem
└── TextMenuItem
```

-   `MenuItem` is the base class for selectable menu commands.
-   `Menu` inherits from `MenuItem` and provides functionality for
    containing and displaying other menu items.
-   `EditMenu` is another full menu, which inherits from `Menu`.
-   The individual operation classes inherit from `MenuItem`.

### Coordinate hierarchy

``` text
ICoordinates
▲
│ implements
│
Coordinates
```

-   `ICoordinates` defines the `X` and `Y` properties to represent positions.
-   `Coordinates` provides the concrete implementation.

## Application Design

The application separates the drawing system from user interaction.

``` text
        Program
           │
    ┌──────┴──────┐
    │             │
  Canvas        Menus
    │             │
    │       Menu commands
    │             │
    └──────┬──────┘
           │
        Shapes
           │
┌──────────┼─────────┐
│          │         │
Point      Line      Text
```

`Program` creates the shared collection of **shapes** and the **canvas**, then
passes them to **menu commands**. The **menu commands** handle **user input** and
**modify** the current **drawing**, while the **shape** classes are responsible for
representing and rendering individual **drawing elements** (**Point**, **Line**, **Text**).
