namespace takrorlash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            START();
            Main(args);
        }
        public static void START()
        {
            Brid brid = new Brid("LAYLAK", 3);
            Fish fish = new Fish("SAZAN", 1);
            Duck duck = new Duck("OQ", 2);
            Console.WriteLine(" 1 => Brid : 2 => Fish : 3 => Duck ");
            Console.Write(" Choose an animal: ");
            int animal=int.Parse(Console.ReadLine());
            switch (animal) 
            {
                case 1:
                    {
                        Console.WriteLine(" 1 => Eat : 2 => Sleep : 3 => Fly ");
                        Console.Write(" Sesect operation: ");
                        int operation=int.Parse(Console.ReadLine());
                        switch(operation)
                        {
                            case 1:
                                brid.Eat();
                                break;
                            case 2:
                                brid.Sleep();
                                break;
                            case 3:
                                brid.fly();
                                break;
                            default:
                                 START();
                                break;
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine(" 1 => Eat : 2 => Sleep : 3 => Swim ");
                        Console.Write(" Sesect operation: ");
                        int operation = int.Parse(Console.ReadLine());
                        switch (operation)
                        {
                            case 1:
                                fish.Eat();
                                break;
                            case 2:
                                fish.Sleep();
                                break;
                            case 3:
                                fish.swim();
                                break;
                            default:
                                START();
                                break;
                        }
                    }
                    break;
                case 3: 
                    {
                        Console.WriteLine(" 1 => Eat : 2 => Sleep : 3 => Swim : 4 => Fly");
                        Console.Write(" Sesect operation: ");
                        int operation = int.Parse(Console.ReadLine());
                        switch (operation)
                        {
                            case 1:
                                duck.Eat();
                                break;
                            case 2:
                                duck.Sleep();
                                break;
                            case 3:
                                duck.swim();
                                break;
                            case 4:
                                duck.fly();
                                break;
                            default:
                                START();
                                break;
                        }
                    }
                    break;
                default:
                    START();
                    break;
            }
        }
    }
}