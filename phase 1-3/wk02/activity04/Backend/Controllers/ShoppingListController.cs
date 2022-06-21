using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingListController : ControllerBase
    {
        //property
        ShoppingDatabase Database { get; set; }

        //constructor
        public ShoppingListController(ShoppingDatabase database)
        {
            Database = database;
        }

        [HttpGet(Name = "GetShoppingList")]
        public ShoppingListItem[] Get()
        {
            return Database.ShoppingListItems.ToArray();
        }

            /*
            private readonly ILogger<WeatherForecastController> _logger;

            public ShoppingListController(ILogger<WeatherForecastController> logger)
            {
                _logger = logger;
            }

            [HttpGet(Name = "GetShoppingList")]
            public ShoppingListItem[] Get()
            {
                var items = new ShoppingListItem[] {
                new ShoppingListItem()
                {
                    Title = "Apples"
                },
                new ShoppingListItem()
                {
                    Title = "Sunbutter"
                },
                new ShoppingListItem()
                {
                    Title = "Chocolate"
                }
            };
                return items;
            }
            */
        }
}
