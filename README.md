## Synopsis

UI Test - automated tests which execute Gherkin test cases against http://uitest.duodecadits.com/.

## Test execution

Runtests.cmd will build the project, unblock all files in the packages folder, and then executes all tests.
The project was built against .NET 4.5.2. Tested with MSBuild version 4.7.2046.0 and newer on Windows 10. 
In case of build failure, please edit the path to a proper version MSBuild in runtests.cmd accordingly.
The path to build with the MSBuild bundled with Visual Studio 2017 is also in the file as a comment.

## Structure

* **Drivers:**	Contains chromedriver.exe
* **Pageobjects:**	Page object classes
* **Scenarios:**	Test cases in Gherkin
* **TestResults:**	Test results
* **Tests:**	Test code
* **Utilities:**	Utility code making everything possible

## Created with

* VS2017 Community Edition, MSBuild 15.1.1012
* Selenium 3.4.0
* SpecFlow 2.2.0