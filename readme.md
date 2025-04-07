# Testing Guidelines for User Management API

## How to Demo Using Terminal

### Prerequisites
1. Ensure the API server is running.
2. Use a tool like `curl` or `httpie` for making HTTP requests.
3. Have valid credentials for an authorized user.

### Steps for Testing

#### 1. Authorized User
- **Command**:  
    ```bash
    curl -X GET http://localhost:port/api/resource -H "Authorization: Bearer <valid_token>"
    ```
- **Expected Output**:  
    ```json
    {
        "status": "success",
        "data": {
            "message": "Access granted",
            "resource": "Your requested data"
        }
    }
    ```

#### 2. Unauthorized User
- **Command**:  
    ```bash
    curl -X GET http://localhost:port/api/resource
    ```
- **Expected Output**:  
    ```json
    {
        "status": "error",
        "message": "Unauthorized access"
    }
    ```
