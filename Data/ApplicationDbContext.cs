using Microsoft.EntityFrameworkCore;

namespace LHD_BaiThi23_24.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    }
}