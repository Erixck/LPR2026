Exercício 5 Uma empresa deseja controlar os
chamados abertos pelos funcionários.
Crie uma struct chamada Chamado contendo:
Numero, Solicitante, Setor, Prioridade (1 a 3), Status e
Descricao
O programa deve possuir as seguintes funções:
● cadastrarChamado(): Permite cadastrar até 10
chamados. Ao cadastrar, o status inicial deve ser:
Aberto
● listarChamados(): Exibe todos os chamados
cadastrados.
● atualizarStatus(): Solicita o número do chamado e
permite alterar o status para: Em andamento,
Resolvido, Cancelado
● classificarPrioridade() Recebe a prioridade e
retorna: 1 = Baixa, 2 = Média, 3 = Alta
● estatisticas() Exibe Quantos chamados estão
abertos; Quantos estão em andamento; Quantos
foram resolvidos; Quantos foram cancelados.