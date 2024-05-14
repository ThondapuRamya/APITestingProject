Feature: USAPopulation

it will retrieve data related to USA population

@tag1
Scenario Outline: Retrieving data related to USA population
	Given Retrieve data from <url> and validate data is retrieved
	When Deserialize the data retrieved from <url> and get entities out of it and create csv file with name as <CsvFileName>
	Then Validate CSV file is created with name as <CsvFileName>
	
Examples: 
|url                                        |CsvFileName|
|data?drilldowns=Nation&measures=Population | PopulationData |
