namespace LMS
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Serach for controllers
            builder.Services.AddControllers();

            //Helps with the build for Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();

            //Swagger setup
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //Map the controllers from the search earlier
            app.MapControllers();

            app.Run();
        }
    }
}
