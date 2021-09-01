using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriLogT01.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("****Test 01 logger in index page");
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 56)
                    {
                        throw new Exception("this is a demo exception");
                    }
                    else
                    {
                        _logger.LogInformation("The value of i is {LoopCountValue}", i);
                    }
                }
               
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "** rex log error");
            }
        }
    }
}
