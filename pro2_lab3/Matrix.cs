﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 *                                                             *
 *            Parallel and Distributed Computing               *
 *             Laboratory work #3. C#                          *
 *                                                             *
 * Task: A = sort(B)*α +  β*Z*(MO*MK)                          *
 *                                                             *
 * File Matrix.cs                                              *
 * @author Kuzmenko Volodymyr                                  *
 * @group IO-21                                                *
 * @date 24.03.15                                              *
 *                                                             *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */

namespace pro2_lab3
{
    class Matrix
    {
        private Vector[] vector;

        public Matrix(int n)
        {
            vector = new Vector[n];
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = new Vector(n);
            }
        }

        public void set(int n, int m, int val)
        {
            vector[n].set(m, val);
        }

        public int get(int n, int m)
        {
            return vector[n].get(m);
        }

        public Vector get(int index)
        {
            return vector[index];
        }

        public int size()
        {
            return vector.Length;
        }

        public String toString()
        {
            String res = "";
            for (int i = 0; i < vector.Length; i++)
            {
                res += vector[i].toString();
                if (i != vector.Length - 1)
                {
                    res += "\n";
                }
            }
            return res;
        }


    }
}
