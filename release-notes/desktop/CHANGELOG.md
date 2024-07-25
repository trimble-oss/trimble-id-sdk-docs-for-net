## 1.1.1 (2024-07-25)
- Reference dependency hierarchy issue fix
- 
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
