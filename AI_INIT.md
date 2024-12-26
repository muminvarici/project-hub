# Project Overview

This project is developed entirely by an AI agent, with commands provided by the user. The `AI_INIT.md` file will be updated throughout the project's development to reflect progress.
So just in this project, AI help is needed much more. Recommend more code completions and commands to the AI agent, and I will update the `AI_INIT.md` file accordingly. 

## Project Structure and Initial Commands

This project is based on the Clean Architecture template, which can be found [here](https://github.com/jasontaylordev/CleanArchitecture). The application serves as a community hub where users can add their project templates and ideas.

## Functional Requirements

1. **User Authentication and Authorization**
    - Users must be able to register for an account using their email address and a password.
    - Users must be able to log in to the application using their registered credentials.
    - The application must support password recovery and reset functionality.
    - Users must be able to log out of the application securely.

2. **Project Template Management**
    - Users must be able to create new project templates by providing necessary details such as project name, description, and tech stack.
    - Users must be able to view a list of their own project templates.
    - Users must be able to update the details of their project templates.
    - Users must be able to delete their project templates.
    - Users must have the option to hide their project templates from public view for personal use.

3. **Tech Stack Integration**
    - Users must be able to add a tech stack to their project templates, specifying the technologies used in the project.

4. **Browsing and Searching**
    - Users must be able to browse through project templates created by other users.
    - Users must be able to search for project templates based on keywords, tech stack, and other relevant criteria.

5. **Rating and Commenting**
    - Users must be able to rate project templates on a scale (e.g., 1 to 5 stars).
    - Users must be able to leave comments on project templates.
    - Users must be able to view ratings and comments left by other users.

6. **User Dashboard**
    - The application must provide a dashboard for users to manage their project templates, view statistics, and track interactions.

7. **Real-Time Notifications**
    - The application must support real-time notifications for user interactions such as comments, ratings, and updates to followed project templates.

8. **Admin Panel**
    - The application must have an admin panel for administrators to manage users and project templates.
    - Administrators must be able to view, edit, and delete any user’s project templates.
    - Administrators must be able to manage user accounts, including suspending or deleting accounts if necessary.

## Non-Functional Requirements

1. **Availability and Scalability**
    - The application should be highly available and scalable to handle a large number of users.

2. **Security and Privacy**
    - The application should ensure data security and user privacy.

3. **Responsive Design**
    - The application should have a responsive design to support various devices and screen sizes.

4. **Performance**
    - The application should provide a fast and smooth user experience with minimal load times.

5. **Maintainability**
    - The application should be maintainable and allow for easy updates and feature additions.

6. **Logging and Monitoring**
    - The application should have comprehensive logging and monitoring to track performance and errors.

## Technology Stack

- .NET 9
- Clean Architecture
- MediatR
- React.js
- FluentValidation
- Entity Framework Core
- Postgresql
- AutoMapper
- Serilog
- Specflow
- Swagger
- xUnit
- Moq
- FluentAssertions
- Docker


Custom scripts:
- Add migration: `dotnet ef migrations add 'MigrationName' -p .\src\Infrastructure\ -s .\src\Web\`
- Update database: `dotnet ef database update -p .\src\Infrastructure\ -s .\src\Web\`