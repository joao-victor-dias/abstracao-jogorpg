
Knight knight = new Knight("Araus", 20, "Knight", 860, 60);
Ninja ninja = new Ninja("Wedge", 10, "Ninja", 1001, 38);
Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 635, 100);
Boss boss = new Boss("Lord of Darkness", 100, "Boss", 1000, 120);

System.Console.WriteLine($"Bem vindo ao RPG Game!\nO game se baseia em uma batalha final entre um Herói e um Boss, com o intuito de salvar o planeta da escassez de um fluido vital para a sobrevivência da população.");
Menu();
Functions();


void Menu()
{
    System.Console.WriteLine("\nEscolha uma opção:");
    System.Console.WriteLine("1 - Visualizar Personagens");
    System.Console.WriteLine("2 - Simulação da Batalha");
    System.Console.WriteLine("3 - Sair");

}

void Functions()
{
    System.Console.Write("Digite o número da opção: ");
    int option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            ListEntities();
            Menu();
            Functions();
            break;
        case 2:
            ListEntities();
            Battle();
            Menu();
            Functions();
            break;
        case 3:
            break;
        default:
            System.Console.WriteLine("Opção incorreta.");
            Functions();
            break;
    }
}

void ListEntities()
{
    System.Console.WriteLine("\nPersonagens:\n");
    System.Console.WriteLine($"{knight.ToString()}");
    System.Console.WriteLine($"{ninja.ToString()}");
    System.Console.WriteLine($"{wizard.ToString()}");
    System.Console.WriteLine($"{boss.ToString()}");
}

void Battle()
{

    System.Console.WriteLine($"\t\n\nChegou o grande dia de defender o planeta. O objetivo é acabar com o Doutor das Trevas.");
    System.Console.WriteLine($"\tTodos os Heróis começaram a atacar juntos.");
    Random randon = new Random();
    for (int i = 0; i < 3; i++)
    {
        int valueAttackKnight = randon.Next(10, 100);
        System.Console.WriteLine($"{knight.Attack(valueAttackKnight, knight.MagicPoints)}");
        int valueAttackNinja = randon.Next(10, 100);
        System.Console.WriteLine($"{ninja.Attack(valueAttackNinja, ninja.MagicPoints)}");
        int valueAttackWizard = randon.Next(10, 100);
        System.Console.WriteLine($"{wizard.Attack(valueAttackWizard, wizard.MagicPoints)}");

        System.Console.WriteLine("O Senhor das Trevas se defende e ataca, mas não consegue acertar seus alvos de maneira eficaz.");
    }

    System.Console.WriteLine("\n\nFinalmente o Senhor das Trevas foi derrotado.");
    System.Console.WriteLine("Os Heróis salvaram o planeta!!\n\n");
}


