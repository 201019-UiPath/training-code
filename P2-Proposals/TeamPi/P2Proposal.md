# Life in the Time of Corona

## Description
Our project will pull CDC data on coronavirus case counts by state, analyze and present the data to the user based on their input, create graphs and predictions of future case counts, and email the data to the user.

## Automation
1. Prompt user input:
    * State/national data
    * Zip code to search testing sites/telehealth centers, grocery stores, pharmacies
    * Graphs
    * Predictions
    * Email
2. Download case count from CDC website
3. Scrape data from downloaded file
4. Data processing
5. Generate graph with Python
6. Generate ML prediction with Python
7. Search testing sites/telehealth centers near zip code on HRSA website
8. Search grocery stores/pharmacies near zip code on Google
9. Email user with case count data, graphs, predictions, health center locations, grocery stores/pharmacies

## Tech Stack
* UiPath
    * Excel activities
    * Outlook activities
* Python

## Team Pi
Nicole Holden, James Mann, Angela Li