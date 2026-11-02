# Chapter 4: Files, Random Numbers, and Form Load Event

## Overview

These notes cover file processing, file dialog boxes, random number generation, and the Windows Forms Load event. They are based on *Starting Out with Visual C#*, 6th Edition, by Tony Gaddis, covering slides 21–43.

**Note:** The PowerPoint is titled Chapter 4, although some slide headings refer to Sections 5.1–5.9. Loop-related topics are excluded from these notes.

## Topics Covered

### 1. File Processing
- Understanding text files and binary files
- Writing data using `StreamWriter`
- Reading data using `StreamReader`
- Using `File.CreateText()` and `File.AppendText()`
- Understanding file paths
- Reading methods: `ReadLine()`, `Read()`, and `ReadToEnd()`
- Using `File.ReadAllText()` and `EndOfStream`
- Managing file resources safely

### 2. File Dialog Boxes
- `OpenFileDialog`
- `SaveFileDialog`
- Checking `DialogResult`
- Accessing the selected file with `FileName`
- Setting the initial folder with `InitialDirectory`

### 3. Random Numbers
- Creating an object of the `Random` class
- Generating integers with `Next()`
- Generating decimal values with `NextDouble()`
- Using minimum and maximum values with `Next(minValue, maxValue)`

### 4. Windows Forms Load Event
- Understanding the Form Load event
- Creating and connecting a Load event handler
- Initializing controls and setting default values
- Loading data before user interaction

## Important Concepts

| Method or Class | Purpose |
|---|---|
| `StreamWriter` | Writes text to a file |
| `StreamReader` | Reads text from a file |
| `File.CreateText()` | Creates or overwrites a text file |
| `File.AppendText()` | Appends text to an existing file |
| `OpenFileDialog` | Allows users to select an existing file |
| `SaveFileDialog` | Allows users to choose a save location |
| `Random.Next()` | Generates a nonnegative pseudorandom integer |
| `Random.NextDouble()` | Generates a value from `0.0` inclusive to `1.0` exclusive |
| Form Load event | Runs its connected event handler when the form loads |

## Learning Objectives

After studying these notes, students should be able to:

- Explain the basic steps of file processing.
- Create, read, and append text files in C#.
- Use file dialog boxes to select files and save locations.
- Generate pseudorandom numbers using the `Random` class.
- Explain the purpose of the Windows Forms Load event.
- Apply appropriate file-handling practices.

## Important Reminders

- `File.CreateText()` overwrites existing file contents.
- `File.AppendText()` preserves existing contents and adds new text at the end.
- `Random.Next(100)` generates values from `0` through `99`.
- `Random.Next(1, 101)` generates values from `1` through `100`.
- Always check `DialogResult.OK` before processing a selected file.
- Close file resources after use or use a `using` statement to dispose of them safely.

## Reference

**Book:** *Starting Out with Visual C#*  
**Edition:** 6th Edition  
**Author:** Tony Gaddis  
**Slides Covered:** 21–43

