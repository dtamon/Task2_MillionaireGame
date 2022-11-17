using Microsoft.EntityFrameworkCore;
using Task2_MillionaireGame.Context;
using Task2_MillionaireGame.Domain;

namespace Task2_MillionaireGame.Services.LevelService
{
    public class LevelRepository : ILevelRepository
    {
        private readonly GameDbContext context;
        public LevelRepository(GameDbContext context)
        {
            this.context = context;
        }
        public List<Level> GetLevels()
        {
            return context.Levels.ToList();
        }

        public Level GetLevelById(int id)
        {
            return context.Levels.FirstOrDefault(x => x.Id == id);
        }
    }
}
