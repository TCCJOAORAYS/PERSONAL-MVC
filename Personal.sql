INSERT INTO
    exercises (
        Id,
        Nome,
        NomeAux,
        Titulo,
        Descricao,
        Tipo,
        Imagem,
        ImagemAux,
        Icon,
        Info,
        Tabela
    )
VALUES
    (
        1,
        'TESTE DE FREEMAN-ROMBERG APOIO UNIPODAL COM OLHOS FECHADOS',
        'Teste De Freeman-Romberg',
        'Cronometrar Quanto Tempo O Indivíduo Permanece',
        'Um Dos Principais Problemas Associados Ao Envelhecimento Humano É A Redução Da Habilidade Para Controlar A Postura E A Marcha, Podendo Levar À Ocorrência De Quedas, Diminuindo, Assim, A Capacidade Funcional Dos Idosos.',
        'Primeiro Teste Rápido',
        '#img',
        '#imgaux',
        'https://raw.githubusercontent.com/Camargo2109/TccPersonalTrainer/main/website/assets/images/icons/exercicio-com-halteres.png',
        '["Sem Oscilar", "Em Apoio Unipodal", "Olhos Fechados", "As Mãos Para Baixo"]',
        '#tabela'
    ),
    (
        2,
        'Teste de tug: Timed up and Go Test',
        'Teste De Tug',
        'Avaliação funcional: Timed Up and Go test',
        'Para realizar o teste como descrito na versão original, o Testado é cronometrado enquanto se levanta de uma cadeira (aproximadamente 46cm), caminha em uma linha reta de 3metros de distância (em um ritmo confortável e seguro), vira, caminha de volta e senta-se sobre a cadeira novamente.',
        'Segundo Teste Rápido',
        '#img',
        '#imgaux',
        'https://raw.githubusercontent.com/Camargo2109/TccPersonalTrainer/main/website/assets/images/icons/exercicio-de-inferior.png',
        '["É aconselhado que o individuo faça o percurso para se familiarizar com o teste antes de iniciá-lo.", "Usar o calçado habitual e apoio para caminhar (bengala, andador) se necessário."]',
        '#tabela'
    ),
    (
        3,
        'Teste de agilidade e equilíbrio dinâmico',
        'Agilidade E Equilíbrio Dinâmico',
        'Quais os objetivos dos testes?',
        'Instrumentos: cadeira com braços, fita métrica, 2 cones e cronômetro. Organização do teste: cadeira em local demarcado e local para os pés tocarem o solo. Dois cones posicionados a 1,50m para trás e 1,80m para cada lado (Figura). Posição do avaliado: sentado na cadeira com os pés (calcanhares) tocando o solo. Posição do avaliador: próximo ao avaliado.',
        'Terceiro Teste Rápido',
        '#img',
        '#imgaux',
        'https://raw.githubusercontent.com/Camargo2109/TccPersonalTrainer/main/website/assets/images/icons/exercicios-de-alongamento.png',
        '["Determinar um programa de treinamento especifico de equilíbrio para reduzir quedas.", "Examinar os efeitos de exercícios de equilíbrio na propriocepção de idosos.", "Verificar o efeito de um programa de treinamento de equilíbrio, de curto e longo período, em idosos.", "Estudar a eficácia dos exercícios de equilíbrio, realizadas em casa."]',
        '#tabela'
    );

SELECT
    *
FROM
    exercises;