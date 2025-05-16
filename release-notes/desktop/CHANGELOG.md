## 1.2.0 (2025-05-15)
- Cross-process synchronization using lock file to support multi instance simultaneously retrieving the tokens
  - Token storage improvements
  - Improved error handling and retry mechanism in case of transient errors
  - Offline scenerio support to retrieve the info from storage without an active network connections
  - Bug fixes and code smells addressed
  - Strong naming added

## 1.1.2 (2025-02-13)
- Bug Fix:
    - Fixed the `GetUserInfo` method to prevent exceptions when some claims are missing.

## 1.2.0-beta.20241217 (2024-12-18)
- New Features
    - Token Storage Improvement: Allowed storage of all types of tokens including access_token, id_token, and token expiry information.
    - Offline Support: Added offline support to fetch user information and tokens when there is no internet connection.
- Improvements
    - Code Refactoring and Coverage: Conducted extensive code refactoring for improved code quality and maintainability, and increased code coverage with additional unit tests.
- Bug Fixes
    - Addressed multiple bugs to enhance overall stability and performance.

## 1.1.1 (2024-07-25)
- Reference dependency hierarchy issue fix
  
# 1.1.0 (2024-06-25)
- Silent Auth support using `prompt=none` that allows applications to indicate whether to display the login UI
- A new method `RetrieveTokenAsync` introduced to know the token expiry with the access token
- TokenRefresh event handler is added to notify the token refresh events
- Some bug fixes and improvements


# 1.0.1 (2024-02-28)
- Addressed backward compatibility issue
- Improved analytics tracking

# 1.0.0

Initial stable version of Trimble.ID.Desktop SDK

- Implements the PKCE OAuth grant, which is used to secure authorization codes in public clients with custom URI scheme redirects. It also supports secure token persistence.
