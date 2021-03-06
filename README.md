# vscode-aspnet5
A sample ASP.NET Core RC1 application scaffolded with OmniSharp's ASP.NET Core Yeoman generator, called [generator-aspnet](https://github.com/omnisharp/generator-aspnet#readme). This is the sample code to accompany my "Getting Started with ASP.NET Core 1.0 in Visual Studio Code" talk. Use the slide deck link corresponding to the presentation you attended:

* [MKE DOT NET](https://github.com/scottaddie/slide-decks/blob/master/Getting%20Started%20with%20ASP.NET%205%20in%20VS%20Code.pptx)
* [MadDotNet User Group](https://github.com/scottaddie/slide-decks/blob/master/Getting%20Started%20with%20ASP.NET%205%20in%20VS%20Code%20-%20RC1.pptx)
* [South Florida Code Camp](https://github.com/scottaddie/slide-decks/blob/master/Getting%20Started%20with%20ASP.NET%205%20in%20VS%20Code%20-%20SFLCC.pptx)
* [Dubuque .NET User Group](https://github.com/scottaddie/slide-decks/blob/master/Getting%20Started%20with%20ASP.NET%205%20in%20VS%20Code%20-%20SFLCC.pptx)
* [NEWDUG](https://github.com/scottaddie/slide-decks/blob/master/Getting%20Started%20with%20ASP.NET%205%20in%20VS%20Code%20-%20SFLCC.pptx)
* [Twin Cities Code Camp](https://github.com/scottaddie/slide-decks/blob/master/Getting%20Started%20with%20ASP.NET%205%20in%20VS%20Code%20-%20SFLCC.pptx)
* [Chicago Code Camp](https://github.com/scottaddie/slide-decks/blob/master/Getting%20Started%20with%20ASP.NET%205%20in%20VS%20Code%20-%20CCC.pptx)


###Setup Instructions
Before getting started, make sure you have installed the DN* tooling required for ASP.NET Core/DNX projects. Specific installation instructions, by platform, can be found [here](https://docs.asp.net/en/latest/getting-started/index.html). Node.js, npm, Bower, and Git will also need to be installed.

1. Open a command shell and navigate to the root project directory. 
2. Install NuGet, npm, and Bower dependencies with: `dnu restore`
3. Start Kestrel web server in Production mode with: `dnx web`

In order to run the Gulp `watch` task, open a command shell and execute the following command: `dnu commands install Microsoft.Dnx.Watcher`. This will make available the `dnx-watch` command on which the Gulp task has a dependency. 
