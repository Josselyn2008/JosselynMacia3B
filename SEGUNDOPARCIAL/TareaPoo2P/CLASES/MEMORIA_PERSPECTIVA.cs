using System;
using System.Collections.Generic;
using System.Text;

namespace TareaPoo2P.CLASES
{
    //Este es para guardar los datos 
    public class MEMORIA_PERSPECTIVA
    {
        private Memento memento; //Llama a la clase memento 
        public void setMemento (Memento memento)
        {
            this.memento = memento;
        }
        public Memento getMemento()
        {
            return memento;
        }

    }
}
