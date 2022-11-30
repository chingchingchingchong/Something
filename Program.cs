            int numberOfHeroes = int.Parse(Console.ReadLine());

            string[] names = new string[numberOfHeroes];
            int[] health = new int[numberOfHeroes];
            int[] mana = new int[numberOfHeroes];

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] stats = Console.ReadLine().Split().ToArray();

                names[i] = stats[0];
                health[i] = int.Parse(stats[1]);
                mana[i] = int.Parse(stats[2]);
            }

            while(true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "End")
                {
                    break;
                }

                switch (commands[0])
                {
                    case "minHP":
                        int Index = Array.IndexOf(health, health.Min());

                        Console.WriteLine($"{names[Index]} - HP: {health[Index]}");
                        break;

                    case "maxMP":
                        int indexMp = Array.IndexOf(mana, mana.Max());
                        Console.WriteLine($"{names[indexMp]} - MP: {mana[indexMp]}");
                        break;

                    case "Display":
                            Console.WriteLine($"{string.Join(", ", names)}");
                            Console.WriteLine($"{string.Join(", ", health)}");
                            Console.WriteLine($"{string.Join(", ", mana)}");
                        break;

                    case "Reverse":
                        names = names.Reverse().ToArray();
                        health = health.Reverse().ToArray();
                        mana = mana.Reverse().ToArray();
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
