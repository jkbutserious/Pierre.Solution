# Pierre's Vendors

#### C# practice for Epicodus, 07.24.2020

## By Jeff Kim

## Description

Pierre's business has been booming and, like any entrepreneur with an influx of customers, he needs a way to keep track of his vendors and orders. Luckily for Pierre, we can create a handy web interface that he can work with - no technical skills required!

This project uses C# and MVC to create a web interface that will allow Pierre to add vendors and keep track of each vendor's orders. Pierre will be able to add orders in each vendor's details page and make sure that those orders belong to those specific vendors. He can then view the details of the order, including the price that he should be paid, by clicking the order title from the list.

## Setup/Installation Requirements

Requirements:
* [.NET Core SDK 2.2](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer)

To use this program:

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/Bakery.Solution.git.
3. Click the **Code** button and click **Download ZIP** to clone the repository to your computer.
4. Open the Windows PowerShell console or the MacOS Terminal and use the 
    
    ```cd [YOUR DOWNLOAD FILEPATH]/Bakery.Solution/Bakery```
    
    command to navigate to the Bakery subdirectory.
5. Use the 

    ```dotnet restore```

    command to install the necessary packages on your computer.

6. Use the 

    ```dotnet run```

    command to run the program.

7. Use the web interface to add vendors and orders and keep track of Pierre's business.

8. If you have any issues running this program, please reach out to the developer or troubleshoot at your own risk.

You will receive output in the form of a range of numbers and strings.

To contribute to this project:

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/Pierre.Solution.
3. Log into or sign up for your GitHub account.
4. Click the **Fork** button to copy the repository and all source code.
5. From your forked repository, you can download or clone the repository, by clicking the **Code** button.
  * To clone the repository in Visual Studio Code's terminal, use the command

    ```git clone https://github.com/jkbutserious/Pierre.Solution```
  * To clone the repository in GitHub Desktop, click the **Open in Desktop** option
  * To download the repository, click the **Download ZIP** option, save the archive to your computer, and extract it to the folder of your choice
6. Use your preferred code editor to edit the appropriate model and view files. New classes should be added in the Models subdirectory and should use the ```Pierre.Models``` namespace. **Note**: the following files are C# project files and should not be edited:
  * Pierre.csproj
  * Pierre.Tests.csproj
7. Save any changes you make in your code editor and use your preferred git solution to commit your changes.
8. Push your changes to your forked repository.

#### Additional Setup/Installation Notes:

* You do not need to run a server to view this document.

* No additional code is necessary to view this project.   

## Specifications

| Behavior | Input | Output |  Completed(Y/N?)  |
| -------- | ----- | ------ | -------- |
| Create an object called Vendor with properties for name, description, and a list of Orders |  |  | N |
| Create an object called Order with properties for title, description, price, and date | Sydney, Australia | | N |
| Allow users to create a new Vendor object through a user interface |  |  | N |
| Allow users to create a new Order for a Vendor object |  |  | N |

## Known Bugs

_No known issues. Please contact me if you have any problems._


## Support and contact details

To report any issues with this page or to contribute to this project, contact Jeff Kim at kim2jy@hotmail.com.

## Technologies Used

* C#
* .NET Core 2.2
* Visual Studio Code 
* Git and Git BASH 


### License

Copyright © 2020 Jeffrey Kim

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.