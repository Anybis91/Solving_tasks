using System;

namespace Task_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroHealth = 1000;
            int heroMana = 500;
            int heroDamage = 20;
            int heroArmor = 15;
            int bossArmor = 25;
            int bossHealth = 1000;
            int bossDamage = 100;
            bool isWork = true;
            string userChose;
            Console.WriteLine("Вы встречаете Босса подземелья!");

            while (isWork)
            {

                Console.WriteLine("Босс наносит удар!");
                int deltaDamageBoss = bossDamage - heroArmor;
                heroHealth -= deltaDamageBoss;

                if (heroHealth > 0 && bossHealth > 0)
                {
                    Console.WriteLine($"Ваше здоровье {heroHealth}, ваша броня {heroArmor}, ваша мана {heroMana}, ваша атака {heroDamage}.\nЗдоровье Босса {bossHealth}, броня босса {bossArmor}.");
                    Console.WriteLine("Ваши действия:\n1-Атака ближнего боя.\n2-Заклинание Рашамон. \n3-Межпространственный разлом. \n4-Заклинание усиления брони. \n5-Заклинание усиления атаки. \n6-Убежать.");
                    userChose = Console.ReadLine();

                    switch (userChose)
                    {
                        case "1":
                            int penetrationDamage = heroDamage - bossArmor;

                            if (penetrationDamage > 0)
                            {
                                bossHealth = bossHealth - penetrationDamage;
                                Console.WriteLine("Вы ударили босса!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Вы ударили босса но он только засмеялся!");
                                break;
                            }
                        case "2":
                            int shadowWarriorDamageHero = 100;
                            int shadowWarriorDamageBoss = 250;
                            int shadowWarriorNeedMana = 200;
                            int shadowWarriorHealth = 100;
                            int shadowWarriorArmor = 10;

                            if (heroMana >= 200)
                            {
                                Console.WriteLine("Вы призвали теневого духа пожертвовав своей жизнью и частью маны! Дух сразу нанес удар боссу игнорируя броню!");
                                heroHealth -= shadowWarriorDamageHero;
                                bossHealth -= shadowWarriorDamageBoss;
                                heroMana -= shadowWarriorNeedMana;
                                Console.WriteLine($"Здоровье Босса {bossHealth}, ваше здоровье  {heroHealth}, ваша мана {heroMana}");
                                Console.WriteLine($"Призванный дух имеет {shadowWarriorHealth} здоровья, {shadowWarriorDamageBoss} атаки по боссу и броню {shadowWarriorArmor}.");

                                string userChoseShadowWarrior;
                                bool isWorkShadowWarior = true;

                                while (isWorkShadowWarior)
                                { 
                                    int deltaBossDamageForWarrior = deltaDamageBoss - shadowWarriorArmor;
                                    shadowWarriorHealth -= deltaBossDamageForWarrior;
                                    Console.WriteLine("Босс переключился на атаку духа! И сразу нанес удар!");
                                    Console.WriteLine($"Здоровье призванного духа {shadowWarriorHealth}");

                                    if (shadowWarriorHealth > 0)
                                    {
                                        Console.WriteLine("Призванный дух ожидает вашего действия:\n1-прогнать. 2-усилить. 3- атакавать босса. 4-поглатить духа.");
                                        userChoseShadowWarrior = Console.ReadLine();

                                        switch (userChoseShadowWarrior)
                                        {
                                            case "1":
                                                Console.WriteLine("Вы прогнали духа!");
                                                isWorkShadowWarior = false;
                                                break;
                                            case "2":
                                                if (heroMana >= 100)
                                                {
                                                    int manaNeedUpgradeWarrior = 100;
                                                    int upgradeDamegeShadowWarrior = 100;
                                                    int manaUpgradeHealthWarrior = 100;
                                                    shadowWarriorHealth += manaUpgradeHealthWarrior;
                                                    shadowWarriorDamageBoss += upgradeDamegeShadowWarrior;
                                                    heroMana -= manaNeedUpgradeWarrior;
                                                    Console.WriteLine($"Вы усилили духа заклятьем Хуганзакура - атака духа выросла {shadowWarriorDamageBoss}, а здоровье выросло до {shadowWarriorHealth}!");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Ваша мана равна {heroMana}, этого не достаточно!");
                                                    Console.WriteLine("Дух покидает сражение!");
                                                    isWorkShadowWarior = false;
                                                    break;
                                                }
                                            case "3":
                                                int deltaDamegeTime = 200;
                                                shadowWarriorDamageBoss -= deltaDamegeTime;
                                                int penetrationDamageWarrior = shadowWarriorDamageBoss - bossArmor;

                                                if (penetrationDamageWarrior > 0)
                                                {
                                                    bossHealth = bossHealth - penetrationDamageWarrior;
                                                    Console.WriteLine($"Вы приказали духу атаковать босса, дух нанес боссу {penetrationDamageWarrior} урона, теперь здоровье босса {bossHealth} ");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Ваш призваннный дух ослаб!");
                                                    Console.WriteLine($"Здоровье босса {bossHealth}");
                                                    break;
                                                }
                                            case "4":
                                                int minHealthShadowWarrior = 1;
                                                int minManaShadowWarrior = 1;
                                                int maxManaShadowWarrior = 30;
                                                int maxHealthShadowWarrior = shadowWarriorHealth;
                                                Random random = new Random();
                                                int randomHealth = random.Next(minHealthShadowWarrior, maxHealthShadowWarrior);
                                                int randomMana = random.Next(minManaShadowWarrior, maxManaShadowWarrior);
                                                heroMana += randomMana;
                                                heroHealth += randomHealth;
                                                Console.WriteLine($"Вы поглащаете духа и восполняете здоровье на {randomHealth} хп, а ману на {randomMana}!\nВаше здоровье  {heroHealth}, ваша мана {heroMana}.");
                                                isWorkShadowWarior = false;
                                                break;
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Ваш дух получил таких п****й что отправился сразу в разлом!");
                                        isWorkShadowWarior = false;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Ваша мана равна {heroMana}, этого не достаточно!");
                            }
                            break;
                        case "3":
                            if (heroHealth < 1000&&heroMana>0)
                            {
                                Console.WriteLine("Вы вызвали межпространственный разлом потратив всю ману, в вас вцепилось щупальца из разлома!\nВаше здоровье начинает воспалняться случайное количество времени! Атаки босса на вас не действуют!");
                                int minRandomTime = 1;
                                int maxRandomTime = 25;
                                int minRandomHealth = 1;
                                int maxRandomHealth = 10;
                                Random randomHealthAndTime = new Random();
                                int randomTime = randomHealthAndTime.Next(minRandomTime, maxRandomTime);
                                int randomHealthFault = randomHealthAndTime.Next(minRandomHealth, maxRandomHealth);
                                heroMana = 0;
                                for (int i = minRandomTime; i < randomTime; i++)
                                {
                                    heroHealth += randomHealthFault;
                                }
                                Console.WriteLine($"Щупальца отпустили вас из разлома ваше здоровье  {heroHealth}, ваша мана {heroMana}.");
                            }
                            else
                            {
                                Console.WriteLine("У вас полное здоровье или не достаточно маны, вы не можите вызвать заклинание!");
                            }
                            break;
                        case "4":
                            int minRandomArmor = 1;
                            int maxRandomArmor = 50;
                            int manaNeedForUpArmor = 70;

                            if (heroMana > manaNeedForUpArmor)
                            {
                                Console.WriteLine("Вы уселяете броню с помощью заклинания!");
                                Random randomArmoreHero = new Random();
                                int randomArmore = randomArmoreHero.Next(minRandomArmor, maxRandomArmor);
                                heroMana -= manaNeedForUpArmor;
                                heroArmor += randomArmore;
                            }
                            else
                            {
                                Console.WriteLine($"Ваша мана равна {heroMana}, этого не достаточно!");
                            }
                            break;
                        case "5":
                            int minRandomDamage = 1;
                            int maxRandomDamage = 30;
                            int manaNeedForUpDamage = 100;

                            if (heroMana > manaNeedForUpDamage)
                            {
                                Console.WriteLine("Вы уселяете свой посох с помощью заклинания!");
                                Random randomDamageHero = new Random();
                                int randomDamage = randomDamageHero.Next(minRandomDamage, maxRandomDamage);
                                heroMana -= manaNeedForUpDamage;
                                heroDamage += randomDamage;
                            }
                            else
                            {
                                Console.WriteLine($"Ваша мана равна {heroMana}, этого не достаточно!");
                            }
                            break;
                        case "6":
                            Console.WriteLine("Вы убежали как трус! Босс упал со смеху!");
                            isWork = false;
                            break;
                    }
                }
                else if (heroHealth <= 0)
                {
                    Console.WriteLine("Ваш герой погиб! Босс утаскивает ваш труп глубже в подземелье.");
                    isWork = false;
                }
                else if (bossHealth <= 0)
                {
                    Console.WriteLine("Ваш герой победил Босса подземелья! Вы уходите глубже в пещеру за сокровищами.");
                    isWork = false;
                }
            }
        }
    }
}
