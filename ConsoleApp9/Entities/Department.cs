﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department()
        {

        }
        public Department( string nome)
        {
            Name =  nome;
        }
    }
}
