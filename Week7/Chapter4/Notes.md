Chapter 4 Notes: Files, Random Numbers, and the Form Load Event
Based on Starting Out with Visual C#, 6th Edition, by Tony Gaddis.
Slides 21--43.
Note: The PowerPoint presentation is titled Chapter 4, although
some slide headings refer to Sections 5.1--5.9. These notes follow the
topics covered in the slides and exclude the loop-related sections.

Table of Contents
1. Using Files for Data Storage
2. OpenFileDialog and
   SaveFileDialog
3. Random Numbers
4. The Form Load Event
5. Quick Review
1. Using Files for Data Storage
Slides: 21--30

File processing allows an application to save and retrieve information.
Unlike data stored only in variables, information saved to a file can
remain available after the application closes.
The Three Main Steps
1. Open: Establish access to the file.
2. Process: Read data from the file or write data to it.
3. Close: Release the file resource when finished.
Text Files and Binary Files
- Text file: Stores information as encoded text that can generally
  be viewed using a text editor.
- Binary file: Stores data in a binary representation that is not
  necessarily readable as ordinary text.
This chapter focuses on text-file processing.
Important File Classes
  Class                               Purpose
  File                              Provides methods for creating,
opening, reading, and writing
files.

  StreamWriter                      Writes text to a file.
StreamReader                      Reads text from a file.
1.1 Writing to a File
The File.CreateText() method creates a text file and returns a
StreamWriter.
using System.IO;

StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");

outputFile.Close();
Explanation:
- File.CreateText() creates the file if it does not exist.
- If the file already exists, its previous contents are overwritten.
- WriteLine() writes text followed by a newline.
- Close() closes the writer.
Write() vs. WriteLine()
  Method          Behavior
  Write()       Writes data without automatically adding a newline.
WriteLine()   Writes data followed by a newline.

Example:
outputFile.Write("Hello ");
outputFile.Write("World");
outputFile.WriteLine("!");
The first two statements write on the same line. The final statement
writes its text and then adds a newline.
1.2 CreateText() vs. AppendText()
  Method                              Behavior
  File.CreateText()                 Creates a file or overwrites its
existing contents.
File.AppendText()                 Opens a file for writing at the
end, preserving existing contents.
Example:
StreamWriter outputFile;
outputFile = File.AppendText("Names.txt");

outputFile.WriteLine("Rahma");
outputFile.Close();
If Names.txt already contains data, the new entry is appended rather
than replacing the existing content.
1.3 Specifying a File Path
A file path specifies the location of a file.

Example using an absolute path:
StreamWriter outputFile =
    File.AppendText(@"C:\Data\Names.txt");
The @ symbol creates a verbatim string literal, allowing
backslashes to be used without escaping them.

Without @, backslashes must be escaped:
string path = "D:\\CSharp\\file.txt";
A relative path, such as "students.txt", is resolved relative to the
application's current working directory.
1.4 Reading from a File
The File.OpenText() method opens a text file for reading and returns a
StreamReader.
using System.IO;

StreamReader inputFile;
inputFile = File.OpenText("students.txt");
The file must be available at the specified location.
File Reading Methods
  Method                              Description
  ReadLine()                        Reads one line and returns it as a
string, or null when no more
lines are available.

  Read()                            Reads one character and returns its
integer character value, or -1 at
the end of the stream.

  ReadToEnd()                       Reads all remaining characters from
the current position to the end of
the stream.
File.ReadAllText()                Reads the entire contents of a file
and returns them as a string.
Example: reading one line.
StreamReader inputFile = File.OpenText("students.txt");

string line = inputFile.ReadLine();

Console.WriteLine(line);

inputFile.Close();
This reads and displays the first line of the file.

Example: reading the entire file.
string contents = File.ReadAllText("students.txt");

Console.WriteLine(contents);
This reads the entire file in one operation and returns its contents as
a single string.
1.5 Reading a File Until the End
The EndOfStream property indicates whether the reader has reached the
end of the stream.
StreamReader inputFile = File.OpenText("students.txt");

while (inputFile.EndOfStream == false)
{
    string line = inputFile.ReadLine();
    Console.WriteLine(line);
}

inputFile.Close();
The condition can also be written as:
while (!inputFile.EndOfStream)
{
    // Read and process the next line
}
The ! operator means logical NOT. Therefore, !inputFile.EndOfStream
means that the reader has not reached the end of the file.

Best practice: Close files after processing them. In modern C#, a
using statement or declaration is often preferred because it ensures
the file resource is disposed of even if an exception occurs.

Slides 28 and 30: File-reading examples.
2. OpenFileDialog and SaveFileDialog
Slides: 31--38

Windows Forms provides standard dialog boxes that allow users to select
files and locations through a graphical interface.
- OpenFileDialog lets the user select an existing file.
- SaveFileDialog lets the user choose a file name and location for
  saving.
These are nonvisual components. In the Windows Forms Designer, they
typically appear in the component tray rather than directly on the form.
2.1 Displaying an Open Dialog
private void openButton_Click(object sender, EventArgs e)
{
    openFileDialog.ShowDialog();
}
ShowDialog() displays the dialog and waits for the user to respond.
2.2 Checking the User's Selection
ShowDialog() returns a DialogResult indicating how the user closed
the dialog.
DialogResult result = openFileDialog.ShowDialog();

if (result == DialogResult.OK)
{
    // The user confirmed the selection
}
else if (result == DialogResult.Cancel)
{
    // The user cancelled the operation
}
Check the result before processing a file because the user may cancel
the dialog.
2.3 The FileName Property
The FileName property provides the selected file's path and name.
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    StreamReader inputFile =
        File.OpenText(openFileDialog.FileName);

    string contents = inputFile.ReadToEnd();
    inputFile.Close();

    MessageBox.Show(contents);
}
The file is opened only if the user confirms the selection.
2.4 The InitialDirectory Property
The InitialDirectory property specifies which folder should appear
when the dialog opens.
openFileDialog.InitialDirectory = @"C:\Data";
This makes C:\Data the initial directory displayed by the dialog.
2.5 Using SaveFileDialog
The SaveFileDialog allows the user to choose where to save a file.
if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    StreamWriter outputFile =
        File.CreateText(saveFileDialog.FileName);

    outputFile.WriteLine("Student information");

    outputFile.Close();
}
The program creates or overwrites the selected file and writes the
specified text.

Important: If the selected file already exists, File.CreateText()
overwrites its contents. Use an appropriate alternative if existing data
must be preserved.

Slides 34, 36, and 38: Dialog-box examples.
3. Random Numbers
Slides: 39--40

C# provides the Random class for generating pseudorandom numbers.
These values are useful in games, simulations, and applications that
require variation.
Creating a Random Object
Random rand = new Random();
This creates an instance of the Random class that can generate
pseudorandom values.
3.1 The Next() Method
Calling Next() without arguments generates a nonnegative integer.
Random rand = new Random();

int number = rand.Next();
The possible range is from 0 to 2,147,483,646, inclusive.
3.2 The NextDouble() Method
NextDouble() generates a double greater than or equal to 0.0 and
less than 1.0.
Random rand = new Random();

double number = rand.NextDouble();
Possible values include:
0.2375
0.8142
0.0561
The exact value varies. The range includes 0.0 but excludes 1.0.
3.3 The Next(maxValue) Method
The Next(maxValue) overload generates an integer starting at zero and
ending just below the specified maximum.
int number = rand.Next(100);
Possible values are 0 through 99.

Rule: The maximum value is exclusive, meaning it is not included in
the result.
3.4 The Next(minValue, maxValue) Method
This overload specifies both the minimum and maximum limits.
int number = rand.Next(1, 101);
Possible values are 1 through 100.

The minimum is inclusive, while the maximum is exclusive.

  Code                  Possible values
  rand.Next(5)        0--4
rand.Next(1, 6)     1--5
rand.Next(10, 21)   10--20
rand.Next(1, 101)   1--100

Important: The argument to Next(maxValue) is the exclusive upper
limit, not the largest possible result.
4. The Form Load Event
Slides: 41--42

The Windows Forms Load event occurs when a form is being loaded and
prepared for display.

It is commonly used to initialize controls, set default values, or load
information before the user interacts with the form.
Example
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}
When the connected Form1_Load event handler runs, the message box
appears.
Creating the Event Handler
In Visual Studio, you can usually create the form's Load event handler
by double-clicking the form in the Designer.

The event handler must be connected to the form's Load event for the
code to execute automatically.
Common Uses
- Initializing variables.
- Setting default control values.
- Loading items into a ListBox or ComboBox.
- Preparing the user interface before interaction.
5. Quick Review
  Concept                             Key fact
  File                              Provides methods for common file
operations.

  StreamWriter                      Writes text to a file.

  StreamReader                      Reads text from a file.

  CreateText()                      Creates or overwrites a text file.

  AppendText()                      Appends text while preserving
existing contents.

  Write()                           Writes without automatically adding
a newline.

  WriteLine()                       Writes text followed by a newline.

  ReadLine()                        Reads one line of text.

  Read()                            Reads one character; returns -1
at the end of the stream.

  ReadToEnd()                       Reads the remaining content of a
stream.

  File.ReadAllText()                Reads the entire file as a string.

  EndOfStream                       Indicates whether the end of the
stream has been reached.

  OpenFileDialog                    Allows the user to select an
existing file.

  SaveFileDialog                    Allows the user to choose a save
location and file name.

  FileName                          Provides the selected file path and
name.

  InitialDirectory                  Specifies the initial folder shown
in a dialog.

  Random.Next(100)                  Generates an integer from 0 to 99.

  Random.Next(1, 101)               Generates an integer from 1 to 100.

  Random.NextDouble()               Generates a value from 0.0
inclusive to 1.0 exclusive.
Form Load event                     Runs its connected handler when the
form loads.
Final Reminders
- Close files after processing them, or use using to manage file
  resources safely.
- Use @ for convenient Windows path strings.
- CreateText() overwrites existing contents; AppendText()
  preserves them.
- Random.Next(maxValue) excludes the maximum value.
- Check DialogResult.OK before processing a file selected through a
  dialog.
- Ensure event handlers are connected to their intended events.
Reference: Starting Out with Visual C#, 6th Edition, Tony Gaddis.
Topics covered: File Processing, File Dialogs, Random Numbers, and
the Form Load Event.