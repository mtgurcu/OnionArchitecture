﻿using MediatR;

namespace Application.Aggregates.User.Commands
{
    public class RegisterUserCommandRequest:IRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
