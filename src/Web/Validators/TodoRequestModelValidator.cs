﻿using MyWebAPITemplate.Source.Web.Models.RequestModels;
using FluentValidation;

namespace MyWebAPITemplate.Source.Web.Validators
{
    public class TodoRequestModelValidator : AbstractValidator<TodoRequestModel>
    {
        public TodoRequestModelValidator()
        {
            RuleFor(model => model.Description)
                .NotEmpty()
                .MaximumLength(100);

        }
    }
}