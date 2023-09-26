using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class CategoryValidation : AbstractValidator<Category>
	{
		public CategoryValidation()
		{
			RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Category can't be empty.");
			RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("You must enter minimum 3 character.");

		}
	}
}
