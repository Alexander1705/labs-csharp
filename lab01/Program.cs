/*
 * Steiner tree problem.
 *
 * Given the set of points on the plane, connect all of them with
 * lines of minimum total length. Line crossing is not allowed.
 *
 * Using Prim's algorithm to find the solution.
 * 
 * Copyright 2018 Alexander Movchan
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> freePoints = readPoints();
            buildSpanningTree(freePoints);
            Console.ReadKey();
        }

        static List<Point> readPoints()
        {
            Console.WriteLine("Enter one point per line (i.e. \"1 1\") or empty line to finish:");

            List<Point> points = new List<Point>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                
                if (inputLine == null || inputLine.Length == 0)
                {
                    break;
                }
                
                string[] inputTokens = inputLine.Split(' ');

                if (inputTokens.Length != 2)
                {
                    Console.WriteLine("Enter exactly two numbers per line!");
                    continue;
                }

                int x, y;

                if (!Int32.TryParse(inputTokens[0], out x) || !Int32.TryParse(inputTokens[1], out y))
                {
                    Console.WriteLine("Enter only integer numbers!");
                    continue;
                }
                
                points.Add(new Point(x, y));
            }

            return points;
        }

        static void buildSpanningTree(List<Point> freePoints)
        {
            List<Point> boundPoints = new List<Point>();
            
            // Add random point to spanning tree.
            boundPoints.Add(freePoints.First());
            freePoints.RemoveAt(0);

            while (freePoints.Count != 0)
            {
                double minDist = Double.MaxValue;
                Point closestFreePoint = freePoints.First();
                Point closestBoundPoint = boundPoints.First();
                
                foreach (Point freePoint in freePoints)
                {
                    foreach (Point boundPoint in boundPoints)
                    {
                        double currDist = freePoint.distanceTo(boundPoint);
                        if (currDist < minDist)
                        {
                            minDist = currDist;
                            closestFreePoint = freePoint;
                            closestBoundPoint = boundPoint;
                        }
                    }
                }

                freePoints.Remove(closestFreePoint);
                boundPoints.Add(closestFreePoint);
                
                Console.WriteLine("Connect points {0} and {1}", closestBoundPoint, closestFreePoint);
            }
        }
    }
}