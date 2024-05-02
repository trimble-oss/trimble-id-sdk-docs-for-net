using Trimble.ID;


IKeySetProvider keysetProvider = new OpenIdKeySetProvider(OpenIdEndpointProvider.Production);

// Create a valiate claimset provider
IClaimsetProvider claimsetProvider = new ValidatedClaimsetProvider(keysetProvider)
                                            .WithOptions(new TokenValidationOptions{ ClockSkew = TimeSpan.FromMinutes(5)});

// Retrieve the claimset
IDictionary<string, object> claimset = await claimsetProvider.RetrieveClaimset("<ID-TOKEN>");

foreach (var claim in claimset)
{
    Console.WriteLine($"{claim.Key}: {claim.Value}");
}



