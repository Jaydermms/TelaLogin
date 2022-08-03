namespace TelaLogin.Entities
{
    static class ValidacaoLogin
    {
        //Classe que valida as informações de login do usuario
        private static Usuario[] Usuario =
        {
            //Para simular um banco de dados, criei um array da classe usuario onde instanciei um novo usuario com as informações de login e senha
            new Usuario(){User = "admin", Senha="123456"}                                                  
        };
        //Criei uma variavel do tipo Usuario com valor de inicio null, essa varialvel vai ter por finalidade guardar as informações do usuario que esta logado
        private static Usuario _userLogado = null;

        public static Usuario UserLogado
        {
            get { return _userLogado; } 
            private set { _userLogado = value; }
        }

        //Função que verifica se os dados que o usuario digitou nos compos da tela de login existe no array Usuario
        public static bool UsuarioLogado(string user, string senha)
        {
            foreach(Usuario obj in Usuario)
            {
                if(obj.User == user && obj.Senha == senha)
                {
                    //Caso exista ira atribuir a variavel UserLogado as informações do usuario logado
                    UserLogado = obj;

                    //Retorna como true, informando assim que os dados digitados na tela de login existem 
                    return true;
                }
            }
            return false;
        }
    }
}
