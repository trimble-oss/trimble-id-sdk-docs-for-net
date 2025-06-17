## 1.2.1 (2025-06-17)
- Removed unsigned assembly jose-jwt in favor of Microsoft.IdentityModel.JsonWebTokens for token validation.

## 1.2.0 (2024-06-25)

* Trimble.ID.Desktop
	- Support for Silent Authentication.
	- A new method `RetrieveTokenAsync` introduced to know the token expiry with the access token
	- TokenRefresh event handler to notify the token refresh events
	- Some bug fixes and improvements

## 1.1.1 (2024-02-28)

* Trimble.ID.Desktop
	- Addressed a backward compatibility issue
	- Improved analytics tracking

## 1.1.0 (2024-01-19)

* Trimble.ID.Desktop
	- Device Authorization Grant token provider support for input-constrained devices
   	- Some improvements

## 1.0.1 (2023-12-14)

* Trimble.ID.Desktop
	- Fixed the ValidatedClaimsetProvider incorrectly adds ClockSkew to Now instead of Token Expiry
	- ValidatedClaimsetProvider Return Dictionary instead of JObject

# 1.0.0

An initial stable version of Trimble.ID.Desktop SDK

The Trimble.ID.Desktop SDK is a desktop variant of the Trimble Identity SDK for .NET. It is built on top of the Trimble.ID.Core SDK.

- Provides interactive token providers for desktop applications:
	- System browser flow
	- Embedded browser flow