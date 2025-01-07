
# Book Management System

This is a Book Management System project consisting of two parts:

- **API** (Backend)
- **UI Web App** (Frontend)

## Getting Started

Follow these steps to set up and run the application locally in **Visual Studio**.

### Prerequisites

Before starting, make sure you have the following installed:

- **Visual Studio 2019 or later**
- **.NET Core SDK**
- **Node.js** (for UI WebApp, if using Angular or React)

## Running the Code

### 1. Clone the Repository

Clone the repository to your local machine:

```bash
git clone https://github.com/thyagarajk/BookManagementSystem.git
```

### 2. Open in Visual Studio

- Open **Visual Studio**.
- Click **Open a Project/Solution** and navigate to the cloned repository.
- Open the solution file (`BookManagementSystem.sln`).

### 3. Set Multiple Startup Projects

To run both the API and the UI WebApp simultaneously:

1. **Right-click on the solution in Solution Explorer** and select **Properties**.
2. Go to the **Startup Project** section.
3. Select **Multiple startup projects**.
4. Set **API** and **UI WebApp** projects to **Start** by clicking the **Action** dropdown for both and selecting **Start**.
5. Click **Apply** and then **OK**.

### 4. Run the Code

Click **Run** (or press `F5`), and both the API and the UI WebApp should start running.

### 5. Check API Swagger URL

Once the API starts, it should open a Swagger page in the browser. The Swagger page typically runs on a port like `http://localhost:5000/swagger` (the exact port may vary).

### 6. Verify the URL in UI WebApp

In the **UI WebApp**, open the browser and navigate to the running app’s URL (e.g., `http://localhost:4200`).

- The UI WebApp should try to call the backend API to get data, but if the base URL in the frontend is mismatched with the API's Swagger URL, you may face issues.
  
### 7. Set the Base URL to Match the Running API Port

- Open the **UI WebApp** code and look for the settings where the base URL for the API is defined.
  - For example, in an Angular app, this could be in `environment.ts` or a service configuration file.
  
- **Update the base URL** to the correct API port that was shown in Swagger (e.g., `http://localhost:5000`).

### 8. Run the Code Again

Once the base URL is updated, **stop the running process** (click **Stop** in Visual Studio), and then **run the code again** by pressing `F5`.

The UI should now correctly connect to the API, and you should be able to see the application working.

---

## Additional Information

- **API URL in Swagger**: When running the backend API, you should check the Swagger page to get the correct URL. This page is usually available at `http://localhost:<swagger-port>/swagger`.
  
- **UI WebApp**: The frontend (UI WebApp) communicates with the backend API. Ensure the URL in the frontend matches the backend API's running port to avoid issues.

---

## Troubleshooting

- **UI does not load or shows errors**: Ensure that both the API and UI WebApp are running and connected. Double-check the API's base URL in the frontend code.
  
- **API is not reachable**: Ensure that the API is running and the correct port is set in the UI.
