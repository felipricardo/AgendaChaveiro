# AgendaChaveiro

-------------------------------------------------------
Controle de Agenda de Trabalho para Chaveiro em C#
-------------------------------------------------------

Este código em C# é um programa simples para controlar a agenda de trabalho de um chaveiro que realiza atendimento a domicílio em um único dia de trabalho. O programa utiliza listas para armazenar informações sobre os atendimentos, incluindo CEP da rua, valor do orçamento e status de realização.

Funcionalidades Principais:

1. Cadastro de Atendimentos: O programa permite que o usuário cadastre até 3 atendimentos, inserindo informações como CEP, valor do orçamento e status de realização.

2. Menu de Opções: O programa apresenta um menu com as seguintes opções:
   - Listar atendimentos agendados: Lista todos os atendimentos agendados, mostrando o CEP da casa e o valor do orçamento.
   - Calcular a soma do dinheiro recebido pelo chaveiro: Calcula a soma do valor do orçamento apenas dos atendimentos com status "Realizado".
   - Encontrar o CEP do orçamento mais caro e o mais barato: Encontra o CEP do atendimento com o orçamento mais caro e mais barato, independentemente do status de realização.
   - Sair do programa: Encerra o programa.

Observações:

- O programa possui um limite de 3 atendimentos para este exemplo, mas você pode ajustar o valor conforme necessário.
- Certifique-se de inserir os valores corretamente durante a execução para evitar erros de entrada.

-------------------------------------------------------

```
INÍCIO
    Criar uma lista de inteiros chamada CEPs
    Criar uma lista de números em ponto flutuante chamada orcamentos
    Criar uma lista de inteiros chamada status

    PARA a de 0 até 2
        Exibir "Digite o CEP da casa a ser atendida:"
        Ler e converter o valor para inteiro e armazenar em CEP
        Adicionar CEP à lista CEPs

        Exibir "Digite o valor do orçamento:"
        Ler e converter o valor para número em ponto flutuante e armazenar em orcamento
        Adicionar orcamento à lista orcamentos

        Exibir "Digite o status do atendimento (0 - Não realizado, 1 - Realizado):"
        Ler e converter o valor para inteiro e armazenar em statusAtendimento
        Adicionar statusAtendimento à lista status
    FIM PARA

    Criar uma variável inteira chamada opcao e inicializá-la com 0

    ENQUANTO opcao diferente de 4 FAÇA
        Exibir "Menu"
        Exibir "1. Listar atendimentos agendados"
        Exibir "2. Calcular a soma do dinheiro recebido pelo chaveiro"
        Exibir "3. Encontrar o CEP do orçamento mais caro e o mais barato"
        Exibir "4. Sair do programa"

        Exibir "Digite a opção:"
        Ler e converter o valor para inteiro e armazenar em opcao

        SE opcao igual a 1 ENTÃO
            PARA a de 0 até 2
                Exibir "CEP:", CEPs[a], "Orçamento:", orcamentos[a]
            FIM PARA
        SENÃO SE opcao igual a 2 ENTÃO
            Criar uma variável em ponto flutuante chamada total e inicializá-la com 0

            PARA a de 0 até 2
                SE status[a] igual a 1 ENTÃO
                    total += orcamentos[a]
                FIM SE
            FIM PARA

            Exibir "A soma do dinheiro recebido pelo chaveiro é:", total
        SENÃO SE opcao igual a 3 ENTÃO
            Criar uma variável em ponto flutuante chamada orcamentoMin e inicializá-la com o valor do primeiro elemento em orcamentos
            Criar uma variável em ponto flutuante chamada orcamentoMax e inicializá-la com o valor do primeiro elemento em orcamentos
            Criar uma variável inteira chamada cepMin e inicializá-la com o valor do primeiro elemento em CEPs
            Criar uma variável inteira chamada cepMax e inicializá-la com o valor do primeiro elemento em CEPs

            PARA a de 1 até 2
                SE orcamentos[a] menor que orcamentoMin ENTÃO
                    orcamentoMin = orcamentos[a]
                    cepMin = CEPs[a]
                FIM SE
                SE orcamentos[a] maior que orcamentoMax ENTÃO
                    orcamentoMax = orcamentos[a]
                    cepMax = CEPs[a]
                FIM SE
            FIM PARA

            Exibir "CEP do orçamento mais barato:", cepMin, "valor:", orcamentoMin
            Exibir "CEP do orçamento mais caro:", cepMax, "valor:", orcamentoMax
        SENÃO SE opcao igual a 4 ENTÃO
            Exibir "Programa encerrado."
        FIM SE
    FIM ENQUANTO
FIM
