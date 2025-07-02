using System;


namespace HolaMundo
{
    
    public class Tarea
    {
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public bool realizada { get; set; }
        public int ID { get; }

        private static int contador = 0;

        public Tarea(string descripcion, DateTime fecha, bool realizada)
        {
            contador++;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.realizada = realizada;
            this.ID = contador;
        }

    }
}
