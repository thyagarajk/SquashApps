using BookManagementSystem.UIWebApp.Services;

namespace BookManagementSystem.UIWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Registering configuration from appsettings.json
            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);


            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

            // Add Razor Pages services
            builder.Services.AddRazorPages();

            // Register HttpClient with base URL from configuration
            builder.Services.AddHttpClient<BookApiService>(client =>
            {
                var baseUrl = builder.Configuration.GetValue<string>("ApiSettings:BaseUrl");
                client.BaseAddress = new Uri(baseUrl);
            });


            // Register BookApiService with HttpClient
            builder.Services.AddHttpClient<BookApiService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Map Razor Pages and set default page
            app.UseEndpoints(endpoints =>
            {
                // Map Razor Pages
                endpoints.MapRazorPages();

                // Redirect root URL to /Books/Index
                endpoints.MapGet("/", context =>
                {
                    context.Response.Redirect("/Books/Index");
                    return Task.CompletedTask;
                });
            });

            app.Run();
        }
    }
}
