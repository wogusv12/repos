﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        private List<String> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }
        public Program() => Console.WriteLine("Program()");
        ~Program() => Console.WriteLine("~Program()");

        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }

        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }
        class MainApp
        {
            static void Main(string[] args)
            {
            Program obj = new Program();

            }
        }
    }

