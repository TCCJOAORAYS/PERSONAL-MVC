using Personal.Models;
using Microsoft.EntityFrameworkCore;

namespace Personal.Data;
public class AppDbSeed
{

    public AppDbSeed(ModelBuilder builder)
    {
        // Adicionar dados iniciais ou configurar a entidade aqui
        List<Exercise> exercises = new List<Exercise>
        {
            new Exercise()
            {
                Id = 1,
                Nome = "Teste de Freeman-Romberg Apoio Unipodal Com Olhos Fechados",
                NomeAux = "Teste De Freeman-Romberg",
                Titulo = "Cronometrar Quanto Tempo O Indivíduo Permanece",
                Descricao = "Um Dos Principais Problemas Associados Ao Envelhecimento Humano É A Redução Da Habilidade Para Controlar A Postura E A Marcha, Podendo Levar À Ocorrência De Quedas, Diminuindo, Assim, A Capacidade Funcional Dos Idosos.",
                Tipo = "Primeiro Teste Rápido",
                Imagem = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/testes/freemann.png",
                ImagemAux = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/exercicios/alongamento.jpg",
                Icon = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/icons/alongamentoicone.png",
                Info = ["Sem Oscilar", "Em Apoio Unipodal", "Olhos Fechados", "As Mãos Para Baixo"],
                Tabela = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/tabelas/1.png"
            },
            new Exercise()
            {
                Id = 2,
                Nome = "Teste de tug: Timed up and Go Test",
                NomeAux = "Teste De Tug",
                Titulo = "Avaliação funcional: Timed Up and Go test",
                Descricao = "Para realizar o teste como descrito na versão original, o Testado é cronometrado enquanto se levanta de uma cadeira (aproximadamente 46cm), caminha em uma linha reta de 3metros de distância (em um ritmo confortável e seguro), vira, caminha de volta e senta-se sobre a cadeira novamente.",
                Tipo = "Segundo Teste Rápido",
                Imagem = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/testes/tug.png",
                ImagemAux = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/exercicios/doreslocais.jpg",
                Icon = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/icons/doricone.png",
                Info = ["É aconselhado que o individuo faça o percurso para se familiarizar com o teste antes de iniciá-lo.", "Usar o calçado habitual e apoio para caminhar (bengala, andador) se necessário."],
                Tabela = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/tabelas/2.png"
            },
            new Exercise()
            {
                Id = 3,
                Nome = "Teste de agilidade e equilíbrio dinâmico",
                NomeAux = "Agilidade E Equilíbrio Dinâmico",
                Titulo = "Quais os objetivos dos testes?",
                Descricao = "Instrumentos: cadeira com braços, fita métrica, 2 cones e cronômetro. Organização do teste: cadeira em local demarcado e local para os pés tocarem o solo. Dois cones posicionados a 1,50m para trás e 1,80m para cada lado (Figura). Posição do avaliado: sentado na cadeira com os pés (calcanhares) tocando o solo. Posição do avaliador: próximo ao avaliado.",
                Tipo = "Terceiro Teste Rápido",
                Imagem = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/testes/equilibrio.png",
                ImagemAux = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/exercicios/massamuscular.jpg",
                Icon = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/icons/musculacaoicone.png",
                Info = ["Determinar um programa de treinamento especifico de equilíbrio para reduzir quedas.", "Examinar os efeitos de exercícios de equilíbrio na propriocepção de idosos.", "Verificar o efeito de um programa de treinamento de equilíbrio, de curto e longo período, em idosos.", "Estudar a eficácia dos exercícios de equilíbrio, realizadas em casa."],
                Tabela = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/tabelas/3.png"
            },
            new Exercise()
            {
                Id = 4,
                Nome = "Deslocamento em quadrado",
                NomeAux = "Agilidade E Equilíbrio Dinâmico",
                Titulo = "Equipamentos necessários",
                Descricao = "Caminhar de maneira normal entre os cones que formam a base do quadrado. Caminhe até o outro cone posicionado na diagonal, conseguindo passar pelos 4 cones e finalizando o percurso. Os testes devem ser realizados quatro vezes sendo uma como reconhecimento e as outras três válidas ,tentando fazer no menor tempo.",
                Tipo = "Quarto Teste Rápido",
                Imagem = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/testes/deslocamento.png",
                ImagemAux = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/exercicios/deslocamento.jpg",
                Icon = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/icons/alongamentoicone.png",
                Info = ["4 cones em distância de aproximadamente de 3 a 4 metros formando um quadrado."],
            },
            new Exercise()
            {
                Id = 5,
                Nome = "Agachamento com cadeira",
                NomeAux = "Força e resistencia",
                Titulo = "Recursos Necessários",
                Descricao = "Organização do teste: cadeira em local demarcado e local para os pés tocarem o solo. Dois cones posicionados a 1,50m para trás e 1,80m para cada lado (Figura). Posição do avaliado: sentado na cadeira com os pés (calcanhares) tocando o solo. Posição do avaliador: próximo ao avaliado.",
                Tipo = "Quinto Teste Rápido",
                Imagem = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/testes/agachamento.jpeg",
                ImagemAux = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/exercicios/agachamentomulher.jpg",
                Icon = "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/icons/doricone.png",
                Info = ["Instrumentos: cadeira com braços, fita métrica, 2 cones e cronômetro."]
            }
        };

        builder.Entity<Exercise>().HasData(exercises);

    }
}


