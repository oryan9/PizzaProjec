using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazerPizzeria.Model;

namespace RazerPizzeria.Pages
{
    public class PizzaModel : PageModel
    {

        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImagetTitle= "Margerita",PizzaName = "Margerita", BasePrice=2,  TomatoSauce =true,   Cheese=true,FinalyPrice=4 },
            new PizzasModel(){ImagetTitle="Bolognese",PizzaName="Bolognese",BasePrice=2,Cheese=true,Pineapple=true,TomatoSauce=true,FinalyPrice=10 },
            new PizzasModel(){ImagetTitle="Carbonara",PizzaName="Carvonara",BasePrice=2,Mushroom=true,Han=true,Cheese=true,FinalyPrice=7},
            new PizzasModel(){ImagetTitle="Hawaiian",PizzaName="Hawaiian",BasePrice=2,Beef=true,Peperoni=true,Cheese=true,FinalyPrice=11},
            new PizzasModel(){ImagetTitle="MeatFeast",PizzaName="MeatFeast",BasePrice=2,TomatoSauce=true,Han=true,Tuna=true,FinalyPrice=10},
            new PizzasModel(){ImagetTitle="Mushroom",PizzaName="Mushroom",BasePrice=2,Pineapple=true,TomatoSauce=true,Cheese=true,FinalyPrice=5},
            new PizzasModel(){ImagetTitle="Pepperoni",PizzaName="Pepperoni",BasePrice=2,Peperoni=true,Han=true,Cheese=true,FinalyPrice=7},
            new PizzasModel(){ImagetTitle="Seafood",PizzaName="Seafood",BasePrice=2,Pineapple=true,Han=true,Cheese=true,FinalyPrice=8},
            new PizzasModel(){ImagetTitle="Vegetarian",PizzaName="Vegetarian",BasePrice=2,Beef=true,Han=true,Cheese=true,FinalyPrice=12},
        };
        public void OnGet()
        {
        }
    }
}
