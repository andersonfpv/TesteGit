using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Aluno_aula01
/// </summary>
public class Aluno_aula01
{


    private int idade;
    private string nome;

    public int Idade { get => idade; set => idade = value; }
    public string Nome { get => nome; set => nome = value; }

    public string Imprimir()
    {
        return "Nome: " + Nome + "Idade: " + Idade;
    }

    //public void setNome(string nome)
    //{
    //    this.nome = nome;
    //}

    //public string getNome()
    //{
    //    return nome;
    //}

}
