# TimeManagementApplication
Create a time management application for students to manage their class time and self-study

How to compile and run software
The name of my software application is Time Management Application.
The application uses WPF (Windows Presentation Foundation) which allows users input. The application is easy to use has no difficult traps for users.
The purpose of the application is for students to help manage their time better between school and self-study. 
Prerequisites that one needs to run the application are:
-	.NET Framework
-	Microsoft Visual Studio
The software is compiled in a visual studio using C# as a language to compile it.
Once the software has been compiled with the correct language, we may run the software. The execution will run the command prompt and output the Main Window which is the beginning of the application. 
When you run the application the first Window is the MainWindow that is the menu. On the menu you will need to select an option to continue to the next Window. You will have to choose between 3 options: Add Module, Self-Study Hours and Report. These options are set in a ListBox. A cancel button is as well there if user chooses to close the application. 
In the Add Module Window the student must enter the Module Code, Name of Module, the number of credits, number of class hours, start date of semester and the number of weeks in the semester. Once that is filled in press Add Module Button which add the module to the ListBox and so you can do this until every module is added to the list. Press the continue button to move on to the next Window.
The next Window is called Self-Study where students must enter the module code. Once the module code is entered press the button Calculate Self-Study Hours. The total hours will be displayed on the ListBox. Press the continue button to move on to the next Window or the back button to go back to the previous Window.
The last Window is called Report where the student must enter the module code, enter the number of hours spent working on the specific module and the end date which refers to the end of the week. Once that is completed press the button Calculate Remaining Hours the record will appear on the ListBox. The student will be able to see the remaining of self-study hours for each module for the current week.
I created a custom class library called TimeManagementLibrary that contains the class called Module. The Module class contains the get and set methods that will store the data being entered by the learner.
