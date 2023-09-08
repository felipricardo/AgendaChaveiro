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
Faça um único programa na linguagem Python (utilizando o conceito de listas) para controlar a agenda de trabalho de um dia de um chaveiro que realiza atendimento a domicílio. Considere: o sistema deve controlar apenas um dia de trabalho, de um único chaveiro, e ele realiza 12 atendimentos por dia. Armazene toda a agenda
do chaveiro de uma só vez antes do menu do programa, armazenando os seguintes dados em listas separadas mas de igual tamanho: CEP da rua da casa que será atendida, o valor do orçamento do atendimento, e um status para cada agendamento que indica se ele foi ou não realizado (1 REALIZADO, 0 NÃO REALIZADO).
Em seguida apresente um menu com as seguintes opções:
1.Listar atendimentos agendados: caso o usuário selecione essa opção, o programa deverá listar em tela todos os agendamentos mostrando o CEP da casa e o valor do orçamento.
2.Calcular a soma do dinheiro recebido pelo chaveiro: caso o usuário selecione essa opção, o programa deverá passar por todos os atendimento, acumulando o valor do orçamento somente dos
atendimentos que o status foi REALIZADO.
3.Encontrar o CEP do orçamento mais caro e o mais barato: caso o usuário selecione essa opção, o programa deverá passar por todos os atendimentos e encontrar qual foi o atendimento com o orçamento
mais caro e o mais barato (independente do atendimento ter sido ou não realizado) e apresentar o CEP de cada um desses atendimentos.
4. Sair do programa: caso o usuário selecione essa opção, o programa deverá ser encerrado!

------ ```

