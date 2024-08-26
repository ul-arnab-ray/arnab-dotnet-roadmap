using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebCalculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public double? FirstNumber { get; set; }

        [BindProperty]
        public double? SecondNumber { get; set; }

        [BindProperty]
        public string Operation { get; set; }

        public double? Result { get; set; }

        public void OnPost()
        {
            if (FirstNumber.HasValue && SecondNumber.HasValue)
            {
                switch (Operation)
                {
                    case "Add":
                        Result = FirstNumber + SecondNumber;
                        break;
                    case "Subtract":
                        Result = FirstNumber - SecondNumber;
                        break;
                    case "Multiply":
                        Result = FirstNumber * SecondNumber;
                        break;
                    case "Divide":
                        if (SecondNumber != 0)
                            Result = FirstNumber / SecondNumber;
                        else
                            ModelState.AddModelError("", "Cannot divide by zero.");
                        break;
                }
            }
        }
    }
}
