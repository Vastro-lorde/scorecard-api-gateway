using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace scorecard_portal
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            //Some swagger UI settings
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "ScoreCard API",
                    Description = "An ASP.NET Core Web API where Decagon engineers (known as Decadevs) can view" +
                    " their weekly performance report and also get evaluation based on skill based test taken on the platform. " +
                    "The digital engineer scorecard is an improvement to the current process.",
                    Contact = new OpenApiContact
                    {
                        Name = "Omatsolaseund@gmail.com",
                        Url = new Uri("mailto:omatsolaseund@gmail.com")
                    }
                });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Enter 'Bearer' [space] and then your valid token in the input below. \r\n\r\n Example : 'Bearer 124fsfs'"
                }
                );
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });

        }
    }
}
