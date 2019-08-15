using System.Linq;
using ContactMicroService.DBContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ContactMicroService.Model;
using ContactMicroService.Repository;
using Swashbuckle.AspNetCore.Swagger;

namespace ContactMicroService
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
			
			services.AddDbContext<ContactContext>(context => { context.UseInMemoryDatabase(databaseName: "ContactDetails"); });
			services.AddTransient<IContactRepository, ContactRepository>();
			services.AddSwaggerGen( c=>
			{
				c.SwaggerDoc("V1.0", new Info { Title="ContactMicroService", Version="1.0"});
				c.IncludeXmlComments(System.IO.Path.Combine(System.AppContext.BaseDirectory,"ContactMicroService.xml"));
			});
			

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseSwagger();

			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/V1.0/swagger.json", "ContactMicroservice Api (V 1.0)");
			});
						
			app.UseMvc();
		}

	}

	
}
