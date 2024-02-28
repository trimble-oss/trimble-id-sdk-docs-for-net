## 1.1.1 (2024-02-28)

- Trimble.ID
	- Addressed a backward compatibility issue
    	- Improved analytics tracking

## 1.1.0 (2024-01-19)

* Trimble.ID
	- Device Authorization Grant token provider support for input-constrained devices
   	- Some improvements

## 1.0.1 (2023-12-14)

* Trimble.ID
	- Fixed the ValidatedClaimsetProvider incorrectly adds ClockSkew to Now instead of Token Expiry
    - ValidatedClaimsetProvider Return Dictionary instead of JObject

# 1.0.0

An initial stable version of Trimble.ID SDK

- It is a base library for OAuth2.0 related protocol operations. It provides:
    - Discovery of endpoints
    - Supported Grant Types Token Providers
    - Token Validation
    - HTTP Client Handler to access a given API with the access token
    - Token Persistence
