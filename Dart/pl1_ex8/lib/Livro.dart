/* 
a. Classe Livro: titulo (String), autor (String), anoPublicacao (int) e disponibilidade (bool). Inclua um
construtor que inicialize estes atributos de forma opcional e um método toString() para mostrar as
informações do livro.
*/

class Livro {
  String titulo;
  String autor;
  int anoPublicacao;
  bool disponibilidade;

  // Construtor com parâmetros nomeados e opcional
  Livro({
    this.titulo = "",
    this.autor = "",
    this.anoPublicacao = 0,
    this.disponibilidade = false,
  });

  @override
  String toString() {
    return 'Título: $titulo, Autor: $autor, Ano de publicação: $anoPublicacao, Disponibilidade: ${disponibilidade ? "Sim" : "Não"}\n';
  }
}
