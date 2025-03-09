using System.Text;
using Task5;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

IBuilder heroBuilder = new HeroBuilder();
CharacterDirector heroDirector = new CharacterDirector(heroBuilder);
Product hero = heroDirector.BuildHero();
Console.WriteLine($"Герой: Зріст: {hero.Height}, Хороші справи: {string.Join(", ", hero.GoodDeeds)}");

IBuilder enemyBuilder = new EnemyBuilder();
CharacterDirector enemyDirector = new CharacterDirector(enemyBuilder);
Product enemy = enemyDirector.BuildEnemy();
Console.WriteLine($"Ворог: Зріст: {enemy.Height}, Погані справи: {string.Join(", ", enemy.EvilDeeds)}");
    