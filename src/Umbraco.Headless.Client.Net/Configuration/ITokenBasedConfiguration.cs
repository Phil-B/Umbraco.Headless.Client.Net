﻿namespace Umbraco.Headless.Client.Net.Configuration
{
    public interface ITokenBasedConfiguration : IHeadlessConfiguration
    {
        string Token { get; }
    }
}
