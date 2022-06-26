namespace Flowers
{

    using System;
    using FlowerField;
    using Validation;

    public class BusinessFlowersManagement
    {
        public static void Menu()
        {
            WelcomeToTheShop.Welcome();

            Console.WriteLine($"Make yor choice: \n 1-list of flowers; \n 2-add new flower; \n 3-update flower;");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1: GetFlowers(); break;
                case 2: AddFlowers(); break;
                case 3: UpdateFlowers(); break;
                default: break;
            }
        }

        public static Flowers Rose()
        {
            Flowers rose = new Flowers();

            rose.FlowerId = 165477;
            rose.FlowerName = "Rose";
            rose.FlowerType = "Common Rose";
            rose.FlowerPodType = "Yellow Rose";
            rose.FlowerSize = 10;
            rose.FlowerPrice = 50.50; ;

            return rose;

            
        }

        public static Flowers Carnation()
        {
            Flowers carnation = new Flowers();

            carnation.FlowerId = 346576;
            carnation.FlowerName = "Carnation";
            carnation.FlowerType = "Common Carnation";
            carnation.FlowerPodType = "Red Carnation";
            carnation.FlowerSize = 7;
            carnation.FlowerPrice = 25.60;
            
            return carnation;

        }

        public static Flowers Cornflower()
        {
            Flowers cornflower = new Flowers();

            cornflower.FlowerId = 585645;
            cornflower.FlowerName = "Cornflower";
            cornflower.FlowerType = "Common Cornflower ";
            cornflower.FlowerPodType = "Cornflower field";
            cornflower.FlowerSize = 5;
            cornflower.FlowerPrice = 10.60;

           return cornflower;

            
        }

        public static void GetFlowers()
        {

            var rose = Rose();
            var carnation = Carnation();
            var cornflower = Cornflower();

            Console.WriteLine("Id: \t\t Name: \t\t Type: \t\t Podtype: \t\t Size: \t\t Price:");
            Console.WriteLine($"{rose.FlowerId} \t\t {rose.FlowerName} \t\t {rose.FlowerType} \t\t {rose.FlowerPodType} \t\t {rose.FlowerSize} \t\t {rose.FlowerPrice}$");
            Console.WriteLine($"{carnation.FlowerId} \t\t {carnation.FlowerName} \t\t {carnation.FlowerType} \t\t {carnation.FlowerPodType} \t\t {carnation.FlowerSize} \t\t {carnation.FlowerPrice}$");
            Console.WriteLine($"{cornflower.FlowerId} \t\t {cornflower.FlowerName} \t\t {cornflower.FlowerType} \t\t {cornflower.FlowerPodType} \t\t {cornflower.FlowerSize} \t\t {cornflower.FlowerPrice}$");
        }

        
        public static Flowers AddFlowers()
        {
            Flowers addFlower = new Flowers();
            ValidationFlowers validationFlowers = new ValidationFlowers();

            addFlower.FlowerId = validationFlowers.ValidationFlowerId(Int32.Parse(Console.ReadLine()));
            addFlower.FlowerName = validationFlowers.ValidationFlowerName(Console.ReadLine());
            addFlower.FlowerType = Console.ReadLine();
            addFlower.FlowerPodType = Console.ReadLine();
            addFlower.FlowerSize = Int32.Parse(Console.ReadLine());
            addFlower.FlowerPrice = Double.Parse(Console.ReadLine());

            Console.WriteLine($"{addFlower.FlowerId} \t\t {addFlower.FlowerName} \t\t {addFlower.FlowerType} \t\t {addFlower.FlowerPodType} \t\t {addFlower.FlowerSize} \t\t {addFlower.FlowerPrice}");

            return addFlower;
        }

        public static Flowers UpdateFlowers()
        {
            Flowers updateFlower = new Flowers();
            ValidationFlowers validationFlowers2 = new ValidationFlowers();

            Console.WriteLine("What doy want to update? \n 1-Rose \n 2-Carnation \n 3-Cornflower");

            int whatToUpdate = Int32.Parse(Console.ReadLine());

            if (whatToUpdate == 1)
            {

                updateFlower.FlowerId = validationFlowers2.ValidationFlowerId(Int32.Parse(Console.ReadLine()));
                updateFlower.FlowerName = validationFlowers2.ValidationFlowerName(Console.ReadLine());
                updateFlower.FlowerType = Console.ReadLine();
                updateFlower.FlowerPodType = Console.ReadLine();
                updateFlower.FlowerSize = Int32.Parse(Console.ReadLine());
                updateFlower.FlowerPrice = Double.Parse(Console.ReadLine());

            }

            if (whatToUpdate == 2)
            {

                updateFlower.FlowerId = validationFlowers2.ValidationFlowerId(Int32.Parse(Console.ReadLine()));
                updateFlower.FlowerName = validationFlowers2.ValidationFlowerName(Console.ReadLine());
                updateFlower.FlowerType = Console.ReadLine();
                updateFlower.FlowerPodType = Console.ReadLine();
                updateFlower.FlowerSize = Int32.Parse(Console.ReadLine());
                updateFlower.FlowerPrice = Double.Parse(Console.ReadLine());

            }

            if (whatToUpdate == 3)
            {

                updateFlower.FlowerId = validationFlowers2.ValidationFlowerId(Int32.Parse(Console.ReadLine()));
                updateFlower.FlowerName = validationFlowers2.ValidationFlowerName(Console.ReadLine());
                updateFlower.FlowerType = Console.ReadLine();
                updateFlower.FlowerPodType = Console.ReadLine();
                updateFlower.FlowerSize = Int32.Parse(Console.ReadLine());
                updateFlower.FlowerPrice = Double.Parse(Console.ReadLine());

            }
            return updateFlower;
        }
    }
}

