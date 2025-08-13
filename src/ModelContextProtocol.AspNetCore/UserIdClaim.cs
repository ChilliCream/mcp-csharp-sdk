namespace ModelContextProtocol.AspNetCore;

public sealed record UserIdClaim(string Type, string Value, string Issuer);
