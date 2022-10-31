using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edka.Sa05;


namespace Edka.Sa05
{
    internal class Program
    {
        public static List<Disciplina> matriz = new List<Disciplina>
        {
            new Disciplina{Disciplinas="Neurociência e aprendizagem",Inicio=new DateTime (2022,08,08), Termino=new DateTime(2022,09,12)},
            new Disciplina{Disciplinas="Habilidades socio emocionais",Inicio=new DateTime (2022,08,10), Termino=new DateTime(2022,08,24)},
            new Disciplina{Disciplinas="Felicidade",Inicio=new DateTime (2022,08,31), Termino=new DateTime(2022,09,14)},
            new Disciplina{Disciplinas="Teoria do Desenvolvimento Humando e da Aprendizagem",Inicio=new DateTime (2022,09,19), Termino=new DateTime(2022,10,24)},
            new Disciplina{Disciplinas="Planejamento Pedagógico",Inicio=new DateTime (2022,08,27), Termino=new DateTime(2022,10,23)},
            new Disciplina{Disciplinas="Educação inclusiva e Cidadania",Inicio=new DateTime (2022,09,21), Termino=new DateTime(2022,11,09)},
            new Disciplina{Disciplinas="Gestão da Sala de Aula",Inicio=new DateTime (2022,11,16), Termino=new DateTime(2022,12,30)},
            new Disciplina{Disciplinas="Met. Dinâmicas e Inovativas",Inicio=new DateTime (2022,10,31), Termino=new DateTime(2022,11,14)},
            new Disciplina{Disciplinas="Projeto Integrador",Inicio=new DateTime (2022,11,21), Termino=new DateTime(2022,12,05)},
            new Disciplina{Disciplinas="Avaliação Por Competências",Inicio=new DateTime (2023,01,01), Termino=new DateTime(2023,01,02)},
            new Disciplina{Disciplinas="Aprendizagem por Competências",Inicio=new DateTime (2023,01,02), Termino=new DateTime(2023,01,03)},
            new Disciplina{Disciplinas="Prática Docente a Distância",Inicio=new DateTime (2023,01,03), Termino=new DateTime(2023,01,04)},
            new Disciplina{Disciplinas="Legislação e diretrizes da Educação Profissional e Tecnologica",Inicio=new DateTime (2023,01,04), Termino=new DateTime(2023,01,05)},
            new Disciplina{Disciplinas="Ambientes de Aprendizagem Inovativos",Inicio=new DateTime (2023,01,05), Termino=new DateTime(2023,01,06)},                     

        };
        static void Main(string[] args)
        {
            var dataInicio = from d in matriz // onde?
                                      orderby d.Inicio 
                                      select d;

            foreach (var item in dataInicio)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
