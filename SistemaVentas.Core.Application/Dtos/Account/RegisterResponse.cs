﻿namespace SistemaVentas.Core.Application.Dtos.Account
{
    public class RegisterResponse
    {
        public string Id { get; set; }
        public string  UserName { get; set; }
        public string? Email { get; set; }
        public List<string>? Roles { get; set; }
        public bool IsVerified { get; set; }
        public bool HasError { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
