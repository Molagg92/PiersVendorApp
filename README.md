# _PiersVendorApp.Solution_

#### _An app for Pier the Baker,  this app helps organize his incoming orders and vendor accounts._

#### By Erik Z. / Molagg92

## Technologies Used

* _C#_
* _.NET v6.0_
* _MSTest.TestAdapter v2.2.10_
* _MSTest.TestFramework v2.2.10_
* _Git_
* _VSCode_

## Description

_This application uses C# to track order details for Pier's Bakery buisness. A user can creat an account with discrptive account information, and order history, as well as submit a new order for a bulk quantity of Pier's famous Sweet Bread._

## Setup/Installation Requirements

* _Clone "PiersVendorApp.Solution“ from the repository to your desktop_
* _Navigate to "PiersVendorApp.Solution" directory via your local terminal command line_
* _Navigate to the production directory "PiersVendorApp"_
* _Navigate to the PiersVendorApp folder in your terminal_
* _Then type ***dotnet build*** in your terminal to make sure everything is up to date and there are no errors_
* _Then launch the webpage by typing ***dotnet watch run --launch-profile "production"*** in the teminal_
* _For issuing and trusting a security certificate, type ***dotnet dev-certs https --trust*** in the terminal and restart your browser_
* _If you would like to run the tests, type ***dotnet restore*** in the terminal to restore the dependencies that are listed in the .csproj file_
* _Run the tests by moving into the PiersVendorApp.Tests folder and typing ***dotnet test*** in the terminal to run tests_

## Known Bugs

* _ Currently the app is having issues adding orders, after an order has been added to list, for some reason the text is not showing on list. As of  07/30/23_

## License

MIT License

Copyright (c) [2023] [Erik Z./Molagg 92]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

_If you run into any issues or have questions, ideas or concerns, please reach out to me via email: Molagg92@gmail.com.  Contributions to the code are highly encouraged._