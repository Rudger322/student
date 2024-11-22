using WindowsFormsApp3;

namespace WindowsFormsApp3
{
    public class Controller
    {
        private User currentUser;

        // сохранение данных пользователя
        public void RegisterUser(User user)
        {
            currentUser = user;
        }

        // получение данных зарегистрированного пользователя
        public User GetRegisteredUser()
        {
            return currentUser;
        }

        //  формирование дорожной карты
        public string GetRoadMap()
        {
            if (currentUser == null)
            {
                return "Для просмотра дорожной карты необходимо зарегистрироваться.";
            }

            // полис
            string[] countriesRequiringPolicy = new[]
            {
                "Азербайджан", "Таджикистан", "Узбекистан", "Молдова",
                "Украина", "Киргизия", "Казахстан", "Армения"
            };

            bool requiresPolicy =
                currentUser.Purpose == Purpose.Работа &&
                countriesRequiringPolicy.Contains(currentUser.Citizenship) &&
                currentUser.Policy == "Нет";

            // формирование дк
            string roadmap = "Ваша дорожная карта:\n";
            DateTime entryDate = currentUser.DateOfEntry;
            DateTime medicalCheckDeadline;

            //  крайний срок прохождения мед. освидетельствования
            if (currentUser.Purpose == Purpose.Работа)
            {
                medicalCheckDeadline = entryDate.AddDays(30);
            }
            else if (currentUser.Purpose != Purpose.Работа && DateTime.Today.AddDays(90) > entryDate && currentUser.IsLongStay)
            {
                medicalCheckDeadline = entryDate.AddDays(90);
            }
            else
            {
                medicalCheckDeadline = DateTime.MaxValue; 
            }

            // просрочка
            if (DateTime.Today > medicalCheckDeadline)
            {
                return "Ваша дорожная карта:\n- Вы просрочили срок прохождения медицинского освидетельствования. Обратитесь в миграционную службу.";
            }

            //  полис
            if (requiresPolicy)
            {
                roadmap += "- Необходимо оформить полис обязательного медицинского страхования.\n";
            }

            //  мед. освидетельствование
            if (medicalCheckDeadline != DateTime.MaxValue)
            {
                roadmap += $"- Пройдите медицинское освидетельствование до {medicalCheckDeadline:dd.MM.yyyy} в любой медицинской организации.\n";
            }

            if (!currentUser.IsLongStay)  
            {
                if (currentUser.Purpose != Purpose.Работа && currentUser.DateOfEntry.AddDays(90) >= DateTime.Now)
                {
                    roadmap += "- Вам не нужно предпринимать никаких действий.\n";
                }
            }

            return roadmap;
        }
    }
}
