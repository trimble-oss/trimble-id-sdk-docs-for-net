## 1.0.1 (2023-12-14)

* Trimble.ID
	- Fixed the ValidatedClaimsetProvider incorrectly adds ClockSkew to Now instead of Token Expiry
    - ValidatedClaimsetProvider Return Dictionary instead of JObject

# 1.0.0

Initial stable version of Trimble.ID SDK

- It is a base library for OAuth2.0 related protocol operations. It provides:
    - Discovery of endpoints
    - Supported Grant Types Token Providers
    - Token Validation
    - HTTP Client Handler to access a given API with the access token
    - Token Persistence
