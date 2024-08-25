# Patikaflix Series Platform
This project is a console application for managing series data, specifically focusing on comedy series. The application allows users to input series details, filter for comedy series, and display them sorted by series name and director.

## Technologies Used
.NET: The application is built using the .NET framework.

C#: The primary programming language used for the implementation.

## Features
Series Creation: Users can input series details including the name, year, type, starting year, director, and the first platform.

Comedy Series Filtering: The application filters out series of type "comedy".

Sorting: The filtered comedy series are sorted by series name and then by director.

Display: The sorted list of comedy series is displayed to the user.

## How to Use
Run the Application: Execute the console application to start the series input process.

Input Series Details: Enter the details for each series as prompted by the application.

Add More Series: After entering each series, you will be asked if you want to add another series. Type 'y' to add more or 'n' to finish.

View Results: The application will filter, sort, and display comedy series based on your input.

## Example
Here’s an example of how to use the application:

1. **Start the Application**

   When you run the application, you will be greeted with the following prompt:

   ```plaintext
   Welcome to Patikaflix! Please enter the series details.
   Enter the series name: Friends
   Enter the year: 1994
   Enter the series type: comedy
   Enter the starting year: 1994
   Enter the director: David Crane
   Enter the first platform: NBC
   Do you want to add another series? (y/n): n

   Series name: Friends
   Type: comedy
   Director: David Crane


