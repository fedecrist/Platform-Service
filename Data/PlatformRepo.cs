using Platform_Service.Models;

namespace Platform_Service.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreatePlatform(Platform platform)
        {
           if (platform == null)
                throw new ArgumentNullException(nameof(platform));

           _context.Platforms.Add(platform);
        }

        public IEnumerable<Platform> GetAllPlatforms() => _context.Platforms.ToList();

        public Platform GetPlatformById(int id) => _context.Platforms.FirstOrDefault(x => x.Id == id);

        // Checks if the DB was updated
        public bool SaveChanges() => _context.SaveChanges() >= 0;
    }
}
