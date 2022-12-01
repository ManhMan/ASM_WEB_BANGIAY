using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM_WEB_BANGIAY
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
            //add th�m secction
            services.AddSession(p => {
                p.IdleTimeout = TimeSpan.FromMinutes(30);
            });
            services.AddControllersWithViews();
            services.AddMvc();
            //Khai b�o DI
            services.AddScoped<ISanPhamRepo, SanPhamRepo>();
            services.AddScoped<INSXRepo, NSXRepo>();
            services.AddScoped<IVoucherRepo, VoucherRepo>();
            services.AddScoped<INguoiDungReop, NguoiDungRepo>();
            services.AddScoped<ILoaiTaiKhoanRepo, LoaiTaiKhoanRepo>();
            services.AddScoped<IHoaDonCHiTietRepo, HoaDonChiTietRepo>();
            services.AddScoped<IHoaDonRepo, HoaDonRepo>();
            services.AddScoped<IGioHangChiTietRepo, GioHangChiTietRepo>();
            services.AddScoped<IGioHangRepo, GioHangRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession(); // Th�m ?? d�ng Session
            //add th�m secstion, c�i section 
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
