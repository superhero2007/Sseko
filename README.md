# Project Setup

1. If you have issues with the following steps, restart your command line application in Administrator mode, turn off Windows Defender "Real-time protection" and "Cloud-based protection", close Visual Studio and other programs, delete all files in `%APPDATA%\npm-cache`, and try again. Issue reported here: https://github.com/npm/npm/issues/18380
2. Install Node.js/npm from https://nodejs.org/en/
3. Run `npm install -g npm@5.3`
4. Run `npm install -g webpack`
5. Git clone project to your machine from https://bitbucket.org/creativegurus/ssekofellows
6. Open the Sseko.Web directory that you just cloned in your command line
7. Run `webpack --config webpack.config.vendor.js`
8. Run `webpack`. There may be some type errors.


# Critical Note

Tsx import file urls are case sensitive, but there are no warnings or errors in intellisense, and the errors that webpack produces when you capitalize an import file url wrong are useless. Make sure that imports are cased properly.


# Contact Me

william@creativegurus.com