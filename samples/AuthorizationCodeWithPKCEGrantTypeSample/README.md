
# Authorization Code with PKCE Grant Type Sample

## Setup

When creating the application in Trimble Developer Console
- set the grant type to Authorization Code
- set the redirect_uri to http://localhost:5000/index.html
- set the logout_uri to https://www.trimble.com

After creating the application update appsettings.json with values for your application
- CLIENT_ID
- SCOPES

This sample can be used to test against Trimble Identity v4

When testing against Trimble Identity v4 update the OPENID_CONFIGURATION_URL to
- https://id.trimble.com/.well-known/openid-configuration 

### Scopes
Trimble Identity v4 uses scopes to determine the *aud* claim in the returned access token

Scopes follow the naming convention `<application/api name>:<access>`
e.g. CSharpSDKTesting:all

The SDK will include the openid scope by default and add any additionally provided scopes. For this sample set the scope in appsettings.json to `<application name>:all` where application name is the name of the application you entered when creating it in Trimble Developer Console.