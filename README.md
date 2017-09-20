# Project Setup

1. Install Node.js/npm from https://nodejs.org/en/
2. If you have issues with the following steps, turn off Windows Defender "Real-time protection" and "Cloud-based protection", close Visual Studio and other programs, then restart PowerShell in Administrator mode, open `%APPDATA%\npm-cache` in file explorer and delete all files, and try again. Issue reported here: https://github.com/npm/npm/issues/18380
3. Make sure that your version of npm is 5.3; run `npm install -g npm@5.3`
4. Make sure that you have webpack installed; run `npm install -g webpack`
5. Git clone project to your machine
6. run `cd C:\path\to\Sseko.Web`
7. run `webpack --config webpack.config.vendor.js`
8. run `webpack`
9. Debug project in Visual Studio 2017


# Critical Note

Tsx import file urls are case sensitive, but there are no warnings or errors in intellisense, and the errors that webpack produces when you capitalize an import file url wrong are useless. Make sure that imports are cased properly.


# Contact Me

william@creativegurus.com