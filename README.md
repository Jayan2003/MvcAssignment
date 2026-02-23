# ASP.NET Core MVC Assignment

## 📌 Project Overview
This project is an ASP.NET Core MVC web application .

The application demonstrates the implementation of:
- MVC Architecture
- Models
- Controllers
- Views
- Interfaces
- Service Layer
- Dependency Injection

---

## 🏗 Architecture

The project follows clean architecture principles:

Controllers → Handle HTTP requests  
Services → Contain business logic  
Interfaces → Define service contracts  
Models → Represent application data  
Views → Render UI using Razor  

---

## 📂 Project Structure

MvcAssignment  
│  
├── Controllers  
│   ├── StudentController  
│   └── CourseController  
│  
├── Models  
│   ├── Student  
│   └── Course  
│  
├── Interfaces  
│   ├── IStudentService  
│   └── ICourseService  
│  
├── Services  
│   ├── StudentService  
│   └── CourseService  
│  
├── Views  
│   ├── Student  
│   └── Course  
│  
└── Program.cs  

---

## 👨‍🎓 Models

### Student
- Id
- Name
- Age

### Course
- Id
- Title
- Hours

---

## 🔗 Controllers & Endpoints

### StudentController
- GET /Student → List all students
- GET /Student/Details/{id} → View student details
- GET /Student/Create → Show create form
- POST /Student/Create → Add new student

### CourseController
- GET /Course → List all courses
- GET /Course/Details/{id} → View course details
- GET /Course/Create → Show create form
- POST /Course/Create → Add new course

---

## 🧠 Dependency Injection

Services are registered in `Program.cs`:

```csharp
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ICourseService, CourseService>();
````

---

## 🚀 How to Run the Project

1. Install .NET 10 SDK
2. Clone the repository:

```bash
git clone https://github.com/YOUR_USERNAME/MvcAssignment.git
```

3. Navigate to the project folder:

```bash
cd MvcAssignment
```

4. Run the application:

```bash
dotnet run
```

5. Open your browser and go to:

```
http://localhost:5250
```

---

## 🛠 Technologies Used

* ASP.NET Core MVC (.NET 10)
* C#
* Razor Views
* Dependency Injection
* Bootstrap (for UI styling)
* Git & GitHub

---

## 👤 Author

**Jayan Ahmed Samer**

---

## 📌 Notes

* Data is stored using in-memory collections (no database).
* The project demonstrates clean architecture principles.
* The Service layer separates business logic from controllers.
