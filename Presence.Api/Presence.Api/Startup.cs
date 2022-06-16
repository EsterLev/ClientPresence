using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Presence.BL;
using Presence.BL.Classes;
using Presence.DAL;
using Presence.DAL.Classes;
using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presence.Api
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
            services.AddControllers();

            services.AddScoped<IParentBL, ParentBL>();
            services.AddScoped<IUsersTypeBL, UsersTypeBL>();
            services.AddScoped<IConnectionBL, ConnectionBL>();
            services.AddScoped<IPresenceTypeBL, PresenceTypeBL>();
            services.AddScoped<IDelaySchoolBusBL, DelaySchoolBusBL>();
            services.AddScoped<IUserBL, UserBL>();
            services.AddScoped<ISchoolBusBL, SchoolBusBL>();
            services.AddScoped<IStudentBL, StudentBL>();
            services.AddScoped<IKindergartenPresenceBL, KindergartenPresenceBL>();
            services.AddScoped<IStudentsPresenceBL, StudentsPresenceBL>();
            services.AddScoped<IKindergartenBL, KindergartenBL>();
            services.AddScoped<IReminderBL, ReminderBL>();
            services.AddScoped<IActingTeacherBL, ActingTeacherBL>();
            services.AddScoped<IBirthdayBL, BirthdayBL>();
            services.AddScoped<IParentDAL, ParentDAL>();
            services.AddScoped<IUsersTypeDAL, UsersTypeDAL>();
            services.AddScoped<IConnectionDAL, ConnectionDAL>();
            services.AddScoped<IPresenceTypeDAL, PresenceTypeDAL>();
            services.AddScoped<IDelaySchoolBusDAL, DelaySchoolBusDAL>();
            services.AddScoped<IUserDAL, UserDAL>();
            services.AddScoped<ISchoolBusDAL, SchoolBusDAL>();
            services.AddScoped<IStudentDAL, StudentDAL>();
            services.AddScoped<IKindergartenPresenceDAL, KindergartenPresenceDAL>();
            services.AddScoped<IStudentsPresenceDAL, StudentsPresenceDAL>();
            services.AddScoped<IKindergartenDAL, KindergartenDAL>();
            services.AddScoped<IReminderDAL, ReminderDAL>();
            services.AddScoped<IActingTeacherDAL, ActingTeacherDAL>();
            services.AddScoped<IBirthdayDAL, BirthdayDAL>();

            services.AddDbContext<PRESENCEContext>(options =>
            options.UseSqlServer("Server=DESKTOP-47JV62I;Database=PRESENCE;Trusted_Connection=True;"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
