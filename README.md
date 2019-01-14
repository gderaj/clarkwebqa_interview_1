# Clark Associates Automation Engineer Practice Test

### Requirements

* Visual Studio (recommended), VSCode, or another IDE that supports C#
    * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) is a free edition you may download
        * Make sure to select the ASP.NET module
* [git](https://git-scm.com/downloads)
* A github account (free to [create](https://github.com/join?source=experiment-header-dropdowns-home) if you don't have one)

### Pre-test steps

* clone this repository
* create a new branch using the following pattern: `git branch -b v1_your_name`

### Your task

Using Page Objects, write a Selenium test that:

* searches for the valentine: "Lets Grow Old Together!"
* adds the valentine to cart
* asserts that the correct valentine and price appear in cart

You will use the following site to perform your tests: http://awful-valentine.com/. This is a practice site designed to be used for testing automation code. There are a handful of valentines that can be "purchased."

The project already includes the C# Selenium and Selenium Support Nuget packages. ChromeDriver will be automatically added to the project's `\bin` folder when built.

### Post-test steps

* commit your code
    * either use the IDE or with git commands:
    ```ssh
    $ git commit -am "your commit message"
    ```
* push your branch
    * either use the IDE or with git commands:
    ```ssh
    $ git push origin v1_your_name
    ```
