using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Pessoa
    {
        #region Propriedades publicas

        public String Cpf { get; set; }

        public String Nome { get; set; }

        public String Email { get; set; }

        public String Telefone { get; set; }
                
        public String Celular { get; set; }

        #endregion

        # region Poderia ser uma classe Endereco mas para o exercicio manteremos assim

        public String Lougradouro { get; set; }
        public Int32 Numero { get; set; }

        public String Cidade { get; set; }
        
        public String Estado { get; set; }

        public String UF { get; set; }

        public String Cep { get; set; }

        public String Complemento { get; set; }

        #endregion
    }
}
