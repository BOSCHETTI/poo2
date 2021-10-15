using System;
using System.Collections.Generic;
using System.Text;
using POO2.Commons;

namespace POO2.General
{    
    public class Aeronave : Veiculo
    {

        private ConsoleTools _consoletools = new ConsoleTools();

        public Aeronave(string tipo) : base(tipo) 
        {
        }
        public override void Mover()
        {
            _consoletools.Escrever("Decolando a aeronave");
        }

        public override void Parar()
        {
            _consoletools.Escrever("Estou pousando a aeronave");
        }
    }   
}
