## Synopsis

UI Test - automated tests which execute Gherkin test cases against http://uitest.duodecadits.com/.

## Test execution

Runtests.cmd will build the project, unblock all files in the packages folder, and then executes all tests.
In case if your computer has a different .NET framework v4.0 version than 30319, please edit the path in the file.
MSBuild.exe bundled with Visual Studio will also work.
Results will be generated into the TestResults folder.

## Structure

* **Drivers**	Contains chromedriver.exe
* **Pageobjects**	Page object classes
* **Scenarios**	Test cases in Gherkin
* **TestResults**	Test results
* **Tests**	Test code
* **Utilities**	Utility code making everything possible

## Created with

* VS2017 Community Edition
* Selenium 3.4.0
* SpecFlow 2.2.0