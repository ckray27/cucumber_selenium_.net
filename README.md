# SpecFlow.Selenium

The goal of this project is to provide a good starting point for those looking to use SpecFlow and Selenium together. It 
is also intended to demonstrate how to implement design patterns in a test framework, where many test frameworks will 
violate many different principles like SOLID, Static Cling (this one is always the most common), 
and Explicit Dependencies.

**Resources**
- [Selenium](http://www.seleniumhq.org/)
- [SpecFlow](http://specflow.org/)



### TODO
- [x] .NET Framework
- [x] Windows setup
- [ ] .NET Standard
- [ ] Visual Studio guide


### Setup - Windows

Download and install [Visual Studio](https://visualstudio.microsoft.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

The required .net frameworks should download/install with your IDE of choice.


#### Visual Studio

Visual Studio needs a little extra configuration. Install these extensions;
- xUnit.NET 2
- SpecFlow


#### Git
```
Download the .exe file as per requirement from https://git-scm.com/download/win
```

### Clone
``
$ git clone https://github.com/ckray27/cucumber_selenium_.net.git
``

#### IDE - Rider

As of writing this guide, generating the code-behind `feature.cs` files requires invoking the generator separately.
Ken Bonny wrote a couple good articles for generating those and how to configure it with File Watcher. The guide will
also walk you through associating the files together.

[Generating SpecFlow Files in Rider](https://kenbonny.net/2018/05/28/generating-specflow-files-in-rider/)

[SpecFlow Steps Generation](https://kenbonny.net/2018/07/23/specflow-steps-generation-and-general-rider-changes/)


Restore dependencies
```
$ nuget restore
```

#### Running Tests
You can run them in the Unit Test explorer of your chosen IDE or via command line

Build
```
$ msbuild
```

Run tests
```
Go to the Test explorer via Test-Windows-Test Explprer then you can click on the Run all test 
or
Select a feature or scenario then right click on it and select Run selected Tests
```

