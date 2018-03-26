using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projetinho;

namespace Activity.ConUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Project BusinessProject = new Project();
            Person Pessoinha = new Person();
            Tasks Tarefinha = new Tasks();
            do
            {

                Console.WriteLine("Seja bem-vindo ao sistema de gestão de projetos");
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Selecione uma das opções abaixo para continuar:");
                Console.WriteLine("1)_Cadastrar Projeto");
                Console.WriteLine("2)_Cadastrar Pessoa");
                Console.WriteLine("3)_Cadastrar Tarefa");
                Console.WriteLine("4)_Listar Projeto");
                Console.WriteLine("9)_Sair do Sistema");

                string nomeProjeto = "";

                switch (int.Parse(Console.ReadLine()))
                {
                    case (1):
                        Console.WriteLine("Insira o código do projeto:");
                        BusinessProject.Code = (Console.ReadLine());
                        BusinessProject.StartDate = DateTime.Now;
                        Console.WriteLine("Insira a data prevista para o fim do projeto:");
                        BusinessProject.EstimatedEndDate = (DateTime.Parse(Console.ReadLine()));
                        Console.WriteLine("Insira o nome do responsável pelo projeto:");
                        BusinessProject.Responsible.Title = (Console.ReadLine());
                        BusinessProject.Removed = false;
                        //codar
                        break;
                    case (2):
                        Console.WriteLine("Insira o nome da pessoa:");
                        Pessoinha.Title = (Console.ReadLine());
                        Console.WriteLine("Insira o email da pessoa:");
                        Pessoinha.Email = (Console.ReadLine());
                        Console.WriteLine("Insira o nome do pai da pessoa:");
                        Pessoinha.FatherName = (Console.ReadLine());
                        Pessoinha.Removed = false;
                        break;
                    case (3):
                        Console.WriteLine("Insira o nome da tarefa:");
                        Tarefinha.Title = (Console.ReadLine());
                        Console.WriteLine("Insira uma descrição para a tarefa:");
                        Tarefinha.Comments = (Console.ReadLine());
                        Tarefinha.Removed = false;
                        Console.WriteLine("Insira o total de horas trabalhadas para essa tarefa:");
                        Tarefinha.WorkHours = (Decimal.Parse(Console.ReadLine()));
                        break;
                    case (4):
                        //codar
                        break;
                }
            } while (int.Parse(Console.ReadLine()) != 9);
        }
    }
}
