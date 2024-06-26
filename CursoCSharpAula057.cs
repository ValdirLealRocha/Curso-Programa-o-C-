// AULA 057 - https://youtu.be/Saa1IPQD0KA?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Coleção List P1 - coleção mais moderna... um array dinamico, tunado...
// abrir terminal e digital na pasta do projeto:
// dotnet new console >>>> tem que ser num terminal cmd
//
// NOTA: ir no termonal de comando e digitar csc <arquivo.cs>
//       isto irá compilar e criar um .exe deste arquivo .cs
//       e depois só digitar o nome do arquivo sem o .cs, e vai rodar no terminal...   
//
// C# é fortemente tipado!!!
//
// [ModificadorClasse] class NOME_DA_CLASSE {
//   //Variaveis / propiedades
//   [EspecificadorAcesso] tipo NOME_PROPRIEDADE;
//   
//    //Métodos
//    [EspecificadorAcesso] retorno NOME_METODO([arg1, ...]) {
//      //Corpo do método
//    }
//  }
//
// **************************************************************************** 
// ModificadorClasse: Define a visibilidade da classe
//   //public: Pública, sem restrição de visualização
//   //abstract: Classe-Base_ para outras classes, não podem ser instanciados
//   //          objetos desta classe
//   //sealed: Classe não pode ser herdada
//   //static: Classe não permite a instanciação de objetos e seus
//   //        membros devem ser static também...
//
// EspecificadorAcesso: Onde um membro da classe pode ser acessado
//   //public: Sem restrição de acesso
//   //private: Só podem ser acessado pela própria classe
//   //protected: Podem ser acessados na própria classe e nas classes derivadas
//   //abstract: Os métodos não tem implementaão somente os cabeçalhos
//   //sealed: O método não pode ser redefinido
//   //virtual: O método pode ser redefinido em uma classe derivada
//   //static: O método pode ser chamado mesmo sem a instanciação de um objeto
// **************************************************************************** 
//
// biblioteca padrão de uso no C#
using System;
using System.Collections.Generic;

// nossa primeira classe
class PrincipalAula057 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) { // lista de argumentos do programa...
    // declaração de variáveis
    List<string> carros = new List<string>();
    List<string> carros2 = new List<string>();

    string[] carros3 = new string[10];

    // add elementos na lista
    carros.Add("Golf");
    carros.Add("HRV");
    carros.Add("Focus");
    carros.Add("Argo");

    Console.WriteLine("--------------------------------------------------");

    // add carros em carros2
    carros2.AddRange(carros);
    //carros.Clear(); // limpa a lista

    // copiar listas... copiar a partir de um elemento x...
    carros.CopyTo(carros3, 2);

    // verifica se exista um item na lista
    if(carros.Contains("Gol")) {
      Console.WriteLine("Gol está na lista");
    }else {
      Console.WriteLine("Gol não foi encontrado na lista.");
    }

    Console.WriteLine("--------------------------------------------------");

    // mostra a lista
    foreach(string c in carros) {
      Console.WriteLine("Carro {0}", c);
    }

    Console.WriteLine("--------------------------------------------------");

    // mostra a lista
    foreach(string c in carros2) {
      Console.WriteLine("Carro2 {0}", c);
    }

    Console.WriteLine("--------------------------------------------------");

    // mostra a lista
    foreach(string c in carros3) {
      Console.WriteLine("Carro3 {0}", c);
    }

    Console.WriteLine("--------------------------------------------------");

    // pesquisa um elemento especifico...
    string car = "HRV";
    int pos = 0;
    pos = carros.IndexOf(car);
    Console.WriteLine("Carros {0} na posição {1}", car, pos);

    Console.WriteLine("--------------------------------------------------");
  }
}