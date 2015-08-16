using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaComprasModel;

namespace ItensLista
{
    public class Bebida : Alimento
    {
        private const string TIPO = "Bebida";
        public Bebida(string _nome, double _calorias, double _preco, string _unidade)
            : base(_nome, TIPO, _calorias, _preco, _unidade)
        {

        }
    }

    public class Matinal : Alimento
    {
        private const string TIPO = "Matinal";
        public Matinal(string _nome, double _calorias, double _preco, string _unidade)
            : base(_nome, TIPO, _calorias, _preco, _unidade)
        {

        }
    }

    public class Peixe : Alimento
    {
        private const string TIPO = "Peixe";
        public Peixe(string _nome,double _calorias, double _preco, string _unidade)
            : base(_nome,TIPO, _calorias,_preco, _unidade)        
        { }
    }

    public class Fruta : Alimento
    {
        private const string TIPO = "Fruta";
        private const string UNIDADE = "KG";
        public Fruta (string _nome,double _calorias, double _preco)
            :base(_nome,TIPO,_calorias,_preco,UNIDADE)
        {   }
    }

    public class Proteina : Alimento
    {
        private const string TIPO ="Proteina";
        public Proteina(string _nome, double _calorias, double _preco, string _unidade)
            :base(_nome,TIPO, _calorias,_preco,_unidade)
        {}
    }

    public class Vegetal : Alimento
    {
        private const string TIPO = "Vegetal";
        public Vegetal(string _nome, double _calorias, double _preco, string _unidade)
            :base(_nome,TIPO,_calorias, _preco,_unidade)
        { }
    }


    public class Banana : Fruta
    {
        private const string NOME = "Banana";
        private const double CALORIAS = 150;
        private const double PRECO = 1.50;
        public Banana()
            :base(NOME,CALORIAS,PRECO)
        { }
    }

    public class Laranja : Fruta
    {
        private const string NOME = "Laranja";
        private const double CALORIAS = 100;
        private const double PRECO = 1.50;
        public Laranja()
            : base(NOME, CALORIAS, PRECO)
        { }
    }

    public class Alface : Vegetal
    {
        private const string NOME = "Alface";
        private const double CALORIAS = 50;
        private const double PRECO = 1.00;
        private const string UNIDADE = "UN";
        public Alface()
            : base(NOME,CALORIAS,PRECO,UNIDADE)
        { }
    }

    public class Queijo : Matinal 

    {
        private const string NOME = "Queijo";
        private const double CALORIAS = 200;
        private const double PRECO = 15.00;
        private const string UNIDADE = "KG";
        public Queijo() 
            : base(NOME, CALORIAS, PRECO, UNIDADE) { }
    }

    public class Guarana : Bebida
    {
        private const string NOME = "Guarana";
        private const double CALORIAS = 150;
        private const double PRECO = 2.00;
        private const string UNIDADE = "Litro";
        public Guarana ()
            : base(NOME, CALORIAS, PRECO, UNIDADE) { }
    }

    public class Presunto : Proteina
    {
        private const string NOME = "Presunto";
        private const double CALORIAS = 300;
        private const double PRECO = 5.00;
        private const string UNIDADE = "KG";
        public Presunto ()
            : base(NOME, CALORIAS, PRECO, UNIDADE) { }
    }

    public class Salmao : Peixe
    {
        private const string NOME = "Salmao";
        private const double CALORIAS = 120;
        private const double PRECO = 6.00;
        private const string UNIDADE = "KG";
        public  Salmao ()
            : base(NOME, CALORIAS, PRECO, UNIDADE) {}
    }



}
