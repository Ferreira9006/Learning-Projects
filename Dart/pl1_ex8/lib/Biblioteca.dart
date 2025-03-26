import 'Livro.dart';

class Biblioteca {
  // i. Uma lista de objetos Livro.
  List<Livro> _livros = [];

  Biblioteca();
  // ii. Um método adicionarLivro(),
  void adicionarLivro(Livro livro) {
    _livros.add(livro);
  }

  /* 
  iii. Um método emprestarLivro(), que recebe o título de um livro e marca o livro como não
  disponível (caso esteja disponível).
  */
  bool emprestarLivro(String titulo) {
    for (var livro in _livros) {
      if (livro.disponibilidade && livro.titulo == titulo) {
        livro.disponibilidade = false;
        return true; // O livro foi emprestado com sucesso.
      }
    }
    return false;
  }

  // iv. Um método devolverLivro(), que recebe o título de um livro e marca o livro como disponível.
  bool devolverLivro(String titulo) {
    for (var livro in _livros) {
      if (livro.titulo == titulo && !livro.disponibilidade) {
        livro.disponibilidade = true;
        return true;
      }
    }
    return false;
  }

  // v. Um método listarLivrosDisponiveis(), que devolve todos os livros disponíveis na biblioteca.
  List<Livro> listarLivrosDisponiveis() {
    List<Livro> livrosDisponiveis = [];
    for (var livro in _livros) {
      if (livro.disponibilidade) {
        livrosDisponiveis.add(livro);
      }
    }
    return livrosDisponiveis;
  }

  // Um método listarLivrosEmprestados(), que mostra todos os livros que não estão disponíveis no momento
  List<Livro> listarLivrosEmprestados() {
    List<Livro> livrosEmprestados = [];
    for (var livro in _livros) {
      if (!livro.disponibilidade) {
        livrosEmprestados.add(livro);
      }
    }
    return livrosEmprestados;
  }
}
