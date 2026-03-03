# 2.1.0 (2026-03-02)

Enhancements:
  - Added account_id and data_region fields in the userinfo response.
  
Dependency Update:
  - Updated trimble-id to 1.4.0
  
# 2.0.1 (2025-06-10)

- Bug Fix: The dynamic redirection port was not being used when the authenticator was reinitialized on the Windows platform.

# 2.0.0 (2024-04-25)

- Added Windows Platform support
- Simplified the client configuration of MobileAuthenticator
- .NET 8 support

# 1.0.1

Bug fixes - Launching the browser for the first time on an Android device.

# 1.0.0

Initial stable version of Trimble.ID.Maui SDK

- Implements the PKCE OAuth grant, which is used to secure authorization codes in public clients with custom URI scheme redirects
- Web browser popup for sign-in
- Token persistence
