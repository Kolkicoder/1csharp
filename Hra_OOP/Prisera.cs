


namespace Hra_OOP
{
    public class Prisera
    {
        private const int maxHp = 400;
        private const int minHp = 0;

        private string name;
        private int currentHp = maxHp;
        private int monsterDamage = 50;
        private List<string> monster = new List<string>();

        public object name1 { get; private set; }
        public object monsterName { get; private set; }

        public bool DealDamage(character opponent)
        {
            opponent.TakeDamage(monsterDamage);
            return true;
        }

        public void SetName(string? playerName)
        {
            name1 = monsterName;
        }

        public void TakeDamage(int playerDamage)
        {
            int currnetHp = playerDamage;
        }

        public int GetCurrentHp()
        {
            return currentHp;
        }

        public string GetName()
        {
            return name;
        }
    }
}
