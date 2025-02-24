﻿using MediatR;

namespace CustomerManagement.Application.Features.Commands.CreateCustomer;

public class CreateCustomerCommandRequest : IRequest<CreateCustomerCommandResponse>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string BankAccountNumber { get; set; }
}