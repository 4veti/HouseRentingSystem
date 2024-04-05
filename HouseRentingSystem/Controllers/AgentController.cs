using HouseRentingSystem.Attributes;
using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using HouseRentingSystem.Extensions;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using static HouseRentingSystem.Core.Constants.ErrorMessages;

namespace HouseRentingSystem.Controllers
{
    public class AgentController : BaseController
    {
        private IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
            agentService = _agentService;
        }

        [HttpGet]
        [CheckIfUserExists]
        public async Task<IActionResult> Become()
        {
            var model = new BecomeAgentFormModel();

            return View(model);
        }

        [HttpPost]
        [CheckIfUserExists]
        public async Task<IActionResult> Become(BecomeAgentFormModel model)
        {
            if (await agentService.UserWithPhoneNumberExistsAsync(model.PhoneNumber))
            {
                ModelState.AddModelError(nameof(Agent.PhoneNumber), PhoneExistsErrorMessage);
            }

            if (await agentService.UserHasRentsAsync(User.Id()))
            {
                ModelState.AddModelError("Error", UserHasRentsErrorMessage);
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await agentService.CreateAsync(User.Id(), model.PhoneNumber);

            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}
