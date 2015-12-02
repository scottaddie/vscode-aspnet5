# vscode-aspnet5
A sample ASP.NET 5 RC1 application scaffolded with OmniSharp's ASP.NET 5 Yeoman generator, called [generator-aspnet](https://github.com/omnisharp/generator-aspnet#readme). This is the sample code to accompany my "Getting Started with ASP.NET 5 in Visual Studio Code" talk. Slides can be found [here](https://github.com/scottaddie/slide-decks/blob/master/Getting%20Started%20with%20ASP.NET%205%20in%20VS%20Code.pptx).

###Setup Instructions
Before getting started, make sure you have installed the DN* tooling required for ASP.NET 5/DNX projects. Specific installation instructions, by platform, can be found [here](https://docs.asp.net/en/latest/getting-started/index.html). Node.js, npm, Bower, and Git will also need to be installed.

1. Open a command shell and navigate to the root project directory. 
2. Install NuGet, npm, and Bower dependencies with: `npm run install-deps`
3. Start Kestrel web server in Production mode with: `dnx web`
