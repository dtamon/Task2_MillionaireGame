using Task2_MillionaireGame.Domain;
using Task2_MillionaireGame.Models;

namespace Task2_MillionaireGame.Services
{
    public interface IHomeService
    {
        public GameViewModel GetGameViewModel(int levelId);
        public Level GetAmountWon(int levelId);
        public static T RandomElement<T>(IList<T> list)
        {
            T element = list[new Random().Next(list.Count)];
            list.Remove(element);
            return element;
        }
    }
}
