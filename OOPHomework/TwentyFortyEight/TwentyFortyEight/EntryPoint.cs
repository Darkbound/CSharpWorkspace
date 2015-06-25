namespace TwentyFortyEight
{
    using System;
    using System.Collections.Generic;



    public class EntryPoint
    {
        static void Main()
        {
            Random rng = new Random();
            int[,] field = new int[4, 4];

            List<Tuple<int, int>> coordinates = new List<Tuple<int, int>>();
            List<Tuple<int, int>> takenCoords = new List<Tuple<int, int>>();

            GenerateCoordinates(field, coordinates);


            GenerateNewNumberOnField(rng, field, coordinates, takenCoords);
            GenerateNewNumberOnField(rng, field, coordinates, takenCoords);
            DrawField(field);

            while (true)
            {

                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);

                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:

                        UpdateAvailableCoordinates(field, coordinates, takenCoords);
                        GenerateNewNumberOnField(rng, field, coordinates, takenCoords);
                        DrawField(field);
                        break;
                    case ConsoleKey.DownArrow:

                        UpdateAvailableCoordinates(field, coordinates, takenCoords);
                        GenerateNewNumberOnField(rng, field, coordinates, takenCoords);
                        DrawField(field);
                        break;
                    case ConsoleKey.LeftArrow:

























                        for (int i = field.GetLength(1) - 1; i >= 0; i--)
                        {
                            for (int j = field.GetLength(0) - 1; j > 0; j--)
                            {

                                if (field[i, j - 1] == 0)
                                {
                                    field[i, j - 1] = field[i, j];
                                    field[i, j] = 0;
                                }
                                else if (field[i, j - 1] == field[i, j])
                                {
                                    field[i, j - 1] = field[i, j] * 2;
                                    field[i, j] = 0;
                                    for (int z = j - 1; z > 0; z--)
                                    {
                                        if (field[i, z - 1] == 0)
                                        {
                                            field[i, z - 1] = field[i, z];
                                            field[i, z] = 0;
                                        }
                                    }

                                }

                            }
                        }







                        UpdateAvailableCoordinates(field, coordinates, takenCoords);

                        GenerateNewNumberOnField(rng, field, coordinates, takenCoords);

                        DrawField(field);























                        break;
                    case ConsoleKey.RightArrow:

                        UpdateAvailableCoordinates(field, coordinates, takenCoords);
                        GenerateNewNumberOnField(rng, field, coordinates, takenCoords);
                        DrawField(field);

                        //move all numbers right and combine what can be combined
                        break;
                    default:
                        break;
                }


                Console.WriteLine("free coordinates");

                foreach (var item in coordinates)
                {
                    Console.WriteLine(item);
                }


                Console.WriteLine("taken coordinates");
                foreach (var item in takenCoords)
                {
                    Console.WriteLine(item);
                }

                if (coordinates.Count == 0)
                {
                    break;
                }
            }



            UpdateScoreBoard();
            LeaderBoard();


        }

        private static void UpdateAvailableCoordinates(int[,] field, List<Tuple<int, int>> coordinates, List<Tuple<int, int>> takenCoords)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Tuple<int, int> currentCoord = new Tuple<int, int>(i, j);

                    if ((field[i, j] == 0) && !coordinates.Contains(currentCoord))
                    {
                        coordinates.Add(currentCoord);
                        takenCoords.Remove(currentCoord);
                    }
                    else if ((field[i, j] != 0) && (!takenCoords.Contains(currentCoord)))
                    {
                        takenCoords.Add(currentCoord);
                        coordinates.Remove(currentCoord);
                    }
                }
            }
        }

        private static void GenerateNewNumberOnField(Random rng, int[,] field, List<Tuple<int, int>> coordinates, List<Tuple<int, int>> takenCoords)
        {
            int num = rng.Next(0, coordinates.Count);
            field[coordinates[num].Item1, coordinates[num].Item2] = 2;
            takenCoords.Add(coordinates[num]);
            coordinates.Remove(coordinates[num]);
        }

        private static void LeaderBoard()
        {

        }

        private static void UpdateScoreBoard()
        {

        }

        private static void GenerateCoordinates(int[,] field, List<Tuple<int, int>> coordinates)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    coordinates.Add(new Tuple<int, int>(i, j));
                }
            }
        }

        private static void DrawField(int[,] field)
        {
            Console.Clear();
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write("{0,5}", field[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
