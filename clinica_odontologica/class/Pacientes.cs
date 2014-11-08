using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica_odontologica
{
    class Pacientes : Config
    {
        public void setPacientes(string[] data) 
        {
            this.save("INSERT INTO teste (nome) VALUES('EDUARDO')");
        }

        public void updatePacientes(int id) { 
        
        }
    }
}
