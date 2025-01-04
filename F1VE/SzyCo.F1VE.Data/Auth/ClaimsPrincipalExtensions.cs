﻿namespace SzyCo.F1VE.Data.Auth;

public static class ClaimsPrincipalExtensions
{

    public static string? GetUserId(this ClaimsPrincipal user)
        => user.FindFirstValue(ClaimTypes.NameIdentifier);

    public static string? GetUserName(this ClaimsPrincipal user)
        => user.FindFirstValue(ClaimTypes.Name);
}