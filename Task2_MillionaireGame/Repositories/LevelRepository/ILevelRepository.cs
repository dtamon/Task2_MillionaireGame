using Task2_MillionaireGame.Domain;

namespace Task2_MillionaireGame.Services.LevelService
{
    public interface ILevelRepository
    {
        public Level GetLevelById(int id);
        public List<Level> GetAllLevels();
    }
}
