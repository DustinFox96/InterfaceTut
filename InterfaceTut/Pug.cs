﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTut {
    class Pug : IBarkable {
        public string Name { get; set; }

        public string GetName() {
            return Name;
        }
        public void SetName(string name) {
            this.Name = name;
        }


        public string Bark() {
            return "pssh";
        }
    }
}
