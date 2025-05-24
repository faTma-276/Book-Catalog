# 📚 Book List API – ASP.NET Core Web API

This is a simple ASP.NET Core Web API project to manage a list of books.  
The API supports adding books and retrieving the full list. This project is intended for learning and starter-level demonstration.

---

## ✅ Features

- [POST] `/api/books` – Add a new book  
- [GET] `/api/books` – Retrieve all books  
- In-memory data storage (no database)  
- Swagger UI enabled for testing

---
## How to Run
1. Clone the repository or unzip the source code.
2. Open the solution in Visual Studio or VS Code.
3. Run the project.

----
## 🧱 Book Model

```json
{
  "title": "string",
  "author": "string"
}

---

## Notes
- No database required.
- No authentication.
- Id is auto-generated and not required in the request or response

# Book Catalog
