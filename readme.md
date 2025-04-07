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
    curl -X GET http://localhost:port/api/resource -H "Authorization: Bearer mock_valid_token"
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
#### 2. Create a New User
- **Command**:  
    ```bash
    curl -X POST http://localhost:port/api/users \
    -H "Authorization: Bearer mock_valid_token" \
    -H "Content-Type: application/json" \
    -d '{"name": "John Doe", "email": "john.doe@example.com"}'
    ```
- **Expected Output**:  
    ```json
    {
        "id": 1,
        "name": "John Doe",
        "email": "john.doe@example.com"
    }
    ```