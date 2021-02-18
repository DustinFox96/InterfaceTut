using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTut {
    class DogParrot : IBarkable {

        public string Name { get; set; }

            public string Bark() {
                return "quack";
            }

        public string GetName() {
            return Name;
        }

        public void SetName(string name) {
            this.Name = name;
        }



        }
    }

