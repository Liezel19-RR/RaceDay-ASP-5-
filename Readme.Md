RaceDay – Programming 2B

1. Project Overview

RaceDay is a web-based event management system for the South African running, walking and cycling community. The system is designed to help event organisers manage sporting events and allow participants to browse events, enrol in events and view results.

The application is being developed using C#, ASP.NET Core Web API, .NET 8 and SQL Server.

2. Technologies Used

* C#
* ASP.NET Core Web API
* .NET 8
* SQL Server LocalDB
* Entity Framework Core
* Swagger / OpenAPI
* Visual Studio 2022
* Git and GitHub

3. User Roles

Organiser

Organisers are responsible for creating and managing events, managing event categories, viewing participant enrolments and recording event results.

Participant

Participants can create accounts, log in, manage their profiles, browse available events and enrol in events.

Public registration creates Participant accounts. Organiser access must be assigned through an authorised process.

4. Project Structure

The project is organised into the following main folders:

* Controllers – handles incoming API requests.
* Data – contains the Entity Framework database context.
* DTOs – contains request and response data-transfer objects.
* Middleware – contains custom session authentication middleware.
* Models – contains the application’s database entity models.

5. Database Design

The application uses SQL Server LocalDB during development. The database connection is configured in appsettings.json.

The six main entity models are:

1. User
2. Event
3. EventType
4. Category
5. Enrolment
6. Result

The RaceDayDbContext class manages database access through Entity Framework Core.

6. Authentication and Security

The authentication functionality includes:

* Participant registration.
* Login using an email address and password.
* Password hashing using ASP.NET Core’s password-hashing service.
* Server-side session storage.
* Logout by clearing the current session.
* Authentication checks for protected endpoints.
* Role-based access checks for Organisers.
* Profile responses that do not expose password hashes.

The user’s role is retrieved from the database rather than accepted from public registration input.

7. Current Authentication Endpoints

HTTP Method	Endpoint	Description
POST	/api/auth/register	Registers a Participant account.
POST	/api/auth/login	Authenticates a user and starts a session.
POST	/api/auth/logout	Clears the current session.
GET	/api/profile	Retrieves the authenticated user’s profile.
GET	/api/profile/organiser-check	Tests Organiser-only access.

The Organiser check endpoint is intended for testing role-based authorisation.

8. How to Run the Project

1. Install Visual Studio 2022 and the .NET 8 SDK.
2. Open the RaceDay.API solution in Visual Studio.
3. Confirm that SQL Server LocalDB is installed.
4. Check the RaceDayConnection setting in appsettings.json.
5. Restore the required NuGet packages.
6. Build the solution.
7. Run the API using the HTTPS launch profile.
8. Open the Swagger page to view and test the available endpoints.

9. Testing

Swagger is used to test API endpoints during development.

The following tests should be completed:

* Successful Participant registration.
* Rejection of duplicate email addresses.
* Successful login with valid credentials.
* Rejection of invalid login credentials.
* Successful profile access after login.
* Rejection of unauthenticated profile requests.
* Rejection of Participant access to Organiser-only endpoints.
* Successful logout and session termination.

Automated unit tests and continuous integration must also be completed and verified.

10. Future Development

The next development stages include:

* Event management endpoints.
* Event category management.
* Participant enrolment functionality.
* Results management.
* Automated unit tests.
* GitHub Actions build and test workflow.
* Project documentation and demonstration video.

11. Author and Module

Student: [LIEZEL RAMASELA RAMMELA]

Module: Programming 2B

Project: RaceDay

12. AI Assistance Disclosure

AI assistance was used to support code development, troubleshooting and documentation. The student must review, test and understand the implementation and follow the institution’s rules for acknowledging AI assistance.


13. The Harvard References
	

Microsoft (2024) *ASP.NET Core documentation*. Available at: https://learn.microsoft.com/en-us/aspnet/core/ (Accessed: 15 October 2024).

Microsoft (2024) *Entity Framework Core documentation*. Available at: https://learn.microsoft.com/en-us/ef/core/ (Accessed: 15 October 2024).

Microsoft (2024) *Session and state management in ASP.NET Core*. Available at: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/app-state (Accessed: 15 October 2024).

Microsoft (2024) *Swagger UI in ASP.NET Core web APIs*. Available at: https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger (Accessed: 15 October 2024).

Swagger (2024) *OpenAPI Specification*. Available at: https://swagger.io/specification/ (Accessed: 15 October 2024).



### Security & Third-Party Libraries


BCrypt.Net (2024) *BCrypt.Net-Next: A .NET implementation of the BCrypt password hashing algorithm*. Available at: https://github.com/BcryptNet/bcrypt.net (Accessed: 15 October 2024).

OWASP Foundation (2024) *Password Storage Cheat Sheet*. Available at: https://cheatsheetseries.owasp.org/cheatsheets/Password_Storage_Cheat_Sheet.html (Accessed: 15 October 2024).

Moq (2024) *Moq: The most popular and friendly mocking framework for .NET*. Available at: https://github.com/moq/moq (Accessed: 15 October 2024).

xUnit.net (2024) *xUnit.net documentation*. Available at: https://xunit.net/ (Accessed: 15 October 2024).


### CI/CD

GitHub (2024) *Understanding GitHub Actions*. Available at: https://docs.github.com/en/actions/learn-github-actions/understanding-github-actions (Accessed: 15 October 2024).


### Academic & Foundational

Freeman, A. (2022) *Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages*. 9th edn. Berkeley, CA: Apress.

Smith, J. (2021) *Entity Framework Core in Action*. 2nd edn. Shelter Island, NY: Manning Publications.