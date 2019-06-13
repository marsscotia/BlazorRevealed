#pragma checksum "c:\Users\marss\source\repos\HostedTest\HostedTest.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cfc7b4f0d5bf35499fe32da348875e9b597e2fe"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HostedTest.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "c:\Users\marss\source\repos\HostedTest\HostedTest.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "c:\Users\marss\source\repos\HostedTest\HostedTest.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "c:\Users\marss\source\repos\HostedTest\HostedTest.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "c:\Users\marss\source\repos\HostedTest\HostedTest.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "c:\Users\marss\source\repos\HostedTest\HostedTest.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "c:\Users\marss\source\repos\HostedTest\HostedTest.Client\_Imports.razor"
using HostedTest.Client;

#line default
#line hidden
#line 7 "c:\Users\marss\source\repos\HostedTest\HostedTest.Client\_Imports.razor"
using HostedTest.Client.Shared;

#line default
#line hidden
#line 2 "c:\Users\marss\source\repos\HostedTest\HostedTest.Client\Pages\Index.razor"
using HostedTest.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 46 "c:\Users\marss\source\repos\HostedTest\HostedTest.Client\Pages\Index.razor"
 
    private State State {get;} = new State()
    {
        Menu = new Menu
        {
            Pizzas = new List<Pizza>
                {
                    new Pizza(1, "Pepperoni", 7.99M, Spiciness.Spicy),
                    new Pizza(2, "Margherita", 6.99M, Spiciness.None),
                    new Pizza(3, "Diabolo", 8.99M, Spiciness.Hot)
                }
        }
    };

    private string SpicinessImage(Spiciness spiciness)
        => $"images/{spiciness.ToString().ToLower()}.png";

    private void AddToBasket(Pizza pizza)
    {
        Console.WriteLine($"Added pizza {pizza.Name}");
        State.Basket.Add(pizza.Id);
    }

    private void RemoveFromBasket(int pos)
    {
        Console.WriteLine($"Removing pizza at position {pos}");
        State.Basket.RemoveAt(pos);
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591