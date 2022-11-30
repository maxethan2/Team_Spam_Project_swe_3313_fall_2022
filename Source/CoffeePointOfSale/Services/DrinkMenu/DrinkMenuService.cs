using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Storage;

namespace CoffeePointOfSale.Services.Menu;

public class DrinkMenuService : IDrinkMenuService
{
    private readonly IStorageService _storageService;

    public DrinkMenuService(IStorageService storageService)
    {
        _storageService = storageService;
        Drinks = _storageService.Read<Drinks>(); //load customers from JSON file
        //your DrinkMenu.json to load on start will go in the JsonStorage directory
    }

    public Drinks Drinks { get; init; }
  //  public void Write() => _storageService.Write(Drinks);
}