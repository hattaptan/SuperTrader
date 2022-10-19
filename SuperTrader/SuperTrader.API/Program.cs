 
using SuperTrader.Business.Manager;
using SuperTrader.Business.Services;
using SuperTrader.DataAccess.DataAccess;
using SuperTrader.DataAccess.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
 
builder.Services.AddSwaggerDocument();



#region DataAccesLayer
builder.Services.AddScoped<IBuyDal, BuyDal>();
builder.Services.AddScoped<IPortfolioDal,PortfolioDal >();
builder.Services.AddScoped <ISellDal,SellDal > ();
builder.Services.AddScoped <IShareDal, ShareDal > ();
builder.Services.AddScoped <ITradersDal,TradersDal > ();
#endregion

#region Business
builder.Services.AddScoped<IBuyService, BuyManager>();
builder.Services.AddScoped<IPortfolioService, PortfolioManager>();
builder.Services.AddScoped<ISellService, SellManager>();
builder.Services.AddScoped<IShareService, ShareManager>();
builder.Services.AddScoped<ITradersService, TradersManager>();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{

    
    app.UseSwaggerUi();
}
app.UseStaticFiles();

app.UseRouting();
 
 
app.UseAuthorization();

app.MapControllers();

app.Run();
