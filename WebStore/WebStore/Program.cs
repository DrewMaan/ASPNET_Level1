var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddControllersWithViews();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();    // ������������� ��. ������������ exceptions � ��������.
}

app.UseRouting();

//app.MapControllerRoute();

app.Run();
