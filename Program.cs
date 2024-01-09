using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos un objeto/instancia de tipo Coche y dar un estado inicial a nuestro Clase 
            Coche coche1 = new Coche();

            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            Coche coche3 = new Coche(4500.25, 1200.35);//Llamado de un constructor con parametros

            Console.WriteLine(coche3.getInfoCoche()); 
            coche3.setExtras(true, "Cuero");
            Console.WriteLine(coche3.getExtras());
        }
    }

    //DIVICION DE CLASES
    //Se debe asignar la palabra reservada "partial" al inicio de la declaracion de clase 
    partial class Coche
    {
        //El Constructores es el estado inicial de la clase y esta no devuelve ningun valor
        //El Constructores es un metodo con el mismo nombre de la clase, no lleva "void" 

        //Constructores
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }

        //Sobrecarga de constructores: Es cuando hay mas de 1 constructor en una clase,
        //estos deben poseer diferentes numeros de parametros
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }
    }
    //-----------------------Fin de Clase----------------------

    //-----------------------Inicio de Clase----------------------
    //Se declara como clase normal con el "partial" al inicio
    partial class Coche 
    { 


        //Metodos "getter", nos dan informacion de las propiedades
        public String getInfoCoche()
        {
            return $"Informacion del coche:\n Ruedas: {ruedas} \n Largo: {largo} \n Ancho: {ancho} ";
        }

        //Metodo "setter", establece propiedades a los objetos
        //Su objetivo no es devolverno una informacion, sino establecer informacion
        //dar valor a las propiedades 
        public void setExtras(bool paramClimatizador, String tapiceria)
        {
            climatizador = paramClimatizador;
            this.tapiceria = tapiceria;//Cuando se quiere hacer referencia al campo de clase se le asigna "this"
            //Esto sucede cuando las variables poseen el mismo nombre
        }

        public String getExtras()
        {
            return $"Extras del coche: \n Tapiceria: {tapiceria}\n Climatizador: {climatizador}";
        }

        //Campo de clase
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
        

    }
}
