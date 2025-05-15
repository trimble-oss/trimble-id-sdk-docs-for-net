## 1.2.0 (2025-05-15)
	- Cross-process synchronization using lock file to support multi instance simultaneously retrieving the tokens
    - Token storage improvements
    - Improved error handling and retry mechanism in case of transient errors
    - Offline scenerio support to retrieve the info from storage without an active network connections
    - Bug fixes and code smells addressed

# 1.0.1 (2024-02-28)
- Addressed backward compatibility issue
- Improved analytics tracking

# 1.0.0

Initial stable version of Trimble.ID.Desktop SDK

- Implements the PKCE OAuth grant, which is used to secure authorization codes in public clients with custom URI scheme redirects. It also supports secure token persistence.
