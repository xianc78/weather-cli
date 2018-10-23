# Weather Client
A simple command line client for checking weather from any US weather station.

## Requirements
All you need is the [Mono runtime](https://mono-project.com) since this was programmed in C# with MonoDevelop, and thanks to this, you can run this program on any OS that Mono supports.

## Using
Just type "mono weather.exe <station id>" in your terminal. If the station id is valid, the terminal will output
the data from the weather station.

## Notes
This client fetches XML data from [National Weather Service's website](https://weather.gov), thus it only works with American (US) weather stations, but I may add international support in the future 
assuming other countries use the same XML format.

## License
This program is licensed under the Modified BSD (3-clause) and I will enforce this license.