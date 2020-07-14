# DotNetCore.Api.CountryData
An example of ASP.NET Core 3.1 Web API project to quickly bootstrap new projects related to Dynamics 365 development. It includes three services `CountryTaxService`, `ShipmentCostService`, and `VoucherDiscountService`. Each service loads static data that can be used in examples.

## Register the services
```cs
    public void ConfigureServices(IServiceCollection services)    
    {
    services.AddSingleton<IShipmentCost, ShipmentCostService>();    
    services.AddSingleton<ICountryTaxService, CountryTaxService>();    
    services.AddSingleton<IVoucherDiscountService, VoucherDiscountService>();
    }
```

## Visual Studio

Open the solution file CountryData.sln and build/run.

## Explore
To explore and test the available APIs simply run the project and use the Postman.

- /CountryTax/ - Help   
- /CountryTax/all - All countries along with tax applied
- /CountryTax/country/amount - Tax applied for given country and amount

- /ShipmentCost/ - Help
- /ShipmentCost/all - Shipment cost for all countries
- /ShipmentCost/country - Shipment cost for given country

- /VoucherDiscount/ - Help
- /VoucherDiscount/all - All available vouchers along with discount
- /VoucherDiscount/code - Discount for given voucher code

## Diagram
![enter image description here](https://github.com/studylearnshare/DotNetCore.Api.CountryData/blob/master/images/CountryData.png)