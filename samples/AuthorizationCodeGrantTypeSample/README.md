
# Authorization Code Grant Type Sample

This sample demonstrates the Trimble Identity v4 C# SDK which is part of the Trimble Cloud Core Platform SDK suite.

Documentation for all Trimble Cloud Core Platform SDKs can be found [here](https://api-stg.trimble.com/t/trimble.com/sdk_documentation/1.0/index.html)

## Setup

To use this sample it is necessary to configure NuGet on your development machine.

See the Usage section (Getting Started > C#) of the SDK documentation for information on how to request and configure access to the Trimble Cloud SDK NuGet repository.

When creating the application in Trimble Developer Console
- set the grant type to Authorization Code
- set the redirect_uri to http://localhost:5000/index.html
- set the logout_uri to https://www.trimble.com

After creating the application update appsettings.json with values for your application
- CONSUMER_KEY
- CONSUMER_SECRET (not required for PKCE)

This sample can be used to test against Trimble Identity v4

When testing against Trimble Identity v4 update the OPENID_CONFIGURATION_URL to
- https://stage.id.trimble.com/.well-known/openid-configuration (production)
- https://stage.id.trimblecloud.com/.well-known/openid-configuration (staging)
The CONSUMER_SECRET value does not need to be set for PKCE

### Scopes
Trimble Identity v4 uses scopes to determine the *aud* claim in the returned access token

Scopes follow the naming convention `<application/api name>:<access>`
e.g. CSharpSDKTesting:all

The SDK will include the openid scope by default and add any additionally provided scopes. For this sample set the scope in appsettings.json to `<application name>:all` where application name is the name of the application you entered when creating it in API Cloud.