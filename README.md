# MOTOR DE VISTORIA 
## AutoCheck.ConsoleApp

### Sobre o projeto
    Este sistema foi desenvolvido utilizando C# .NET com o objetivo de realizar o cadastramento de vistoria veicular, de maneira simplificada e intuitiva ao usuário que utilizá-lo. 
    Inicialmente, é solicitado ao usuário informações básicas do veículo, e em sequência o diagnóstico dos itens vistoriados de maneira generalizada. Após inserir e avaliar o veículo de acordo com as informações inseridas, o sistema armazena em uma lista onde o usuário consegue visualizar os cadastros realizados, bem como o resultado da vistoria. Além destas opções, encerrar a execução também consta como opção no menu inicial. 
---
#### Como executar
    
> _Certifique-se de ter instalado em sua máquina:
**.NET SDK** (versão 8.0 ou superior recomendada). Editor de código **Visual Studio Code** ou  similar, também o **Git** atualizado_.
- Com _**Visual Studio Code**_ aberto, crie uma pasta com o nome que preferir, para armazenar o projeto. Para criar pelo terminal utilize `mkdir SuaPasta`.
- No terminal, abra a pasta onde irá salvar o projeto com o comando `cd` e o caminho da pasta. Ex: `cd caminho/sua/pasta/SuaPasta`.
- Com a pasta aberta, clone o repositório utilizando o comando:

  `git clone https://github.com/Marlonmml/AutoCheck.ConsoleApp.git` 
- Após efetuar o clone do repositório em sua máquina, no terminal execute o comando ``dotnet build``. 
    - Caso acuse alguma falta de arquivos após a _build_, execute ``dotnet restore``.
    - Se não ocorrer nenhum erro, execute o próximo comando:``dotnet run``. 
- A aplicação irá executar no terminal.
- Para encerrar a aplicação em qualquer etapa de execução, utilize o atalho _**Ctrl + C**_.
    
---
#### Conceitos e abordagens 
>Neste projeto foram utilizados alguns conceitos abordados e revisados ao longo do curso **Desenvolvedor Back-End [.Net] Senai SCTEC** _(MÓDULO 01)_.

Para desenvolver esta aplicação, partiu-se do paradigma de programação **POO**, onde inicialmente foram criadas _Classes_ e _Subclasses_ que utilizam conceitos primordiais como:
- _Herança, Polimorfismo_
- _Estruturas condicionais, Loops, Listas_
- _Métodos sobreescritos, Encapsulamento_
- _Construtor de classe_

Além de outros conceitos importantes para o bom funcionamento, fácil compreensão e reutilização de código.

Dentro da aplicação, como regra de negócio na etapa de avaliação do objeto `Veiculo` de `<ItemVistoria> VistoriaRealizada`, dentro de `public class AvaliadorVistoria`, foi aplicada a seguinte lógica de cálculo:
- `Percentual = (double)PontuacaoObtida / PontuacaoMaxima * 100` Onde de forma simples a variável que armazena a pontuação dos itens vistoriados, dividida pela variável que armazena a pontuação máxima, resulta um valor que é multiplicado pelo número 100. Chegando assim ao percentual critério de aprovação estipulado. 

>_Nesta aplicação de Console, não foi aplicada nenhuma arquitetura de integração cliente-servidor. Esta prática não foi contextualizada e também não consta como requisito no enunciado Mini-Projeto Avaliativo._

##### Vídeo explicativo com execução do program:

[VÍDEO EXPLICATIVO](https://drive.google.com/file/d/1bi9o1zRwBaVevn8HtNQo8SY3Eijey52W/view?usp=drive_link)











