using Logging.Models;
using Microsoft.AspNetCore.Mvc;

namespace Logging.Controllers
{
    internal class AccountController : Controller
    {
        private ILogger Logger { get; }

        public AccountController(ILogger<AccountController> logger)
        {
            Logger = logger;
        }

        [Route("/")]
        public IActionResult GetAllAccount()
        {
            return Ok(new List<Account>());
        }

        [Route("/{id}")]
        public IActionResult GetAllAccount(int id)
        {
            Account? account = new List<Account>().SingleOrDefault(a => a.AccountId == id);

            return account is not null ?
                Ok(account) :
                NotFound(new { Message = "Account Not Found" });
        }

        [HttpPut]
        public IActionResult UpdateAccount(Account account)
        {
            Account? accountFound = new List<Account>().Find((a) => a.AccountId == account.AccountId);
            if (accountFound is null)
            {
                return NotFound();
            }

            (accountFound.AccountId, accountFound.AccountName) = (account.AccountId, account.AccountName);

            return Ok(account);
        }

        [HttpDelete]
        public static IActionResult? DeleteAccount(int id)
        {
            int count = new List<Account>().RemoveAll(a => a.AccountId == id);
            return null;
        }

        [HttpPost]
        public IActionResult Create(Account account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            new List<Account>().Add(account);

            return Created(Url?.ToString() ?? nameof(Create), account);
        }
    }
}