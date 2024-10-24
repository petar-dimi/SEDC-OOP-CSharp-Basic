﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Dog() 
        { 

        }
        public Dog(string name,string breed,string color)
        {
            Name = name;
            Breed = breed;
            Color = color;
            
        }

        public string Eat()
        {
            return $"{Name} is now eating";
        }
        public  string Play()
        {
            return $"{Name} is now playing";
        }
        public  string ChasingTail()
        {
            return $"{Name} is now chasing it's tail";
        }
    }
}