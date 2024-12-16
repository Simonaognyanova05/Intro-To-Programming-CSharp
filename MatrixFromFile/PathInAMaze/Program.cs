using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace PathInAMaze
{
    internal class Program
    {
        static int[] dx = { 0, 1, 0, -1 }; 
        static int[] dy = { 1, 0, -1, 0 }; 
        static bool foundPath = false;
        static int N;

        static void Main()
        {
            Console.WriteLine("File Name: ");
            string fileName = Console.ReadLine();
            string[] lines = File.ReadAllLines(fileName);

            N = int.Parse(lines[0]);
            int startX = int.Parse(lines[1]) - 1; 
            int startY = int.Parse(lines[2]) - 1;
            int exitX = int.Parse(lines[3]) - 1;
            int exitY = int.Parse(lines[4]) - 1;

            int[,] maze = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] line = lines[5 + i].Split();
                for (int j = 0; j < N; j++)
                {
                    maze[i, j] = int.Parse(line[j]);
                }
            }

            bool[,] visited = new bool[N, N];

            string path = "";
            FindPath(maze, visited, startX, startY, exitX, exitY, ref path);

            if (foundPath)
            {
                Console.WriteLine(path + " -> EXIT");
            }
            else
            {
                Console.WriteLine("NO PATH");
            }
        }

        static void FindPath(int[,] maze, bool[,] visited, int x, int y, int exitX, int exitY, ref string path)
        {
            if (x == exitX && y == exitY)
            {
                path += $"({x + 1}, {y + 1})"; 
                foundPath = true;
                return;
            }

            if (x < 0 || x >= N || y < 0 || y >= N || maze[x, y] == 1 || visited[x, y])
            {
                return;
            }
            visited[x, y] = true;

            path += $"({x + 1}, {y + 1})";

            for (int i = 0; i < 4; i++)
            {
                int newX = x + dx[i];
                int newY = y + dy[i];

                if (foundPath) return;

                FindPath(maze, visited, newX, newY, exitX, exitY, ref path);

                if (!foundPath)
                {
                    path = path.Substring(0, path.Length - 11); 
                }
            }

            visited[x, y] = false;
        }
    }
}
