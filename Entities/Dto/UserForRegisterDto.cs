﻿using Entities.Abstract;

namespace Entities.Dto;
public class UserForRegisterDto : IDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
}
