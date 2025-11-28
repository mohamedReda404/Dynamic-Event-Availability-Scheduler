# Dynamic Event & Availability Scheduler

## Project Overview
This is a backend system I built to help users manage events, meetings, and personal schedules in an easy and organized way. Unlike regular calendar apps, this system can detect scheduling conflicts and suggest the best times for events based on users’ availability. It also supports notifications and basic reporting, making it practical for personal use or small teams.

---

## Key Features
- **User Management:** Users can register, login, and have role-based access with JWT authentication.
- **Event Scheduling:** Create, update, and manage events with details like participants, description, and time.
- **Dynamic Availability Matching:** The system checks for conflicts and suggests optimal times automatically.
- **Notifications:** Send reminders through Email or Telegram using background tasks (Hangfire / Hosted Services).
- **Reporting & Analytics:** Keep track of completed, pending, and canceled events; basic statistics on time usage.
- **Real-time Updates:** Optional SignalR integration for live updates.
- **Advanced Features :** Support for recurring events and time zones.

---

## Technologies Used
- **Backend / API:** .NET 10, ASP.NET Core Web API, Entity Framework Core, SQL Server, Repository Pattern, Unit of Work, DTOs, AutoMapper
- **Authentication & Security:** JWT Authentication, Refresh Tokens, Role-based Authorization, Password Hashing (BCrypt)
- **Notifications / Background Jobs:** Hangfire / Hosted Services, Email, Telegram Bot API
- **Scheduling Logic:** Conflict Detection Algorithm, Dynamic Availability Matching
- **Real-time Features:** SignalR
- **Reporting / Export:** PDF / JSON Reports
- **Tools / DevOps:** Swagger-Scalar/OpenAPI, Postman, Git/GitHub, Docker


